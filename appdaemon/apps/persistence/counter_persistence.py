from base import Base
import appdaemon.plugins.hass.hassapi as hass
import globals
from globals import PEOPLE
import datetime
from datetime import timedelta, date

class CounterPersistence(Base):
    
    def initialize(self) -> None:
        """Initialize."""
        super().initialize()

        self.counter = self.args["counter"]
        self.input_number = self.args["input_number"]
        self.listen_state(self.mirror_counter, self.counter)
        self.listen_event(self.persist_counter, "plugin_started")
    
    def mirror_counter(self, entity, attribute, old, new, kwargs):
        number = self.get_state(self.input_number)
        if new > old and new > number:
            self.call_service("input_number/set_value", entity_id = self.input_number, value = new)
        elif new == "0":
            self.call_service("input_number/set_value", entity_id = self.input_number, value = 0.0)

    def persist_counter(self, event_name, data, kwargs):
        count = int(self.get_state(self.input_number).split('.')[0])
        for x in range(count + 1):
            self.log(count)
            self.log(self.get_state(self.counter))
            self.log(x)
            current_count = int(self.get_state(self.counter))
            if current_count < count:
                self.call_service("counter/increment", entity_id = self.counter)