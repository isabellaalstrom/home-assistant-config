from enum import Enum

# Global variables

ios_isa = 'ios_isabellas_iphone_x'
notify_ios_isa = "notify/ios_isabellas_iphone_x"

isa = "person.isa"
stefan = "person.stefan"

alarm = "alarm_control_panel.house"


notification_mode = {}
notification_mode["start_quiet_weekday"] = "23:00:00"
notification_mode["start_quiet_weekend"] = "23:59:00"
notification_mode["stop_quiet_weekday"] = "07:00:00"
notification_mode["stop_quiet_weekend"] = "09:00:00"


presence_state = {}
# Change this if you want to change the display name
presence_state["home"] = "Home"
presence_state["just_arrived"] = "Just arrived"
presence_state["just_left"] = "Just left"
presence_state["away"] = "Away"
presence_state["extended_away"] = "Extended away"


PEOPLE = {
    'Isa': {
        'device_tracker': 'device_tracker.isa_addon_presence',
        'proximity': 'proximity.home_isa',
        'notifier': 'ios_isabellas_iphone_x'
    },
    'Stefan': {
        'device_tracker': 'device_tracker.stefan_addon_presence',
        'proximity': 'proximity.home_stefan',
        'notifier': 'ios_stefan_iphone_7'
    }
}

