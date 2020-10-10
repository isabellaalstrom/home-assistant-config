using NetDaemon.Common;
using NetDaemon.Common.Fluent;

namespace Netdaemon.Generated.Extensions
{
    public static partial class EntityExtension
    {
        public static SwitchEntities SwitchEx(this NetDaemonApp app) => new SwitchEntities(app);
        public static AutomationEntities AutomationEx(this NetDaemonApp app) => new AutomationEntities(app);
        public static LightEntities LightEx(this NetDaemonApp app) => new LightEntities(app);
        public static CameraEntities CameraEx(this NetDaemonApp app) => new CameraEntities(app);
        public static ScriptEntities ScriptEx(this NetDaemonApp app) => new ScriptEntities(app);
        public static MediaPlayerEntities MediaPlayerEx(this NetDaemonApp app) => new MediaPlayerEntities(app);
        public static SceneEntities SceneEx(this NetDaemonApp app) => new SceneEntities(app);
    }

    public partial class SwitchEntities
    {
        private readonly NetDaemonApp _app;
        public SwitchEntities(NetDaemonApp app)
        {
            _app = app;
        }

        public IEntity Ac73bc0cfe8 => _app.Entity("switch.ac_73bc0cfe_8");
        public IEntity XiaofangLitterboxDownstairsYellowLed => _app.Entity("switch.xiaofang_litterbox_downstairs_yellow_led");
        public IEntity XiaofangYardBlueLed => _app.Entity("switch.xiaofang_yard_blue_led");
        public IEntity XiaofangNightVision => _app.Entity("switch.xiaofang_night_vision");
        public IEntity XiaofangYardMotionDetection => _app.Entity("switch.xiaofang_yard_motion_detection");
        public IEntity WasherPlugSwitch => _app.Entity("switch.washer_plug_switch");
        public IEntity NetdaemonCleaningMode => _app.Entity("switch.netdaemon_cleaning_mode");
        public IEntity XiaofangLitterboxDownstairsIrFilter => _app.Entity("switch.xiaofang_litterbox_downstairs_ir_filter");
        public IEntity DafangKitchenNightMode => _app.Entity("switch.dafang_kitchen_night_mode");
        public IEntity XiaofangMotionSendMail => _app.Entity("switch.xiaofang_motion_send_mail");
        public IEntity Ac26bc0cfe9 => _app.Entity("switch.ac_26bc0cfe_9");
        public IEntity XiaofangUpstairsLitterboxServer => _app.Entity("switch.xiaofang_upstairs_litterbox_server");
        public IEntity XiaofangLitterboxUpstairsYellowLed => _app.Entity("switch.xiaofang_litterbox_upstairs_yellow_led");
        public IEntity DafangKitchenMotionDetection => _app.Entity("switch.dafang_kitchen_motion_detection");
        public IEntity Ac37de34216 => _app.Entity("switch.ac_37de342_16");
        public IEntity XiaofangUpstairsLitterboxNightVision => _app.Entity("switch.xiaofang_upstairs_litterbox_night_vision");
        public IEntity Ac37de34214 => _app.Entity("switch.ac_37de342_14");
        public IEntity DafangKitchenH264RtspServer => _app.Entity("switch.dafang_kitchen_h264_rtsp_server");
        public IEntity DafangIsasroomBlueLed => _app.Entity("switch.dafang_isasroom_blue_led");
        public IEntity NetdaemonMotionSnapshot => _app.Entity("switch.netdaemon_motion_snapshot");
        public IEntity Ac17bc0cfe9 => _app.Entity("switch.ac_17bc0cfe_9");
        public IEntity XiaofangLitterboxDownstairsNightMode => _app.Entity("switch.xiaofang_litterbox_downstairs_night_mode");
        public IEntity XiaofangLitterboxUpstairsNightMode => _app.Entity("switch.xiaofang_litterbox_upstairs_night_mode");
        public IEntity XiaofangLitterboxDownstairsNightModeAuto => _app.Entity("switch.xiaofang_litterbox_downstairs_night_mode_auto");
        public IEntity XiaofangH264RtspServer => _app.Entity("switch.xiaofang_h264_rtsp_server");
        public IEntity XiaofangRecording => _app.Entity("switch.xiaofang_recording");
        public IEntity XiaofangLitterboxUpstairsMotionTracking => _app.Entity("switch.xiaofang_litterbox_upstairs_motion_tracking");
        public IEntity XiaofangIrFilter => _app.Entity("switch.xiaofang_ir_filter");
        public IEntity DafangNightVision => _app.Entity("switch.dafang_night_vision");
        public IEntity DafangKitchenBlueLed => _app.Entity("switch.dafang_kitchen_blue_led");
        public IEntity DafangIsasRoomServer => _app.Entity("switch.dafang_isas_room_server");
        public IEntity NetdaemonWasher => _app.Entity("switch.netdaemon_washer");
        public IEntity XiaofangLitterboxUpstairsIrFilter => _app.Entity("switch.xiaofang_litterbox_upstairs_ir_filter");
        public IEntity Ac82bc0cfe0 => _app.Entity("switch.ac_82bc0cfe_0");
        public IEntity Ac37de34215 => _app.Entity("switch.ac_37de342_15");
        public IEntity Ac61bc0cfe5 => _app.Entity("switch.ac_61bc0cfe_5");
        public IEntity DafangKitchenNightModeAuto => _app.Entity("switch.dafang_kitchen_night_mode_auto");
        public IEntity DryerPlugSwitch => _app.Entity("switch.dryer_plug_switch");
        public IEntity XiaofangLitterboxDownstairsIrLed => _app.Entity("switch.xiaofang_litterbox_downstairs_ir_led");
        public IEntity DafangIsasroomH264RtspServer => _app.Entity("switch.dafang_isasroom_h264_rtsp_server");
        public IEntity DafangCalibrate => _app.Entity("switch.dafang_calibrate");
        public IEntity DafangIsasroomNightModeAuto => _app.Entity("switch.dafang_isasroom_night_mode_auto");
        public IEntity XiaofangMotionDetection => _app.Entity("switch.xiaofang_motion_detection");
        public IEntity XiaofangYardIrFilter => _app.Entity("switch.xiaofang_yard_ir_filter");
        public IEntity XiaofangLitterboxDownstairsMotionDetection => _app.Entity("switch.xiaofang_litterbox_downstairs_motion_detection");
        public IEntity XiaofangLitterboxDownstairsMotionTracking => _app.Entity("switch.xiaofang_litterbox_downstairs_motion_tracking");
        public IEntity XiaofangYardH264RtspServer => _app.Entity("switch.xiaofang_yard_h264_rtsp_server");
        public IEntity SannceCalibrate => _app.Entity("switch.sannce_calibrate");
        public IEntity BikeCharger => _app.Entity("switch.bike_charger");
        public IEntity DafangKitchenYellowLed => _app.Entity("switch.dafang_kitchen_yellow_led");
        public IEntity Ac17bc0cfe8 => _app.Entity("switch.ac_17bc0cfe_8");
        public IEntity XiaofangLitterboxUpstairsMotionDetection => _app.Entity("switch.xiaofang_litterbox_upstairs_motion_detection");
        public IEntity DafangIsasroomNightMode => _app.Entity("switch.dafang_isasroom_night_mode");
        public IEntity DafangIsasRoomNightVision => _app.Entity("switch.dafang_isas_room_night_vision");
        public IEntity NetdaemonVacuum => _app.Entity("switch.netdaemon_vacuum");
        public IEntity TiguanCombustionEngineHeating => _app.Entity("switch.tiguan_combustion_engine_heating");
        public IEntity NetdaemonAirCleanerSchedule => _app.Entity("switch.netdaemon_air_cleaner_schedule");
        public IEntity XiaofangIrLed => _app.Entity("switch.xiaofang_ir_led");
        public IEntity DafangKitchenIrLed => _app.Entity("switch.dafang_kitchen_ir_led");
        public IEntity NetdaemonIsaMode => _app.Entity("switch.netdaemon_isa_mode");
        public IEntity LivingroomTv => _app.Entity("switch.livingroom_tv");
        public IEntity XiaofangYardNightMode => _app.Entity("switch.xiaofang_yard_night_mode");
        public IEntity XiaofangYardIrLed => _app.Entity("switch.xiaofang_yard_ir_led");
        public IEntity OutdoorYardHangingLights => _app.Entity("switch.outdoor_yard_hanging_lights");
        public IEntity XiaofangYardNightModeAuto => _app.Entity("switch.xiaofang_yard_night_mode_auto");
        public IEntity DafangKitchenMotionTracking => _app.Entity("switch.dafang_kitchen_motion_tracking");
        public IEntity NetdaemonAlarmHandler => _app.Entity("switch.netdaemon_alarm_handler");
        public IEntity XiaofangLitterboxDownstairsBlueLed => _app.Entity("switch.xiaofang_litterbox_downstairs_blue_led");
        public IEntity OutdoorPlug => _app.Entity("switch.outdoor_plug");
        public IEntity XiaofangNightModeAuto => _app.Entity("switch.xiaofang_night_mode_auto");
        public IEntity DafangIsasroomMotionDetection => _app.Entity("switch.dafang_isasroom_motion_detection");
        public IEntity DafangServer => _app.Entity("switch.dafang_server");
        public IEntity XiaofangYellowLed => _app.Entity("switch.xiaofang_yellow_led");
        public IEntity XiaofangBlueLed => _app.Entity("switch.xiaofang_blue_led");
        public IEntity XiaofangYardYellowLed => _app.Entity("switch.xiaofang_yard_yellow_led");
        public IEntity DafangIsasroomIrFilter => _app.Entity("switch.dafang_isasroom_ir_filter");
        public IEntity XiaofangLitterboxUpstairsH264RtspServer => _app.Entity("switch.xiaofang_litterbox_upstairs_h264_rtsp_server");
        public IEntity XiaofangNightMode => _app.Entity("switch.xiaofang_night_mode");
        public IEntity TiguanRequestInProgress => _app.Entity("switch.tiguan_request_in_progress");
        public IEntity XiaofangServer => _app.Entity("switch.xiaofang_server");
        public IEntity XiaofangLitterboxUpstairsBlueLed => _app.Entity("switch.xiaofang_litterbox_upstairs_blue_led");
        public IEntity XiaofangMotionTracking => _app.Entity("switch.xiaofang_motion_tracking");
        public IEntity XiaofangLitterboxDownstairsH264RtspServer => _app.Entity("switch.xiaofang_litterbox_downstairs_h264_rtsp_server");
        public IEntity BedroomTv => _app.Entity("switch.bedroom_tv");
        public IEntity DafangKitchenIrFilter => _app.Entity("switch.dafang_kitchen_ir_filter");
        public IEntity DafangIsasRoomCalibrate => _app.Entity("switch.dafang_isas_room_calibrate");
        public IEntity NetdaemonDryer => _app.Entity("switch.netdaemon_dryer");
        public IEntity DafangIsasroomYellowLed => _app.Entity("switch.dafang_isasroom_yellow_led");
        public IEntity XiaofangLitterboxUpstairsNightModeAuto => _app.Entity("switch.xiaofang_litterbox_upstairs_night_mode_auto");
        public IEntity XiaofangLitterboxUpstairsIrLed => _app.Entity("switch.xiaofang_litterbox_upstairs_ir_led");
        public IEntity DafangIsasroomIrLed => _app.Entity("switch.dafang_isasroom_ir_led");
    }

    public partial class AutomationEntities
    {
        private readonly NetDaemonApp _app;
        public AutomationEntities(NetDaemonApp app)
        {
            _app = app;
        }

        public IEntity HouseGuestModeOn => _app.Entity("automation.house_guest_mode_on");
        public IEntity NewAutomation => _app.Entity("automation.new_automation");
        public IEntity NotifyOnLowWaterLevel => _app.Entity("automation.notify_on_low_water_level");
        public IEntity CatsDownstairsLitterboxAutoLight => _app.Entity("automation.cats_downstairs_litterbox_auto_light");
        public IEntity LivingRoomRollerBlindDownAt06 => _app.Entity("automation.living_room_roller_blind_down_at_06");
        public IEntity LightsLightsOnAtComingHomeAtNightDelayTenThenTurnOffOutdoor => _app.Entity("automation.lights_lights_on_at_coming_home_at_night_delay_ten_then_turn_off_outdoor");
        public IEntity LightsBedroomCeilingLightSwitch => _app.Entity("automation.lights_bedroom_ceiling_light_switch");
        public IEntity LightsLightsOnAtPresenceWhileDark => _app.Entity("automation.lights_lights_on_at_presence_while_dark");
        public IEntity LightDashboardNoBlackout => _app.Entity("automation.light_dashboard_no_blackout");
        public IEntity SystemDeviceStatus => _app.Entity("automation.system_device_status");
        public IEntity AddGenericTest => _app.Entity("automation.add_generic_test");
        public IEntity ClimateHighTemperatures => _app.Entity("automation.climate_high_temperatures");
        public IEntity HouseRoborockFullBin => _app.Entity("automation.house_roborock_full_bin");
        public IEntity SystemAlertAcknowledgementAction => _app.Entity("automation.system_alert_acknowledgement_action");
        public IEntity SystemDiskSpaceFillingUp => _app.Entity("automation.system_disk_space_filling_up");
        public IEntity ClimateNotificationOnHighHumidityInDownstairsBathroom => _app.Entity("automation.climate_notification_on_high_humidity_in_downstairs_bathroom");
        public IEntity SecurityRingDoorbellFlashLights => _app.Entity("automation.security_ring_doorbell_flash_lights");
        public IEntity LightDashboardBlackout => _app.Entity("automation.light_dashboard_blackout");
        public IEntity HouseCleaningModeOff => _app.Entity("automation.house_cleaning_mode_off");
        public IEntity SecurityKrisinformationAlert => _app.Entity("automation.security_krisinformation_alert");
        public IEntity HouseSetWashingMachineLastUsedTime => _app.Entity("automation.house_set_washing_machine_last_used_time");
        public IEntity SystemIpBanNotify => _app.Entity("automation.system_ip_ban_notify");
        public IEntity HouseNotificationOnHighTempInBedroom => _app.Entity("automation.house_notification_on_high_temp_in_bedroom");
        public IEntity PresencePresenceHomebound => _app.Entity("automation.presence_presence_homebound");
        public IEntity SecuritySmokeAlarm => _app.Entity("automation.security_smoke_alarm");
        public IEntity LightsNotificationOnWindowOpenAndLightsOn => _app.Entity("automation.lights_notification_on_window_open_and_lights_on");
        public IEntity HouseNotificationOnLowTempInBedroom => _app.Entity("automation.house_notification_on_low_temp_in_bedroom");
        public IEntity CatsLitterboxAllCounterResetAtMidnight => _app.Entity("automation.cats_litterbox_all_counter_reset_at_midnight");
        public IEntity PresencePresenceMqttEvent => _app.Entity("automation.presence_presence_mqtt_event");
        public IEntity SystemHassStopped => _app.Entity("automation.system_hass_stopped");
        public IEntity SystemZWaveReady => _app.Entity("automation.system_z_wave_ready");
        public IEntity SystemMonitorStatus => _app.Entity("automation.system_monitor_status");
        public IEntity CatsSendImageToDiscord => _app.Entity("automation.cats_send_image_to_discord");
        public IEntity SystemHassStarted => _app.Entity("automation.system_hass_started");
        public IEntity SystemHassUpdater => _app.Entity("automation.system_hass_updater");
        public IEntity SystemHassNewPlatformDiscovered => _app.Entity("automation.system_hass_new_platform_discovered");
        public IEntity LightsLightsOnPassageAtComingHomeAtNight => _app.Entity("automation.lights_lights_on_passage_at_coming_home_at_night");
        public IEntity LivingRoomRollerBlindUpAt10 => _app.Entity("automation.living_room_roller_blind_up_at_10");
        public IEntity LightsLightsOffWhenBedroomWindowOpen => _app.Entity("automation.lights_lights_off_when_bedroom_window_open");
        public IEntity HouseGuestModeOff => _app.Entity("automation.house_guest_mode_off");
        public IEntity WriteServoValueToEsp => _app.Entity("automation.write_servo_value_to_esp");
        public IEntity TtsSonosStefanLeavingGolfCourse => _app.Entity("automation.tts_sonos_stefan_leaving_golf_course");
        public IEntity LivingRoomRollerBlindsDown => _app.Entity("automation.living_room_roller_blinds_down");
        public IEntity SecurityKrisinformationNews => _app.Entity("automation.security_krisinformation_news");
        public IEntity SystemHassNewDeviceTracked => _app.Entity("automation.system_hass_new_device_tracked");
        public IEntity FanSwitch => _app.Entity("automation.fan_switch");
        public IEntity SystemNewRepoInHacs => _app.Entity("automation.system_new_repo_in_hacs");
        public IEntity HouseCleaningMode => _app.Entity("automation.house_cleaning_mode");
        public IEntity SecurityRingDoorbellLowBattery => _app.Entity("automation.security_ring_doorbell_low_battery");
        public IEntity SystemHassNewEntityRegistered => _app.Entity("automation.system_hass_new_entity_registered");
        public IEntity LivingRoomRollerBlindDown => _app.Entity("automation.living_room_roller_blind_down");
        public IEntity LivingRoomRollerBlindsDown2 => _app.Entity("automation.living_room_roller_blinds_down_2");
    }

    public partial class LightEntities
    {
        private readonly NetDaemonApp _app;
        public LightEntities(NetDaemonApp app)
        {
            _app = app;
        }

        public IEntity OutdoorLights => _app.Entity("light.outdoor_lights");
        public IEntity StefanLightstrip => _app.Entity("light.stefan_lightstrip");
        public IEntity IsaFilament => _app.Entity("light.isa_filament");
        public IEntity OutdoorYardHangingLights => _app.Entity("light.outdoor_yard_hanging_lights");
        public IEntity WalkInCloset1 => _app.Entity("light.walk_in_closet_1");
        public IEntity OutdoorYardLight => _app.Entity("light.outdoor_yard_light");
        public IEntity OutdoorLightStrings => _app.Entity("light.outdoor_light_strings");
        public IEntity DownstairsLitterboxLightStrip => _app.Entity("light.downstairs_litterbox_light_strip");
        public IEntity FloorlampReadingLight => _app.Entity("light.floorlamp_reading_light");
        public IEntity BedsideLamp => _app.Entity("light.bedside_lamp");
        public IEntity PassageCeilingSpotlightsLevel => _app.Entity("light.passage_ceiling_spotlights_level");
        public IEntity StairsBottomSpot => _app.Entity("light.stairs_bottom_spot");
        public IEntity WalkInCloset4 => _app.Entity("light.walk_in_closet_4");
        public IEntity OutdoorFrontHangingLights => _app.Entity("light.outdoor_front_hanging_lights");
        public IEntity KitchenCeilingSpotlightsLevel => _app.Entity("light.kitchen_ceiling_spotlights_level");
        public IEntity OutdoorFrontLight => _app.Entity("light.outdoor_front_light");
        public IEntity UpstairsLights => _app.Entity("light.upstairs_lights");
        public IEntity UpstairsHallwayCeilingLightLevel => _app.Entity("light.upstairs_hallway_ceiling_light_level");
        public IEntity StairsLights => _app.Entity("light.stairs_lights");
        public IEntity StairsTopSpot => _app.Entity("light.stairs_top_spot");
        public IEntity StairsMiddleSpot => _app.Entity("light.stairs_middle_spot");
        public IEntity FloorlampUplight => _app.Entity("light.floorlamp_uplight");
        public IEntity OutdoorLedstrip1 => _app.Entity("light.outdoor_ledstrip_1");
        public IEntity HallwayWindowLight => _app.Entity("light.hallway_window_light");
        public IEntity Candles => _app.Entity("light.candles");
        public IEntity LightsAutomation => _app.Entity("light.lights_automation");
        public IEntity LivingRoomCeilingLightLevel => _app.Entity("light.living_room_ceiling_light_level");
        public IEntity ChristmasStarLight => _app.Entity("light.christmas_star_light");
        public IEntity OutdoorWallLamps => _app.Entity("light.outdoor_wall_lamps");
        public IEntity GatewayLight => _app.Entity("light.gateway_light");
        public IEntity InsideLights => _app.Entity("light.inside_lights");
        public IEntity WalkInClosetLights => _app.Entity("light.walk_in_closet_lights");
        public IEntity OutdoorYardLightNet => _app.Entity("light.outdoor_yard_light_net");
        public IEntity LivingRoomSpotlightsLevel => _app.Entity("light.living_room_spotlights_level");
        public IEntity WalkInCloset2 => _app.Entity("light.walk_in_closet_2");
        public IEntity IsaCeilingLight => _app.Entity("light.isa_ceiling_light");
        public IEntity DownstairsLights => _app.Entity("light.downstairs_lights");
        public IEntity BedroomCeilingLight => _app.Entity("light.bedroom_ceiling_light");
        public IEntity WalkInCloset3 => _app.Entity("light.walk_in_closet_3");
        public IEntity DiningRoomCeilingLightLevel => _app.Entity("light.dining_room_ceiling_light_level");
    }

    public partial class CameraEntities
    {
        private readonly NetDaemonApp _app;
        public CameraEntities(NetDaemonApp app)
        {
            _app = app;
        }

        public ICamera IsasRoom => _app.Camera("camera.isas_room");
        public ICamera RingDoorbell => _app.Camera("camera.ring_doorbell");
        public ICamera XiaofangYard => _app.Camera("camera.xiaofang_yard");
        public ICamera PassageAxis => _app.Camera("camera.passage_axis");
        public ICamera SnapshotDownstairsLitterbox => _app.Camera("camera.snapshot_downstairs_litterbox");
        public ICamera XiaofangMotionSnapshot => _app.Camera("camera.xiaofang_motion_snapshot");
        public ICamera XiaofangLitterboxUpstairsMotionSnapshot => _app.Camera("camera.xiaofang_litterbox_upstairs_motion_snapshot");
        public ICamera SnapshotLivingRoom => _app.Camera("camera.snapshot_living_room");
        public ICamera RockroboMap => _app.Camera("camera.rockrobo_map");
        public ICamera SnapshotPassage => _app.Camera("camera.snapshot_passage");
        public ICamera LivingRoomAxis => _app.Camera("camera.living_room_axis");
        public ICamera SnapshotIsasRoom => _app.Camera("camera.snapshot_isas_room");
        public ICamera Hallway => _app.Camera("camera.hallway");
        public ICamera SnapshotHallway => _app.Camera("camera.snapshot_hallway");
        public ICamera FisksatraMeteogram => _app.Camera("camera.fisksatra_meteogram");
        public ICamera DafangKitchenMotionSnapshot => _app.Camera("camera.dafang_kitchen_motion_snapshot");
        public ICamera SnapshotUpstairsLitterbox => _app.Camera("camera.snapshot_upstairs_litterbox");
        public ICamera DafangIsasroomMotionSnapshot => _app.Camera("camera.dafang_isasroom_motion_snapshot");
        public ICamera Yard => _app.Camera("camera.yard");
        public ICamera DafangKitchen => _app.Camera("camera.dafang_kitchen");
        public ICamera StockholmMeteogram => _app.Camera("camera.stockholm_meteogram");
        public ICamera XiaofangYardMotionSnapshot => _app.Camera("camera.xiaofang_yard_motion_snapshot");
        public ICamera XiaofangLitterboxDownstairsMotionSnapshot => _app.Camera("camera.xiaofang_litterbox_downstairs_motion_snapshot");
        public ICamera UpstairsLitterbox => _app.Camera("camera.upstairs_litterbox");
        public ICamera DownstairsLitterbox => _app.Camera("camera.downstairs_litterbox");
        public ICamera Ender3Pro => _app.Camera("camera.ender_3_pro");
        public ICamera Xiaofang2 => _app.Camera("camera.xiaofang_2");
    }

    public partial class ScriptEntities
    {
        private readonly NetDaemonApp _app;
        public ScriptEntities(NetDaemonApp app)
        {
            _app = app;
        }

        public IEntity SannceCalibrate => _app.Entity("script.sannce_calibrate");
        public IEntity DafangIsasRoomRight => _app.Entity("script.dafang_isas_room_right");
        public IEntity E1587035537523 => _app.Entity("script.1587035537523");
        public IEntity SannceLeft => _app.Entity("script.sannce_left");
        public IEntity DafangIsasRoomUp => _app.Entity("script.dafang_isas_room_up");
        public IEntity SannceUp => _app.Entity("script.sannce_up");
        public IEntity DafangIsasRoomDown => _app.Entity("script.dafang_isas_room_down");
        public IEntity SannceRight => _app.Entity("script.sannce_right");
        public IEntity DafangCalibrate => _app.Entity("script.dafang_calibrate");
        public IEntity CleaningTime => _app.Entity("script.cleaning_time");
        public IEntity AirCleanerQuiet => _app.Entity("script.air_cleaner_quiet");
        public IEntity DafangRight => _app.Entity("script.dafang_right");
        public IEntity DafangLeft => _app.Entity("script.dafang_left");
        public IEntity CleaningMusic => _app.Entity("script.cleaning_music");
        public IEntity GoodMorningLightsAndDisarm => _app.Entity("script.good_morning_lights_and_disarm");
        public IEntity SannceDown => _app.Entity("script.sannce_down");
        public IEntity SonosSay => _app.Entity("script.sonos_say");
        public IEntity DafangDown => _app.Entity("script.dafang_down");
        public IEntity CleaningTimeOver => _app.Entity("script.cleaning_time_over");
        public IEntity AirCleanerTurbo => _app.Entity("script.air_cleaner_turbo");
        public IEntity E1587037128688 => _app.Entity("script.1587037128688");
        public IEntity DafangIsasRoomLeft => _app.Entity("script.dafang_isas_room_left");
        public IEntity DafangUp => _app.Entity("script.dafang_up");
        public IEntity AirCleanerAuto => _app.Entity("script.air_cleaner_auto");
        public IEntity DafangIsasRoomCalibrate => _app.Entity("script.dafang_isas_room_calibrate");
    }

    public partial class MediaPlayerEntities
    {
        private readonly NetDaemonApp _app;
        public MediaPlayerEntities(NetDaemonApp app)
        {
            _app = app;
        }

        public IMediaPlayer ShieldPlex => _app.MediaPlayer("media_player.shield_plex");
        public IMediaPlayer LivingRoomTv => _app.MediaPlayer("media_player.living_room_tv");
        public IMediaPlayer SpotifyIsabellaGrossAlstrom => _app.MediaPlayer("media_player.spotify_isabella_gross_alstrom");
        public IMediaPlayer Chromecast8855 => _app.MediaPlayer("media_player.chromecast8855");
        public IMediaPlayer LivingRoomSonos => _app.MediaPlayer("media_player.living_room_sonos");
        public IMediaPlayer BedroomTv => _app.MediaPlayer("media_player.bedroom_tv");
        public IMediaPlayer Shield => _app.MediaPlayer("media_player.shield");
        public IMediaPlayer LivingRoomNvidiaShield => _app.MediaPlayer("media_player.living_room_nvidia_shield");
    }

    public partial class SceneEntities
    {
        private readonly NetDaemonApp _app;
        public SceneEntities(NetDaemonApp app)
        {
            _app = app;
        }

        public IEntity MovieTime => _app.Entity("scene.movie_time");
        public IEntity FloorlampUplightNormal => _app.Entity("scene.floorlamp_uplight_normal");
        public IEntity WelcomeHome => _app.Entity("scene.welcome_home");
        public IEntity Goodnight => _app.Entity("scene.goodnight");
        public IEntity EveningLights => _app.Entity("scene.evening_lights");
        public IEntity MorningLights => _app.Entity("scene.morning_lights");
        public IEntity DarkLightsOff => _app.Entity("scene.dark_lights_off");
        public IEntity DarkLightsOn => _app.Entity("scene.dark_lights_on");
    }
}