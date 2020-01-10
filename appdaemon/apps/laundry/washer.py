from base import Base
import globals
from globals import PEOPLE
import datetime


class Washer(Base):

    def initialize(self) -> None:
        """Initialize."""
        super().initialize()

        self.power_sensor_idle = self.args["power_sensor"]
        self.washer_state = self.args["input_select"]
        self.hatch = self.args["hatch_sensor"]

        self.light = self.args["light"]
        self.light_state = None

        self.reminder_handle = None

        self.listen_state(self.washer_running, self.power_sensor_idle, new = "False", duration = 90)
        self.listen_state(self.washer_clean, self.power_sensor_idle, new = "True", duration = 270)
        self.listen_state(self.washer_emptied, self.hatch, new = "on")
        
        self.listen_state(self.coming_home, PEOPLE['Isa']['device_tracker'], new = "Just arrived")

        self.listen_event(self.snooze_reminder, "ios.notification_action_fired", actionName = "WASHER_NOT_EMPTIED")

    def coming_home(self, entity, attribute, new, old, kwargs):
        if (new != old) and self.washer_state == "Clean":
            self.log("Coming home to clean laundry. Turning on status light.")
            self.light_state = self.get_state(self.light, attribute = "all")
            self.turn_on(self.light, color_name = "blue", brightness = 20)

    def washer_running(self, entity, attribute, new, old, kwargs):
        if new != old:
            self.select_option(self.washer_state, "Running")
            self.log("Washer running")
            self.notification_manager.log_home(message = "🧼 Washer running.") 
    
    def washer_clean(self, entity, attribute, new, old, kwargs):
        if new != old and self.get_state(self.washer_state) == "Running":
            self.select_option(self.washer_state, "Clean")
            self.set_state("sensor.washer_animation", state = "blink")
            self.log("Washer clean")
            
            if self.presence_helper.anyone_home() and not self.now_is_between("23:00:00", "07:00:00") and not self.presence_helper.has_guests():
                self.light_state = self.get_state(self.light, attribute = "all")
                self.turn_on(self.light, color_name = "blue", brightness = 20)

            self.data = {"push": {"category":"washer", "thread-id":"home-assistant"}}
            self.notification_manager.notify_if_home(person = "Isa", message = "🧼 Washing machine is done", data = self.data)
            self.notification_manager.log_home(message = "🧼 Washer clean.")
            
    def washer_emptied(self, entity, attribute, new, old, kwargs):
        if new != old and self.get_state(self.washer_state) == "Clean":
            self.select_option(self.washer_state, "Idle")
            self.set_state("sensor.washer_animation", state = "none")
            self.log("Washer emptied, now idle")

            if self.reminder_handle is not None:
                self.cancel_timer(self.reminder_handle)
                self.reminder_handle = None

            if self.light_state["state"] == "off":
                self.turn_on(self.light, color_temp = 366)
                self.turn_off(self.light)
                self.notification_manager.log_home(message = "🧼 Washer emptied, now idle. Turning off lamp.")

            else:
                brightness = self.light_state["attributes"]["brightness"]
                    
                self.turn_on(self.light, color_temp = 366, brightness = brightness)
                self.notification_manager.log_home(message = "🧼 Washer emptied, now idle. Returning lamp to previous state.")

    def snooze_reminder(self, event_name, data, kwargs):
        self.reminder_handle = self.run_in(self.remind_again, 1800)
    
    def remind_again(self):
        self.data = {"push": {"category":"washer", "thread-id":"home-assistant"}}
        self.notification_manager.notify_if_home(person = "Isa", message = "🧼 Washing machine is done", data = self.data)
