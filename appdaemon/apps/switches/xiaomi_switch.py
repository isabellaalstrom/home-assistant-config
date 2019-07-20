import appdaemon.plugins.hass.hassapi as hass
import time

class XiaomiDimmer(hass.Hass):

  def initialize(self):
    self.listen_event(self.button_pressed, "deconz_event", id = self.args["id"] )
    self.table_hold = False
    self.table_dim = False
    self.light = self.args["lightId"]
    self.secondLight = self.args["secondLightId"]

  def button_pressed(self, event_name, data, kwargs):
    self.click_type=data["event"]
    
    if self.click_type == 1002:
      if self.light is not "none":
        self.log('Button release')
        if self.table_hold == False or self.get_state(self.light) == "off":
          self.table_pressed = False
          if "only_on" in self.args:
            self.turn_on(self.light)
          else:
            self.toggle(self.light)
        self.table_hold = False
    
    elif self.click_type == 1000:
      if self.light is not "none":
        self.log('Button push')
        self.table_pressed = True
        time.sleep(0.3)
        self.table_hold = True
        if self.table_pressed:
          self.log("Long press")
          self.long_press()
          self.table_dim = not self.table_dim
    
    elif self.click_type == 1004:
      if self.secondLight is not "none":
        self.log('Button double click')
        self.toggle(self.secondLight)

    elif self.click_type == 1005:
      if self.light is not "none":
        self.log('Button triple click')
        self.turn_on(self.light, color_temp = 366, brightness = 150)

    elif self.click_type == 1006:
      self.log('Button quadruple click')

  def long_press(self):
    self.log("Dimming")    
    prevBrightness = self.get_state(entity=self.args['lightId'], attribute="brightness")

    if self.table_dim == False and self.table_hold == True:
      while self.table_hold:
        prevBrightness = self.get_state(entity=self.args['lightId'], attribute="brightness")
        if prevBrightness == None:
          prevBrightness = 0
        self.new_brightness = prevBrightness + 10
        if self.new_brightness >= 255:
          self.new_brightness = 255
        self.turn_on(self.light, brightness = self.new_brightness)
      self.table_hold = False  

    elif self.table_dim == True and self.table_hold == True and self.get_state(self.light) == "on":
      while self.table_hold:
        self.new_brightness = self.get_state(self.light, attribute="brightness") - 10
        if self.new_brightness <= 0:
          self.new_brightness = 10
        self.turn_on(self.light, brightness = self.new_brightness)
      self.table_hold = False