from base import Base
import globals
from globals import PEOPLE
import datetime
from datetime import timedelta, date

class MorningLights(Base):
    def initialize(self):
        """Initialize."""
        super().initialize()

        self.morning_on = True
        self.morning_lights = "scene.morning_lights"
        self.motion_sensor = "binary_sensor.upstairs_hallway_pir_sensor"
        self.bedroom_door = "binary_sensor.bedroom_door"

        self.listen_state(self.morning_lights_on, self.motion_sensor)
        self.listen_state(self.morning_lights_on, self.bedroom_door)
        
        time = datetime.time(23, 0, 0)
        self.run_daily(self.reset_morning, time)
        
    def morning_lights_on(self, entity, attribute, new, old, kwargs):
        if new != old and new == "on":
            if self.now_is_between("06:00:00", "08:00:00") and not self.morning_on:
                if self.sun_down():
                    self.turn_on_device(self.morning_lights)
                    self.morning_on = True
                    self.log("Turned on morning lights")
                
    def reset_morning(self, kwargs):
      self.morning_on = False