using JoySoftware.HomeAssistant.NetDaemon.Common;

namespace Netdaemon.Generated.Extensions
{
    public static partial class EntityExtension
    {
        public static LightEntities LightEx(this NetDaemonApp app) => new LightEntities(app);
        public static SwitchEntities SwitchEx(this NetDaemonApp app) => new SwitchEntities(app);
        public static AutomationEntities AutomationEx(this NetDaemonApp app) => new AutomationEntities(app);
        public static ScriptEntities ScriptEx(this NetDaemonApp app) => new ScriptEntities(app);
        public static MediaPlayerEntities MediaPlayerEx(this NetDaemonApp app) => new MediaPlayerEntities(app);
        public static CameraEntities CameraEx(this NetDaemonApp app) => new CameraEntities(app);
        public static SceneEntities SceneEx(this NetDaemonApp app) => new SceneEntities(app);
    }

    public partial class LightEntities
    {
        private readonly NetDaemonApp _app;
        public LightEntities(NetDaemonApp app)
        {
            _app = app;
        }

        public IEntity Telldus3 => _app.Entity("light.telldus_3");
        public IEntity StairsLights => _app.Entity("light.stairs_lights");
        public IEntity ChristmasStarLight => _app.Entity("light.christmas_star_light");
        public IEntity WalkInClosetLights => _app.Entity("light.walk_in_closet_lights");
        public IEntity OutdoorYardLightNet => _app.Entity("light.outdoor_yard_light_net");
        public IEntity PassageCeilingSpotlightsLevel => _app.Entity("light.passage_ceiling_spotlights_level");
        public IEntity StairsMiddleSpot => _app.Entity("light.stairs_middle_spot");
        public IEntity DownstairsLitterboxLightStrip => _app.Entity("light.downstairs_litterbox_light_strip");
        public IEntity WalkInCloset4 => _app.Entity("light.walk_in_closet_4");
        public IEntity BedroomCeilingLight => _app.Entity("light.bedroom_ceiling_light");
        public IEntity HallwayWindowLight => _app.Entity("light.hallway_window_light");
        public IEntity OutdoorLightStrings => _app.Entity("light.outdoor_light_strings");
        public IEntity StairsBottomSpot => _app.Entity("light.stairs_bottom_spot");
        public IEntity IsaFilament => _app.Entity("light.isa_filament");
        public IEntity IsaCeilingLight => _app.Entity("light.isa_ceiling_light");
        public IEntity Candles => _app.Entity("light.candles");
        public IEntity OutdoorLights => _app.Entity("light.outdoor_lights");
        public IEntity OutdoorWallLamps => _app.Entity("light.outdoor_wall_lamps");
        public IEntity UpstairsHallwayCeilingLightLevel => _app.Entity("light.upstairs_hallway_ceiling_light_level");
        public IEntity KitchenCeilingSpotlightsLevel => _app.Entity("light.kitchen_ceiling_spotlights_level");
        public IEntity WalkInCloset1 => _app.Entity("light.walk_in_closet_1");
        public IEntity WalkInCloset3 => _app.Entity("light.walk_in_closet_3");
        public IEntity LightsAutomation => _app.Entity("light.lights_automation");
        public IEntity OutdoorHangingLights => _app.Entity("light.outdoor_hanging_lights");
        public IEntity OutdoorFrontHangingLights => _app.Entity("light.outdoor_front_hanging_lights");
        public IEntity GatewayLight34ce008bfc4b => _app.Entity("light.gateway_light_34ce008bfc4b");
        public IEntity Globe => _app.Entity("light.globe");
        public IEntity StefanLightstrip => _app.Entity("light.stefan_lightstrip");
        public IEntity UpstairsLights => _app.Entity("light.upstairs_lights");
        public IEntity BedsideLamp => _app.Entity("light.bedside_lamp");
        public IEntity FloorlampReadingLight => _app.Entity("light.floorlamp_reading_light");
        public IEntity FloorlampUplight => _app.Entity("light.floorlamp_uplight");
        public IEntity LivingRoomSpotlightsLevel => _app.Entity("light.living_room_spotlights_level");
        public IEntity OutdoorLedstrip1 => _app.Entity("light.outdoor_ledstrip_1");
        public IEntity LivingRoomCeilingLightLevel => _app.Entity("light.living_room_ceiling_light_level");
        public IEntity OutdoorYardLight => _app.Entity("light.outdoor_yard_light");
        public IEntity StairsTopSpot => _app.Entity("light.stairs_top_spot");
        public IEntity OutdoorPlug => _app.Entity("light.outdoor_plug");
        public IEntity DownstairsLights => _app.Entity("light.downstairs_lights");
        public IEntity WalkInCloset2 => _app.Entity("light.walk_in_closet_2");
        public IEntity InsideLights => _app.Entity("light.inside_lights");
        public IEntity DiningRoomCeilingLightLevel => _app.Entity("light.dining_room_ceiling_light_level");
        public IEntity OutdoorFrontLight => _app.Entity("light.outdoor_front_light");
    }

    public partial class SwitchEntities
    {
        private readonly NetDaemonApp _app;
        public SwitchEntities(NetDaemonApp app)
        {
            _app = app;
        }

        public IEntity Dafang2NightVision => _app.Entity("switch.dafang_2_night_vision");
        public IEntity BikeCharger => _app.Entity("switch.bike_charger");
        public IEntity DafangMotionTracking => _app.Entity("switch.dafang_motion_tracking");
        public IEntity Switch2 => _app.Entity("switch.switch_2");
        public IEntity XiaofangServer => _app.Entity("switch.xiaofang_server");
        public IEntity DafangNightModeAuto => _app.Entity("switch.dafang_night_mode_auto");
        public IEntity DafangCalibrate => _app.Entity("switch.dafang_calibrate");
        public IEntity DafangBlueLed => _app.Entity("switch.dafang_blue_led");
        public IEntity DafangYellowLed => _app.Entity("switch.dafang_yellow_led");
        public IEntity DafangMotionSendMail => _app.Entity("switch.dafang_motion_send_mail");
        public IEntity DafangNightMode => _app.Entity("switch.dafang_night_mode");
        public IEntity DryerPlugSwitch => _app.Entity("switch.dryer_plug_switch");
        public IEntity DafangIrFilter => _app.Entity("switch.dafang_ir_filter");
        public IEntity XiaofangNightVision => _app.Entity("switch.xiaofang_night_vision");
        public IEntity DafangIrLed => _app.Entity("switch.dafang_ir_led");
        public IEntity DafangMotionSendTelegram => _app.Entity("switch.dafang_motion_send_telegram");
        public IEntity Switch3 => _app.Entity("switch.switch_3");
        public IEntity RoombaVacuum => _app.Entity("switch.roomba_vacuum");
        public IEntity Q90r => _app.Entity("switch.q90r");
        public IEntity OutdoorPlug => _app.Entity("switch.outdoor_plug");
        public IEntity DafangServer => _app.Entity("switch.dafang_server");
        public IEntity TurnOffServo => _app.Entity("switch.turn_off_servo");
        public IEntity LivingroomTv => _app.Entity("switch.livingroom_tv");
        public IEntity DafangH264RtspServer => _app.Entity("switch.dafang_h264_rtsp_server");
        public IEntity DafangMotionDetection => _app.Entity("switch.dafang_motion_detection");
        public IEntity Dafang2Calibrate => _app.Entity("switch.dafang_2_calibrate");
        public IEntity DimmerSwitch => _app.Entity("switch.dimmer_switch");
        public IEntity Dafang2Server => _app.Entity("switch.dafang_2_server");
        public IEntity DafangNightVision => _app.Entity("switch.dafang_night_vision");
        public IEntity DashboardRefreshPage => _app.Entity("switch.dashboard_refresh_page");
        public IEntity DafangMjpegRtspServer => _app.Entity("switch.dafang_mjpeg_rtsp_server");
        public IEntity WasherPlugSwitch => _app.Entity("switch.washer_plug_switch");
        public IEntity LivingroomMovieSystem => _app.Entity("switch.livingroom_movie_system");
        public IEntity SannceCalibrate => _app.Entity("switch.sannce_calibrate");
    }

    public partial class AutomationEntities
    {
        private readonly NetDaemonApp _app;
        public AutomationEntities(NetDaemonApp app)
        {
            _app = app;
        }

        public IEntity HouseDayModeToNight => _app.Entity("automation.house_day_mode_to_night");
        public IEntity SystemHassUpdater => _app.Entity("automation.system_hass_updater");
        public IEntity HouseGuestModeOn => _app.Entity("automation.house_guest_mode_on");
        public IEntity LivingRoomRollerBlindsDown2 => _app.Entity("automation.living_room_roller_blinds_down_2");
        public IEntity HouseGuestModeOff => _app.Entity("automation.house_guest_mode_off");
        public IEntity SystemHassNewPlatformDiscovered => _app.Entity("automation.system_hass_new_platform_discovered");
        public IEntity TtsSonosStefanLeavingGolfCourse => _app.Entity("automation.tts_sonos_stefan_leaving_golf_course");
        public IEntity FanSwitch => _app.Entity("automation.fan_switch");
        public IEntity SecurityRingDoorbellFlashLights => _app.Entity("automation.security_ring_doorbell_flash_lights");
        public IEntity CatsDownstairsLitterboxAutoLight => _app.Entity("automation.cats_downstairs_litterbox_auto_light");
        public IEntity HouseIsaModeOff => _app.Entity("automation.house_isa_mode_off");
        public IEntity SystemHassStarted => _app.Entity("automation.system_hass_started");
        public IEntity LightsLightsOnAtPresenceWhileDark => _app.Entity("automation.lights_lights_on_at_presence_while_dark");
        public IEntity WriteServoValueToEsp => _app.Entity("automation.write_servo_value_to_esp");
        public IEntity SystemIpBanNotify => _app.Entity("automation.system_ip_ban_notify");
        public IEntity SystemDeviceStatus => _app.Entity("automation.system_device_status");
        public IEntity LivingRoomRollerBlindDown => _app.Entity("automation.living_room_roller_blind_down");
        public IEntity SystemHassNewEntityRegistered => _app.Entity("automation.system_hass_new_entity_registered");
        public IEntity LivingRoomRollerBlindsDown => _app.Entity("automation.living_room_roller_blinds_down");
        public IEntity NewAutomation => _app.Entity("automation.new_automation");
        public IEntity TemperatureNotificationOnHighHumidityInDownstairsBathroom => _app.Entity("automation.temperature_notification_on_high_humidity_in_downstairs_bathroom");
        public IEntity SecurityKrisinformationNews => _app.Entity("automation.security_krisinformation_news");
        public IEntity LivingRoomRollerBlindUpAt10 => _app.Entity("automation.living_room_roller_blind_up_at_10");
        public IEntity LightsLightsOffWhenBedroomWindowOpen => _app.Entity("automation.lights_lights_off_when_bedroom_window_open");
        public IEntity SystemZWaveReady => _app.Entity("automation.system_z_wave_ready");
        public IEntity PresencePresenceHomebound => _app.Entity("automation.presence_presence_homebound");
        public IEntity SecuritySmokeAlarm => _app.Entity("automation.security_smoke_alarm");
        public IEntity PresencePresenceMqttEvent => _app.Entity("automation.presence_presence_mqtt_event");
        public IEntity HouseNotificationOnLowTempInBedroom => _app.Entity("automation.house_notification_on_low_temp_in_bedroom");
        public IEntity NotifyOnLowWaterLevel => _app.Entity("automation.notify_on_low_water_level");
        public IEntity CatsLitterboxAllCounterResetAtMidnight => _app.Entity("automation.cats_litterbox_all_counter_reset_at_midnight");
        public IEntity SystemMonitorStatus => _app.Entity("automation.system_monitor_status");
        public IEntity HouseCleaningMode => _app.Entity("automation.house_cleaning_mode");
        public IEntity LightsNotificationOnWindowOpenAndLightsOn => _app.Entity("automation.lights_notification_on_window_open_and_lights_on");
        public IEntity SystemHassStopped => _app.Entity("automation.system_hass_stopped");
        public IEntity LightsLightsOnPassageAtComingHomeAtNight => _app.Entity("automation.lights_lights_on_passage_at_coming_home_at_night");
        public IEntity LivingRoomRollerBlindDownAt06 => _app.Entity("automation.living_room_roller_blind_down_at_06");
        public IEntity SecurityRingDoorbellLowBattery => _app.Entity("automation.security_ring_doorbell_low_battery");
        public IEntity SystemHassNewDeviceTracked => _app.Entity("automation.system_hass_new_device_tracked");
        public IEntity SystemNewRepoInHacs => _app.Entity("automation.system_new_repo_in_hacs");
        public IEntity CatsSendImageToDiscord => _app.Entity("automation.cats_send_image_to_discord");
        public IEntity HouseNotificationOnHighTempInBedroom => _app.Entity("automation.house_notification_on_high_temp_in_bedroom");
        public IEntity LightsLightsOnAtComingHomeAtNightDelayTenThenOff => _app.Entity("automation.lights_lights_on_at_coming_home_at_night_delay_ten_then_off");
        public IEntity TtsSonosOnMediaCenterNotOn => _app.Entity("automation.tts_sonos_on_media_center_not_on");
        public IEntity SecurityKrisinformationAlert => _app.Entity("automation.security_krisinformation_alert");
        public IEntity HouseIsaModeAsk => _app.Entity("automation.house_isa_mode_ask");
        public IEntity TemperatureHighTemperatures => _app.Entity("automation.temperature_high_temperatures");
        public IEntity HouseIsaModeOn => _app.Entity("automation.house_isa_mode_on");
        public IEntity HouseCleaningModeOff => _app.Entity("automation.house_cleaning_mode_off");
    }

    public partial class ScriptEntities
    {
        private readonly NetDaemonApp _app;
        public ScriptEntities(NetDaemonApp app)
        {
            _app = app;
        }

        public IEntity SonosSay => _app.Entity("script.sonos_say");
        public IEntity SannceRight => _app.Entity("script.sannce_right");
        public IEntity CloseAtticCameraOnDashboard => _app.Entity("script.close_attic_camera_on_dashboard");
        public IEntity SannceCalibrate => _app.Entity("script.sannce_calibrate");
        public IEntity CleaningMusic => _app.Entity("script.cleaning_music");
        public IEntity DafangDown => _app.Entity("script.dafang_down");
        public IEntity AirCleanerAuto => _app.Entity("script.air_cleaner_auto");
        public IEntity Goodnight => _app.Entity("script.goodnight");
        public IEntity Dafang2Calibrate => _app.Entity("script.dafang_2_calibrate");
        public IEntity E1587035537523 => _app.Entity("script.1587035537523");
        public IEntity Dafang2Down => _app.Entity("script.dafang_2_down");
        public IEntity DafangCalibrate => _app.Entity("script.dafang_calibrate");
        public IEntity ShowAtticCameraOnDashboard => _app.Entity("script.show_attic_camera_on_dashboard");
        public IEntity CleaningTimeOver => _app.Entity("script.cleaning_time_over");
        public IEntity DafangUp => _app.Entity("script.dafang_up");
        public IEntity BedroomTvOnOff => _app.Entity("script.bedroom_tv_on_off");
        public IEntity GoodMorning => _app.Entity("script.good_morning");
        public IEntity E1587037128688 => _app.Entity("script.1587037128688");
        public IEntity AirCleanerTurbo => _app.Entity("script.air_cleaner_turbo");
        public IEntity AirCleanerQuiet => _app.Entity("script.air_cleaner_quiet");
        public IEntity Dafang2Left => _app.Entity("script.dafang_2_left");
        public IEntity TvOnOff => _app.Entity("script.tv_on_off");
        public IEntity DafangLeft => _app.Entity("script.dafang_left");
        public IEntity TvMuteUnmute => _app.Entity("script.tv_mute_unmute");
        public IEntity CleaningTime => _app.Entity("script.cleaning_time");
        public IEntity Dafang2Right => _app.Entity("script.dafang_2_right");
        public IEntity SannceDown => _app.Entity("script.sannce_down");
        public IEntity Dafang2Up => _app.Entity("script.dafang_2_up");
        public IEntity SannceLeft => _app.Entity("script.sannce_left");
        public IEntity DafangRight => _app.Entity("script.dafang_right");
        public IEntity SannceUp => _app.Entity("script.sannce_up");
        public IEntity MediaSystemOnOff => _app.Entity("script.media_system_on_off");
    }

    public partial class MediaPlayerEntities
    {
        private readonly NetDaemonApp _app;
        public MediaPlayerEntities(NetDaemonApp app)
        {
            _app = app;
        }

        public IMediaPlayer BedroomChromecast => _app.MediaPlayer("media_player.bedroom_chromecast");
        public IMediaPlayer SamsungHtE6730 => _app.MediaPlayer("media_player.samsung_ht_e6730");
        public IMediaPlayer Shield => _app.MediaPlayer("media_player.shield");
        public IMediaPlayer BedroomTv => _app.MediaPlayer("media_player.bedroom_tv");
        public IMediaPlayer ShieldPlex => _app.MediaPlayer("media_player.shield_plex");
        public IMediaPlayer LivingRoomTv => _app.MediaPlayer("media_player.living_room_tv");
        public IMediaPlayer Chromecast8855 => _app.MediaPlayer("media_player.chromecast8855");
        public IMediaPlayer LivingRoomNvidiaShield => _app.MediaPlayer("media_player.living_room_nvidia_shield");
        public IMediaPlayer LivingRoomSonos => _app.MediaPlayer("media_player.living_room_sonos");
    }

    public partial class CameraEntities
    {
        private readonly NetDaemonApp _app;
        public CameraEntities(NetDaemonApp app)
        {
            _app = app;
        }

        public ICamera FisksatraMeteogram => _app.Camera("camera.fisksatra_meteogram");
        public ICamera StockholmMeteogram => _app.Camera("camera.stockholm_meteogram");
        public ICamera FrontDoor => _app.Camera("camera.front_door");
        public ICamera Dafang1 => _app.Camera("camera.dafang_1");
        public ICamera IsasRoom => _app.Camera("camera.isas_room");
        public ICamera Attic => _app.Camera("camera.attic");
        public ICamera Haningestrand => _app.Camera("camera.haningestrand");
        public ICamera LivingRoomAxis => _app.Camera("camera.living_room_axis");
        public ICamera SnapshotIsasRoom => _app.Camera("camera.snapshot_isas_room");
        public ICamera SnapshotLivingRoom => _app.Camera("camera.snapshot_living_room");
        public ICamera DafangMotionSnapshot => _app.Camera("camera.dafang_motion_snapshot");
        public ICamera SnapshotPassage => _app.Camera("camera.snapshot_passage");
        public ICamera PassageAxis => _app.Camera("camera.passage_axis");
        public ICamera SnapshotHallway => _app.Camera("camera.snapshot_hallway");
        public ICamera Hallway => _app.Camera("camera.hallway");
        public ICamera UpstairsLitterbox => _app.Camera("camera.upstairs_litterbox");
        public ICamera SnapshotAttic => _app.Camera("camera.snapshot_attic");
        public ICamera Yard => _app.Camera("camera.yard");
        public ICamera Ender3Pro => _app.Camera("camera.ender_3_pro");
    }

    public partial class SceneEntities
    {
        private readonly NetDaemonApp _app;
        public SceneEntities(NetDaemonApp app)
        {
            _app = app;
        }

        public IEntity DarkLightsOn => _app.Entity("scene.dark_lights_on");
        public IEntity MorningLights => _app.Entity("scene.morning_lights");
        public IEntity FloorlampUplightNormal => _app.Entity("scene.floorlamp_uplight_normal");
        public IEntity EveningLights => _app.Entity("scene.evening_lights");
        public IEntity DarkLightsOff => _app.Entity("scene.dark_lights_off");
        public IEntity WelcomeHome => _app.Entity("scene.welcome_home");
        public IEntity MovieTime => _app.Entity("scene.movie_time");
    }
}