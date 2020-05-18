from base import Base
from globals import PEOPLE
import globals
import json
import datetime as dt
from datetime import timedelta, date, datetime

class Summary(Base):
    def initialize(self) -> None:
        """Initialize."""
        super().initialize()
        self.listen_state(self.coming_home, PEOPLE['Isa']['device_tracker'], new = "Just arrived")
        
        self.run_daily(self.morning_summary, dt.time(8, 0, 0))

    def morning_summary(self, kwargs):
        self.make_todo_summary()

    def make_todo_summary(self):
        message = ""
        todoCount = 0

        messageOverdue = ""
        overdueCount = 0

        chores = self.get_state("sensor.grocy_chores", attribute = "all")["attributes"]["items"]
        sortedChores = sorted(chores, key=lambda r: r["_next_estimated_execution_time"])
        
        for chore in sortedChores:
            dueDate = datetime.strptime(chore["_next_estimated_execution_time"][0:10], "%Y-%m-%d")
            today = datetime.today()

            if today > dueDate:
                messageOverdue = messageOverdue + f"- {chore['_name']}.\n"
                overdueCount = overdueCount + 1

            if today is dueDate:
                message = message + f"- {chore['_name']} .\n"
                todoCount = todoCount + 1

        if message is not "":
            title = f"✅ {todoCount} Todo"
            self.call_service(PEOPLE['Isa']['notify/service'], title = title, message = message)
        if messageOverdue is not "":
            titleOverdue = f"❌ {overdueCount} Overdue"
            self.call_service(PEOPLE['Isa']['notify/service'], title = titleOverdue, message = messageOverdue)


    def coming_home(self, entity, attribute, new, old, kwargs):
        if (new != old):
            self.log("Isa has just arrived, building summary")
            self.build_coming_home()
            self.make_todo_summary()


        
    def build_coming_home(self):
        title = ""
        message = ""
        message_part = 0
        
        litterbox_downstairs_visits = self.get_state("counter.litterbox_downstairs_visits")
        litterbox_upstairs_visits = self.get_state("counter.litterbox_upstairs_visits")
        mailbox = self.get_state("input_select.mailbox_status")
        laundry = self.get_state("input_select.washing_machine_status")
        dryer = self.get_state("input_select.dryer_status")
        
        if (int(litterbox_downstairs_visits) > 0):
            # start = "" if message_part == 0 else " "
            end = "" if int(litterbox_upstairs_visits) > 1 else "."
            message = "💩 {} visits to downstairs litterbox".format(litterbox_downstairs_visits) + end
            message_part = message_part + 1
            
        if (int(litterbox_upstairs_visits) > 0):
            start = "💩 " if message_part == 0 else " and "
            message = message + start + "{} visits to upstairs litterbox".format(litterbox_upstairs_visits)
            message_part = message_part + 1
            
        if (mailbox != "Empty"):
            start = "" if message_part == 0 else "\n"
            message = message + start + "💌 You have {}.".format(mailbox.lower())
            message_part = message_part + 1
        
        if (laundry != "Idle"):
            start = "" if message_part == 0 else "\n"
            message = message + start + "👕 The laundry is {}.".format(laundry.lower())
            message_part = message_part + 1
        if (dryer != "Idle"):
            start = "" if message_part == 0 else "\n"
            message = message + start + "👔 The dryer is {}.".format(dryer.lower())
            message_part = message_part + 1
        if (message != ""):
            self.log(message)
            self.call_service(PEOPLE['Isa']['notify/service'], title = "🏠 Welcome home", message = message)