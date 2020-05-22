import appdaemon.plugins.hass.hassapi as hass
import datetime
import time
import globals
from globals import PEOPLE
from base import Base

class Mailbox(Base):
    
    def initialize(self) -> None:
        """Initialize."""
        super().initialize()
        self.door_sensor = self.args["mail_door_sensor"]
        self.slot_sensor = self.args["mail_slot_sensor"]
        self.mail_status = self.args["mail_status"]
        self.state = self.get_state(self.mail_status)

        self.newState = ""
        self.just_opened_door = False
        self.just_notified = False
        
        self.listen_state(self.just_opened, self.args["door"])

        if "mail_slot_sensor" in self.args:
            self.listen_state(self.mailbox_opened, self.slot_sensor)
        if "mail_door_sensor" in self.args:
            self.listen_state(self.mailbox_opened, self.door_sensor)
 
    def just_opened(self, entity, attribute, old, new, kwargs):
        if (new == "Open"):
            self.log("Just opened front door")
            self.just_opened_door = True
            self.run_in(self.reset_just_opened, 90)

    def reset_just_opened(self, kwargs):
        self.log("Front door no longer just opened")
        self.just_opened_door = False
    
    def reset_notification(self, kwargs):
        self.log("Reset notification delay")
        self.just_notified = False

    def mailbox_opened(self, entity, attribute, old, new, kwargs):
        self.state = self.get_state(self.mail_status)
        if (new == "on" and new != old):
            self.log("Mailbox opened")
            if (entity == self.slot_sensor):
                if (self.state == "Mail" or self.state == "Empty" or self.state is None):
                    self.newState = "Mail"
                    self.log("Mail. Old state: {} - New state: {}".format(self.state, self.newState))
                else:
                    self.newState = "Package and mail"
                    self.log("Mail. Old state: {} - New state: {}".format(self.state, self.newState))

                if (self.state != self.newState and self.just_notified is False):
                    self.notification_manager.notify_if_home(person = "Isa", message = "📬 You've got {}".format(self.newState))
                    self.just_notified = True
                    self.run_in(self.reset_notification, 60)
                    self.notification_manager.log_home(message = "📬 You've got {}".format(self.newState))
                self.log(self.newState)
                self.call_service("dwains_theme/notification_create", message = "📬 {}".format(self.newState), notification_id = "mailbox")
                self.select_option(self.mail_status, self.newState)

            elif (entity == self.door_sensor):
                self.package_or_emptied(entity, old, new)


    def package_or_emptied(self, entity, old, new):
        if (entity == self.door_sensor):

            if (self.just_opened_door or self.presence_helper.anyone_just_arrived()):
                self.mailbox_emptied()
            else:
                self.new_package()
        
    def mailbox_emptied(self):
        self.notification_manager.notify_if_home(person = "Isa", message = "📭 Mailbox emptied")

        self.call_service("dwains_theme/notification_dismiss", notification_id = "mailbox")
        self.newState = "Empty"
        self.select_option(self.mail_status, self.newState)
        self.log("Mailbox emptied")
        self.notification_manager.log_home(message = "📭 Mailbox emptied")
    
    def new_package(self):
        if (self.state == "Package" or self.state == "Empty" or self.state is None):
            self.newState = "Package"
            self.log("Package. Old state: {} - New state: {}".format(self.state, self.newState))
        else:
            self.newState = "Package and mail"
            self.log("Package. Old state: {} - New state: {}".format(self.state, self.newState))
            
        if (self.state != self.newState and self.just_notified is False):
            self.notification_manager.notify_if_home(person = "Isa", message = "📦 You've got {}".format(self.newState))
            self.just_notified = True
            self.run_in(self.reset_notification, 60)
            self.notification_manager.log_home(message = "📦 You've got {}".format(self.newState))  

        self.call_service("dwains_theme/notification_create", message = "📦 {}".format(self.newState), notification_id = "mailbox")
        self.select_option(self.mail_status, self.newState)
        self.log("Check mail")
    
    def local_time_str(self, utc_datetime):
        now_timestamp = time.time()
        offset = datetime.datetime.fromtimestamp(now_timestamp) - datetime.datetime.utcfromtimestamp(now_timestamp)
        local_datetime = utc_datetime + offset
        return local_datetime.strftime("%Y-%m-%d %H:%M")
