from base import Base
import globals
from globals import PEOPLE
import datetime


class MedicineReminder(Base):

    def initialize(self) -> None:
        """Initialize."""
        super().initialize()

        self.remind_time = self.args["remind_time"]
        self.medicine_kind = self.args["medicine_kind"]
        self.notify_target = self.args["notify_target"]
        
        self.snoozed = False
        self.reminder_handle = None

        self.listen_event(self.cancel_reminder, "ios.notification_action_fired", actionName = "MEDICINE_TAKEN")
        self.beta_data = {"push":{"sound": {"critical": 1, "name": "default", "volume": 0.1 },"category": "MEDICINE", "thread-id": "medicine"}}    
        self.notify("Take the pill", title = "Medicine!", name = 'mobile_app_isabella_s_iphone_x', data = self.beta_data)
        runtime = self.parse_time(self.remind_time)
        self.run_daily(self.start_reminder, runtime)

    def start_reminder(self, kwargs):
        reminder_start = self.datetime()
        if (self.reminder_handle is not None):
            return
        else:
            self.reminder_handle = self.run_every(self.remind, reminder_start, 1200)
            
    def remind(self, kwargs):
        self.notification_manager.log_home(message = "Remind about medicine")

        self.beta_data = {"push":{"sound": {"critical": 1, "name": "default", "volume": 0.1 },"category": "MEDICINE", "thread-id": "medicine"}}
        self.notify("Take the pill", title = "Medicine!", name = 'mobile_app_isabella_s_iphone_x', data = self.beta_data)
        
    def cancel_reminder(self, event_name, data, kwargs):
        self.cancel_timer(self.reminder_handle)
        self.reminder_handle = None
        self.notification_manager.log_home(message = "Medicine reminder canceled.")
        
        