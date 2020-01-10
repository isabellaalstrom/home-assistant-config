from enum import Enum

# Global variables

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
        'person': 'person.isa',
        'device_tracker': 'device_tracker.isa_addon_presence',
        'proximity': 'proximity.home_isa',
        'notifier': 'mobile_app_isabella_s_iphone_x',
        'notify/service': 'notify/mobile_app_isabella_s_iphone_x',
        'wifi_tracker': 'device_tracker.isabellas_iphone_x_wifi',
        'bt_tracker_dining_room': 'sensor.dining_room_isabellas_iphone_x_bt',
        'bt_tracker_living_room': 'sensor.living_room_isabellas_iphone_x_bt'
    },
    'Stefan': {
        'person': 'person.stefan',
        'device_tracker': 'device_tracker.stefan_addon_presence',
        'proximity': 'proximity.home_stefan',
        'notifier': 'notify.mobile_app_igrims',
        'notify/service': 'notify/notify.mobile_app_igrims',
        'wifi_tracker': 'device_tracker.igrims',
        'bt_tracker_dining_room': 'sensor.dining_room_stefan_iphone_11_bt',
        'bt_tracker_living_room': 'sensor.living_room_stefan_iphone_11_bt'
    }
}

