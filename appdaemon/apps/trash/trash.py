import appdaemon.plugins.hass.hassapi as hass
import datetime
import time
import globals
from globals import PEOPLE
from base import Base

class Trash(Base):
    
    def initialize(self) -> None:
        """Initialize."""
        super().initialize()
        self.trash_sensor = 'sensor.trash'
        self.trash_calendar = 'calendar.garbage_day'
        self.trash_status = "input_select.trash_status"

        self.out = 'Out'
        self.home = 'Home'
        self.put_out = 'Put out'
        self.take_in = 'Take in'

        self.reminder_handle = None

        self.listen_state(self.check_trash_status, self.trash_calendar)
        self.listen_state(self.check_calendar_status, self.trash_sensor)
        self.listen_state(self.remind, self.trash_status)
 
    def check_trash_status(self, entity, attribute, old, new, kwargs):
        trash_state = self.get_state(self.trash_sensor)
        if new == 'on' and new != old:
            if trash_state == 'Home':
                self.select_option(self.trash_status, self.put_out)

                reminder_start = self.datetime()
                if (self.reminder_handle is not None):
                    return
                else:
                    self.reminder_handle = self.run_every(self.remind, reminder_start, 1800)

            elif trash_state == 'Away':
                self.select_option(self.trash_status, self.out)

        elif new == 'off' and new != old:
            if trash_state == 'Home':
                self.select_option(self.trash_status, self.home)
            elif trash_state == 'Away':
                self.select_option(self.trash_status, self.take_in)

                reminder_start = self.datetime()
                if (self.reminder_handle is not None):
                    return
                else:
                    self.reminder_handle = self.run_every(self.remind, reminder_start, 5400)

    def check_calendar_status(self, entity, attribute, old, new, kwargs):
        calendar_state = self.get_state(self.trash_calendar)
        if new == 'Home' and new != old:
            self.notification_manager.log_home(message = "Trash is home")
            if calendar_state == 'on':
                self.select_option(self.trash_status, self.put_out)
            elif calendar_state == 'off':
                self.select_option(self.trash_status, self.home)

        elif new == 'Away' and new != old:
            self.notification_manager.log_home(message = "Trash is out")
            if calendar_state == 'on':
                self.select_option(self.trash_status, self.take_in)
            elif calendar_state == 'off':
                self.select_option(self.trash_status, self.out)

    def remind(self, entity, attribute, old, new, kwargs):
        trash_state = self.get_state(self.trash_status)
        if (trash_state == "Put out"):
            self.data = {"push": {"thread-id":"trash"}}
            self.notification_manager.notify_if_home(person = "Isa", message = "🗑 Put out trash!", data = self.data)
        elif (trash_state == "Take in"):
            self.data = {"push": {"thread-id":"trash"}}
            self.notification_manager.notify_if_home(person = "Isa", message = "🗑 Take in trash!", data = self.data)
        else:
            self.log("Reminder canceled")
            self.cancel_timer(self.reminder_handle)
            self.reminder_handle = None
            self.notification_manager.log_home(message = "🗑 Trash status is good, reminder canceled.")