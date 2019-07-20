from base import Base
import globals
from globals import PEOPLE

class NotificationManager(Base):

    def initialize(self) -> None:
        """Initialize."""
        super().initialize()

        self.discord_home = "notify/discord_home_hook"
        self.discord_alarm = "notify/discord_alarm_hook"
        self.discord_krisinfo = "notify/discord_krisinfo_hook"
        self.discord_monitor = "notify/discord_monitor_hook"
        self.discord_system = "notify/discord_system_hook"
        
    """title and during_quiet is optional, default is not during quiet time, use True to override"""
    def notify_if_home(self, person:str, message:str, title:str="", during_quiet:bool=False, data:dict={"push": { "thread-id":"home-assistant"}}, **kwargs:dict):
        self.log(f"Checking if {person} is home")
        if self.get_state(PEOPLE[person]['device_tracker']) == "Home":
            if during_quiet is False:
                if not self.quiet_time():
                    self.notify(message, title = title, name = PEOPLE[person]['notifier'], data = data)
                    if title == "":
                        self.log(f"Sending notification: {message}")
                    else:
                        self.log(f"Sending notification: {title}, {message}")

            else:
                self.log("Sending notification during quiet time")
                self.notify(message, title = title, name = PEOPLE[person]['notifier'])
        else:
            self.log(f"{person} is not home, not sending notification.")
        
    def quiet_time(self) -> bool:
        if self.get_state("binary_sensor.workday_sensor") == "on":
            return self.now_is_between(globals.notification_mode["start_quiet_weekday"], globals.notification_mode["stop_quiet_weekday"])
        else:
            return self.now_is_between(globals.notification_mode["start_quiet_weekend"], globals.notification_mode["stop_quiet_weekend"])


    def log_hass(self, message:str, mention:bool=False, **kwargs:dict):
        if mention is False:
            # self.call_service(self.discord, target = self.hass_channel, message = message)
            self.call_service(self.discord_system, message = message)
        else:
            self.call_service(self.discord_system, message = f"@here {message}")
    def log_home(self, message:str, mention:bool=False, **kwargs:dict):
        if mention is False:
            self.call_service(self.discord_home,  message = message)
        else:
            self.call_service(self.discord_home, message = f"@here {message}")
            
    def log_alarm(self, message:str, mention:bool=False, **kwargs:dict):
        if mention is False:
            self.call_service(self.discord_alarm, message = message)
        else:
            self.call_service(self.discord_alarm, message = f"@here {message}")
            
    def log_monitor(self, message:str, mention:bool=False, **kwargs:dict):
        if mention is False:
            self.call_service(self.discord_monitor, message = message)
        else:
            self.call_service(self.discord_monitor, message = f"@here {message}")