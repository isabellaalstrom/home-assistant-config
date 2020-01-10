from base import Base
import globals
from globals import PEOPLE
import datetime
from datetime import timedelta, date

class LightSchedule(Base):
    def initialize(self):
        """Initialize."""
        super().initialize()

        self.outdoor_lights = "light.outdoor_lights"
        self.hallway_window = "light.hallway_window_light"
        self.outdoor_light_strings = "light.outdoor_light_strings"
        self.outdoor_wall_lamps = "light.outdoor_wall_lamps"
        
        self.dark_lights_on = "scene.dark_lights_on"
        self.dark_lights_off = "script.dark_lights_off"

        self.run_at_sunset(self.outdoor_lights_on, offset = datetime.timedelta(minutes = -45).total_seconds())
        
        self.scheduler.run_on_evening_before_weekday(self.outdoor_lights_out, self.parse_time("00:30:00"))
        self.scheduler.run_on_night_before_weekend_day(self.outdoor_lights_out, self.parse_time("01:30:00"))
        self.scheduler.run_on_weekdays(self.outdoor_lights_on_morning, self.parse_time("06:30:00"))

        self.run_at_sunrise(self.outdoor_lights_off_at_sunrise, offset = datetime.timedelta(minutes = 45).total_seconds())

    def outdoor_lights_on_morning(self, kwargs):
        if not self.sun_up():
            self.turn_on_device(self.outdoor_wall_lamps, transition = 30, brightness_pct = 100)
            self.turn_on_device(self.outdoor_light_strings)
            self.turn_on_device(self.hallway_window, transition = 30, brightness_pct = 70)
            self.log("Turned on outdoor lights")
            self.notification_manager.log_home(message = "💡 Turned on outdoor lights and hallway window.")
        else:
            self.notification_manager.log_home(message = "💡 Sun is already up, not turning on lights.")

    def outdoor_lights_off_at_sunrise(self, kwargs):
        self.turn_off_device(self.outdoor_lights)
        self.turn_off_device(self.hallway_window)
        if self.now_is_between("06:30:00", "sunrise + 00:45:00"):
            self.log("Turned off outdoor lights")
            self.notification_manager.log_home(message = "💡 Turned off all outdoor lights and hallway window.")
        else:
            self.notification_manager.log_home(message = "💡 Lights should not be on, but I'll turn them off just in case.")

    def outdoor_lights_on(self, kwargs):
        self.turn_on_device(self.outdoor_wall_lamps, transition = 30, brightness_pct = 100)
        self.turn_on_device(self.outdoor_light_strings)
        self.turn_on_device(self.hallway_window, transition = 30, brightness_pct = 50)
        self.log("Turned on outdoor lights")
        self.notification_manager.log_home(message = "💡 Turned on outdoor lights and hallway window.")
    
    def outdoor_lights_out(self, kwargs):
        self.turn_on_device(self.outdoor_wall_lamps, transition = 30, brightness_pct = 10)
        self.turn_on_device(self.hallway_window, transition = 30, brightness_pct = 10)
        self.log("Turned off outdoor lights")
        self.notification_manager.log_home(message = "💡 Turned down outdoor wall lamps and hallway window, keeping light strings on.")
