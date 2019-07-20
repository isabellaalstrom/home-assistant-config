import appdaemon.plugins.hass.hassapi as hass
import datetime
import time
import globals
from globals import PEOPLE
from base import Base

class AirCleaner(Base):
    def initialize(self) -> None:
        """Initialize."""
        super().initialize()
        if "input_select" in self.args:
            self.listen_state(self.set_state, self.args["input_select"])

    def set_state(self, entity, attribute, old, new, kwargs):
        if (new == 'Quiet'):
            self.turn_on('script.air_cleaner_quiet')
            self.log('Air cleaner set to quiet')
        elif (new == 'Auto'):
            self.turn_on('script.air_cleaner_auto')
            self.log('Air cleaner set to auto')
        elif (new == 'Turbo'):
            self.turn_on('script.air_cleaner_turbo')
            self.log('Air cleaner set to turbo')
            
class AirCleanerSchedule(Base):

    def initialize(self) -> None:
        """Initialize."""
        super().initialize()
        autoTime = self.parse_time(self.args["auto_time"])
        turboTime = self.parse_time(self.args["turbo_time"])
        quietTime = self.parse_time(self.args["quiet_time"])

        self.run_daily(self.auto_at_11, autoTime)
        self.run_daily(self.quiet_at_21, quietTime)

    def auto_at_11(self, kwargs):
        if not self.presence_helper.anyone_home():
            self.turn_on('script.air_cleaner_auto')
            self.log('Air cleaner set to auto')
            self.notification_manager.log_home(message = "Air cleaner set to auto.")
        
    def turbo_at_19_pollen(self, kwargs):
        self.turn_on('script.air_cleaner_turbo')
        self.log('Air cleaner set to turbo')
        self.notification_manager.log_home(message = "Air cleaner set to turbo.")
        
    def quiet_at_21(self, kwargs):
        self.turn_on('script.air_cleaner_quiet')
        self.log('Air cleaner set to quiet')
        self.notification_manager.log_home(message = "Air cleaner set to quiet.")