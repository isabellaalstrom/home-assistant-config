import appdaemon.plugins.hass.hassapi as hass
import globals
from globals import PEOPLE
class SceneSwitch(hass.Hass):
    def initialize(self):
        if 'event' in self.args:
            self.listen_event(self.handle_event, self.args['event'])

    def handle_event(self, event_name, data, kwargs):
        if data['id'] == self.args['id']:
            self.log(data['event'])
            # | button single press
            if data['event'] == 1002:
                self.call_service("script/turn_on", entity_id = 'script.goodnight')
                self.call_service(PEOPLE['Isa']['notify/service'], title = "Scene switch", message = "Goodnight")
            # | button long press
            elif data['event'] == 1001:
                self.call_service(PEOPLE['Isa']['notify/service'], title = "Scene switch", message = "Long pressed |")
            # | button long press release
            elif data['event'] == 1003:
                self.call_service(PEOPLE['Isa']['notify/service'], title = "Scene switch", message = "Released |")

            # O button single press
            elif data['event'] == 2002:
                self.call_service("scene/turn_on", entity_id = 'scene.morning_lights')
                self.call_service(PEOPLE['Isa']['notify/service'], title = "Scene switch", message = "Pressed |")
            # O button long press
            elif data['event'] == 2001:
                self.call_service(PEOPLE['Isa']['notify/service'], title = "Scene switch", message = "Pressed |")
            # O button long press release
            elif data['event'] == 2003:
                self.call_service(PEOPLE['Isa']['notify/service'], title = "Scene switch", message = "Pressed |")