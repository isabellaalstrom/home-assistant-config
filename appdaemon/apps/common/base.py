#
# Base class for all applications in my home automations setup. 
# Thanks to https://github.com/bachya/smart-home/ for inspiration 
# of code design and some solutions
#
from typing import Callable
import datetime

import appdaemon.plugins.hass.hassapi as hass
# from globals import GlobalEvents
import globals
from globals import PEOPLE

class Base(hass.Hass):
    """Define a base automation object."""

    def initialize(self) -> None:
        self.entities = self.args.get('entities', {})
        self.handles = {}  
        self.properties = self.args.get('properties', {})

        # Take every dependecy and create a reference to it:
        for app in self.args.get('dependencies', []):
            if not getattr(self, app, None):
                setattr(self, app, self.get_app(app))

    def turn_on_device(self, entity:str, **kwargs:dict) -> None:
        if entity.startswith('light'):
            self.call_service("light/turn_on", entity_id=entity, **kwargs) 
        else:
            self.turn_on(entity)

    def turn_off_device(self, entity:str, **kwargs:dict) -> None:
        
        if entity.startswith('light'):
            self.call_service("light/turn_off", entity_id=entity, **kwargs)
        else:
            self.turn_off(entity)
            
    # Helper functions to trigger on specific time and days
    def run_on_days(self,
            hass, callback: Callable[..., None], day_list: list,
            start: datetime.time, **kwargs):
        """Run a callback on certain days (at the specified time)."""
        handle = []
        upcoming_days = []

        today = hass.date()
        todays_event = datetime.datetime.combine(today, start)

        if (todays_event > hass.datetime()):
            if today.strftime('%A') in day_list:
                upcoming_days.append(today)

        for day_number in range(1, 8):
            day = today + datetime.timedelta(days=day_number)
            if day.strftime('%A') in day_list:
                if len(upcoming_days) < len(day_list):
                    upcoming_days.append(day)

        for day in upcoming_days:
            event = datetime.datetime.combine(day, start)
            handle.append(hass.run_every(callback, event, 604800, **kwargs))

        return handle

    def run_on_weekdays(self,
            hass, callback: Callable[..., None], start: datetime.time,
            **kwargs):
        """Run a callback on weekdays (at the specified time)."""
        return hass.run_on_days(callback, ['Monday', 'Tuesday', 'Wednesday', 'Thursday', 'Friday'], start, **kwargs)

    def run_on_weekend_days(self,
            hass, callback: Callable[..., None], start: datetime.time,
            **kwargs):
        """Run a callback on weekend days (at the specified time)."""
        return hass.run_on_days(callback, ['Saturday', 'Sunday'], start, **kwargs)

    def run_on_evening_before_weekend(self,
            hass, callback: Callable[..., None], start: datetime.time,
            **kwargs):
        """Run a callback on evenings before weekend days (at the specified time)."""
        return hass.run_on_days(callback, ['Friday', 'Saturday'], start, **kwargs)

    def run_on_evening_before_weekday(self,
            hass, callback: Callable[..., None], start: datetime.time,
            **kwargs) -> list:
        """Run a callback on evenings before weekdays (at the specified time)."""
        return hass.run_on_days(callback, ['Monday', 'Tuesday', 'Wednesday', 'Thursday', 'Sunday'], start, **kwargs)

class App(Base):
    """Define a base app object."""
    pass
    
