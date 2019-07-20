import appdaemon.plugins.hass.hassapi as hass
import datetime
import globals

class NotifyPresence(hass.Hass):

    def initialize(self):
        if "device" in self.args:
            self.listen_state(self.notify, self.args["device"])

    def notify(self, entity, attribute, old, new, kwargs):
        if (new != old and new != None):
            self.call_service("notify/ios_isabellas_iphone_x", message = "{} was {}, is now {}".format(self.friendly_name(entity), old, new))