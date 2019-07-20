import appdaemon.plugins.hass.hassapi as hass
import datetime
import globals

class UnlockedBy(hass.Hass):

    def initialize(self):
        self.lock_sensor = self.args["unlocked_by"]
        self.new = ""
        
        if "unlocked_by" in self.args:
            self.listen_state(self.set_tracker, self.lock_sensor)
        
    def set_tracker(self, entity, attribute, old, new, kwargs):
        if "_" not in new:
            self.new = new
            attributes = {}
            attributes['source_type'] = "lock"
            lock = self.get_state(entity=self.lock_sensor, attribute="all")
            i = datetime.datetime.now()
            now = i.strftime('%Y-%m-%d %H.%M.%S')
            if (new == 'Stefan'):
                device = self.get_state(entity=self.args["stefan"], attribute="all")
                deviceState = self.get_state(self.args["stefan"])
                self.set_state("device_tracker.stefan_iphone_7", state = "Home")
                attributes["lock_last_updated"] = now
                if (deviceState != 'Home' and deviceState != 'Just arrived'):
                    self.set_state(self.args["stefan"], state='Just arrived', attributes=attributes)
            if (new == 'Isabella'):
                device = self.get_state(entity=self.args["isa"], attribute="all")
                deviceState = self.get_state(self.args["isa"])
                attributes["lock_last_updated"] = now
                if (deviceState != 'Home' and deviceState != 'Just arrived'):
                    self.set_state(self.args["isa"], state='Just arrived', attributes=attributes)
            self.run_in(self.update, 30)
            
    def update(self, kwargs):
        self.set_state(self.lock_sensor, state = f"{self.new}_")
        self.log("updated lock sensor")
        
class MendGps(hass.Hass):
    def initialize(self):
        self.gps = self.args["gps"]
        self.bt = self.args["bt"]
        self.wifi = self.args["wifi"]
        
        self.handle = None

        self.listen_state(self.tracker, self.bt)
        self.listen_state(self.tracker, self.wifi)

    def tracker(self, entity, attribute, old, new, kwargs):
        if new == 'not_home':
            self.cancel_timer(self.handle)
            self.handle = self.run_in(self.scan_left, 1800)
            
    def scan_left(self, kwargs):
        gps_state = self.get_state(self.gps)
        wifi_state = self.get_state(self.wifi)
        bt_state = self.get_state(self.bt)
        
        if gps_state == 'home' and wifi_state == 'not_home' and bt_state == 'not_home':
            self.call_service("notify/ios_isabellas_iphone_x", message = f"Bt and wifi is not home, set {self.gps} to not home")
            self.set_state(self.gps, state = 'not_home')
        else:
            self.log("Conditions not met")