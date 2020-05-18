from base import Base
import globals
from globals import PEOPLE
import datetime
from datetime import timedelta, date

class VacuumingSchedule(Base):
    
    def initialize(self) -> None:
        """Initialize."""
        super().initialize()

        self.stefan = "person.stefan"
        self.isa = "person.isa"

        self.vacuum_downstairs_scheduled = "input_boolean.vacuum_downstairs_scheduled"
        self.vacuum_upstairs_scheduled = "input_boolean.vacuum_upstairs_scheduled"

        self.roborock = "vacuum.roborock"
        self.roomba = "vacuum.roomba"

        runtime = datetime.time(6, 45, 0)
        self.run_daily(self.ask_if_vacuum, runtime)

        self.listen_event(self.schedule_vacuuming_downstairs, "ios.notification_action_fired", actionName = "VACUUM_DOWNSTAIRS")
        self.listen_event(self.schedule_vacuuming_upstairs, "ios.notification_action_fired", actionName = "VACUUM_UPSTAIRS")
        self.listen_event(self.schedule_vacuuming_both, "ios.notification_action_fired", actionName = "VACUUM_BOTH")
        self.listen_event(self.no_scheduled_vacuuming, "ios.notification_action_fired", actionName = "VACUUM_STOP_ASKING")

        self.listen_state(self.check_for_start_vacuuming, self.stefan, old = "Just left")
        self.listen_state(self.check_for_start_vacuuming, self.isa, old = "Just left")
        self.listen_state(self.vacuuming_done, self.roborock, new = "docked", old = "returning")

    def check_for_start_vacuuming(self, entity, attribute, new, old, kwargs):
        if not self.presence_helper.anyone_home():
            if self.get_state(self.vacuum_downstairs_scheduled) == "on":
                self.call_service("vacuum/start", entity_id = self.roborock)
                self.notification_manager.log_home(message = "🧹 Starting vacuum downstairs.")
            if self.get_state(self.vacuum_upstairs_scheduled) == "on":
                self.call_service("vacuum/start", entity_id = self.roomba)
                self.notification_manager.log_home(message = "🧹 Starting vacuum upstairs.")
            self.turn_off(self.vacuum_downstairs_scheduled)
            self.turn_off(self.vacuum_upstairs_scheduled)

    def ask_if_vacuum(self, kwargs):
        if self.get_state("calendar.cleaning_day") == "off":
            self.notification_manager.log_home(message = "🧹 Asking about scheduling vacuuming today.")

            data = {"push":{"category": "vacuum", "thread-id": "vacuum"}}    
            self.notify("Where do you want to vacuum today?", name = 'mobile_app_isabella_s_iphone_x', data = data)
        else:
            self.notification_manager.log_home(message = "🧹 No robot vacuuming today - it's cleaning day.")

    def schedule_vacuuming_downstairs(self, event_name, data, kwargs):
        self.schedule_downstairs()

    def schedule_vacuuming_upstairs(self, event_name, data, kwargs):
        self.schedule_upstairs()

    def schedule_vacuuming_both(self, event_name, data, kwargs):
        self.schedule_downstairs()
        self.schedule_upstairs()

    def no_scheduled_vacuuming(self, event_name, data, kwargs):
        self.turn_off(self.vacuum_downstairs_scheduled)
        self.turn_off(self.vacuum_upstairs_scheduled)
        self.notification_manager.log_home(message = "🧹 No scheduled vacuuming today.")

    def schedule_downstairs(self):
        self.turn_on(self.vacuum_downstairs_scheduled)
        self.notification_manager.log_home(message = "🧹 Scheduling vacuuming downstairs.")

    def schedule_upstairs(self):
        self.turn_on(self.vacuum_upstairs_scheduled)
        self.notification_manager.log_home(message = "🧹 Scheduling vacuuming upstairs.")

    def vacuuming_done(self, entity, attribute, new, old, kwargs):
        vacuum_state = self.get_state(self.roborock, attribute="all")
        cleaned_area = vacuum_state["attributes"]["cleaned_area"]
        cleaning_time = vacuum_state["attributes"]["cleaning_time"]
        self.notification_manager.log_home(message = f"🧹 Roborock cleaned {cleaned_area} m² in {cleaning_time} minutes and is now docked.")
