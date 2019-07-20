import appdaemon.plugins.hass.hassapi as hass
class TradfriRemote(hass.Hass):
    def initialize(self):
        if 'event' in self.args:
            self.listen_event(self.handle_event, self.args['event'])

    def handle_event(self, event_name, data, kwargs):
        if data['id'] == self.args['id']:
            self.log(data['event'])
            if data['event'] == 1002:
                self.log('Button toggle')
                self.toggle(self.args['lightId'])

            elif data['event'] == 2002:
                prevBrightness = self.get_state(entity=self.args['lightId'], attribute="brightness")
                self.log('Button dim up')
                self.log(prevBrightness)
                if prevBrightness == None:
                    self.turn_on(self.args['lightId'], brightness = 25)
                else:
                    self.turn_on(self.args['lightId'], brightness = int(prevBrightness) + 25)
                self.log(self.get_state(entity=self.args['lightId'], attribute="brightness"))

            elif data['event'] == 3002:
                prevBrightness = self.get_state(entity=self.args['lightId'], attribute="brightness")
                self.log('Button dim down')
                self.log(prevBrightness)
                if prevBrightness < 26:
                    self.turn_off(self.args['lightId'])
                elif prevBrightness != None:
                    self.turn_on(self.args['lightId'], brightness = prevBrightness - 25)
                self.log(self.get_state(entity=self.args['lightId'], attribute="brightness"))

            elif data['event'] == 4002:
                self.log('Button left')
                if (self.args['sideButtonType'] == 'color'):
                    self.log('Color toggle left')
                    prevColor = self.get_state(entity=self.args['lightId'], attribute="color_name")
                    if (prevColor == None):
                        self.turn_on(self.args['lightId'], color_name = 'turquoise')
                    self.log(prevColor)
                    

            elif data['event'] == 5002:
                self.log('Button right')
                if (self.args['sideButtonType'] == 'color'):
                    self.log('Color toggle right')