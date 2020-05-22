from base import Base
import globals
from globals import PEOPLE
import datetime


class Dryer(Base):

    def initialize(self) -> None:
        """Initialize."""
        super().initialize()
        self.power_sensor_idle = self.args["power_sensor"]
        self.dryer_state = self.args["input_select"]
        self.hatch = self.args["hatch_sensor"]

        self.light = self.args["light"]
        self.light_state = None

        self.reminder_handle = None

        self.listen_state(self.dryer_running, self.power_sensor_idle, new = "False", duration = 90)
        self.listen_state(self.dryer_clean, self.power_sensor_idle, new = "True", duration = 270)
        self.listen_state(self.dryer_emptied, self.hatch, new = "on")
        
        self.listen_state(self.coming_home, PEOPLE['Isa']['device_tracker'], new = "Just arrived")

        self.listen_event(self.snooze_reminder, "ios.notification_action_fired", actionName = "DRYER_NOT_EMPTIED")

    def coming_home(self, entity, attribute, new, old, kwargs):
        if (new != old) and self.dryer_state == "Clean":
            self.log("Coming home to dry laundry. Turning on status light.")
            self.light_state = self.get_state(self.light, attribute = "all")
            self.turn_on(self.light, color_name = "green", brightness = 20)

    def dryer_running(self, entity, attribute, new, old, kwargs):
        if new != old:
            self.select_option(self.dryer_state, "Running")
            self.log("Dryer running")
            self.notification_manager.log_home(message = "🧺 Dryer running.") 
            self.call_service("dwains_theme/notification_create", message = "🧺 Dryer running", notification_id = "washer")
    
    def dryer_clean(self, entity, attribute, new, old, kwargs):
        if new != old and self.get_state(self.dryer_state) == "Running":
            self.select_option(self.dryer_state, "Clean")
            self.log("Dryer clean")
            
            if self.presence_helper.anyone_home() and not self.now_is_between("23:00:00", "07:00:00") and not self.presence_helper.has_guests():
                self.light_state = self.get_state(self.light, attribute = "all")
                self.turn_on(self.light, color_name = "green", brightness = 20)

            self.data = {"push": {"category":"dryer", "thread-id":"home-assistant"}}
            self.notification_manager.notify_if_home(person = "Isa", message = "🧺 Dryer is done", data = self.data)
            self.call_service("dwains_theme/notification_create", message = "🧺 Dryer is done", notification_id = "dryer")
            self.notification_manager.log_home(message = "🧺 Dryer is done.")

    def dryer_emptied(self, entity, attribute, new, old, kwargs):
        if new != old and self.get_state(self.dryer_state) == "Clean":
            self.select_option(self.dryer_state, "Idle")
            self.log("Dryer emptied, now idle")

            if self.reminder_handle is not None:
                self.cancel_timer(self.reminder_handle)
                self.reminder_handle = None

            if self.light_state["state"] == "off":
                self.turn_on(self.light, color_temp = 366)
                self.turn_off(self.light)
                self.notification_manager.log_home(message = "🧺 Dryer emptied, now idle. Turning off lamp.")

            else:
                brightness = self.light_state["attributes"]["brightness"]
                    
                self.turn_on(self.light, color_temp = 366, brightness = brightness)
                self.notification_manager.log_home(message = "🧺 Dryer emptied, now idle. Returning lamp to previous state.")
            self.call_service("dwains_theme/notification_dismiss", notification_id = "dryer")

    def snooze_reminder(self, event_name, data, kwargs):
        self.reminder_handle = self.run_in(self.remind_again, 1800)
    
    def remind_again(self):
        self.data = {"push": {"category":"dryer", "thread-id":"home-assistant"}}
        self.notification_manager.notify_if_home(person = "Isa", message = "🧺 Dryer is done", data = self.data)
