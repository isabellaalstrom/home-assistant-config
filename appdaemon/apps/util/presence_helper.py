from base import Base
import globals
from globals import PEOPLE

class PresenceHelper(Base):
    
    def initialize(self) -> None:
        """Initialize."""
        super().initialize()

    def anyone_home(self, **kwargs:dict) -> bool:
        isa = self.get_state(PEOPLE['Isa']['device_tracker'])
        stefan = self.get_state(PEOPLE['Stefan']['device_tracker'])
        if (stefan == "Just arrived" or stefan == "Home" or isa == "Just arrived" or isa == "Home"):
            return True
        else:
            return False
            
    def anyone_just_arrived(self, **kwargs:dict) -> bool:
        isa = self.get_state(PEOPLE['Isa']['device_tracker'])
        stefan = self.get_state(PEOPLE['Stefan']['device_tracker'])
        if (stefan == "Just arrived" or isa == "Just arrived"):
            return True
        else:
            return False

    def isa_home_alone(self, **kwargs:dict) -> bool:
        isa = self.get_state(PEOPLE['Isa']['device_tracker'])
        stefan = self.get_state(PEOPLE['Stefan']['device_tracker'])
        
        if (stefan != "Just arrived" or stefan != "Home"  or isa == "Just arrived" or isa == "Home"):
            return True
        else:
            return False