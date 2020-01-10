import appdaemon.plugins.hass.hassapi as hass
import datetime
import globals

class NotifyPresence(hass.Hass):

    def initialize(self):
        if "device" in self.args:
            self.listen_state(self.notify, self.args["device"])

    def notify(self, entity, attribute, old, new, kwargs):
        if (new != old and new != None):
            self.call_service("notify/mobile_app_isabella_s_iphone_x", message = "{} was {}, is now {}".format(self.friendly_name(entity), old, new))
            # self.notification_manager.log_monitor(message = f"Device tracker change. {entity} was {old}, now {new}")
