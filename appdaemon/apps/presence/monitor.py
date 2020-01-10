import appdaemon.plugins.hass.hassapi as hass
import datetime
import time
import globals
from globals import PEOPLE
from base import Base
import json

class Monitor(Base):
    
    def initialize(self) -> None:
        """Initialize."""
        super().initialize()

        self.listen_state(self.trigger_departure_scan, "binary_sensor.yard_door")
        self.listen_state(self.trigger_departure_scan, "sensor.front_door_access_control")
        self.listen_state(self.bt_change, "sensor.dining_room_isabellas_iphone_x_bt")
        self.listen_state(self.bt_change, "sensor.dining_room_stefan_iphone_11_bt")
        self.listen_state(self.bt_change, "sensor.living_room_isabellas_iphone_x_bt")
        self.listen_state(self.bt_change, "sensor.living_room_stefan_iphone_11_bt")
        self.listen_state(self.monitor_status, "sensor.monitor_dining_room")
        self.listen_state(self.monitor_status, "sensor.monitor_living_room")

        self.listen_state(self.restart, PEOPLE['Isa']['wifi_tracker'], new = "not_home")
        self.listen_state(self.restart, PEOPLE['Stefan']['wifi_tracker'], new = "not_home")
        self.listen_event(self.restart_at_hass_start, "plugin_started")

    def restart_at_hass_start(self, event_name, data, kwargs):
        self.call_service("mqtt/publish", topic = "monitor/scan/restart")

    def restart(self, entity, attribute, new, old, kwargs):
        if self.presence_helper.anyone_home():
            self.call_service("mqtt/publish", topic = "monitor/scan/restart")

    def bt_change(self, entity, attribute, old, new, kwargs):
        if new != old:
            self.log(f"Bt tracker change from monitor. {entity} was {old}, now {new}")
            self.notification_manager.log_monitor(message = f"Bt tracker change from monitor. {entity} was {old}, now {new}")

    def trigger_departure_scan(self, entity, attribute, old, new, kwargs):
        if new == "22" or new == "on":
            self.log("Initiating departure scan in 30 sec")

            self.run_in(self.scan_depart, 30)
            self.run_in(self.scan_depart, 60)
            self.run_in(self.scan_depart, 90)
            self.log("Last departure scan in 30 sec")
            self.run_in(self.scan_depart, 120)

    def monitor_status(self, entity, attribute, old, new, kwargs):
        if new != old:
            self.notification_manager.log_monitor(message = f"{entity} is {new}")
            if new == "online":
                self.run_in(self.scan_arrive, 5)
                self.run_in(self.scan_arrive, 30)
                self.run_in(self.scan_arrive, 60)
                
            
    def scan_arrive(self, kwargs):
        self.notification_manager.log_monitor(message = f"Requested scan for arrival.")
        self.call_service("mqtt/publish", topic = "monitor/scan/arrive")
        
    def scan_depart(self, kwargs):
        self.notification_manager.log_monitor(message = f"Requested scan for departure.")
        self.call_service("mqtt/publish", topic = "monitor/scan/depart")
