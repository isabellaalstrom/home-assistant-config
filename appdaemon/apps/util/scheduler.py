import datetime
from typing import Callable
from base import Base

class Scheduler(Base):
    def initialize(self):
        """Initialize."""
        super().initialize()

    def run_on_days(self, callback: Callable[..., None], day_list: list,
            start: datetime.time, **kwargs) -> list:
        """Run a callback on certain days (at the specified time)."""
        handle = []
        upcoming_days = []

        today = self.date()
        todays_event = datetime.datetime.combine(today, start)

        if todays_event > self.datetime():
            if today.strftime('%A') in day_list:
                upcoming_days.append(today)

        for day_number in range(1, 8):
            day = today + datetime.timedelta(days=day_number)
            if day.strftime('%A') in day_list:
                if len(upcoming_days) < len(day_list):
                    upcoming_days.append(day)

        for day in upcoming_days:
            event = datetime.datetime.combine(day, start)
            handle.append(self.run_every(callback, event, 604800, **kwargs))

        return handle


    def run_on_weekdays(self, callback: Callable[..., None], start: datetime.time,
            **kwargs) -> list:
        """Run a callback on weekdays (at the specified time)."""
        return self.run_on_days(
            callback, ['Monday', 'Tuesday', 'Wednesday', 'Thursday', 'Friday'],
            start, **kwargs)

    def run_on_weekend_days(self, callback: Callable[..., None], start: datetime.time,
            **kwargs) -> list:
        """Run a callback on weekend days (at the specified time)."""
        return self.run_on_days(callback, ['Saturday', 'Sunday'], start, **kwargs)

    def run_on_night_before_weekend_day(self, callback: Callable[..., None], start: datetime.time,
            **kwargs):
        """Run a callback on nights to weekend days (at the specified time)."""
        return self.run_on_days(callback, ['Saturday', 'Sunday'], start, **kwargs)

    def run_on_evening_before_weekday(self, callback: Callable[..., None], start: datetime.time,
            **kwargs) -> list:
        """Run a callback on evenings before weekdays (at the specified time)."""
        return self.run_on_days(callback, ['Monday', 'Tuesday', 'Wednesday', 'Thursday', 'Sunday'], start, **kwargs)
