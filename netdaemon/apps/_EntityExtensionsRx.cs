using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using NetDaemon.Common;
using NetDaemon.Common.Reactive;
using NetDaemon.Common.Fluent;

namespace Netdaemon.Generated.Reactive
{
    public class GeneratedAppBase : NetDaemonRxApp
    {
        public SwitchEntities Switch => new SwitchEntities(this);
        public AutomationEntities Automation => new AutomationEntities(this);
        public LightEntities Light => new LightEntities(this);
        public CameraEntities Camera => new CameraEntities(this);
        public BinarySensorEntities BinarySensor => new BinarySensorEntities(this);
        public SensorEntities Sensor => new SensorEntities(this);
        public InputBooleanEntities InputBoolean => new InputBooleanEntities(this);
        public CoverEntities Cover => new CoverEntities(this);
        public CalendarEntities Calendar => new CalendarEntities(this);
        public RemoteEntities Remote => new RemoteEntities(this);
        public DeviceTrackerEntities DeviceTracker => new DeviceTrackerEntities(this);
        public InputSelectEntities InputSelect => new InputSelectEntities(this);
        public ScriptEntity Script => new ScriptEntity(this, new string[]{""});
        public ZoneEntities Zone => new ZoneEntities(this);
        public LockEntities Lock => new LockEntities(this);
        public MediaPlayerEntities MediaPlayer => new MediaPlayerEntities(this);
        public ZwaveEntities Zwave => new ZwaveEntities(this);
        public SceneEntities Scene => new SceneEntities(this);
        public PlantEntities Plant => new PlantEntities(this);
        public InputNumberEntities InputNumber => new InputNumberEntities(this);
        public SunEntities Sun => new SunEntities(this);
        public NetdaemonEntities Netdaemon => new NetdaemonEntities(this);
        public AlertEntities Alert => new AlertEntities(this);
        public ClimateEntities Climate => new ClimateEntities(this);
        public VacuumEntities Vacuum => new VacuumEntities(this);
        public WeatherEntities Weather => new WeatherEntities(this);
        public AlarmControlPanelEntities AlarmControlPanel => new AlarmControlPanelEntities(this);
        public CounterEntities Counter => new CounterEntities(this);
        public EntityControllerEntities EntityController => new EntityControllerEntities(this);
        public PersonEntities Person => new PersonEntities(this);
        public InputDatetimeEntities InputDatetime => new InputDatetimeEntities(this);
        public ImageProcessingEntities ImageProcessing => new ImageProcessingEntities(this);
        public ProximityEntities Proximity => new ProximityEntities(this);
    }

    public partial class SwitchEntity : RxEntity
    {
        public string EntityId => EntityIds.First();
        public string? Area => DaemonRxApp.State(EntityId)?.Area;
        public dynamic? Attribute => DaemonRxApp.State(EntityId)?.Attribute;
        public DateTime LastChanged => DaemonRxApp.State(EntityId).LastChanged;
        public DateTime LastUpdated => DaemonRxApp.State(EntityId).LastUpdated;
        public dynamic? State => DaemonRxApp.State(EntityId)?.State;
        public SwitchEntity(INetDaemonReactive daemon, IEnumerable<string> entityIds): base(daemon, entityIds)
        {
        }
    }

    public partial class AutomationEntity : RxEntity
    {
        public string EntityId => EntityIds.First();
        public string? Area => DaemonRxApp.State(EntityId)?.Area;
        public dynamic? Attribute => DaemonRxApp.State(EntityId)?.Attribute;
        public DateTime LastChanged => DaemonRxApp.State(EntityId).LastChanged;
        public DateTime LastUpdated => DaemonRxApp.State(EntityId).LastUpdated;
        public dynamic? State => DaemonRxApp.State(EntityId)?.State;
        public AutomationEntity(INetDaemonReactive daemon, IEnumerable<string> entityIds): base(daemon, entityIds)
        {
        }

        public void Trigger(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            serviceData["entity_id"] = EntityId;
            DaemonRxApp.CallService("automation", "trigger", serviceData);
        }

        public void Reload(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("automation", "reload", serviceData);
        }
    }

    public partial class LightEntity : RxEntity
    {
        public string EntityId => EntityIds.First();
        public string? Area => DaemonRxApp.State(EntityId)?.Area;
        public dynamic? Attribute => DaemonRxApp.State(EntityId)?.Attribute;
        public DateTime LastChanged => DaemonRxApp.State(EntityId).LastChanged;
        public DateTime LastUpdated => DaemonRxApp.State(EntityId).LastUpdated;
        public dynamic? State => DaemonRxApp.State(EntityId)?.State;
        public LightEntity(INetDaemonReactive daemon, IEnumerable<string> entityIds): base(daemon, entityIds)
        {
        }
    }

    public partial class CameraEntity : RxEntity
    {
        public string EntityId => EntityIds.First();
        public string? Area => DaemonRxApp.State(EntityId)?.Area;
        public dynamic? Attribute => DaemonRxApp.State(EntityId)?.Attribute;
        public DateTime LastChanged => DaemonRxApp.State(EntityId).LastChanged;
        public DateTime LastUpdated => DaemonRxApp.State(EntityId).LastUpdated;
        public dynamic? State => DaemonRxApp.State(EntityId)?.State;
        public CameraEntity(INetDaemonReactive daemon, IEnumerable<string> entityIds): base(daemon, entityIds)
        {
        }

        public void EnableMotionDetection(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            serviceData["entity_id"] = EntityId;
            DaemonRxApp.CallService("camera", "enable_motion_detection", serviceData);
        }

        public void DisableMotionDetection(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            serviceData["entity_id"] = EntityId;
            DaemonRxApp.CallService("camera", "disable_motion_detection", serviceData);
        }

        public void Snapshot(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            serviceData["entity_id"] = EntityId;
            DaemonRxApp.CallService("camera", "snapshot", serviceData);
        }

        public void PlayStream(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            serviceData["entity_id"] = EntityId;
            DaemonRxApp.CallService("camera", "play_stream", serviceData);
        }

        public void Record(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            serviceData["entity_id"] = EntityId;
            DaemonRxApp.CallService("camera", "record", serviceData);
        }
    }

    public partial class BinarySensorEntity : RxEntity
    {
        public string EntityId => EntityIds.First();
        public string? Area => DaemonRxApp.State(EntityId)?.Area;
        public dynamic? Attribute => DaemonRxApp.State(EntityId)?.Attribute;
        public DateTime LastChanged => DaemonRxApp.State(EntityId).LastChanged;
        public DateTime LastUpdated => DaemonRxApp.State(EntityId).LastUpdated;
        public dynamic? State => DaemonRxApp.State(EntityId)?.State;
        public BinarySensorEntity(INetDaemonReactive daemon, IEnumerable<string> entityIds): base(daemon, entityIds)
        {
        }
    }

    public partial class SensorEntity : RxEntity
    {
        public string EntityId => EntityIds.First();
        public string? Area => DaemonRxApp.State(EntityId)?.Area;
        public dynamic? Attribute => DaemonRxApp.State(EntityId)?.Attribute;
        public DateTime LastChanged => DaemonRxApp.State(EntityId).LastChanged;
        public DateTime LastUpdated => DaemonRxApp.State(EntityId).LastUpdated;
        public dynamic? State => DaemonRxApp.State(EntityId)?.State;
        public SensorEntity(INetDaemonReactive daemon, IEnumerable<string> entityIds): base(daemon, entityIds)
        {
        }
    }

    public partial class InputBooleanEntity : RxEntity
    {
        public string EntityId => EntityIds.First();
        public string? Area => DaemonRxApp.State(EntityId)?.Area;
        public dynamic? Attribute => DaemonRxApp.State(EntityId)?.Attribute;
        public DateTime LastChanged => DaemonRxApp.State(EntityId).LastChanged;
        public DateTime LastUpdated => DaemonRxApp.State(EntityId).LastUpdated;
        public dynamic? State => DaemonRxApp.State(EntityId)?.State;
        public InputBooleanEntity(INetDaemonReactive daemon, IEnumerable<string> entityIds): base(daemon, entityIds)
        {
        }

        public void Reload(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("input_boolean", "reload", serviceData);
        }
    }

    public partial class CoverEntity : RxEntity
    {
        public string EntityId => EntityIds.First();
        public string? Area => DaemonRxApp.State(EntityId)?.Area;
        public dynamic? Attribute => DaemonRxApp.State(EntityId)?.Attribute;
        public DateTime LastChanged => DaemonRxApp.State(EntityId).LastChanged;
        public DateTime LastUpdated => DaemonRxApp.State(EntityId).LastUpdated;
        public dynamic? State => DaemonRxApp.State(EntityId)?.State;
        public CoverEntity(INetDaemonReactive daemon, IEnumerable<string> entityIds): base(daemon, entityIds)
        {
        }

        public void OpenCover(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            serviceData["entity_id"] = EntityId;
            DaemonRxApp.CallService("cover", "open_cover", serviceData);
        }

        public void CloseCover(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            serviceData["entity_id"] = EntityId;
            DaemonRxApp.CallService("cover", "close_cover", serviceData);
        }

        public void SetCoverPosition(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            serviceData["entity_id"] = EntityId;
            DaemonRxApp.CallService("cover", "set_cover_position", serviceData);
        }

        public void StopCover(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            serviceData["entity_id"] = EntityId;
            DaemonRxApp.CallService("cover", "stop_cover", serviceData);
        }

        public void OpenCoverTilt(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            serviceData["entity_id"] = EntityId;
            DaemonRxApp.CallService("cover", "open_cover_tilt", serviceData);
        }

        public void CloseCoverTilt(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            serviceData["entity_id"] = EntityId;
            DaemonRxApp.CallService("cover", "close_cover_tilt", serviceData);
        }

        public void StopCoverTilt(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            serviceData["entity_id"] = EntityId;
            DaemonRxApp.CallService("cover", "stop_cover_tilt", serviceData);
        }

        public void SetCoverTiltPosition(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            serviceData["entity_id"] = EntityId;
            DaemonRxApp.CallService("cover", "set_cover_tilt_position", serviceData);
        }

        public void ToggleCoverTilt(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            serviceData["entity_id"] = EntityId;
            DaemonRxApp.CallService("cover", "toggle_cover_tilt", serviceData);
        }
    }

    public partial class CalendarEntity : RxEntity
    {
        public string EntityId => EntityIds.First();
        public string? Area => DaemonRxApp.State(EntityId)?.Area;
        public dynamic? Attribute => DaemonRxApp.State(EntityId)?.Attribute;
        public DateTime LastChanged => DaemonRxApp.State(EntityId).LastChanged;
        public DateTime LastUpdated => DaemonRxApp.State(EntityId).LastUpdated;
        public dynamic? State => DaemonRxApp.State(EntityId)?.State;
        public CalendarEntity(INetDaemonReactive daemon, IEnumerable<string> entityIds): base(daemon, entityIds)
        {
        }
    }

    public partial class RemoteEntity : RxEntity
    {
        public string EntityId => EntityIds.First();
        public string? Area => DaemonRxApp.State(EntityId)?.Area;
        public dynamic? Attribute => DaemonRxApp.State(EntityId)?.Attribute;
        public DateTime LastChanged => DaemonRxApp.State(EntityId).LastChanged;
        public DateTime LastUpdated => DaemonRxApp.State(EntityId).LastUpdated;
        public dynamic? State => DaemonRxApp.State(EntityId)?.State;
        public RemoteEntity(INetDaemonReactive daemon, IEnumerable<string> entityIds): base(daemon, entityIds)
        {
        }

        public void SendCommand(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            serviceData["entity_id"] = EntityId;
            DaemonRxApp.CallService("remote", "send_command", serviceData);
        }

        public void LearnCommand(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            serviceData["entity_id"] = EntityId;
            DaemonRxApp.CallService("remote", "learn_command", serviceData);
        }
    }

    public partial class DeviceTrackerEntity : RxEntity
    {
        public string EntityId => EntityIds.First();
        public string? Area => DaemonRxApp.State(EntityId)?.Area;
        public dynamic? Attribute => DaemonRxApp.State(EntityId)?.Attribute;
        public DateTime LastChanged => DaemonRxApp.State(EntityId).LastChanged;
        public DateTime LastUpdated => DaemonRxApp.State(EntityId).LastUpdated;
        public dynamic? State => DaemonRxApp.State(EntityId)?.State;
        public DeviceTrackerEntity(INetDaemonReactive daemon, IEnumerable<string> entityIds): base(daemon, entityIds)
        {
        }

        public void See(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("device_tracker", "see", serviceData);
        }
    }

    public partial class InputSelectEntity : RxEntity
    {
        public string EntityId => EntityIds.First();
        public string? Area => DaemonRxApp.State(EntityId)?.Area;
        public dynamic? Attribute => DaemonRxApp.State(EntityId)?.Attribute;
        public DateTime LastChanged => DaemonRxApp.State(EntityId).LastChanged;
        public DateTime LastUpdated => DaemonRxApp.State(EntityId).LastUpdated;
        public dynamic? State => DaemonRxApp.State(EntityId)?.State;
        public InputSelectEntity(INetDaemonReactive daemon, IEnumerable<string> entityIds): base(daemon, entityIds)
        {
        }

        public void Reload(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("input_select", "reload", serviceData);
        }

        public void SelectOption(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            serviceData["entity_id"] = EntityId;
            DaemonRxApp.CallService("input_select", "select_option", serviceData);
        }

        public void SelectNext(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            serviceData["entity_id"] = EntityId;
            DaemonRxApp.CallService("input_select", "select_next", serviceData);
        }

        public void SelectPrevious(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            serviceData["entity_id"] = EntityId;
            DaemonRxApp.CallService("input_select", "select_previous", serviceData);
        }

        public void SetOptions(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            serviceData["entity_id"] = EntityId;
            DaemonRxApp.CallService("input_select", "set_options", serviceData);
        }
    }

    public partial class ScriptEntity : RxEntity
    {
        public string EntityId => EntityIds.First();
        public string? Area => DaemonRxApp.State(EntityId)?.Area;
        public dynamic? Attribute => DaemonRxApp.State(EntityId)?.Attribute;
        public DateTime LastChanged => DaemonRxApp.State(EntityId).LastChanged;
        public DateTime LastUpdated => DaemonRxApp.State(EntityId).LastUpdated;
        public dynamic? State => DaemonRxApp.State(EntityId)?.State;
        public ScriptEntity(INetDaemonReactive daemon, IEnumerable<string> entityIds): base(daemon, entityIds)
        {
        }

        public void S1587035537523(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("script", "1587035537523", serviceData);
        }

        public void S1587037128688(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("script", "1587037128688", serviceData);
        }

        public void GoodMorningLightsAndDisarm(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("script", "good_morning_lights_and_disarm", serviceData);
        }

        public void SonosSay(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("script", "sonos_say", serviceData);
        }

        public void CleaningTime(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("script", "cleaning_time", serviceData);
        }

        public void CleaningTimeOver(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("script", "cleaning_time_over", serviceData);
        }

        public void CleaningMusic(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("script", "cleaning_music", serviceData);
        }

        public void DafangIsasRoomUp(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("script", "dafang_isas_room_up", serviceData);
        }

        public void DafangIsasRoomDown(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("script", "dafang_isas_room_down", serviceData);
        }

        public void DafangIsasRoomLeft(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("script", "dafang_isas_room_left", serviceData);
        }

        public void DafangIsasRoomRight(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("script", "dafang_isas_room_right", serviceData);
        }

        public void DafangIsasRoomCalibrate(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("script", "dafang_isas_room_calibrate", serviceData);
        }

        public void DafangUp(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("script", "dafang_up", serviceData);
        }

        public void DafangDown(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("script", "dafang_down", serviceData);
        }

        public void DafangLeft(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("script", "dafang_left", serviceData);
        }

        public void DafangRight(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("script", "dafang_right", serviceData);
        }

        public void DafangCalibrate(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("script", "dafang_calibrate", serviceData);
        }

        public void SannceUp(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("script", "sannce_up", serviceData);
        }

        public void SannceDown(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("script", "sannce_down", serviceData);
        }

        public void SannceLeft(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("script", "sannce_left", serviceData);
        }

        public void SannceRight(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("script", "sannce_right", serviceData);
        }

        public void SannceCalibrate(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("script", "sannce_calibrate", serviceData);
        }

        public void AirCleanerQuiet(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("script", "air_cleaner_quiet", serviceData);
        }

        public void AirCleanerAuto(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("script", "air_cleaner_auto", serviceData);
        }

        public void AirCleanerTurbo(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("script", "air_cleaner_turbo", serviceData);
        }

        public void Reload(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("script", "reload", serviceData);
        }
    }

    public partial class ZoneEntity : RxEntity
    {
        public string EntityId => EntityIds.First();
        public string? Area => DaemonRxApp.State(EntityId)?.Area;
        public dynamic? Attribute => DaemonRxApp.State(EntityId)?.Attribute;
        public DateTime LastChanged => DaemonRxApp.State(EntityId).LastChanged;
        public DateTime LastUpdated => DaemonRxApp.State(EntityId).LastUpdated;
        public dynamic? State => DaemonRxApp.State(EntityId)?.State;
        public ZoneEntity(INetDaemonReactive daemon, IEnumerable<string> entityIds): base(daemon, entityIds)
        {
        }

        public void Reload(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("zone", "reload", serviceData);
        }
    }

    public partial class LockEntity : RxEntity
    {
        public string EntityId => EntityIds.First();
        public string? Area => DaemonRxApp.State(EntityId)?.Area;
        public dynamic? Attribute => DaemonRxApp.State(EntityId)?.Attribute;
        public DateTime LastChanged => DaemonRxApp.State(EntityId).LastChanged;
        public DateTime LastUpdated => DaemonRxApp.State(EntityId).LastUpdated;
        public dynamic? State => DaemonRxApp.State(EntityId)?.State;
        public LockEntity(INetDaemonReactive daemon, IEnumerable<string> entityIds): base(daemon, entityIds)
        {
        }

        public void Unlock(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            serviceData["entity_id"] = EntityId;
            DaemonRxApp.CallService("lock", "unlock", serviceData);
        }

        public void Lock(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            serviceData["entity_id"] = EntityId;
            DaemonRxApp.CallService("lock", "lock", serviceData);
        }

        public void Open(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            serviceData["entity_id"] = EntityId;
            DaemonRxApp.CallService("lock", "open", serviceData);
        }

        public void SetUsercode(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("lock", "set_usercode", serviceData);
        }

        public void GetUsercode(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("lock", "get_usercode", serviceData);
        }

        public void ClearUsercode(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("lock", "clear_usercode", serviceData);
        }
    }

    public partial class MediaPlayerEntity : RxEntity
    {
        public string EntityId => EntityIds.First();
        public string? Area => DaemonRxApp.State(EntityId)?.Area;
        public dynamic? Attribute => DaemonRxApp.State(EntityId)?.Attribute;
        public DateTime LastChanged => DaemonRxApp.State(EntityId).LastChanged;
        public DateTime LastUpdated => DaemonRxApp.State(EntityId).LastUpdated;
        public dynamic? State => DaemonRxApp.State(EntityId)?.State;
        public MediaPlayerEntity(INetDaemonReactive daemon, IEnumerable<string> entityIds): base(daemon, entityIds)
        {
        }

        public void VolumeUp(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            serviceData["entity_id"] = EntityId;
            DaemonRxApp.CallService("media_player", "volume_up", serviceData);
        }

        public void VolumeDown(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            serviceData["entity_id"] = EntityId;
            DaemonRxApp.CallService("media_player", "volume_down", serviceData);
        }

        public void MediaPlayPause(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            serviceData["entity_id"] = EntityId;
            DaemonRxApp.CallService("media_player", "media_play_pause", serviceData);
        }

        public void MediaPlay(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            serviceData["entity_id"] = EntityId;
            DaemonRxApp.CallService("media_player", "media_play", serviceData);
        }

        public void MediaPause(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            serviceData["entity_id"] = EntityId;
            DaemonRxApp.CallService("media_player", "media_pause", serviceData);
        }

        public void MediaStop(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            serviceData["entity_id"] = EntityId;
            DaemonRxApp.CallService("media_player", "media_stop", serviceData);
        }

        public void MediaNextTrack(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            serviceData["entity_id"] = EntityId;
            DaemonRxApp.CallService("media_player", "media_next_track", serviceData);
        }

        public void MediaPreviousTrack(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            serviceData["entity_id"] = EntityId;
            DaemonRxApp.CallService("media_player", "media_previous_track", serviceData);
        }

        public void ClearPlaylist(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            serviceData["entity_id"] = EntityId;
            DaemonRxApp.CallService("media_player", "clear_playlist", serviceData);
        }

        public void VolumeSet(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            serviceData["entity_id"] = EntityId;
            DaemonRxApp.CallService("media_player", "volume_set", serviceData);
        }

        public void VolumeMute(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            serviceData["entity_id"] = EntityId;
            DaemonRxApp.CallService("media_player", "volume_mute", serviceData);
        }

        public void MediaSeek(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            serviceData["entity_id"] = EntityId;
            DaemonRxApp.CallService("media_player", "media_seek", serviceData);
        }

        public void SelectSource(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            serviceData["entity_id"] = EntityId;
            DaemonRxApp.CallService("media_player", "select_source", serviceData);
        }

        public void SelectSoundMode(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            serviceData["entity_id"] = EntityId;
            DaemonRxApp.CallService("media_player", "select_sound_mode", serviceData);
        }

        public void PlayMedia(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            serviceData["entity_id"] = EntityId;
            DaemonRxApp.CallService("media_player", "play_media", serviceData);
        }

        public void ShuffleSet(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            serviceData["entity_id"] = EntityId;
            DaemonRxApp.CallService("media_player", "shuffle_set", serviceData);
        }
    }

    public partial class ZwaveEntity : RxEntity
    {
        public string EntityId => EntityIds.First();
        public string? Area => DaemonRxApp.State(EntityId)?.Area;
        public dynamic? Attribute => DaemonRxApp.State(EntityId)?.Attribute;
        public DateTime LastChanged => DaemonRxApp.State(EntityId).LastChanged;
        public DateTime LastUpdated => DaemonRxApp.State(EntityId).LastUpdated;
        public dynamic? State => DaemonRxApp.State(EntityId)?.State;
        public ZwaveEntity(INetDaemonReactive daemon, IEnumerable<string> entityIds): base(daemon, entityIds)
        {
        }

        public void StartNetwork(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("zwave", "start_network", serviceData);
        }

        public void AddNode(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("zwave", "add_node", serviceData);
        }

        public void AddNodeSecure(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("zwave", "add_node_secure", serviceData);
        }

        public void RemoveNode(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("zwave", "remove_node", serviceData);
        }

        public void CancelCommand(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("zwave", "cancel_command", serviceData);
        }

        public void HealNetwork(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("zwave", "heal_network", serviceData);
        }

        public void SoftReset(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("zwave", "soft_reset", serviceData);
        }

        public void TestNetwork(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("zwave", "test_network", serviceData);
        }

        public void StopNetwork(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("zwave", "stop_network", serviceData);
        }

        public void RenameNode(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("zwave", "rename_node", serviceData);
        }

        public void RenameValue(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("zwave", "rename_value", serviceData);
        }

        public void SetConfigParameter(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("zwave", "set_config_parameter", serviceData);
        }

        public void SetNodeValue(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("zwave", "set_node_value", serviceData);
        }

        public void RefreshNodeValue(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("zwave", "refresh_node_value", serviceData);
        }

        public void PrintConfigParameter(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("zwave", "print_config_parameter", serviceData);
        }

        public void RemoveFailedNode(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("zwave", "remove_failed_node", serviceData);
        }

        public void ReplaceFailedNode(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("zwave", "replace_failed_node", serviceData);
        }

        public void ChangeAssociation(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("zwave", "change_association", serviceData);
        }

        public void SetWakeup(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("zwave", "set_wakeup", serviceData);
        }

        public void PrintNode(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("zwave", "print_node", serviceData);
        }

        public void RefreshEntity(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            serviceData["entity_id"] = EntityId;
            DaemonRxApp.CallService("zwave", "refresh_entity", serviceData);
        }

        public void RefreshNode(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("zwave", "refresh_node", serviceData);
        }

        public void ResetNodeMeters(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("zwave", "reset_node_meters", serviceData);
        }

        public void SetPollIntensity(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("zwave", "set_poll_intensity", serviceData);
        }

        public void HealNode(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("zwave", "heal_node", serviceData);
        }

        public void TestNode(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("zwave", "test_node", serviceData);
        }
    }

    public partial class SceneEntity : RxEntity
    {
        public string EntityId => EntityIds.First();
        public string? Area => DaemonRxApp.State(EntityId)?.Area;
        public dynamic? Attribute => DaemonRxApp.State(EntityId)?.Attribute;
        public DateTime LastChanged => DaemonRxApp.State(EntityId).LastChanged;
        public DateTime LastUpdated => DaemonRxApp.State(EntityId).LastUpdated;
        public dynamic? State => DaemonRxApp.State(EntityId)?.State;
        public SceneEntity(INetDaemonReactive daemon, IEnumerable<string> entityIds): base(daemon, entityIds)
        {
        }

        public void Reload(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("scene", "reload", serviceData);
        }

        public void Apply(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("scene", "apply", serviceData);
        }

        public void Create(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("scene", "create", serviceData);
        }
    }

    public partial class PlantEntity : RxEntity
    {
        public string EntityId => EntityIds.First();
        public string? Area => DaemonRxApp.State(EntityId)?.Area;
        public dynamic? Attribute => DaemonRxApp.State(EntityId)?.Attribute;
        public DateTime LastChanged => DaemonRxApp.State(EntityId).LastChanged;
        public DateTime LastUpdated => DaemonRxApp.State(EntityId).LastUpdated;
        public dynamic? State => DaemonRxApp.State(EntityId)?.State;
        public PlantEntity(INetDaemonReactive daemon, IEnumerable<string> entityIds): base(daemon, entityIds)
        {
        }
    }

    public partial class InputNumberEntity : RxEntity
    {
        public string EntityId => EntityIds.First();
        public string? Area => DaemonRxApp.State(EntityId)?.Area;
        public dynamic? Attribute => DaemonRxApp.State(EntityId)?.Attribute;
        public DateTime LastChanged => DaemonRxApp.State(EntityId).LastChanged;
        public DateTime LastUpdated => DaemonRxApp.State(EntityId).LastUpdated;
        public dynamic? State => DaemonRxApp.State(EntityId)?.State;
        public InputNumberEntity(INetDaemonReactive daemon, IEnumerable<string> entityIds): base(daemon, entityIds)
        {
        }

        public void Reload(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("input_number", "reload", serviceData);
        }

        public void SetValue(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            serviceData["entity_id"] = EntityId;
            DaemonRxApp.CallService("input_number", "set_value", serviceData);
        }

        public void Increment(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            serviceData["entity_id"] = EntityId;
            DaemonRxApp.CallService("input_number", "increment", serviceData);
        }

        public void Decrement(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            serviceData["entity_id"] = EntityId;
            DaemonRxApp.CallService("input_number", "decrement", serviceData);
        }
    }

    public partial class SunEntity : RxEntity
    {
        public string EntityId => EntityIds.First();
        public string? Area => DaemonRxApp.State(EntityId)?.Area;
        public dynamic? Attribute => DaemonRxApp.State(EntityId)?.Attribute;
        public DateTime LastChanged => DaemonRxApp.State(EntityId).LastChanged;
        public DateTime LastUpdated => DaemonRxApp.State(EntityId).LastUpdated;
        public dynamic? State => DaemonRxApp.State(EntityId)?.State;
        public SunEntity(INetDaemonReactive daemon, IEnumerable<string> entityIds): base(daemon, entityIds)
        {
        }
    }

    public partial class NetdaemonEntity : RxEntity
    {
        public string EntityId => EntityIds.First();
        public string? Area => DaemonRxApp.State(EntityId)?.Area;
        public dynamic? Attribute => DaemonRxApp.State(EntityId)?.Attribute;
        public DateTime LastChanged => DaemonRxApp.State(EntityId).LastChanged;
        public DateTime LastUpdated => DaemonRxApp.State(EntityId).LastUpdated;
        public dynamic? State => DaemonRxApp.State(EntityId)?.State;
        public NetdaemonEntity(INetDaemonReactive daemon, IEnumerable<string> entityIds): base(daemon, entityIds)
        {
        }

        public void RegisterService(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("netdaemon", "register_service", serviceData);
        }

        public void ReloadApps(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("netdaemon", "reload_apps", serviceData);
        }
    }

    public partial class AlertEntity : RxEntity
    {
        public string EntityId => EntityIds.First();
        public string? Area => DaemonRxApp.State(EntityId)?.Area;
        public dynamic? Attribute => DaemonRxApp.State(EntityId)?.Attribute;
        public DateTime LastChanged => DaemonRxApp.State(EntityId).LastChanged;
        public DateTime LastUpdated => DaemonRxApp.State(EntityId).LastUpdated;
        public dynamic? State => DaemonRxApp.State(EntityId)?.State;
        public AlertEntity(INetDaemonReactive daemon, IEnumerable<string> entityIds): base(daemon, entityIds)
        {
        }
    }

    public partial class ClimateEntity : RxEntity
    {
        public string EntityId => EntityIds.First();
        public string? Area => DaemonRxApp.State(EntityId)?.Area;
        public dynamic? Attribute => DaemonRxApp.State(EntityId)?.Attribute;
        public DateTime LastChanged => DaemonRxApp.State(EntityId).LastChanged;
        public DateTime LastUpdated => DaemonRxApp.State(EntityId).LastUpdated;
        public dynamic? State => DaemonRxApp.State(EntityId)?.State;
        public ClimateEntity(INetDaemonReactive daemon, IEnumerable<string> entityIds): base(daemon, entityIds)
        {
        }

        public void SetHvacMode(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            serviceData["entity_id"] = EntityId;
            DaemonRxApp.CallService("climate", "set_hvac_mode", serviceData);
        }

        public void SetPresetMode(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            serviceData["entity_id"] = EntityId;
            DaemonRxApp.CallService("climate", "set_preset_mode", serviceData);
        }

        public void SetAuxHeat(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            serviceData["entity_id"] = EntityId;
            DaemonRxApp.CallService("climate", "set_aux_heat", serviceData);
        }

        public void SetTemperature(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            serviceData["entity_id"] = EntityId;
            DaemonRxApp.CallService("climate", "set_temperature", serviceData);
        }

        public void SetHumidity(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            serviceData["entity_id"] = EntityId;
            DaemonRxApp.CallService("climate", "set_humidity", serviceData);
        }

        public void SetFanMode(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            serviceData["entity_id"] = EntityId;
            DaemonRxApp.CallService("climate", "set_fan_mode", serviceData);
        }

        public void SetSwingMode(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            serviceData["entity_id"] = EntityId;
            DaemonRxApp.CallService("climate", "set_swing_mode", serviceData);
        }
    }

    public partial class VacuumEntity : RxEntity
    {
        public string EntityId => EntityIds.First();
        public string? Area => DaemonRxApp.State(EntityId)?.Area;
        public dynamic? Attribute => DaemonRxApp.State(EntityId)?.Attribute;
        public DateTime LastChanged => DaemonRxApp.State(EntityId).LastChanged;
        public DateTime LastUpdated => DaemonRxApp.State(EntityId).LastUpdated;
        public dynamic? State => DaemonRxApp.State(EntityId)?.State;
        public VacuumEntity(INetDaemonReactive daemon, IEnumerable<string> entityIds): base(daemon, entityIds)
        {
        }

        public void StartPause(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            serviceData["entity_id"] = EntityId;
            DaemonRxApp.CallService("vacuum", "start_pause", serviceData);
        }

        public void Start(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            serviceData["entity_id"] = EntityId;
            DaemonRxApp.CallService("vacuum", "start", serviceData);
        }

        public void Pause(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            serviceData["entity_id"] = EntityId;
            DaemonRxApp.CallService("vacuum", "pause", serviceData);
        }

        public void ReturnToBase(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            serviceData["entity_id"] = EntityId;
            DaemonRxApp.CallService("vacuum", "return_to_base", serviceData);
        }

        public void CleanSpot(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            serviceData["entity_id"] = EntityId;
            DaemonRxApp.CallService("vacuum", "clean_spot", serviceData);
        }

        public void Locate(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            serviceData["entity_id"] = EntityId;
            DaemonRxApp.CallService("vacuum", "locate", serviceData);
        }

        public void Stop(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            serviceData["entity_id"] = EntityId;
            DaemonRxApp.CallService("vacuum", "stop", serviceData);
        }

        public void SetFanSpeed(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            serviceData["entity_id"] = EntityId;
            DaemonRxApp.CallService("vacuum", "set_fan_speed", serviceData);
        }

        public void SendCommand(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            serviceData["entity_id"] = EntityId;
            DaemonRxApp.CallService("vacuum", "send_command", serviceData);
        }
    }

    public partial class WeatherEntity : RxEntity
    {
        public string EntityId => EntityIds.First();
        public string? Area => DaemonRxApp.State(EntityId)?.Area;
        public dynamic? Attribute => DaemonRxApp.State(EntityId)?.Attribute;
        public DateTime LastChanged => DaemonRxApp.State(EntityId).LastChanged;
        public DateTime LastUpdated => DaemonRxApp.State(EntityId).LastUpdated;
        public dynamic? State => DaemonRxApp.State(EntityId)?.State;
        public WeatherEntity(INetDaemonReactive daemon, IEnumerable<string> entityIds): base(daemon, entityIds)
        {
        }
    }

    public partial class AlarmControlPanelEntity : RxEntity
    {
        public string EntityId => EntityIds.First();
        public string? Area => DaemonRxApp.State(EntityId)?.Area;
        public dynamic? Attribute => DaemonRxApp.State(EntityId)?.Attribute;
        public DateTime LastChanged => DaemonRxApp.State(EntityId).LastChanged;
        public DateTime LastUpdated => DaemonRxApp.State(EntityId).LastUpdated;
        public dynamic? State => DaemonRxApp.State(EntityId)?.State;
        public AlarmControlPanelEntity(INetDaemonReactive daemon, IEnumerable<string> entityIds): base(daemon, entityIds)
        {
        }

        public void AlarmDisarm(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            serviceData["entity_id"] = EntityId;
            DaemonRxApp.CallService("alarm_control_panel", "alarm_disarm", serviceData);
        }

        public void AlarmArmHome(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            serviceData["entity_id"] = EntityId;
            DaemonRxApp.CallService("alarm_control_panel", "alarm_arm_home", serviceData);
        }

        public void AlarmArmAway(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            serviceData["entity_id"] = EntityId;
            DaemonRxApp.CallService("alarm_control_panel", "alarm_arm_away", serviceData);
        }

        public void AlarmArmNight(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            serviceData["entity_id"] = EntityId;
            DaemonRxApp.CallService("alarm_control_panel", "alarm_arm_night", serviceData);
        }

        public void AlarmArmCustomBypass(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            serviceData["entity_id"] = EntityId;
            DaemonRxApp.CallService("alarm_control_panel", "alarm_arm_custom_bypass", serviceData);
        }

        public void AlarmTrigger(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            serviceData["entity_id"] = EntityId;
            DaemonRxApp.CallService("alarm_control_panel", "alarm_trigger", serviceData);
        }

        public void AlarmSetIgnoreOpenSensors(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("alarm_control_panel", "alarm_set_ignore_open_sensors", serviceData);
        }

        public void AlarmYamlSave(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("alarm_control_panel", "alarm_yaml_save", serviceData);
        }

        public void AlarmYamlUser(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("alarm_control_panel", "alarm_yaml_user", serviceData);
        }

        public void AlarmArmNightFromPanel(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("alarm_control_panel", "alarm_arm_night_from_panel", serviceData);
        }

        public void AlarmArmHomeFromPanel(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("alarm_control_panel", "alarm_arm_home_from_panel", serviceData);
        }

        public void AlarmArmAwayFromPanel(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("alarm_control_panel", "alarm_arm_away_from_panel", serviceData);
        }
    }

    public partial class CounterEntity : RxEntity
    {
        public string EntityId => EntityIds.First();
        public string? Area => DaemonRxApp.State(EntityId)?.Area;
        public dynamic? Attribute => DaemonRxApp.State(EntityId)?.Attribute;
        public DateTime LastChanged => DaemonRxApp.State(EntityId).LastChanged;
        public DateTime LastUpdated => DaemonRxApp.State(EntityId).LastUpdated;
        public dynamic? State => DaemonRxApp.State(EntityId)?.State;
        public CounterEntity(INetDaemonReactive daemon, IEnumerable<string> entityIds): base(daemon, entityIds)
        {
        }

        public void Increment(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            serviceData["entity_id"] = EntityId;
            DaemonRxApp.CallService("counter", "increment", serviceData);
        }

        public void Decrement(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            serviceData["entity_id"] = EntityId;
            DaemonRxApp.CallService("counter", "decrement", serviceData);
        }

        public void Reset(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            serviceData["entity_id"] = EntityId;
            DaemonRxApp.CallService("counter", "reset", serviceData);
        }

        public void Configure(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            serviceData["entity_id"] = EntityId;
            DaemonRxApp.CallService("counter", "configure", serviceData);
        }
    }

    public partial class EntityControllerEntity : RxEntity
    {
        public string EntityId => EntityIds.First();
        public string? Area => DaemonRxApp.State(EntityId)?.Area;
        public dynamic? Attribute => DaemonRxApp.State(EntityId)?.Attribute;
        public DateTime LastChanged => DaemonRxApp.State(EntityId).LastChanged;
        public DateTime LastUpdated => DaemonRxApp.State(EntityId).LastUpdated;
        public dynamic? State => DaemonRxApp.State(EntityId)?.State;
        public EntityControllerEntity(INetDaemonReactive daemon, IEnumerable<string> entityIds): base(daemon, entityIds)
        {
        }

        public void ClearBlock(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            serviceData["entity_id"] = EntityId;
            DaemonRxApp.CallService("entity_controller", "clear_block", serviceData);
        }

        public void EnableStayMode(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("entity_controller", "enable_stay_mode", serviceData);
        }

        public void DisableStayMode(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("entity_controller", "disable_stay_mode", serviceData);
        }

        public void SetNightMode(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            serviceData["entity_id"] = EntityId;
            DaemonRxApp.CallService("entity_controller", "set_night_mode", serviceData);
        }
    }

    public partial class PersonEntity : RxEntity
    {
        public string EntityId => EntityIds.First();
        public string? Area => DaemonRxApp.State(EntityId)?.Area;
        public dynamic? Attribute => DaemonRxApp.State(EntityId)?.Attribute;
        public DateTime LastChanged => DaemonRxApp.State(EntityId).LastChanged;
        public DateTime LastUpdated => DaemonRxApp.State(EntityId).LastUpdated;
        public dynamic? State => DaemonRxApp.State(EntityId)?.State;
        public PersonEntity(INetDaemonReactive daemon, IEnumerable<string> entityIds): base(daemon, entityIds)
        {
        }

        public void Reload(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("person", "reload", serviceData);
        }
    }

    public partial class InputDatetimeEntity : RxEntity
    {
        public string EntityId => EntityIds.First();
        public string? Area => DaemonRxApp.State(EntityId)?.Area;
        public dynamic? Attribute => DaemonRxApp.State(EntityId)?.Attribute;
        public DateTime LastChanged => DaemonRxApp.State(EntityId).LastChanged;
        public DateTime LastUpdated => DaemonRxApp.State(EntityId).LastUpdated;
        public dynamic? State => DaemonRxApp.State(EntityId)?.State;
        public InputDatetimeEntity(INetDaemonReactive daemon, IEnumerable<string> entityIds): base(daemon, entityIds)
        {
        }

        public void Reload(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("input_datetime", "reload", serviceData);
        }

        public void SetDatetime(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            serviceData["entity_id"] = EntityId;
            DaemonRxApp.CallService("input_datetime", "set_datetime", serviceData);
        }
    }

    public partial class ImageProcessingEntity : RxEntity
    {
        public string EntityId => EntityIds.First();
        public string? Area => DaemonRxApp.State(EntityId)?.Area;
        public dynamic? Attribute => DaemonRxApp.State(EntityId)?.Attribute;
        public DateTime LastChanged => DaemonRxApp.State(EntityId).LastChanged;
        public DateTime LastUpdated => DaemonRxApp.State(EntityId).LastUpdated;
        public dynamic? State => DaemonRxApp.State(EntityId)?.State;
        public ImageProcessingEntity(INetDaemonReactive daemon, IEnumerable<string> entityIds): base(daemon, entityIds)
        {
        }

        public void Scan(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is object)
            {
                var expObject = ((object)data).ToExpandoObject();
                serviceData.CopyFrom(expObject);
            }

            serviceData["entity_id"] = EntityId;
            DaemonRxApp.CallService("image_processing", "scan", serviceData);
        }
    }

    public partial class ProximityEntity : RxEntity
    {
        public string EntityId => EntityIds.First();
        public string? Area => DaemonRxApp.State(EntityId)?.Area;
        public dynamic? Attribute => DaemonRxApp.State(EntityId)?.Attribute;
        public DateTime LastChanged => DaemonRxApp.State(EntityId).LastChanged;
        public DateTime LastUpdated => DaemonRxApp.State(EntityId).LastUpdated;
        public dynamic? State => DaemonRxApp.State(EntityId)?.State;
        public ProximityEntity(INetDaemonReactive daemon, IEnumerable<string> entityIds): base(daemon, entityIds)
        {
        }
    }

    public partial class SwitchEntities
    {
        private readonly NetDaemonRxApp _app;
        public SwitchEntities(NetDaemonRxApp app)
        {
            _app = app;
        }

        public SwitchEntity Ac73bc0cfe8 => new SwitchEntity(_app, new string[]{"switch.ac_73bc0cfe_8"});
        public SwitchEntity XiaofangLitterboxDownstairsYellowLed => new SwitchEntity(_app, new string[]{"switch.xiaofang_litterbox_downstairs_yellow_led"});
        public SwitchEntity XiaofangYardBlueLed => new SwitchEntity(_app, new string[]{"switch.xiaofang_yard_blue_led"});
        public SwitchEntity XiaofangNightVision => new SwitchEntity(_app, new string[]{"switch.xiaofang_night_vision"});
        public SwitchEntity XiaofangYardMotionDetection => new SwitchEntity(_app, new string[]{"switch.xiaofang_yard_motion_detection"});
        public SwitchEntity WasherPlugSwitch => new SwitchEntity(_app, new string[]{"switch.washer_plug_switch"});
        public SwitchEntity NetdaemonCleaningMode => new SwitchEntity(_app, new string[]{"switch.netdaemon_cleaning_mode"});
        public SwitchEntity XiaofangLitterboxDownstairsIrFilter => new SwitchEntity(_app, new string[]{"switch.xiaofang_litterbox_downstairs_ir_filter"});
        public SwitchEntity DafangKitchenNightMode => new SwitchEntity(_app, new string[]{"switch.dafang_kitchen_night_mode"});
        public SwitchEntity XiaofangMotionSendMail => new SwitchEntity(_app, new string[]{"switch.xiaofang_motion_send_mail"});
        public SwitchEntity Ac26bc0cfe9 => new SwitchEntity(_app, new string[]{"switch.ac_26bc0cfe_9"});
        public SwitchEntity XiaofangUpstairsLitterboxServer => new SwitchEntity(_app, new string[]{"switch.xiaofang_upstairs_litterbox_server"});
        public SwitchEntity XiaofangLitterboxUpstairsYellowLed => new SwitchEntity(_app, new string[]{"switch.xiaofang_litterbox_upstairs_yellow_led"});
        public SwitchEntity DafangKitchenMotionDetection => new SwitchEntity(_app, new string[]{"switch.dafang_kitchen_motion_detection"});
        public SwitchEntity Ac37de34216 => new SwitchEntity(_app, new string[]{"switch.ac_37de342_16"});
        public SwitchEntity XiaofangUpstairsLitterboxNightVision => new SwitchEntity(_app, new string[]{"switch.xiaofang_upstairs_litterbox_night_vision"});
        public SwitchEntity Ac37de34214 => new SwitchEntity(_app, new string[]{"switch.ac_37de342_14"});
        public SwitchEntity DafangKitchenH264RtspServer => new SwitchEntity(_app, new string[]{"switch.dafang_kitchen_h264_rtsp_server"});
        public SwitchEntity DafangIsasroomBlueLed => new SwitchEntity(_app, new string[]{"switch.dafang_isasroom_blue_led"});
        public SwitchEntity NetdaemonMotionSnapshot => new SwitchEntity(_app, new string[]{"switch.netdaemon_motion_snapshot"});
        public SwitchEntity Ac17bc0cfe9 => new SwitchEntity(_app, new string[]{"switch.ac_17bc0cfe_9"});
        public SwitchEntity XiaofangLitterboxDownstairsNightMode => new SwitchEntity(_app, new string[]{"switch.xiaofang_litterbox_downstairs_night_mode"});
        public SwitchEntity XiaofangLitterboxUpstairsNightMode => new SwitchEntity(_app, new string[]{"switch.xiaofang_litterbox_upstairs_night_mode"});
        public SwitchEntity XiaofangLitterboxDownstairsNightModeAuto => new SwitchEntity(_app, new string[]{"switch.xiaofang_litterbox_downstairs_night_mode_auto"});
        public SwitchEntity XiaofangH264RtspServer => new SwitchEntity(_app, new string[]{"switch.xiaofang_h264_rtsp_server"});
        public SwitchEntity XiaofangRecording => new SwitchEntity(_app, new string[]{"switch.xiaofang_recording"});
        public SwitchEntity XiaofangLitterboxUpstairsMotionTracking => new SwitchEntity(_app, new string[]{"switch.xiaofang_litterbox_upstairs_motion_tracking"});
        public SwitchEntity XiaofangIrFilter => new SwitchEntity(_app, new string[]{"switch.xiaofang_ir_filter"});
        public SwitchEntity DafangNightVision => new SwitchEntity(_app, new string[]{"switch.dafang_night_vision"});
        public SwitchEntity DafangKitchenBlueLed => new SwitchEntity(_app, new string[]{"switch.dafang_kitchen_blue_led"});
        public SwitchEntity DafangIsasRoomServer => new SwitchEntity(_app, new string[]{"switch.dafang_isas_room_server"});
        public SwitchEntity NetdaemonWasher => new SwitchEntity(_app, new string[]{"switch.netdaemon_washer"});
        public SwitchEntity XiaofangLitterboxUpstairsIrFilter => new SwitchEntity(_app, new string[]{"switch.xiaofang_litterbox_upstairs_ir_filter"});
        public SwitchEntity Ac82bc0cfe0 => new SwitchEntity(_app, new string[]{"switch.ac_82bc0cfe_0"});
        public SwitchEntity Ac37de34215 => new SwitchEntity(_app, new string[]{"switch.ac_37de342_15"});
        public SwitchEntity Ac61bc0cfe5 => new SwitchEntity(_app, new string[]{"switch.ac_61bc0cfe_5"});
        public SwitchEntity DafangKitchenNightModeAuto => new SwitchEntity(_app, new string[]{"switch.dafang_kitchen_night_mode_auto"});
        public SwitchEntity DryerPlugSwitch => new SwitchEntity(_app, new string[]{"switch.dryer_plug_switch"});
        public SwitchEntity XiaofangLitterboxDownstairsIrLed => new SwitchEntity(_app, new string[]{"switch.xiaofang_litterbox_downstairs_ir_led"});
        public SwitchEntity DafangIsasroomH264RtspServer => new SwitchEntity(_app, new string[]{"switch.dafang_isasroom_h264_rtsp_server"});
        public SwitchEntity DafangCalibrate => new SwitchEntity(_app, new string[]{"switch.dafang_calibrate"});
        public SwitchEntity DafangIsasroomNightModeAuto => new SwitchEntity(_app, new string[]{"switch.dafang_isasroom_night_mode_auto"});
        public SwitchEntity XiaofangMotionDetection => new SwitchEntity(_app, new string[]{"switch.xiaofang_motion_detection"});
        public SwitchEntity XiaofangYardIrFilter => new SwitchEntity(_app, new string[]{"switch.xiaofang_yard_ir_filter"});
        public SwitchEntity XiaofangLitterboxDownstairsMotionDetection => new SwitchEntity(_app, new string[]{"switch.xiaofang_litterbox_downstairs_motion_detection"});
        public SwitchEntity XiaofangLitterboxDownstairsMotionTracking => new SwitchEntity(_app, new string[]{"switch.xiaofang_litterbox_downstairs_motion_tracking"});
        public SwitchEntity XiaofangYardH264RtspServer => new SwitchEntity(_app, new string[]{"switch.xiaofang_yard_h264_rtsp_server"});
        public SwitchEntity SannceCalibrate => new SwitchEntity(_app, new string[]{"switch.sannce_calibrate"});
        public SwitchEntity BikeCharger => new SwitchEntity(_app, new string[]{"switch.bike_charger"});
        public SwitchEntity DafangKitchenYellowLed => new SwitchEntity(_app, new string[]{"switch.dafang_kitchen_yellow_led"});
        public SwitchEntity Ac17bc0cfe8 => new SwitchEntity(_app, new string[]{"switch.ac_17bc0cfe_8"});
        public SwitchEntity XiaofangLitterboxUpstairsMotionDetection => new SwitchEntity(_app, new string[]{"switch.xiaofang_litterbox_upstairs_motion_detection"});
        public SwitchEntity DafangIsasroomNightMode => new SwitchEntity(_app, new string[]{"switch.dafang_isasroom_night_mode"});
        public SwitchEntity DafangIsasRoomNightVision => new SwitchEntity(_app, new string[]{"switch.dafang_isas_room_night_vision"});
        public SwitchEntity NetdaemonVacuum => new SwitchEntity(_app, new string[]{"switch.netdaemon_vacuum"});
        public SwitchEntity TiguanCombustionEngineHeating => new SwitchEntity(_app, new string[]{"switch.tiguan_combustion_engine_heating"});
        public SwitchEntity NetdaemonAirCleanerSchedule => new SwitchEntity(_app, new string[]{"switch.netdaemon_air_cleaner_schedule"});
        public SwitchEntity XiaofangIrLed => new SwitchEntity(_app, new string[]{"switch.xiaofang_ir_led"});
        public SwitchEntity DafangKitchenIrLed => new SwitchEntity(_app, new string[]{"switch.dafang_kitchen_ir_led"});
        public SwitchEntity NetdaemonIsaMode => new SwitchEntity(_app, new string[]{"switch.netdaemon_isa_mode"});
        public SwitchEntity LivingroomTv => new SwitchEntity(_app, new string[]{"switch.livingroom_tv"});
        public SwitchEntity XiaofangYardNightMode => new SwitchEntity(_app, new string[]{"switch.xiaofang_yard_night_mode"});
        public SwitchEntity XiaofangYardIrLed => new SwitchEntity(_app, new string[]{"switch.xiaofang_yard_ir_led"});
        public SwitchEntity OutdoorYardHangingLights => new SwitchEntity(_app, new string[]{"switch.outdoor_yard_hanging_lights"});
        public SwitchEntity XiaofangYardNightModeAuto => new SwitchEntity(_app, new string[]{"switch.xiaofang_yard_night_mode_auto"});
        public SwitchEntity DafangKitchenMotionTracking => new SwitchEntity(_app, new string[]{"switch.dafang_kitchen_motion_tracking"});
        public SwitchEntity NetdaemonAlarmHandler => new SwitchEntity(_app, new string[]{"switch.netdaemon_alarm_handler"});
        public SwitchEntity XiaofangLitterboxDownstairsBlueLed => new SwitchEntity(_app, new string[]{"switch.xiaofang_litterbox_downstairs_blue_led"});
        public SwitchEntity OutdoorPlug => new SwitchEntity(_app, new string[]{"switch.outdoor_plug"});
        public SwitchEntity XiaofangNightModeAuto => new SwitchEntity(_app, new string[]{"switch.xiaofang_night_mode_auto"});
        public SwitchEntity DafangIsasroomMotionDetection => new SwitchEntity(_app, new string[]{"switch.dafang_isasroom_motion_detection"});
        public SwitchEntity DafangServer => new SwitchEntity(_app, new string[]{"switch.dafang_server"});
        public SwitchEntity XiaofangYellowLed => new SwitchEntity(_app, new string[]{"switch.xiaofang_yellow_led"});
        public SwitchEntity XiaofangBlueLed => new SwitchEntity(_app, new string[]{"switch.xiaofang_blue_led"});
        public SwitchEntity XiaofangYardYellowLed => new SwitchEntity(_app, new string[]{"switch.xiaofang_yard_yellow_led"});
        public SwitchEntity DafangIsasroomIrFilter => new SwitchEntity(_app, new string[]{"switch.dafang_isasroom_ir_filter"});
        public SwitchEntity XiaofangLitterboxUpstairsH264RtspServer => new SwitchEntity(_app, new string[]{"switch.xiaofang_litterbox_upstairs_h264_rtsp_server"});
        public SwitchEntity XiaofangNightMode => new SwitchEntity(_app, new string[]{"switch.xiaofang_night_mode"});
        public SwitchEntity TiguanRequestInProgress => new SwitchEntity(_app, new string[]{"switch.tiguan_request_in_progress"});
        public SwitchEntity XiaofangServer => new SwitchEntity(_app, new string[]{"switch.xiaofang_server"});
        public SwitchEntity XiaofangLitterboxUpstairsBlueLed => new SwitchEntity(_app, new string[]{"switch.xiaofang_litterbox_upstairs_blue_led"});
        public SwitchEntity XiaofangMotionTracking => new SwitchEntity(_app, new string[]{"switch.xiaofang_motion_tracking"});
        public SwitchEntity XiaofangLitterboxDownstairsH264RtspServer => new SwitchEntity(_app, new string[]{"switch.xiaofang_litterbox_downstairs_h264_rtsp_server"});
        public SwitchEntity BedroomTv => new SwitchEntity(_app, new string[]{"switch.bedroom_tv"});
        public SwitchEntity DafangKitchenIrFilter => new SwitchEntity(_app, new string[]{"switch.dafang_kitchen_ir_filter"});
        public SwitchEntity DafangIsasRoomCalibrate => new SwitchEntity(_app, new string[]{"switch.dafang_isas_room_calibrate"});
        public SwitchEntity NetdaemonDryer => new SwitchEntity(_app, new string[]{"switch.netdaemon_dryer"});
        public SwitchEntity DafangIsasroomYellowLed => new SwitchEntity(_app, new string[]{"switch.dafang_isasroom_yellow_led"});
        public SwitchEntity XiaofangLitterboxUpstairsNightModeAuto => new SwitchEntity(_app, new string[]{"switch.xiaofang_litterbox_upstairs_night_mode_auto"});
        public SwitchEntity XiaofangLitterboxUpstairsIrLed => new SwitchEntity(_app, new string[]{"switch.xiaofang_litterbox_upstairs_ir_led"});
        public SwitchEntity DafangIsasroomIrLed => new SwitchEntity(_app, new string[]{"switch.dafang_isasroom_ir_led"});
    }

    public partial class AutomationEntities
    {
        private readonly NetDaemonRxApp _app;
        public AutomationEntities(NetDaemonRxApp app)
        {
            _app = app;
        }

        public AutomationEntity HouseGuestModeOn => new AutomationEntity(_app, new string[]{"automation.house_guest_mode_on"});
        public AutomationEntity NewAutomation => new AutomationEntity(_app, new string[]{"automation.new_automation"});
        public AutomationEntity NotifyOnLowWaterLevel => new AutomationEntity(_app, new string[]{"automation.notify_on_low_water_level"});
        public AutomationEntity CatsDownstairsLitterboxAutoLight => new AutomationEntity(_app, new string[]{"automation.cats_downstairs_litterbox_auto_light"});
        public AutomationEntity LivingRoomRollerBlindDownAt06 => new AutomationEntity(_app, new string[]{"automation.living_room_roller_blind_down_at_06"});
        public AutomationEntity LightsLightsOnAtComingHomeAtNightDelayTenThenTurnOffOutdoor => new AutomationEntity(_app, new string[]{"automation.lights_lights_on_at_coming_home_at_night_delay_ten_then_turn_off_outdoor"});
        public AutomationEntity LightsBedroomCeilingLightSwitch => new AutomationEntity(_app, new string[]{"automation.lights_bedroom_ceiling_light_switch"});
        public AutomationEntity LightsLightsOnAtPresenceWhileDark => new AutomationEntity(_app, new string[]{"automation.lights_lights_on_at_presence_while_dark"});
        public AutomationEntity LightDashboardNoBlackout => new AutomationEntity(_app, new string[]{"automation.light_dashboard_no_blackout"});
        public AutomationEntity SystemDeviceStatus => new AutomationEntity(_app, new string[]{"automation.system_device_status"});
        public AutomationEntity AddGenericTest => new AutomationEntity(_app, new string[]{"automation.add_generic_test"});
        public AutomationEntity ClimateHighTemperatures => new AutomationEntity(_app, new string[]{"automation.climate_high_temperatures"});
        public AutomationEntity HouseRoborockFullBin => new AutomationEntity(_app, new string[]{"automation.house_roborock_full_bin"});
        public AutomationEntity SystemAlertAcknowledgementAction => new AutomationEntity(_app, new string[]{"automation.system_alert_acknowledgement_action"});
        public AutomationEntity SystemDiskSpaceFillingUp => new AutomationEntity(_app, new string[]{"automation.system_disk_space_filling_up"});
        public AutomationEntity ClimateNotificationOnHighHumidityInDownstairsBathroom => new AutomationEntity(_app, new string[]{"automation.climate_notification_on_high_humidity_in_downstairs_bathroom"});
        public AutomationEntity SecurityRingDoorbellFlashLights => new AutomationEntity(_app, new string[]{"automation.security_ring_doorbell_flash_lights"});
        public AutomationEntity LightDashboardBlackout => new AutomationEntity(_app, new string[]{"automation.light_dashboard_blackout"});
        public AutomationEntity HouseCleaningModeOff => new AutomationEntity(_app, new string[]{"automation.house_cleaning_mode_off"});
        public AutomationEntity SecurityKrisinformationAlert => new AutomationEntity(_app, new string[]{"automation.security_krisinformation_alert"});
        public AutomationEntity HouseSetWashingMachineLastUsedTime => new AutomationEntity(_app, new string[]{"automation.house_set_washing_machine_last_used_time"});
        public AutomationEntity SystemIpBanNotify => new AutomationEntity(_app, new string[]{"automation.system_ip_ban_notify"});
        public AutomationEntity HouseNotificationOnHighTempInBedroom => new AutomationEntity(_app, new string[]{"automation.house_notification_on_high_temp_in_bedroom"});
        public AutomationEntity PresencePresenceHomebound => new AutomationEntity(_app, new string[]{"automation.presence_presence_homebound"});
        public AutomationEntity SecuritySmokeAlarm => new AutomationEntity(_app, new string[]{"automation.security_smoke_alarm"});
        public AutomationEntity LightsNotificationOnWindowOpenAndLightsOn => new AutomationEntity(_app, new string[]{"automation.lights_notification_on_window_open_and_lights_on"});
        public AutomationEntity HouseNotificationOnLowTempInBedroom => new AutomationEntity(_app, new string[]{"automation.house_notification_on_low_temp_in_bedroom"});
        public AutomationEntity CatsLitterboxAllCounterResetAtMidnight => new AutomationEntity(_app, new string[]{"automation.cats_litterbox_all_counter_reset_at_midnight"});
        public AutomationEntity PresencePresenceMqttEvent => new AutomationEntity(_app, new string[]{"automation.presence_presence_mqtt_event"});
        public AutomationEntity SystemHassStopped => new AutomationEntity(_app, new string[]{"automation.system_hass_stopped"});
        public AutomationEntity SystemZWaveReady => new AutomationEntity(_app, new string[]{"automation.system_z_wave_ready"});
        public AutomationEntity SystemMonitorStatus => new AutomationEntity(_app, new string[]{"automation.system_monitor_status"});
        public AutomationEntity CatsSendImageToDiscord => new AutomationEntity(_app, new string[]{"automation.cats_send_image_to_discord"});
        public AutomationEntity SystemHassStarted => new AutomationEntity(_app, new string[]{"automation.system_hass_started"});
        public AutomationEntity SystemHassUpdater => new AutomationEntity(_app, new string[]{"automation.system_hass_updater"});
        public AutomationEntity SystemHassNewPlatformDiscovered => new AutomationEntity(_app, new string[]{"automation.system_hass_new_platform_discovered"});
        public AutomationEntity LightsLightsOnPassageAtComingHomeAtNight => new AutomationEntity(_app, new string[]{"automation.lights_lights_on_passage_at_coming_home_at_night"});
        public AutomationEntity LivingRoomRollerBlindUpAt10 => new AutomationEntity(_app, new string[]{"automation.living_room_roller_blind_up_at_10"});
        public AutomationEntity LightsLightsOffWhenBedroomWindowOpen => new AutomationEntity(_app, new string[]{"automation.lights_lights_off_when_bedroom_window_open"});
        public AutomationEntity HouseGuestModeOff => new AutomationEntity(_app, new string[]{"automation.house_guest_mode_off"});
        public AutomationEntity WriteServoValueToEsp => new AutomationEntity(_app, new string[]{"automation.write_servo_value_to_esp"});
        public AutomationEntity TtsSonosStefanLeavingGolfCourse => new AutomationEntity(_app, new string[]{"automation.tts_sonos_stefan_leaving_golf_course"});
        public AutomationEntity LivingRoomRollerBlindsDown => new AutomationEntity(_app, new string[]{"automation.living_room_roller_blinds_down"});
        public AutomationEntity SecurityKrisinformationNews => new AutomationEntity(_app, new string[]{"automation.security_krisinformation_news"});
        public AutomationEntity SystemHassNewDeviceTracked => new AutomationEntity(_app, new string[]{"automation.system_hass_new_device_tracked"});
        public AutomationEntity FanSwitch => new AutomationEntity(_app, new string[]{"automation.fan_switch"});
        public AutomationEntity SystemNewRepoInHacs => new AutomationEntity(_app, new string[]{"automation.system_new_repo_in_hacs"});
        public AutomationEntity HouseCleaningMode => new AutomationEntity(_app, new string[]{"automation.house_cleaning_mode"});
        public AutomationEntity SecurityRingDoorbellLowBattery => new AutomationEntity(_app, new string[]{"automation.security_ring_doorbell_low_battery"});
        public AutomationEntity SystemHassNewEntityRegistered => new AutomationEntity(_app, new string[]{"automation.system_hass_new_entity_registered"});
        public AutomationEntity LivingRoomRollerBlindDown => new AutomationEntity(_app, new string[]{"automation.living_room_roller_blind_down"});
        public AutomationEntity LivingRoomRollerBlindsDown2 => new AutomationEntity(_app, new string[]{"automation.living_room_roller_blinds_down_2"});
    }

    public partial class LightEntities
    {
        private readonly NetDaemonRxApp _app;
        public LightEntities(NetDaemonRxApp app)
        {
            _app = app;
        }

        public LightEntity OutdoorLights => new LightEntity(_app, new string[]{"light.outdoor_lights"});
        public LightEntity StefanLightstrip => new LightEntity(_app, new string[]{"light.stefan_lightstrip"});
        public LightEntity IsaFilament => new LightEntity(_app, new string[]{"light.isa_filament"});
        public LightEntity OutdoorYardHangingLights => new LightEntity(_app, new string[]{"light.outdoor_yard_hanging_lights"});
        public LightEntity WalkInCloset1 => new LightEntity(_app, new string[]{"light.walk_in_closet_1"});
        public LightEntity OutdoorYardLight => new LightEntity(_app, new string[]{"light.outdoor_yard_light"});
        public LightEntity OutdoorLightStrings => new LightEntity(_app, new string[]{"light.outdoor_light_strings"});
        public LightEntity DownstairsLitterboxLightStrip => new LightEntity(_app, new string[]{"light.downstairs_litterbox_light_strip"});
        public LightEntity FloorlampReadingLight => new LightEntity(_app, new string[]{"light.floorlamp_reading_light"});
        public LightEntity BedsideLamp => new LightEntity(_app, new string[]{"light.bedside_lamp"});
        public LightEntity PassageCeilingSpotlightsLevel => new LightEntity(_app, new string[]{"light.passage_ceiling_spotlights_level"});
        public LightEntity StairsBottomSpot => new LightEntity(_app, new string[]{"light.stairs_bottom_spot"});
        public LightEntity WalkInCloset4 => new LightEntity(_app, new string[]{"light.walk_in_closet_4"});
        public LightEntity OutdoorFrontHangingLights => new LightEntity(_app, new string[]{"light.outdoor_front_hanging_lights"});
        public LightEntity KitchenCeilingSpotlightsLevel => new LightEntity(_app, new string[]{"light.kitchen_ceiling_spotlights_level"});
        public LightEntity OutdoorFrontLight => new LightEntity(_app, new string[]{"light.outdoor_front_light"});
        public LightEntity UpstairsLights => new LightEntity(_app, new string[]{"light.upstairs_lights"});
        public LightEntity UpstairsHallwayCeilingLightLevel => new LightEntity(_app, new string[]{"light.upstairs_hallway_ceiling_light_level"});
        public LightEntity StairsLights => new LightEntity(_app, new string[]{"light.stairs_lights"});
        public LightEntity StairsTopSpot => new LightEntity(_app, new string[]{"light.stairs_top_spot"});
        public LightEntity StairsMiddleSpot => new LightEntity(_app, new string[]{"light.stairs_middle_spot"});
        public LightEntity FloorlampUplight => new LightEntity(_app, new string[]{"light.floorlamp_uplight"});
        public LightEntity OutdoorLedstrip1 => new LightEntity(_app, new string[]{"light.outdoor_ledstrip_1"});
        public LightEntity HallwayWindowLight => new LightEntity(_app, new string[]{"light.hallway_window_light"});
        public LightEntity Candles => new LightEntity(_app, new string[]{"light.candles"});
        public LightEntity LightsAutomation => new LightEntity(_app, new string[]{"light.lights_automation"});
        public LightEntity LivingRoomCeilingLightLevel => new LightEntity(_app, new string[]{"light.living_room_ceiling_light_level"});
        public LightEntity ChristmasStarLight => new LightEntity(_app, new string[]{"light.christmas_star_light"});
        public LightEntity OutdoorWallLamps => new LightEntity(_app, new string[]{"light.outdoor_wall_lamps"});
        public LightEntity GatewayLight => new LightEntity(_app, new string[]{"light.gateway_light"});
        public LightEntity InsideLights => new LightEntity(_app, new string[]{"light.inside_lights"});
        public LightEntity WalkInClosetLights => new LightEntity(_app, new string[]{"light.walk_in_closet_lights"});
        public LightEntity OutdoorYardLightNet => new LightEntity(_app, new string[]{"light.outdoor_yard_light_net"});
        public LightEntity LivingRoomSpotlightsLevel => new LightEntity(_app, new string[]{"light.living_room_spotlights_level"});
        public LightEntity WalkInCloset2 => new LightEntity(_app, new string[]{"light.walk_in_closet_2"});
        public LightEntity IsaCeilingLight => new LightEntity(_app, new string[]{"light.isa_ceiling_light"});
        public LightEntity DownstairsLights => new LightEntity(_app, new string[]{"light.downstairs_lights"});
        public LightEntity BedroomCeilingLight => new LightEntity(_app, new string[]{"light.bedroom_ceiling_light"});
        public LightEntity WalkInCloset3 => new LightEntity(_app, new string[]{"light.walk_in_closet_3"});
        public LightEntity DiningRoomCeilingLightLevel => new LightEntity(_app, new string[]{"light.dining_room_ceiling_light_level"});
    }

    public partial class CameraEntities
    {
        private readonly NetDaemonRxApp _app;
        public CameraEntities(NetDaemonRxApp app)
        {
            _app = app;
        }

        public CameraEntity IsasRoom => new CameraEntity(_app, new string[]{"camera.isas_room"});
        public CameraEntity RingDoorbell => new CameraEntity(_app, new string[]{"camera.ring_doorbell"});
        public CameraEntity XiaofangYard => new CameraEntity(_app, new string[]{"camera.xiaofang_yard"});
        public CameraEntity PassageAxis => new CameraEntity(_app, new string[]{"camera.passage_axis"});
        public CameraEntity SnapshotDownstairsLitterbox => new CameraEntity(_app, new string[]{"camera.snapshot_downstairs_litterbox"});
        public CameraEntity XiaofangMotionSnapshot => new CameraEntity(_app, new string[]{"camera.xiaofang_motion_snapshot"});
        public CameraEntity XiaofangLitterboxUpstairsMotionSnapshot => new CameraEntity(_app, new string[]{"camera.xiaofang_litterbox_upstairs_motion_snapshot"});
        public CameraEntity SnapshotLivingRoom => new CameraEntity(_app, new string[]{"camera.snapshot_living_room"});
        public CameraEntity RockroboMap => new CameraEntity(_app, new string[]{"camera.rockrobo_map"});
        public CameraEntity SnapshotPassage => new CameraEntity(_app, new string[]{"camera.snapshot_passage"});
        public CameraEntity LivingRoomAxis => new CameraEntity(_app, new string[]{"camera.living_room_axis"});
        public CameraEntity SnapshotIsasRoom => new CameraEntity(_app, new string[]{"camera.snapshot_isas_room"});
        public CameraEntity Hallway => new CameraEntity(_app, new string[]{"camera.hallway"});
        public CameraEntity SnapshotHallway => new CameraEntity(_app, new string[]{"camera.snapshot_hallway"});
        public CameraEntity FisksatraMeteogram => new CameraEntity(_app, new string[]{"camera.fisksatra_meteogram"});
        public CameraEntity DafangKitchenMotionSnapshot => new CameraEntity(_app, new string[]{"camera.dafang_kitchen_motion_snapshot"});
        public CameraEntity SnapshotUpstairsLitterbox => new CameraEntity(_app, new string[]{"camera.snapshot_upstairs_litterbox"});
        public CameraEntity DafangIsasroomMotionSnapshot => new CameraEntity(_app, new string[]{"camera.dafang_isasroom_motion_snapshot"});
        public CameraEntity Yard => new CameraEntity(_app, new string[]{"camera.yard"});
        public CameraEntity DafangKitchen => new CameraEntity(_app, new string[]{"camera.dafang_kitchen"});
        public CameraEntity StockholmMeteogram => new CameraEntity(_app, new string[]{"camera.stockholm_meteogram"});
        public CameraEntity XiaofangYardMotionSnapshot => new CameraEntity(_app, new string[]{"camera.xiaofang_yard_motion_snapshot"});
        public CameraEntity XiaofangLitterboxDownstairsMotionSnapshot => new CameraEntity(_app, new string[]{"camera.xiaofang_litterbox_downstairs_motion_snapshot"});
        public CameraEntity UpstairsLitterbox => new CameraEntity(_app, new string[]{"camera.upstairs_litterbox"});
        public CameraEntity DownstairsLitterbox => new CameraEntity(_app, new string[]{"camera.downstairs_litterbox"});
        public CameraEntity Ender3Pro => new CameraEntity(_app, new string[]{"camera.ender_3_pro"});
        public CameraEntity Xiaofang2 => new CameraEntity(_app, new string[]{"camera.xiaofang_2"});
    }

    public partial class BinarySensorEntities
    {
        private readonly NetDaemonRxApp _app;
        public BinarySensorEntities(NetDaemonRxApp app)
        {
            _app = app;
        }

        public BinarySensorEntity WalkInClosetSmokeAlarm => new BinarySensorEntity(_app, new string[]{"binary_sensor.walk_in_closet_smoke_alarm"});
        public BinarySensorEntity UpdateSl => new BinarySensorEntity(_app, new string[]{"binary_sensor.update_sl"});
        public BinarySensorEntity TiguanDoorClosedLeftBack => new BinarySensorEntity(_app, new string[]{"binary_sensor.tiguan_door_closed_left_back"});
        public BinarySensorEntity WasherHatch => new BinarySensorEntity(_app, new string[]{"binary_sensor.washer_hatch"});
        public BinarySensorEntity WithingsInBedIsa => new BinarySensorEntity(_app, new string[]{"binary_sensor.withings_in_bed_isa"});
        public BinarySensorEntity XiaofangLitterboxUpstairsMotionSensor => new BinarySensorEntity(_app, new string[]{"binary_sensor.xiaofang_litterbox_upstairs_motion_sensor"});
        public BinarySensorEntity XiaofangYardMotionSensor => new BinarySensorEntity(_app, new string[]{"binary_sensor.xiaofang_yard_motion_sensor"});
        public BinarySensorEntity Ac82bc0cfe0 => new BinarySensorEntity(_app, new string[]{"binary_sensor.ac_82bc0cfe_0"});
        public BinarySensorEntity SnapshotsStale => new BinarySensorEntity(_app, new string[]{"binary_sensor.snapshots_stale"});
        public BinarySensorEntity GrocyExpiringProducts => new BinarySensorEntity(_app, new string[]{"binary_sensor.grocy_expiring_products"});
        public BinarySensorEntity FrontDoor => new BinarySensorEntity(_app, new string[]{"binary_sensor.front_door"});
        public BinarySensorEntity Roomba => new BinarySensorEntity(_app, new string[]{"binary_sensor.roomba"});
        public BinarySensorEntity WaterHeaterSensor => new BinarySensorEntity(_app, new string[]{"binary_sensor.water_heater_sensor"});
        public BinarySensorEntity RingLowBattery => new BinarySensorEntity(_app, new string[]{"binary_sensor.ring_low_battery"});
        public BinarySensorEntity WorkdaySensor => new BinarySensorEntity(_app, new string[]{"binary_sensor.workday_sensor"});
        public BinarySensorEntity RingDoorbellMotion => new BinarySensorEntity(_app, new string[]{"binary_sensor.ring_doorbell_motion"});
        public BinarySensorEntity Ac61bc0cfe5 => new BinarySensorEntity(_app, new string[]{"binary_sensor.ac_61bc0cfe_5"});
        public BinarySensorEntity Ender3ProPrinting => new BinarySensorEntity(_app, new string[]{"binary_sensor.ender_3_pro_printing"});
        public BinarySensorEntity XiaofangYardMotionSensor2 => new BinarySensorEntity(_app, new string[]{"binary_sensor.xiaofang_yard_motion_sensor_2"});
        public BinarySensorEntity Ac17bc0cfe8 => new BinarySensorEntity(_app, new string[]{"binary_sensor.ac_17bc0cfe_8"});
        public BinarySensorEntity PassageAxisMotion0 => new BinarySensorEntity(_app, new string[]{"binary_sensor.passage_axis_motion_0"});
        public BinarySensorEntity BackDoor => new BinarySensorEntity(_app, new string[]{"binary_sensor.back_door"});
        public BinarySensorEntity TiguanWindowClosedRightFront => new BinarySensorEntity(_app, new string[]{"binary_sensor.tiguan_window_closed_right_front"});
        public BinarySensorEntity Ac37de34215 => new BinarySensorEntity(_app, new string[]{"binary_sensor.ac_37de342_15"});
        public BinarySensorEntity TiguanTrunkLocked => new BinarySensorEntity(_app, new string[]{"binary_sensor.tiguan_trunk_locked"});
        public BinarySensorEntity UpstairsHallwaySmokeAlarm => new BinarySensorEntity(_app, new string[]{"binary_sensor.upstairs_hallway_smoke_alarm"});
        public BinarySensorEntity YardDoorLock => new BinarySensorEntity(_app, new string[]{"binary_sensor.yard_door_lock"});
        public BinarySensorEntity KitchenMotion => new BinarySensorEntity(_app, new string[]{"binary_sensor.kitchen_motion"});
        public BinarySensorEntity BedroomDoor => new BinarySensorEntity(_app, new string[]{"binary_sensor.bedroom_door"});
        public BinarySensorEntity VerisureEthernetStatus => new BinarySensorEntity(_app, new string[]{"binary_sensor.verisure_ethernet_status"});
        public BinarySensorEntity TiguanDoorClosedLeftFront => new BinarySensorEntity(_app, new string[]{"binary_sensor.tiguan_door_closed_left_front"});
        public BinarySensorEntity IkeaHydroWaterLevel => new BinarySensorEntity(_app, new string[]{"binary_sensor.ikea_hydro_water_level"});
        public BinarySensorEntity Ac26bc0cfe9 => new BinarySensorEntity(_app, new string[]{"binary_sensor.ac_26bc0cfe_9"});
        public BinarySensorEntity DafangIsasroomMotionSensor => new BinarySensorEntity(_app, new string[]{"binary_sensor.dafang_isasroom_motion_sensor"});
        public BinarySensorEntity UpstairsHallwayMotionSensor => new BinarySensorEntity(_app, new string[]{"binary_sensor.upstairs_hallway_motion_sensor"});
        public BinarySensorEntity GrocyExpiredProducts => new BinarySensorEntity(_app, new string[]{"binary_sensor.grocy_expired_products"});
        public BinarySensorEntity TiguanWindowClosedLeftFront => new BinarySensorEntity(_app, new string[]{"binary_sensor.tiguan_window_closed_left_front"});
        public BinarySensorEntity TiguanSunroofClosed => new BinarySensorEntity(_app, new string[]{"binary_sensor.tiguan_sunroof_closed"});
        public BinarySensorEntity Updater => new BinarySensorEntity(_app, new string[]{"binary_sensor.updater"});
        public BinarySensorEntity Ac37de34216 => new BinarySensorEntity(_app, new string[]{"binary_sensor.ac_37de342_16"});
        public BinarySensorEntity Ac17bc0cfe9 => new BinarySensorEntity(_app, new string[]{"binary_sensor.ac_17bc0cfe_9"});
        public BinarySensorEntity GrocyMissingProducts => new BinarySensorEntity(_app, new string[]{"binary_sensor.grocy_missing_products"});
        public BinarySensorEntity RpiZeroPing => new BinarySensorEntity(_app, new string[]{"binary_sensor.rpi_zero_ping"});
        public BinarySensorEntity TiguanDoorClosedRightBack => new BinarySensorEntity(_app, new string[]{"binary_sensor.tiguan_door_closed_right_back"});
        public BinarySensorEntity RingDoorbellDing => new BinarySensorEntity(_app, new string[]{"binary_sensor.ring_doorbell_ding"});
        public BinarySensorEntity MailboxPackage => new BinarySensorEntity(_app, new string[]{"binary_sensor.mailbox_package"});
        public BinarySensorEntity PassageMotionSensor => new BinarySensorEntity(_app, new string[]{"binary_sensor.passage_motion_sensor"});
        public BinarySensorEntity TiguanParkingLight => new BinarySensorEntity(_app, new string[]{"binary_sensor.tiguan_parking_light"});
        public BinarySensorEntity LivingRoomDashboardPing => new BinarySensorEntity(_app, new string[]{"binary_sensor.living_room_dashboard_ping"});
        public BinarySensorEntity Ac37de34214 => new BinarySensorEntity(_app, new string[]{"binary_sensor.ac_37de342_14"});
        public BinarySensorEntity MailboxLetter => new BinarySensorEntity(_app, new string[]{"binary_sensor.mailbox_letter"});
        public BinarySensorEntity DownstairsLitterboxMotion => new BinarySensorEntity(_app, new string[]{"binary_sensor.downstairs_litterbox_motion"});
        public BinarySensorEntity TiguanDoorsLocked => new BinarySensorEntity(_app, new string[]{"binary_sensor.tiguan_doors_locked"});
        public BinarySensorEntity BedroomWindow => new BinarySensorEntity(_app, new string[]{"binary_sensor.bedroom_window"});
        public BinarySensorEntity DiningRoomWindow => new BinarySensorEntity(_app, new string[]{"binary_sensor.dining_room_window"});
        public BinarySensorEntity DiningRoomSmokeAlarm => new BinarySensorEntity(_app, new string[]{"binary_sensor.dining_room_smoke_alarm"});
        public BinarySensorEntity TiguanLowFuel => new BinarySensorEntity(_app, new string[]{"binary_sensor.tiguan_low_fuel"});
        public BinarySensorEntity IsasRoomWindow => new BinarySensorEntity(_app, new string[]{"binary_sensor.isas_room_window"});
        public BinarySensorEntity UpstairsHallwayDashboardPing => new BinarySensorEntity(_app, new string[]{"binary_sensor.upstairs_hallway_dashboard_ping"});
        public BinarySensorEntity UpstairsLitterlocker => new BinarySensorEntity(_app, new string[]{"binary_sensor.upstairs_litterlocker"});
        public BinarySensorEntity StefansOfficeMotion => new BinarySensorEntity(_app, new string[]{"binary_sensor.stefans_office_motion"});
        public BinarySensorEntity DafangKitchenMotionSensor => new BinarySensorEntity(_app, new string[]{"binary_sensor.dafang_kitchen_motion_sensor"});
        public BinarySensorEntity TiguanWindowsClosed => new BinarySensorEntity(_app, new string[]{"binary_sensor.tiguan_windows_closed"});
        public BinarySensorEntity TiguanWindowClosedLeftBack => new BinarySensorEntity(_app, new string[]{"binary_sensor.tiguan_window_closed_left_back"});
        public BinarySensorEntity Ender3ProPrintingError => new BinarySensorEntity(_app, new string[]{"binary_sensor.ender_3_pro_printing_error"});
        public BinarySensorEntity LivingRoomAxisMotion0 => new BinarySensorEntity(_app, new string[]{"binary_sensor.living_room_axis_motion_0"});
        public BinarySensorEntity XiaofangLitterboxDownstairsMotionSensor => new BinarySensorEntity(_app, new string[]{"binary_sensor.xiaofang_litterbox_downstairs_motion_sensor"});
        public BinarySensorEntity StefansOfficeDoor => new BinarySensorEntity(_app, new string[]{"binary_sensor.stefans_office_door"});
        public BinarySensorEntity BalconyDoor => new BinarySensorEntity(_app, new string[]{"binary_sensor.balcony_door"});
        public BinarySensorEntity VibrationSensor1 => new BinarySensorEntity(_app, new string[]{"binary_sensor.vibration_sensor_1"});
        public BinarySensorEntity UpstairsLitterboxMotion => new BinarySensorEntity(_app, new string[]{"binary_sensor.upstairs_litterbox_motion"});
        public BinarySensorEntity TiguanTrunkClosed => new BinarySensorEntity(_app, new string[]{"binary_sensor.tiguan_trunk_closed"});
        public BinarySensorEntity DryerHatch => new BinarySensorEntity(_app, new string[]{"binary_sensor.dryer_hatch"});
        public BinarySensorEntity TiguanDoorClosedRightFront => new BinarySensorEntity(_app, new string[]{"binary_sensor.tiguan_door_closed_right_front"});
        public BinarySensorEntity TiguanWindowClosedRightBack => new BinarySensorEntity(_app, new string[]{"binary_sensor.tiguan_window_closed_right_back"});
        public BinarySensorEntity YardDoor => new BinarySensorEntity(_app, new string[]{"binary_sensor.yard_door"});
        public BinarySensorEntity GrocyOverdueChores => new BinarySensorEntity(_app, new string[]{"binary_sensor.grocy_overdue_chores"});
        public BinarySensorEntity HallwayMotion => new BinarySensorEntity(_app, new string[]{"binary_sensor.hallway_motion"});
        public BinarySensorEntity CleanUp => new BinarySensorEntity(_app, new string[]{"binary_sensor.clean_up"});
        public BinarySensorEntity GrocyOverdueTasks => new BinarySensorEntity(_app, new string[]{"binary_sensor.grocy_overdue_tasks"});
        public BinarySensorEntity VibrationSensor2 => new BinarySensorEntity(_app, new string[]{"binary_sensor.vibration_sensor_2"});
        public BinarySensorEntity Ac73bc0cfe8 => new BinarySensorEntity(_app, new string[]{"binary_sensor.ac_73bc0cfe_8"});
    }

    public partial class SensorEntities
    {
        private readonly NetDaemonRxApp _app;
        public SensorEntities(NetDaemonRxApp app)
        {
            _app = app;
        }

        public SensorEntity ShenzhenNeoElectronicsCoLtdBatteryPoweredPirSensorAlarmLevel => new SensorEntity(_app, new string[]{"sensor.shenzhen_neo_electronics_co_ltd_battery_powered_pir_sensor_alarm_level"});
        public SensorEntity Date => new SensorEntity(_app, new string[]{"sensor.date"});
        public SensorEntity IsabellaSIphoneXBssid => new SensorEntity(_app, new string[]{"sensor.isabella_s_iphone_x_bssid"});
        public SensorEntity BedroomFanBatteryLevel => new SensorEntity(_app, new string[]{"sensor.bedroom_fan_battery_level"});
        public SensorEntity BackDoorBatteryLevel => new SensorEntity(_app, new string[]{"sensor.back_door_battery_level"});
        public SensorEntity LivingRoomSpotlightsEnergy => new SensorEntity(_app, new string[]{"sensor.living_room_spotlights_energy"});
        public SensorEntity WithingsMuscleMassKgIsa2 => new SensorEntity(_app, new string[]{"sensor.withings_muscle_mass_kg_isa_2"});
        public SensorEntity WasherPlugRelativeHumidity => new SensorEntity(_app, new string[]{"sensor.washer_plug_relative_humidity"});
        public SensorEntity PassageCeilingSpotlightsEnergy => new SensorEntity(_app, new string[]{"sensor.passage_ceiling_spotlights_energy"});
        public SensorEntity Plex => new SensorEntity(_app, new string[]{"sensor.plex"});
        public SensorEntity DownstairsBathroomHumidity => new SensorEntity(_app, new string[]{"sensor.downstairs_bathroom_humidity"});
        public SensorEntity DiskUsePercent => new SensorEntity(_app, new string[]{"sensor.disk_use_percent"});
        public SensorEntity FrontDoorAlarmType => new SensorEntity(_app, new string[]{"sensor.front_door_alarm_type"});
        public SensorEntity CurrentVersion => new SensorEntity(_app, new string[]{"sensor.current_version"});
        public SensorEntity Miflora2Temperature => new SensorEntity(_app, new string[]{"sensor.miflora_2_temperature"});
        public SensorEntity Ender3ProCurrentState => new SensorEntity(_app, new string[]{"sensor.ender_3_pro_current_state"});
        public SensorEntity Dryer => new SensorEntity(_app, new string[]{"sensor.dryer"});
        public SensorEntity Miflora2Illuminance => new SensorEntity(_app, new string[]{"sensor.miflora_2_illuminance"});
        public SensorEntity Miflora1SoilConductivity => new SensorEntity(_app, new string[]{"sensor.miflora_1_soil_conductivity"});
        public SensorEntity OutdoorSwitchBatteryLevel => new SensorEntity(_app, new string[]{"sensor.outdoor_switch_battery_level"});
        public SensorEntity Miflora3Illuminance => new SensorEntity(_app, new string[]{"sensor.miflora_3_illuminance"});
        public SensorEntity IsabellaSIphoneXFloorsDescended => new SensorEntity(_app, new string[]{"sensor.isabella_s_iphone_x_floors_descended"});
        public SensorEntity TiguanServiceInspection => new SensorEntity(_app, new string[]{"sensor.tiguan_service_inspection"});
        public SensorEntity StefansIphoneGeocodedLocation => new SensorEntity(_app, new string[]{"sensor.stefans_iphone_geocoded_location"});
        public SensorEntity IsabellaSIphoneXGeocodedLocation => new SensorEntity(_app, new string[]{"sensor.isabella_s_iphone_x_geocoded_location"});
        public SensorEntity WithingsFatFreeMassKgIsa2 => new SensorEntity(_app, new string[]{"sensor.withings_fat_free_mass_kg_isa_2"});
        public SensorEntity FloorlampDimmerBatteryLevel => new SensorEntity(_app, new string[]{"sensor.floorlamp_dimmer_battery_level"});
        public SensorEntity DryerPlugVelocity => new SensorEntity(_app, new string[]{"sensor.dryer_plug_velocity"});
        public SensorEntity GeocodedLocation => new SensorEntity(_app, new string[]{"sensor.geocoded_location"});
        public SensorEntity YardDoorBatteryLevel => new SensorEntity(_app, new string[]{"sensor.yard_door_battery_level"});
        public SensorEntity LivingRoomSpotlightsInterval => new SensorEntity(_app, new string[]{"sensor.living_room_spotlights_interval"});
        public SensorEntity GrocyTasks => new SensorEntity(_app, new string[]{"sensor.grocy_tasks"});
        public SensorEntity LivingRoomSpotlightsAlarmType => new SensorEntity(_app, new string[]{"sensor.living_room_spotlights_alarm_type"});
        public SensorEntity PassageCeilingSpotlightsAlarmType => new SensorEntity(_app, new string[]{"sensor.passage_ceiling_spotlights_alarm_type"});
        public SensorEntity Miflora2SoilConductivity => new SensorEntity(_app, new string[]{"sensor.miflora_2_soil_conductivity"});
        public SensorEntity IsaHeartRate => new SensorEntity(_app, new string[]{"sensor.isa_heart_rate"});
        public SensorEntity StefansOfficeTemperatureBatteryLevel => new SensorEntity(_app, new string[]{"sensor.stefans_office_temperature_battery_level"});
        public SensorEntity DownstairsLitterboxVisits => new SensorEntity(_app, new string[]{"sensor.downstairs_litterbox_visits"});
        public SensorEntity HouseMotion => new SensorEntity(_app, new string[]{"sensor.house_motion"});
        public SensorEntity Refrigerator2 => new SensorEntity(_app, new string[]{"sensor.refrigerator_2"});
        public SensorEntity UnlockedBy => new SensorEntity(_app, new string[]{"sensor.unlocked_by"});
        public SensorEntity DarkSkyCloudCoverage1d => new SensorEntity(_app, new string[]{"sensor.dark_sky_cloud_coverage_1d"});
        public SensorEntity RingDoorbellBattery => new SensorEntity(_app, new string[]{"sensor.ring_doorbell_battery"});
        public SensorEntity BedroomHumidity => new SensorEntity(_app, new string[]{"sensor.bedroom_humidity"});
        public SensorEntity BatteryState2 => new SensorEntity(_app, new string[]{"sensor.battery_state_2"});
        public SensorEntity Ssid => new SensorEntity(_app, new string[]{"sensor.ssid"});
        public SensorEntity Washer => new SensorEntity(_app, new string[]{"sensor.washer"});
        public SensorEntity PassageMotionBatteryLevel => new SensorEntity(_app, new string[]{"sensor.passage_motion_battery_level"});
        public SensorEntity Hacs => new SensorEntity(_app, new string[]{"sensor.hacs"});
        public SensorEntity WasherPlugEnergy => new SensorEntity(_app, new string[]{"sensor.washer_plug_energy"});
        public SensorEntity FrontDoorBurglar => new SensorEntity(_app, new string[]{"sensor.front_door_burglar"});
        public SensorEntity Ac82bc0cfe0RssiNumeric => new SensorEntity(_app, new string[]{"sensor.ac_82bc0cfe_0_rssi_numeric"});
        public SensorEntity DarkSkySummary => new SensorEntity(_app, new string[]{"sensor.dark_sky_summary"});
        public SensorEntity BedroomDoor => new SensorEntity(_app, new string[]{"sensor.bedroom_door"});
        public SensorEntity BedroomDoorBatteryLevel => new SensorEntity(_app, new string[]{"sensor.bedroom_door_battery_level"});
        public SensorEntity TiguanOilInspection => new SensorEntity(_app, new string[]{"sensor.tiguan_oil_inspection"});
        public SensorEntity WithingsFatRatioPctIsa => new SensorEntity(_app, new string[]{"sensor.withings_fat_ratio_pct_isa"});
        public SensorEntity StefansIphoneSim1 => new SensorEntity(_app, new string[]{"sensor.stefans_iphone_sim_1"});
        public SensorEntity DashboardMotionBatteryLevel => new SensorEntity(_app, new string[]{"sensor.dashboard_motion_battery_level"});
        public SensorEntity LivingRoomIsabellasIphoneXBt => new SensorEntity(_app, new string[]{"sensor.living_room_isabellas_iphone_x_bt"});
        public SensorEntity WithingsSpo2PctIsa => new SensorEntity(_app, new string[]{"sensor.withings_spo2_pct_isa"});
        public SensorEntity LivingRoomSpotlightsPower2 => new SensorEntity(_app, new string[]{"sensor.living_room_spotlights_power_2"});
        public SensorEntity Ender3ProTimeElapsed => new SensorEntity(_app, new string[]{"sensor.ender_3_pro_time_elapsed"});
        public SensorEntity PassageMotionAlarmLevel => new SensorEntity(_app, new string[]{"sensor.passage_motion_alarm_level"});
        public SensorEntity DownstairsLitterboxMotionBatteryLevel => new SensorEntity(_app, new string[]{"sensor.downstairs_litterbox_motion_battery_level"});
        public SensorEntity StefansIphoneSsid => new SensorEntity(_app, new string[]{"sensor.stefans_iphone_ssid"});
        public SensorEntity ShenzhenNeoElectronicsCoLtdBatteryPoweredPirSensorLuminance => new SensorEntity(_app, new string[]{"sensor.shenzhen_neo_electronics_co_ltd_battery_powered_pir_sensor_luminance"});
        public SensorEntity IsabellaSIphoneXSim1 => new SensorEntity(_app, new string[]{"sensor.isabella_s_iphone_x_sim_1"});
        public SensorEntity DarkSkyNearestStormDistance => new SensorEntity(_app, new string[]{"sensor.dark_sky_nearest_storm_distance"});
        public SensorEntity StefansIphoneAverageActivePace => new SensorEntity(_app, new string[]{"sensor.stefans_iphone_average_active_pace"});
        public SensorEntity Ender3ProTargetTool0Temp => new SensorEntity(_app, new string[]{"sensor.ender_3_pro_target_tool0_temp"});
        public SensorEntity BedroomTemperature => new SensorEntity(_app, new string[]{"sensor.bedroom_temperature"});
        public SensorEntity LivingRoomSpotlightsAlarmLevel => new SensorEntity(_app, new string[]{"sensor.living_room_spotlights_alarm_level"});
        public SensorEntity WithingsWeightKgIsa => new SensorEntity(_app, new string[]{"sensor.withings_weight_kg_isa"});
        public SensorEntity WasherPlugAlarmLevel => new SensorEntity(_app, new string[]{"sensor.washer_plug_alarm_level"});
        public SensorEntity Trash => new SensorEntity(_app, new string[]{"sensor.trash"});
        public SensorEntity DiningRoomCeilingLightEnergy => new SensorEntity(_app, new string[]{"sensor.dining_room_ceiling_light_energy"});
        public SensorEntity DiningRoomWindow => new SensorEntity(_app, new string[]{"sensor.dining_room_window"});
        public SensorEntity HpEnvy5540SeriesTriColorInk => new SensorEntity(_app, new string[]{"sensor.hp_envy_5540_series_tri_color_ink"});
        public SensorEntity Miflora2Moisture => new SensorEntity(_app, new string[]{"sensor.miflora_2_moisture"});
        public SensorEntity PassageCeilingSpotlightsPower2 => new SensorEntity(_app, new string[]{"sensor.passage_ceiling_spotlights_power_2"});
        public SensorEntity WithingsBoneMassKgIsa2 => new SensorEntity(_app, new string[]{"sensor.withings_bone_mass_kg_isa_2"});
        public SensorEntity KrisinformationStockholm => new SensorEntity(_app, new string[]{"sensor.krisinformation_stockholm"});
        public SensorEntity RoborockError => new SensorEntity(_app, new string[]{"sensor.roborock_error"});
        public SensorEntity Ender3ProTimeRemaining => new SensorEntity(_app, new string[]{"sensor.ender_3_pro_time_remaining"});
        public SensorEntity DownstairsLitterboxMotion => new SensorEntity(_app, new string[]{"sensor.downstairs_litterbox_motion"});
        public SensorEntity IsaWeight => new SensorEntity(_app, new string[]{"sensor.isa_weight"});
        public SensorEntity DarkSkyPrecip1d => new SensorEntity(_app, new string[]{"sensor.dark_sky_precip_1d"});
        public SensorEntity PassageCeilingSpotlightsSystem => new SensorEntity(_app, new string[]{"sensor.passage_ceiling_spotlights_system"});
        public SensorEntity KitchenCeilingSpotlightsHeat => new SensorEntity(_app, new string[]{"sensor.kitchen_ceiling_spotlights_heat"});
        public SensorEntity LivingRoomSpotlightsPower => new SensorEntity(_app, new string[]{"sensor.living_room_spotlights_power"});
        public SensorEntity RefrigeratorBatteryLevel => new SensorEntity(_app, new string[]{"sensor.refrigerator_battery_level"});
        public SensorEntity Miflora1Temperature => new SensorEntity(_app, new string[]{"sensor.miflora_1_temperature"});
        public SensorEntity LastAction => new SensorEntity(_app, new string[]{"sensor.last_action"});
        public SensorEntity TradfriOnOffSwitchBatteryLevel => new SensorEntity(_app, new string[]{"sensor.tradfri_on_off_switch_battery_level"});
        public SensorEntity VersionAvailable => new SensorEntity(_app, new string[]{"sensor.version_available"});
        public SensorEntity Ender3ProTargetBedTemp => new SensorEntity(_app, new string[]{"sensor.ender_3_pro_target_bed_temp"});
        public SensorEntity DryerPlugExporting => new SensorEntity(_app, new string[]{"sensor.dryer_plug_exporting"});
        public SensorEntity WithingsFatFreeMassKgIsa => new SensorEntity(_app, new string[]{"sensor.withings_fat_free_mass_kg_isa"});
        public SensorEntity DiningRoomStefanIphone11Bt => new SensorEntity(_app, new string[]{"sensor.dining_room_stefan_iphone_11_bt"});
        public SensorEntity StefansOfficeTemperature => new SensorEntity(_app, new string[]{"sensor.stefans_office_temperature"});
        public SensorEntity ShenzhenNeoElectronicsCoLtdBatteryPoweredPirSensorSourcenodeid => new SensorEntity(_app, new string[]{"sensor.shenzhen_neo_electronics_co_ltd_battery_powered_pir_sensor_sourcenodeid"});
        public SensorEntity UpstairsLitterlockerBatteryLevel => new SensorEntity(_app, new string[]{"sensor.upstairs_litterlocker_battery_level"});
        public SensorEntity StefansIphoneStorage => new SensorEntity(_app, new string[]{"sensor.stefans_iphone_storage"});
        public SensorEntity HallwayMotionBatteryLevel => new SensorEntity(_app, new string[]{"sensor.hallway_motion_battery_level"});
        public SensorEntity DafangKitchenLightSensor => new SensorEntity(_app, new string[]{"sensor.dafang_kitchen_light_sensor"});
        public SensorEntity LastUpdateTrigger => new SensorEntity(_app, new string[]{"sensor.last_update_trigger"});
        public SensorEntity RefrigeratorTemperature => new SensorEntity(_app, new string[]{"sensor.refrigerator_temperature"});
        public SensorEntity DarkSkyWindSpeed => new SensorEntity(_app, new string[]{"sensor.dark_sky_wind_speed"});
        public SensorEntity WaterHeaterFlood => new SensorEntity(_app, new string[]{"sensor.water_heater_flood"});
        public SensorEntity WithingsHeartPulseBpmIsa => new SensorEntity(_app, new string[]{"sensor.withings_heart_pulse_bpm_isa"});
        public SensorEntity DarkSkyApparentTemperature => new SensorEntity(_app, new string[]{"sensor.dark_sky_apparent_temperature"});
        public SensorEntity FrontDoorBatteryLevel => new SensorEntity(_app, new string[]{"sensor.front_door_battery_level"});
        public SensorEntity RingDoorbellWifiSignalStrength => new SensorEntity(_app, new string[]{"sensor.ring_doorbell_wifi_signal_strength"});
        public SensorEntity Ac17bc0cfe9RssiNumeric => new SensorEntity(_app, new string[]{"sensor.ac_17bc0cfe_9_rssi_numeric"});
        public SensorEntity IsabellaSIphoneXDistance => new SensorEntity(_app, new string[]{"sensor.isabella_s_iphone_x_distance"});
        public SensorEntity TradfriRemoteBatteryLevel => new SensorEntity(_app, new string[]{"sensor.tradfri_remote_battery_level"});
        public SensorEntity IsaCalories => new SensorEntity(_app, new string[]{"sensor.isa_calories"});
        public SensorEntity PassageCeilingSpotlightsVelocity => new SensorEntity(_app, new string[]{"sensor.passage_ceiling_spotlights_velocity"});
        public SensorEntity RingDoorbellLastDing => new SensorEntity(_app, new string[]{"sensor.ring_doorbell_last_ding"});
        public SensorEntity LastBoot => new SensorEntity(_app, new string[]{"sensor.last_boot"});
        public SensorEntity WithingsFatMassKgIsa2 => new SensorEntity(_app, new string[]{"sensor.withings_fat_mass_kg_isa_2"});
        public SensorEntity DarkSkyPrecipProbability => new SensorEntity(_app, new string[]{"sensor.dark_sky_precip_probability"});
        public SensorEntity DiningRoomCeilingLightPower => new SensorEntity(_app, new string[]{"sensor.dining_room_ceiling_light_power"});
        public SensorEntity DarkSkyPrecipIntensity => new SensorEntity(_app, new string[]{"sensor.dark_sky_precip_intensity"});
        public SensorEntity UpstairsHallwayMotionBurglar => new SensorEntity(_app, new string[]{"sensor.upstairs_hallway_motion_burglar"});
        public SensorEntity VerisureMail => new SensorEntity(_app, new string[]{"sensor.verisure_mail"});
        public SensorEntity Battery158d0001d37bdd => new SensorEntity(_app, new string[]{"sensor.battery_158d0001d37bdd"});
        public SensorEntity IsaHeight => new SensorEntity(_app, new string[]{"sensor.isa_height"});
        public SensorEntity UpstairsHallwayMotionBatteryLevel => new SensorEntity(_app, new string[]{"sensor.upstairs_hallway_motion_battery_level"});
        public SensorEntity WaterHeaterAlarmType => new SensorEntity(_app, new string[]{"sensor.water_heater_alarm_type"});
        public SensorEntity Ac37de34216RssiNumeric => new SensorEntity(_app, new string[]{"sensor.ac_37de342_16_rssi_numeric"});
        public SensorEntity RingDoorbellVolume => new SensorEntity(_app, new string[]{"sensor.ring_doorbell_volume"});
        public SensorEntity WaterHeater => new SensorEntity(_app, new string[]{"sensor.water_heater"});
        public SensorEntity StefansIphoneFloorsAscended => new SensorEntity(_app, new string[]{"sensor.stefans_iphone_floors_ascended"});
        public SensorEntity ProcessorUse => new SensorEntity(_app, new string[]{"sensor.processor_use"});
        public SensorEntity DateTime => new SensorEntity(_app, new string[]{"sensor.date_time"});
        public SensorEntity StefansIphoneBatteryLevel => new SensorEntity(_app, new string[]{"sensor.stefans_iphone_battery_level"});
        public SensorEntity UpstairsLitterboxMotionBatteryLevel => new SensorEntity(_app, new string[]{"sensor.upstairs_litterbox_motion_battery_level"});
        public SensorEntity KitchenSink => new SensorEntity(_app, new string[]{"sensor.kitchen_sink"});
        public SensorEntity DarkSkyDaytimeHighTemperature1d => new SensorEntity(_app, new string[]{"sensor.dark_sky_daytime_high_temperature_1d"});
        public SensorEntity PassageCeilingSpotlightsPower => new SensorEntity(_app, new string[]{"sensor.passage_ceiling_spotlights_power"});
        public SensorEntity GrocyChores => new SensorEntity(_app, new string[]{"sensor.grocy_chores"});
        public SensorEntity StefansOfficeMotionIlluminance => new SensorEntity(_app, new string[]{"sensor.stefans_office_motion_illuminance"});
        public SensorEntity KitchenCeilingSpotlightsPower2 => new SensorEntity(_app, new string[]{"sensor.kitchen_ceiling_spotlights_power_2"});
        public SensorEntity IsaDimmerBatteryLevel => new SensorEntity(_app, new string[]{"sensor.isa_dimmer_battery_level"});
        public SensorEntity WithingsWeightKgIsa2 => new SensorEntity(_app, new string[]{"sensor.withings_weight_kg_isa_2"});
        public SensorEntity PassageCeilingSpotlightsHeat => new SensorEntity(_app, new string[]{"sensor.passage_ceiling_spotlights_heat"});
        public SensorEntity IsabellaSIphoneXFloorsAscended => new SensorEntity(_app, new string[]{"sensor.isabella_s_iphone_x_floors_ascended"});
        public SensorEntity BedroomWindow => new SensorEntity(_app, new string[]{"sensor.bedroom_window"});
        public SensorEntity PassageCeilingSpotlightsExporting => new SensorEntity(_app, new string[]{"sensor.passage_ceiling_spotlights_exporting"});
        public SensorEntity Power51 => new SensorEntity(_app, new string[]{"sensor.power_51"});
        public SensorEntity DownstairsLitterboxSwitchBatteryLevel => new SensorEntity(_app, new string[]{"sensor.downstairs_litterbox_switch_battery_level"});
        public SensorEntity PassageHumidity => new SensorEntity(_app, new string[]{"sensor.passage_humidity"});
        public SensorEntity TiguanLastTripAverageSpeed => new SensorEntity(_app, new string[]{"sensor.tiguan_last_trip_average_speed"});
        public SensorEntity StefansIphoneBssid => new SensorEntity(_app, new string[]{"sensor.stefans_iphone_bssid"});
        public SensorEntity RoborockBinFull => new SensorEntity(_app, new string[]{"sensor.roborock_bin_full"});
        public SensorEntity PassageCeilingSpotlightsAlarmLevel => new SensorEntity(_app, new string[]{"sensor.passage_ceiling_spotlights_alarm_level"});
        public SensorEntity WithingsFatRatioPctIsa2 => new SensorEntity(_app, new string[]{"sensor.withings_fat_ratio_pct_isa_2"});
        public SensorEntity WaterHeaterAlarmLevel => new SensorEntity(_app, new string[]{"sensor.water_heater_alarm_level"});
        public SensorEntity EbikeCharger => new SensorEntity(_app, new string[]{"sensor.ebike_charger"});
        public SensorEntity DryerPlugRainRate => new SensorEntity(_app, new string[]{"sensor.dryer_plug_rain_rate"});
        public SensorEntity DarkSkyPrecip => new SensorEntity(_app, new string[]{"sensor.dark_sky_precip"});
        public SensorEntity LivingRoomSpotlightsExporting => new SensorEntity(_app, new string[]{"sensor.living_room_spotlights_exporting"});
        public SensorEntity LumiSensorSwitchBatteryLevel => new SensorEntity(_app, new string[]{"sensor.lumi_sensor_switch_battery_level"});
        public SensorEntity DarkSkyPrecipIntensity1d => new SensorEntity(_app, new string[]{"sensor.dark_sky_precip_intensity_1d"});
        public SensorEntity DryerPlugPower => new SensorEntity(_app, new string[]{"sensor.dryer_plug_power"});
        public SensorEntity TiguanCombustionRange => new SensorEntity(_app, new string[]{"sensor.tiguan_combustion_range"});
        public SensorEntity KitchenCeilingSpotlightsPower => new SensorEntity(_app, new string[]{"sensor.kitchen_ceiling_spotlights_power"});
        public SensorEntity MemoryUsePercent => new SensorEntity(_app, new string[]{"sensor.memory_use_percent"});
        public SensorEntity StefansIphoneLastUpdateTrigger => new SensorEntity(_app, new string[]{"sensor.stefans_iphone_last_update_trigger"});
        public SensorEntity FrontDoorAccessControl => new SensorEntity(_app, new string[]{"sensor.front_door_access_control"});
        public SensorEntity DryerPlugAlarmLevel => new SensorEntity(_app, new string[]{"sensor.dryer_plug_alarm_level"});
        public SensorEntity RoombaBatteryLevel => new SensorEntity(_app, new string[]{"sensor.roomba_battery_level"});
        public SensorEntity WithingsTemperatureCIsa => new SensorEntity(_app, new string[]{"sensor.withings_temperature_c_isa"});
        public SensorEntity StefansIphoneActivity => new SensorEntity(_app, new string[]{"sensor.stefans_iphone_activity"});
        public SensorEntity SnapshotBackup => new SensorEntity(_app, new string[]{"sensor.snapshot_backup"});
        public SensorEntity Repvagen => new SensorEntity(_app, new string[]{"sensor.repvagen"});
        public SensorEntity StefansIphoneFloorsDescended => new SensorEntity(_app, new string[]{"sensor.stefans_iphone_floors_descended"});
        public SensorEntity MonitorLivingRoom => new SensorEntity(_app, new string[]{"sensor.monitor_living_room"});
        public SensorEntity MailboxPackageBatteryLevel => new SensorEntity(_app, new string[]{"sensor.mailbox_package_battery_level"});
        public SensorEntity KitchenCeilingSpotlightsAlarmType => new SensorEntity(_app, new string[]{"sensor.kitchen_ceiling_spotlights_alarm_type"});
        public SensorEntity StorageSensorBatteryLevel => new SensorEntity(_app, new string[]{"sensor.storage_sensor_battery_level"});
        public SensorEntity MonitorDiningRoom => new SensorEntity(_app, new string[]{"sensor.monitor_dining_room"});
        public SensorEntity YardDoor => new SensorEntity(_app, new string[]{"sensor.yard_door"});
        public SensorEntity IsabellaSIphoneXLastUpdateTrigger => new SensorEntity(_app, new string[]{"sensor.isabella_s_iphone_x_last_update_trigger"});
        public SensorEntity WasherPlugVelocity => new SensorEntity(_app, new string[]{"sensor.washer_plug_velocity"});
        public SensorEntity TiguanLastConnected => new SensorEntity(_app, new string[]{"sensor.tiguan_last_connected"});
        public SensorEntity WithingsBodyTemperatureCIsa2 => new SensorEntity(_app, new string[]{"sensor.withings_body_temperature_c_isa_2"});
        public SensorEntity BalconyDoorBatteryLevel => new SensorEntity(_app, new string[]{"sensor.balcony_door_battery_level"});
        public SensorEntity PassageTemperature => new SensorEntity(_app, new string[]{"sensor.passage_temperature"});
        public SensorEntity IsasRoomWindowBatteryLevel => new SensorEntity(_app, new string[]{"sensor.isas_room_window_battery_level"});
        public SensorEntity PassageTemperatureBatteryLevel => new SensorEntity(_app, new string[]{"sensor.passage_temperature_battery_level"});
        public SensorEntity Miflora3Temperature => new SensorEntity(_app, new string[]{"sensor.miflora_3_temperature"});
        public SensorEntity StefansIphoneSteps => new SensorEntity(_app, new string[]{"sensor.stefans_iphone_steps"});
        public SensorEntity KitchenCeilingSpotlightsEnergy => new SensorEntity(_app, new string[]{"sensor.kitchen_ceiling_spotlights_energy"});
        public SensorEntity Miflora3SoilConductivity => new SensorEntity(_app, new string[]{"sensor.miflora_3_soil_conductivity"});
        public SensorEntity WithingsDiastolicBloodPressureMmhgIsa2 => new SensorEntity(_app, new string[]{"sensor.withings_diastolic_blood_pressure_mmhg_isa_2"});
        public SensorEntity KitchenCeilingSpotlightsSystem => new SensorEntity(_app, new string[]{"sensor.kitchen_ceiling_spotlights_system"});
        public SensorEntity IsabellaSIphoneXBatteryLevel => new SensorEntity(_app, new string[]{"sensor.isabella_s_iphone_x_battery_level"});
        public SensorEntity HpEnvy5540SeriesBlackInk => new SensorEntity(_app, new string[]{"sensor.hp_envy_5540_series_black_ink"});
        public SensorEntity Battery158d0001d37c82 => new SensorEntity(_app, new string[]{"sensor.battery_158d0001d37c82"});
        public SensorEntity WasherPlugAlarmType => new SensorEntity(_app, new string[]{"sensor.washer_plug_alarm_type"});
        public SensorEntity IsabellaSIphoneXSsid => new SensorEntity(_app, new string[]{"sensor.isabella_s_iphone_x_ssid"});
        public SensorEntity UpstairsHallwayMotionAlarmLevel => new SensorEntity(_app, new string[]{"sensor.upstairs_hallway_motion_alarm_level"});
        public SensorEntity RingDoorbellWifiSignalCategory => new SensorEntity(_app, new string[]{"sensor.ring_doorbell_wifi_signal_category"});
        public SensorEntity UpstairsHallwayMotionLuminance => new SensorEntity(_app, new string[]{"sensor.upstairs_hallway_motion_luminance"});
        public SensorEntity DashboardMotion => new SensorEntity(_app, new string[]{"sensor.dashboard_motion"});
        public SensorEntity WasherPlugPower => new SensorEntity(_app, new string[]{"sensor.washer_plug_power"});
        public SensorEntity BalconyDoor => new SensorEntity(_app, new string[]{"sensor.balcony_door"});
        public SensorEntity DryerHatchBatteryLevel => new SensorEntity(_app, new string[]{"sensor.dryer_hatch_battery_level"});
        public SensorEntity StefansIphoneSim2 => new SensorEntity(_app, new string[]{"sensor.stefans_iphone_sim_2"});
        public SensorEntity Smhialert => new SensorEntity(_app, new string[]{"sensor.smhialert"});
        public SensorEntity IsabellaSIphoneXSteps => new SensorEntity(_app, new string[]{"sensor.isabella_s_iphone_x_steps"});
        public SensorEntity BackDoor => new SensorEntity(_app, new string[]{"sensor.back_door"});
        public SensorEntity Ac26bc0cfe9RssiNumeric => new SensorEntity(_app, new string[]{"sensor.ac_26bc0cfe_9_rssi_numeric"});
        public SensorEntity ShenzhenNeoElectronicsCoLtdBatteryPoweredPirSensorBurglar => new SensorEntity(_app, new string[]{"sensor.shenzhen_neo_electronics_co_ltd_battery_powered_pir_sensor_burglar"});
        public SensorEntity StorageHumidity => new SensorEntity(_app, new string[]{"sensor.storage_humidity"});
        public SensorEntity BedroomTemperatureBatteryLevel => new SensorEntity(_app, new string[]{"sensor.bedroom_temperature_battery_level"});
        public SensorEntity Ac37de34214RssiNumeric => new SensorEntity(_app, new string[]{"sensor.ac_37de342_14_rssi_numeric"});
        public SensorEntity DarkSkyCloudCoverage => new SensorEntity(_app, new string[]{"sensor.dark_sky_cloud_coverage"});
        public SensorEntity PassageMotionAlarmType => new SensorEntity(_app, new string[]{"sensor.passage_motion_alarm_type"});
        public SensorEntity VibrationSensor1BatteryLevel => new SensorEntity(_app, new string[]{"sensor.vibration_sensor_1_battery_level"});
        public SensorEntity StefansIphoneConnectionType => new SensorEntity(_app, new string[]{"sensor.stefans_iphone_connection_type"});
        public SensorEntity WithingsSystolicBloodPressureMmhgIsa2 => new SensorEntity(_app, new string[]{"sensor.withings_systolic_blood_pressure_mmhg_isa_2"});
        public SensorEntity WithingsSpo2PctIsa2 => new SensorEntity(_app, new string[]{"sensor.withings_spo2_pct_isa_2"});
        public SensorEntity XiaomiMap => new SensorEntity(_app, new string[]{"sensor.xiaomi_map"});
        public SensorEntity VibrationSensor2BatteryLevel => new SensorEntity(_app, new string[]{"sensor.vibration_sensor_2_battery_level"});
        public SensorEntity PassageMotionBurglar => new SensorEntity(_app, new string[]{"sensor.passage_motion_burglar"});
        public SensorEntity LivingRoomRollerBlindEnergy => new SensorEntity(_app, new string[]{"sensor.living_room_roller_blind_energy"});
        public SensorEntity Miflora1Moisture => new SensorEntity(_app, new string[]{"sensor.miflora_1_moisture"});
        public SensorEntity ShenzhenNeoElectronicsCoLtdBatteryPoweredPirSensorAlarmType => new SensorEntity(_app, new string[]{"sensor.shenzhen_neo_electronics_co_ltd_battery_powered_pir_sensor_alarm_type"});
        public SensorEntity TiguanFuelLevel => new SensorEntity(_app, new string[]{"sensor.tiguan_fuel_level"});
        public SensorEntity KitchenCeilingSpotlightsAlarmLevel => new SensorEntity(_app, new string[]{"sensor.kitchen_ceiling_spotlights_alarm_level"});
        public SensorEntity DarkSkyOvernightLowTemperature1d => new SensorEntity(_app, new string[]{"sensor.dark_sky_overnight_low_temperature_1d"});
        public SensorEntity Ac37de34215RssiNumeric => new SensorEntity(_app, new string[]{"sensor.ac_37de342_15_rssi_numeric"});
        public SensorEntity Miflora1Illuminance => new SensorEntity(_app, new string[]{"sensor.miflora_1_illuminance"});
        public SensorEntity UpstairsLitterboxSwitchBatteryLevel => new SensorEntity(_app, new string[]{"sensor.upstairs_litterbox_switch_battery_level"});
        public SensorEntity BedroomWindowBatteryLevel => new SensorEntity(_app, new string[]{"sensor.bedroom_window_battery_level"});
        public SensorEntity Ender3ProJobPercentage => new SensorEntity(_app, new string[]{"sensor.ender_3_pro_job_percentage"});
        public SensorEntity BedsideDimmerBatteryLevel => new SensorEntity(_app, new string[]{"sensor.bedside_dimmer_battery_level"});
        public SensorEntity Ac73bc0cfe8RssiNumeric => new SensorEntity(_app, new string[]{"sensor.ac_73bc0cfe_8_rssi_numeric"});
        public SensorEntity Miflora1BatteryLevel => new SensorEntity(_app, new string[]{"sensor.miflora_1_battery_level"});
        public SensorEntity LivingRoomSpotlightsPreviousReading => new SensorEntity(_app, new string[]{"sensor.living_room_spotlights_previous_reading"});
        public SensorEntity FrontDoorLock => new SensorEntity(_app, new string[]{"sensor.front_door_lock"});
        public SensorEntity IsabellaSIphoneXActivity => new SensorEntity(_app, new string[]{"sensor.isabella_s_iphone_x_activity"});
        public SensorEntity WasherPlugPower2 => new SensorEntity(_app, new string[]{"sensor.washer_plug_power_2"});
        public SensorEntity Battery158d0001d37be5 => new SensorEntity(_app, new string[]{"sensor.battery_158d0001d37be5"});
        public SensorEntity PassageMotionLuminance => new SensorEntity(_app, new string[]{"sensor.passage_motion_luminance"});
        public SensorEntity Time => new SensorEntity(_app, new string[]{"sensor.time"});
        public SensorEntity DarkSkyTemperature => new SensorEntity(_app, new string[]{"sensor.dark_sky_temperature"});
        public SensorEntity XiaomiSwitch2BatteryLevel => new SensorEntity(_app, new string[]{"sensor.xiaomi_switch_2_battery_level"});
        public SensorEntity StefanRemoteBatteryLevel => new SensorEntity(_app, new string[]{"sensor.stefan_remote_battery_level"});
        public SensorEntity XiaomiGatewayIllumination => new SensorEntity(_app, new string[]{"sensor.xiaomi_gateway_illumination"});
        public SensorEntity WasherPlugExporting => new SensorEntity(_app, new string[]{"sensor.washer_plug_exporting"});
        public SensorEntity Ender3ProActualTool0Temp => new SensorEntity(_app, new string[]{"sensor.ender_3_pro_actual_tool0_temp"});
        public SensorEntity TiguanLastTripDuration => new SensorEntity(_app, new string[]{"sensor.tiguan_last_trip_duration"});
        public SensorEntity ConnectionType => new SensorEntity(_app, new string[]{"sensor.connection_type"});
        public SensorEntity WithingsFatMassKgIsa => new SensorEntity(_app, new string[]{"sensor.withings_fat_mass_kg_isa"});
        public SensorEntity DryerPlugEnergy => new SensorEntity(_app, new string[]{"sensor.dryer_plug_energy"});
        public SensorEntity LivingRoomRollerBlindPower => new SensorEntity(_app, new string[]{"sensor.living_room_roller_blind_power"});
        public SensorEntity DryerPlugAlarmType => new SensorEntity(_app, new string[]{"sensor.dryer_plug_alarm_type"});
        public SensorEntity MemoryFree => new SensorEntity(_app, new string[]{"sensor.memory_free"});
        public SensorEntity TiguanLastTripLength => new SensorEntity(_app, new string[]{"sensor.tiguan_last_trip_length"});
        public SensorEntity WaterHeaterBatteryLevel => new SensorEntity(_app, new string[]{"sensor.water_heater_battery_level"});
        public SensorEntity Ender3ProActualBedTemp => new SensorEntity(_app, new string[]{"sensor.ender_3_pro_actual_bed_temp"});
        public SensorEntity WithingsPulseWaveVelocityIsa2 => new SensorEntity(_app, new string[]{"sensor.withings_pulse_wave_velocity_isa_2"});
        public SensorEntity KrisinformationSverige => new SensorEntity(_app, new string[]{"sensor.krisinformation_sverige"});
        public SensorEntity Miflora3BatteryLevel => new SensorEntity(_app, new string[]{"sensor.miflora_3_battery_level"});
        public SensorEntity GrocyShoppingList => new SensorEntity(_app, new string[]{"sensor.grocy_shopping_list"});
        public SensorEntity IsabellaSIphoneXConnectionType => new SensorEntity(_app, new string[]{"sensor.isabella_s_iphone_x_connection_type"});
        public SensorEntity LivingRoomSpotlightsHeat => new SensorEntity(_app, new string[]{"sensor.living_room_spotlights_heat"});
        public SensorEntity DiningRoomIsabellasIphoneXBt => new SensorEntity(_app, new string[]{"sensor.dining_room_isabellas_iphone_x_bt"});
        public SensorEntity IsaSteps => new SensorEntity(_app, new string[]{"sensor.isa_steps"});
        public SensorEntity HpEnvy5540SeriesUptime => new SensorEntity(_app, new string[]{"sensor.hp_envy_5540_series_uptime"});
        public SensorEntity TradfriOnOffSwitchBatteryLevel2 => new SensorEntity(_app, new string[]{"sensor.tradfri_on_off_switch_battery_level_2"});
        public SensorEntity StefansOfficeMotionBatteryLevel => new SensorEntity(_app, new string[]{"sensor.stefans_office_motion_battery_level"});
        public SensorEntity DownstairsBathroomTemperatureBatteryLevel => new SensorEntity(_app, new string[]{"sensor.downstairs_bathroom_temperature_battery_level"});
        public SensorEntity Bssid => new SensorEntity(_app, new string[]{"sensor.bssid"});
        public SensorEntity UpstairsHallwayMotionAlarmType => new SensorEntity(_app, new string[]{"sensor.upstairs_hallway_motion_alarm_type"});
        public SensorEntity StorageTemperature => new SensorEntity(_app, new string[]{"sensor.storage_temperature"});
        public SensorEntity Ac61bc0cfe5RssiNumeric => new SensorEntity(_app, new string[]{"sensor.ac_61bc0cfe_5_rssi_numeric"});
        public SensorEntity DownstairsBathroomTemperature => new SensorEntity(_app, new string[]{"sensor.downstairs_bathroom_temperature"});
        public SensorEntity FrontDoorAlarmLevel => new SensorEntity(_app, new string[]{"sensor.front_door_alarm_level"});
        public SensorEntity DarkSkyMinutelySummary => new SensorEntity(_app, new string[]{"sensor.dark_sky_minutely_summary"});
        public SensorEntity WithingsSkinTemperatureCIsa2 => new SensorEntity(_app, new string[]{"sensor.withings_skin_temperature_c_isa_2"});
        public SensorEntity Ac17bc0cfe8RssiNumeric => new SensorEntity(_app, new string[]{"sensor.ac_17bc0cfe_8_rssi_numeric"});
        public SensorEntity DryerPlugPower2 => new SensorEntity(_app, new string[]{"sensor.dryer_plug_power_2"});
        public SensorEntity BatteryLevel2 => new SensorEntity(_app, new string[]{"sensor.battery_level_2"});
        public SensorEntity IsabellaSIphoneXAverageActivePace => new SensorEntity(_app, new string[]{"sensor.isabella_s_iphone_x_average_active_pace"});
        public SensorEntity HallwayDimmerBatteryLevel => new SensorEntity(_app, new string[]{"sensor.hallway_dimmer_battery_level"});
        public SensorEntity IsabellaSIphoneXBatteryState => new SensorEntity(_app, new string[]{"sensor.isabella_s_iphone_x_battery_state"});
        public SensorEntity DarkSkyDailyMaxPrecipIntensity1d => new SensorEntity(_app, new string[]{"sensor.dark_sky_daily_max_precip_intensity_1d"});
        public SensorEntity OuterWindows => new SensorEntity(_app, new string[]{"sensor.outer_windows"});
        public SensorEntity RingDoorbellLastMotion => new SensorEntity(_app, new string[]{"sensor.ring_doorbell_last_motion"});
        public SensorEntity HpEnvy5540Series => new SensorEntity(_app, new string[]{"sensor.hp_envy_5540_series"});
        public SensorEntity IsabellaSIphoneXStorage => new SensorEntity(_app, new string[]{"sensor.isabella_s_iphone_x_storage"});
        public SensorEntity RefrigeratorHumidity => new SensorEntity(_app, new string[]{"sensor.refrigerator_humidity"});
        public SensorEntity WasherHatchBatteryLevel => new SensorEntity(_app, new string[]{"sensor.washer_hatch_battery_level"});
        public SensorEntity DiningRoomWindowBatteryLevel => new SensorEntity(_app, new string[]{"sensor.dining_room_window_battery_level"});
        public SensorEntity Miflora3Moisture => new SensorEntity(_app, new string[]{"sensor.miflora_3_moisture"});
        public SensorEntity Activity => new SensorEntity(_app, new string[]{"sensor.activity"});
        public SensorEntity KitchenCeilingSpotlightsVelocity => new SensorEntity(_app, new string[]{"sensor.kitchen_ceiling_spotlights_velocity"});
        public SensorEntity RingDoorbellLastActivity => new SensorEntity(_app, new string[]{"sensor.ring_doorbell_last_activity"});
        public SensorEntity StefansOfficeDoorBatteryLevel => new SensorEntity(_app, new string[]{"sensor.stefans_office_door_battery_level"});
        public SensorEntity WithingsTemperatureCIsa2 => new SensorEntity(_app, new string[]{"sensor.withings_temperature_c_isa_2"});
        public SensorEntity GrocyStock => new SensorEntity(_app, new string[]{"sensor.grocy_stock"});
        public SensorEntity WithingsHeartPulseBpmIsa2 => new SensorEntity(_app, new string[]{"sensor.withings_heart_pulse_bpm_isa_2"});
        public SensorEntity IsaSleep => new SensorEntity(_app, new string[]{"sensor.isa_sleep"});
        public SensorEntity StefansIphoneBatteryState => new SensorEntity(_app, new string[]{"sensor.stefans_iphone_battery_state"});
        public SensorEntity UpstairsLitterboxMotion => new SensorEntity(_app, new string[]{"sensor.upstairs_litterbox_motion"});
        public SensorEntity DarkSkyWindSpeed1d => new SensorEntity(_app, new string[]{"sensor.dark_sky_wind_speed_1d"});
        public SensorEntity TiguanCombinedRange => new SensorEntity(_app, new string[]{"sensor.tiguan_combined_range"});
        public SensorEntity LivingRoomSpotlightsSystem => new SensorEntity(_app, new string[]{"sensor.living_room_spotlights_system"});
        public SensorEntity LivingRoomStefanIphone11Bt => new SensorEntity(_app, new string[]{"sensor.living_room_stefan_iphone_11_bt"});
        public SensorEntity StefansOfficeHumidity => new SensorEntity(_app, new string[]{"sensor.stefans_office_humidity"});
        public SensorEntity IsaMoveTime => new SensorEntity(_app, new string[]{"sensor.isa_move_time"});
        public SensorEntity StefansIpadStorage => new SensorEntity(_app, new string[]{"sensor.stefans_ipad_storage"});
        public SensorEntity StorageSensor2 => new SensorEntity(_app, new string[]{"sensor.storage_sensor_2"});
        public SensorEntity TiguanLastTripAverageFuelConsumption => new SensorEntity(_app, new string[]{"sensor.tiguan_last_trip_average_fuel_consumption"});
        public SensorEntity DarkSkyPrecipProbability1d => new SensorEntity(_app, new string[]{"sensor.dark_sky_precip_probability_1d"});
        public SensorEntity FrontDoor => new SensorEntity(_app, new string[]{"sensor.front_door"});
        public SensorEntity UpstairsLitterboxVisits => new SensorEntity(_app, new string[]{"sensor.upstairs_litterbox_visits"});
        public SensorEntity Miflora2BatteryLevel => new SensorEntity(_app, new string[]{"sensor.miflora_2_battery_level"});
        public SensorEntity TiguanOdometer => new SensorEntity(_app, new string[]{"sensor.tiguan_odometer"});
        public SensorEntity GrocyMealPlan => new SensorEntity(_app, new string[]{"sensor.grocy_meal_plan"});
        public SensorEntity StefansIphoneDistance => new SensorEntity(_app, new string[]{"sensor.stefans_iphone_distance"});
        public SensorEntity MailboxLetterBatteryLevel => new SensorEntity(_app, new string[]{"sensor.mailbox_letter_battery_level"});
        public SensorEntity IsaRemoteBatteryLevel => new SensorEntity(_app, new string[]{"sensor.isa_remote_battery_level"});
        public SensorEntity DarkSkySummary1d => new SensorEntity(_app, new string[]{"sensor.dark_sky_summary_1d"});
        public SensorEntity Consumption50 => new SensorEntity(_app, new string[]{"sensor.consumption_50"});
        public SensorEntity IsaDistance => new SensorEntity(_app, new string[]{"sensor.isa_distance"});
        public SensorEntity IsasRoomWindow => new SensorEntity(_app, new string[]{"sensor.isas_room_window"});
        public SensorEntity KitchenCeilingSpotlightsExporting => new SensorEntity(_app, new string[]{"sensor.kitchen_ceiling_spotlights_exporting"});
        public SensorEntity LivingRoomRollerBlindPreviousReading => new SensorEntity(_app, new string[]{"sensor.living_room_roller_blind_previous_reading"});
        public SensorEntity OuterDoors => new SensorEntity(_app, new string[]{"sensor.outer_doors"});
        public SensorEntity Laundry => new SensorEntity(_app, new string[]{"sensor.laundry"});
    }

    public partial class InputBooleanEntities
    {
        private readonly NetDaemonRxApp _app;
        public InputBooleanEntities(NetDaemonRxApp app)
        {
            _app = app;
        }

        public InputBooleanEntity AdMailbox => new InputBooleanEntity(_app, new string[]{"input_boolean.ad_mailbox"});
        public InputBooleanEntity AdMedicineReminder => new InputBooleanEntity(_app, new string[]{"input_boolean.ad_medicine_reminder"});
        public InputBooleanEntity AdCameraMotionNotification => new InputBooleanEntity(_app, new string[]{"input_boolean.ad_camera_motion_notification"});
        public InputBooleanEntity AdTrash => new InputBooleanEntity(_app, new string[]{"input_boolean.ad_trash"});
        public InputBooleanEntity VacuumWhenHomeScheduled => new InputBooleanEntity(_app, new string[]{"input_boolean.vacuum_when_home_scheduled"});
        public InputBooleanEntity AdCameraMotionSnapshots => new InputBooleanEntity(_app, new string[]{"input_boolean.ad_camera_motion_snapshots"});
        public InputBooleanEntity AdSensorLights => new InputBooleanEntity(_app, new string[]{"input_boolean.ad_sensor_lights"});
        public InputBooleanEntity AdLaundry => new InputBooleanEntity(_app, new string[]{"input_boolean.ad_laundry"});
        public InputBooleanEntity AdVacuuming => new InputBooleanEntity(_app, new string[]{"input_boolean.ad_vacuuming"});
        public InputBooleanEntity EcLightsOnRingControl => new InputBooleanEntity(_app, new string[]{"input_boolean.ec_lights_on_ring_control"});
        public InputBooleanEntity Test => new InputBooleanEntity(_app, new string[]{"input_boolean.test"});
        public InputBooleanEntity DndIsa => new InputBooleanEntity(_app, new string[]{"input_boolean.dnd_isa"});
        public InputBooleanEntity AdSummaries => new InputBooleanEntity(_app, new string[]{"input_boolean.ad_summaries"});
        public InputBooleanEntity VacuumDownstairsScheduled => new InputBooleanEntity(_app, new string[]{"input_boolean.vacuum_downstairs_scheduled"});
        public InputBooleanEntity VacationMode => new InputBooleanEntity(_app, new string[]{"input_boolean.vacation_mode"});
        public InputBooleanEntity GoodMorningIsa => new InputBooleanEntity(_app, new string[]{"input_boolean.good_morning_isa"});
        public InputBooleanEntity AdPresence => new InputBooleanEntity(_app, new string[]{"input_boolean.ad_presence"});
        public InputBooleanEntity EcYardLightNetControl => new InputBooleanEntity(_app, new string[]{"input_boolean.ec_yard_light_net_control"});
        public InputBooleanEntity GuestMode => new InputBooleanEntity(_app, new string[]{"input_boolean.guest_mode"});
        public InputBooleanEntity AdLitterboxes => new InputBooleanEntity(_app, new string[]{"input_boolean.ad_litterboxes"});
        public InputBooleanEntity AdBikeCharger => new InputBooleanEntity(_app, new string[]{"input_boolean.ad_bike_charger"});
        public InputBooleanEntity WorkingFromHome => new InputBooleanEntity(_app, new string[]{"input_boolean.working_from_home"});
        public InputBooleanEntity IsaMode => new InputBooleanEntity(_app, new string[]{"input_boolean.isa_mode"});
        public InputBooleanEntity AdAlarm => new InputBooleanEntity(_app, new string[]{"input_boolean.ad_alarm"});
        public InputBooleanEntity AdLightSchedule => new InputBooleanEntity(_app, new string[]{"input_boolean.ad_light_schedule"});
        public InputBooleanEntity AdAirCleanerSchedule => new InputBooleanEntity(_app, new string[]{"input_boolean.ad_air_cleaner_schedule"});
    }

    public partial class CoverEntities
    {
        private readonly NetDaemonRxApp _app;
        public CoverEntities(NetDaemonRxApp app)
        {
            _app = app;
        }

        public CoverEntity LivingRoomRollerBlindSwitch => new CoverEntity(_app, new string[]{"cover.living_room_roller_blind_switch"});
        public CoverEntity DafangKitchenMoveUpDown => new CoverEntity(_app, new string[]{"cover.dafang_kitchen_move_up_down"});
        public CoverEntity DafangIsasroomMoveLeftRight => new CoverEntity(_app, new string[]{"cover.dafang_isasroom_move_left_right"});
        public CoverEntity LivingRoomRollerBlindLevel => new CoverEntity(_app, new string[]{"cover.living_room_roller_blind_level"});
        public CoverEntity DafangLeftRight => new CoverEntity(_app, new string[]{"cover.dafang_left_right"});
        public CoverEntity XiaofangMoveUpDown => new CoverEntity(_app, new string[]{"cover.xiaofang_move_up_down"});
        public CoverEntity DafangKitchenMoveLeftRight => new CoverEntity(_app, new string[]{"cover.dafang_kitchen_move_left_right"});
        public CoverEntity DafangUpDown => new CoverEntity(_app, new string[]{"cover.dafang_up_down"});
        public CoverEntity DafangIsasRoomLeftRight => new CoverEntity(_app, new string[]{"cover.dafang_isas_room_left_right"});
        public CoverEntity DafangIsasRoomUpDown => new CoverEntity(_app, new string[]{"cover.dafang_isas_room_up_down"});
        public CoverEntity DafangIsasroomMoveUpDown => new CoverEntity(_app, new string[]{"cover.dafang_isasroom_move_up_down"});
        public CoverEntity XiaofangMoveLeftRight => new CoverEntity(_app, new string[]{"cover.xiaofang_move_left_right"});
        public CoverEntity SannceUpDown => new CoverEntity(_app, new string[]{"cover.sannce_up_down"});
        public CoverEntity SannceLeftRight => new CoverEntity(_app, new string[]{"cover.sannce_left_right"});
    }

    public partial class CalendarEntities
    {
        private readonly NetDaemonRxApp _app;
        public CalendarEntities(NetDaemonRxApp app)
        {
            _app = app;
        }

        public CalendarEntity HomeAssistantDevs => new CalendarEntity(_app, new string[]{"calendar.home_assistant_devs"});
        public CalendarEntity HouseCleaning => new CalendarEntity(_app, new string[]{"calendar.house_cleaning"});
        public CalendarEntity WorkFromOffice => new CalendarEntity(_app, new string[]{"calendar.work_from_office"});
        public CalendarEntity IsabellaAlstrom => new CalendarEntity(_app, new string[]{"calendar.isabella_alstrom"});
        public CalendarEntity CleaningDayOffset => new CalendarEntity(_app, new string[]{"calendar.cleaning_day_offset"});
        public CalendarEntity GarbageDay => new CalendarEntity(_app, new string[]{"calendar.garbage_day"});
        public CalendarEntity House => new CalendarEntity(_app, new string[]{"calendar.house"});
        public CalendarEntity TakeInGarbage => new CalendarEntity(_app, new string[]{"calendar.take_in_garbage"});
        public CalendarEntity Isabellaalstromisotopse => new CalendarEntity(_app, new string[]{"calendar.isabellaalstromisotopse"});
        public CalendarEntity CleaningDay => new CalendarEntity(_app, new string[]{"calendar.cleaning_day"});
    }

    public partial class RemoteEntities
    {
        private readonly NetDaemonRxApp _app;
        public RemoteEntities(NetDaemonRxApp app)
        {
            _app = app;
        }

        public RemoteEntity Bedroom => new RemoteEntity(_app, new string[]{"remote.bedroom"});
        public RemoteEntity Vardagsrum => new RemoteEntity(_app, new string[]{"remote.vardagsrum"});
    }

    public partial class DeviceTrackerEntities
    {
        private readonly NetDaemonRxApp _app;
        public DeviceTrackerEntities(NetDaemonRxApp app)
        {
            _app = app;
        }

        public DeviceTrackerEntity NvidiaShield => new DeviceTrackerEntity(_app, new string[]{"device_tracker.nvidia_shield"});
        public DeviceTrackerEntity AxisLivingRoom => new DeviceTrackerEntity(_app, new string[]{"device_tracker.axis_living_room"});
        public DeviceTrackerEntity Tile8b84f9654688b3ec => new DeviceTrackerEntity(_app, new string[]{"device_tracker.tile_8b84f9654688b3ec"});
        public DeviceTrackerEntity DafangKitchen => new DeviceTrackerEntity(_app, new string[]{"device_tracker.dafang_kitchen"});
        public DeviceTrackerEntity StefansIphone => new DeviceTrackerEntity(_app, new string[]{"device_tracker.stefans_iphone"});
        public DeviceTrackerEntity IsaAddonPresence => new DeviceTrackerEntity(_app, new string[]{"device_tracker.isa_addon_presence"});
        public DeviceTrackerEntity XiaofangDownstairsLitterbox => new DeviceTrackerEntity(_app, new string[]{"device_tracker.xiaofang_downstairs_litterbox"});
        public DeviceTrackerEntity Tiguan => new DeviceTrackerEntity(_app, new string[]{"device_tracker.tiguan"});
        public DeviceTrackerEntity DafangIsa => new DeviceTrackerEntity(_app, new string[]{"device_tracker.dafang_isa"});
        public DeviceTrackerEntity VerisureHub => new DeviceTrackerEntity(_app, new string[]{"device_tracker.verisure_hub"});
        public DeviceTrackerEntity XiaofangYardLeft => new DeviceTrackerEntity(_app, new string[]{"device_tracker.xiaofang_yard_left"});
        public DeviceTrackerEntity StefanAddonPresence => new DeviceTrackerEntity(_app, new string[]{"device_tracker.stefan_addon_presence"});
        public DeviceTrackerEntity AxisPassage => new DeviceTrackerEntity(_app, new string[]{"device_tracker.axis_passage"});
        public DeviceTrackerEntity BroadlinkBedroom => new DeviceTrackerEntity(_app, new string[]{"device_tracker.broadlink_bedroom"});
        public DeviceTrackerEntity IsabellaSIphoneX => new DeviceTrackerEntity(_app, new string[]{"device_tracker.isabella_s_iphone_x"});
        public DeviceTrackerEntity Nas => new DeviceTrackerEntity(_app, new string[]{"device_tracker.nas"});
        public DeviceTrackerEntity XiaofangYardRight => new DeviceTrackerEntity(_app, new string[]{"device_tracker.xiaofang_yard_right"});
        public DeviceTrackerEntity DahuaCamera => new DeviceTrackerEntity(_app, new string[]{"device_tracker.dahua_camera"});
        public DeviceTrackerEntity StefansIphoneWifi => new DeviceTrackerEntity(_app, new string[]{"device_tracker.stefans_iphone_wifi"});
        public DeviceTrackerEntity XiaofangUpstairsLitterbox => new DeviceTrackerEntity(_app, new string[]{"device_tracker.xiaofang_upstairs_litterbox"});
        public DeviceTrackerEntity StefansIpad => new DeviceTrackerEntity(_app, new string[]{"device_tracker.stefans_ipad"});
        public DeviceTrackerEntity IsaComputer => new DeviceTrackerEntity(_app, new string[]{"device_tracker.isa_computer"});
        public DeviceTrackerEntity RpiZero => new DeviceTrackerEntity(_app, new string[]{"device_tracker.rpi_zero"});
        public DeviceTrackerEntity XiaomiGateway => new DeviceTrackerEntity(_app, new string[]{"device_tracker.xiaomi_gateway"});
        public DeviceTrackerEntity Sonos => new DeviceTrackerEntity(_app, new string[]{"device_tracker.sonos"});
        public DeviceTrackerEntity BroadlinkLivingRoom => new DeviceTrackerEntity(_app, new string[]{"device_tracker.broadlink_living_room"});
        public DeviceTrackerEntity RpiDashboard => new DeviceTrackerEntity(_app, new string[]{"device_tracker.rpi_dashboard"});
        public DeviceTrackerEntity Roborock => new DeviceTrackerEntity(_app, new string[]{"device_tracker.roborock"});
        public DeviceTrackerEntity SannceHallway => new DeviceTrackerEntity(_app, new string[]{"device_tracker.sannce_hallway"});
        public DeviceTrackerEntity StefanComputer => new DeviceTrackerEntity(_app, new string[]{"device_tracker.stefan_computer"});
        public DeviceTrackerEntity NintendoSwitch => new DeviceTrackerEntity(_app, new string[]{"device_tracker.nintendo_switch"});
        public DeviceTrackerEntity IsabellasIphoneWifi => new DeviceTrackerEntity(_app, new string[]{"device_tracker.isabellas_iphone_wifi"});
    }

    public partial class InputSelectEntities
    {
        private readonly NetDaemonRxApp _app;
        public InputSelectEntities(NetDaemonRxApp app)
        {
            _app = app;
        }

        public InputSelectEntity HouseMode => new InputSelectEntity(_app, new string[]{"input_select.house_mode"});
        public InputSelectEntity UlitterboxState => new InputSelectEntity(_app, new string[]{"input_select.ulitterbox_state"});
        public InputSelectEntity DlitterboxState => new InputSelectEntity(_app, new string[]{"input_select.dlitterbox_state"});
        public InputSelectEntity TrashStatus => new InputSelectEntity(_app, new string[]{"input_select.trash_status"});
        public InputSelectEntity EbikeChargerStatus => new InputSelectEntity(_app, new string[]{"input_select.ebike_charger_status"});
        public InputSelectEntity DryerStatus => new InputSelectEntity(_app, new string[]{"input_select.dryer_status"});
        public InputSelectEntity WashingMachineStatus => new InputSelectEntity(_app, new string[]{"input_select.washing_machine_status"});
        public InputSelectEntity RoombaMode => new InputSelectEntity(_app, new string[]{"input_select.roomba_mode"});
        public InputSelectEntity MailboxStatus => new InputSelectEntity(_app, new string[]{"input_select.mailbox_status"});
        public InputSelectEntity AirCleaner => new InputSelectEntity(_app, new string[]{"input_select.air_cleaner"});
    }

    public partial class ScriptEntities
    {
        private readonly NetDaemonRxApp _app;
        public ScriptEntities(NetDaemonRxApp app)
        {
            _app = app;
        }

        public ScriptEntity SannceCalibrate => new ScriptEntity(_app, new string[]{"script.sannce_calibrate"});
        public ScriptEntity DafangIsasRoomRight => new ScriptEntity(_app, new string[]{"script.dafang_isas_room_right"});
        public ScriptEntity E1587035537523 => new ScriptEntity(_app, new string[]{"script.1587035537523"});
        public ScriptEntity SannceLeft => new ScriptEntity(_app, new string[]{"script.sannce_left"});
        public ScriptEntity DafangIsasRoomUp => new ScriptEntity(_app, new string[]{"script.dafang_isas_room_up"});
        public ScriptEntity SannceUp => new ScriptEntity(_app, new string[]{"script.sannce_up"});
        public ScriptEntity DafangIsasRoomDown => new ScriptEntity(_app, new string[]{"script.dafang_isas_room_down"});
        public ScriptEntity SannceRight => new ScriptEntity(_app, new string[]{"script.sannce_right"});
        public ScriptEntity DafangCalibrate => new ScriptEntity(_app, new string[]{"script.dafang_calibrate"});
        public ScriptEntity CleaningTime => new ScriptEntity(_app, new string[]{"script.cleaning_time"});
        public ScriptEntity AirCleanerQuiet => new ScriptEntity(_app, new string[]{"script.air_cleaner_quiet"});
        public ScriptEntity DafangRight => new ScriptEntity(_app, new string[]{"script.dafang_right"});
        public ScriptEntity DafangLeft => new ScriptEntity(_app, new string[]{"script.dafang_left"});
        public ScriptEntity CleaningMusic => new ScriptEntity(_app, new string[]{"script.cleaning_music"});
        public ScriptEntity GoodMorningLightsAndDisarm => new ScriptEntity(_app, new string[]{"script.good_morning_lights_and_disarm"});
        public ScriptEntity SannceDown => new ScriptEntity(_app, new string[]{"script.sannce_down"});
        public ScriptEntity SonosSay => new ScriptEntity(_app, new string[]{"script.sonos_say"});
        public ScriptEntity DafangDown => new ScriptEntity(_app, new string[]{"script.dafang_down"});
        public ScriptEntity CleaningTimeOver => new ScriptEntity(_app, new string[]{"script.cleaning_time_over"});
        public ScriptEntity AirCleanerTurbo => new ScriptEntity(_app, new string[]{"script.air_cleaner_turbo"});
        public ScriptEntity E1587037128688 => new ScriptEntity(_app, new string[]{"script.1587037128688"});
        public ScriptEntity DafangIsasRoomLeft => new ScriptEntity(_app, new string[]{"script.dafang_isas_room_left"});
        public ScriptEntity DafangUp => new ScriptEntity(_app, new string[]{"script.dafang_up"});
        public ScriptEntity AirCleanerAuto => new ScriptEntity(_app, new string[]{"script.air_cleaner_auto"});
        public ScriptEntity DafangIsasRoomCalibrate => new ScriptEntity(_app, new string[]{"script.dafang_isas_room_calibrate"});
    }

    public partial class ZoneEntities
    {
        private readonly NetDaemonRxApp _app;
        public ZoneEntities(NetDaemonRxApp app)
        {
            _app = app;
        }

        public ZoneEntity WorkSolna2 => new ZoneEntity(_app, new string[]{"zone.work_solna_2"});
        public ZoneEntity Work => new ZoneEntity(_app, new string[]{"zone.work"});
        public ZoneEntity Haningestrand => new ZoneEntity(_app, new string[]{"zone.haningestrand"});
        public ZoneEntity BrulleNaprapat => new ZoneEntity(_app, new string[]{"zone.brulle_naprapat"});
        public ZoneEntity Home => new ZoneEntity(_app, new string[]{"zone.home"});
        public ZoneEntity Store => new ZoneEntity(_app, new string[]{"zone.store"});
        public ZoneEntity BrulleOchSaara => new ZoneEntity(_app, new string[]{"zone.brulle_och_saara"});
        public ZoneEntity Slussen => new ZoneEntity(_app, new string[]{"zone.slussen"});
        public ZoneEntity Emelie => new ZoneEntity(_app, new string[]{"zone.emelie"});
        public ZoneEntity Saltis9Halsbana => new ZoneEntity(_app, new string[]{"zone.saltis_9_halsbana"});
        public ZoneEntity SaltisHal615 => new ZoneEntity(_app, new string[]{"zone.saltis_hal_6_15"});
        public ZoneEntity Gun => new ZoneEntity(_app, new string[]{"zone.gun"});
        public ZoneEntity Fagelbro => new ZoneEntity(_app, new string[]{"zone.fagelbro"});
        public ZoneEntity JohannesOchTessie => new ZoneEntity(_app, new string[]{"zone.johannes_och_tessie"});
        public ZoneEntity SaltisGk => new ZoneEntity(_app, new string[]{"zone.saltis_gk"});
        public ZoneEntity Henriksdal => new ZoneEntity(_app, new string[]{"zone.henriksdal"});
    }

    public partial class LockEntities
    {
        private readonly NetDaemonRxApp _app;
        public LockEntities(NetDaemonRxApp app)
        {
            _app = app;
        }

        public LockEntity Ytterdorr => new LockEntity(_app, new string[]{"lock.ytterdorr"});
        public LockEntity TiguanTrunkLocked => new LockEntity(_app, new string[]{"lock.tiguan_trunk_locked"});
        public LockEntity TiguanDoorLocked => new LockEntity(_app, new string[]{"lock.tiguan_door_locked"});
    }

    public partial class MediaPlayerEntities
    {
        private readonly NetDaemonRxApp _app;
        public MediaPlayerEntities(NetDaemonRxApp app)
        {
            _app = app;
        }

        public MediaPlayerEntity ShieldPlex => new MediaPlayerEntity(_app, new string[]{"media_player.shield_plex"});
        public MediaPlayerEntity LivingRoomTv => new MediaPlayerEntity(_app, new string[]{"media_player.living_room_tv"});
        public MediaPlayerEntity SpotifyIsabellaGrossAlstrom => new MediaPlayerEntity(_app, new string[]{"media_player.spotify_isabella_gross_alstrom"});
        public MediaPlayerEntity Chromecast8855 => new MediaPlayerEntity(_app, new string[]{"media_player.chromecast8855"});
        public MediaPlayerEntity LivingRoomSonos => new MediaPlayerEntity(_app, new string[]{"media_player.living_room_sonos"});
        public MediaPlayerEntity BedroomTv => new MediaPlayerEntity(_app, new string[]{"media_player.bedroom_tv"});
        public MediaPlayerEntity Shield => new MediaPlayerEntity(_app, new string[]{"media_player.shield"});
        public MediaPlayerEntity LivingRoomNvidiaShield => new MediaPlayerEntity(_app, new string[]{"media_player.living_room_nvidia_shield"});
    }

    public partial class ZwaveEntities
    {
        private readonly NetDaemonRxApp _app;
        public ZwaveEntities(NetDaemonRxApp app)
        {
            _app = app;
        }

        public ZwaveEntity AeotecZw090ZstickGen5 => new ZwaveEntity(_app, new string[]{"zwave.aeotec_zw090_zstick_gen5"});
        public ZwaveEntity DryerPlug => new ZwaveEntity(_app, new string[]{"zwave.dryer_plug"});
        public ZwaveEntity PassageMotion => new ZwaveEntity(_app, new string[]{"zwave.passage_motion"});
        public ZwaveEntity UpstairsHallwayMotion => new ZwaveEntity(_app, new string[]{"zwave.upstairs_hallway_motion"});
        public ZwaveEntity PassageCeilingSpotlights => new ZwaveEntity(_app, new string[]{"zwave.passage_ceiling_spotlights"});
        public ZwaveEntity UpstairsHallwayCeilingLight => new ZwaveEntity(_app, new string[]{"zwave.upstairs_hallway_ceiling_light"});
        public ZwaveEntity ShenzhenNeoElectronicsCoLtdBatteryPoweredPirSensor => new ZwaveEntity(_app, new string[]{"zwave.shenzhen_neo_electronics_co_ltd_battery_powered_pir_sensor"});
        public ZwaveEntity KitchenCeilingSpotlights => new ZwaveEntity(_app, new string[]{"zwave.kitchen_ceiling_spotlights"});
        public ZwaveEntity WaterHeater => new ZwaveEntity(_app, new string[]{"zwave.water_heater"});
        public ZwaveEntity FrontDoor => new ZwaveEntity(_app, new string[]{"zwave.front_door"});
        public ZwaveEntity LivingRoomCeilingLight => new ZwaveEntity(_app, new string[]{"zwave.living_room_ceiling_light"});
        public ZwaveEntity DiningRoomCeilingLight => new ZwaveEntity(_app, new string[]{"zwave.dining_room_ceiling_light"});
        public ZwaveEntity WasherPlug => new ZwaveEntity(_app, new string[]{"zwave.washer_plug"});
        public ZwaveEntity LivingRoomSpotlights => new ZwaveEntity(_app, new string[]{"zwave.living_room_spotlights"});
        public ZwaveEntity UnknownNode5 => new ZwaveEntity(_app, new string[]{"zwave.unknown_node_5"});
        public ZwaveEntity LivingRoomRollerBlind => new ZwaveEntity(_app, new string[]{"zwave.living_room_roller_blind"});
    }

    public partial class SceneEntities
    {
        private readonly NetDaemonRxApp _app;
        public SceneEntities(NetDaemonRxApp app)
        {
            _app = app;
        }

        public SceneEntity MovieTime => new SceneEntity(_app, new string[]{"scene.movie_time"});
        public SceneEntity FloorlampUplightNormal => new SceneEntity(_app, new string[]{"scene.floorlamp_uplight_normal"});
        public SceneEntity WelcomeHome => new SceneEntity(_app, new string[]{"scene.welcome_home"});
        public SceneEntity Goodnight => new SceneEntity(_app, new string[]{"scene.goodnight"});
        public SceneEntity EveningLights => new SceneEntity(_app, new string[]{"scene.evening_lights"});
        public SceneEntity MorningLights => new SceneEntity(_app, new string[]{"scene.morning_lights"});
        public SceneEntity DarkLightsOff => new SceneEntity(_app, new string[]{"scene.dark_lights_off"});
        public SceneEntity DarkLightsOn => new SceneEntity(_app, new string[]{"scene.dark_lights_on"});
    }

    public partial class PlantEntities
    {
        private readonly NetDaemonRxApp _app;
        public PlantEntities(NetDaemonRxApp app)
        {
            _app = app;
        }

        public PlantEntity One => new PlantEntity(_app, new string[]{"plant.one"});
        public PlantEntity Three => new PlantEntity(_app, new string[]{"plant.three"});
        public PlantEntity Two => new PlantEntity(_app, new string[]{"plant.two"});
    }

    public partial class InputNumberEntities
    {
        private readonly NetDaemonRxApp _app;
        public InputNumberEntities(NetDaemonRxApp app)
        {
            _app = app;
        }

        public InputNumberEntity AllLitterboxPersistence => new InputNumberEntity(_app, new string[]{"input_number.all_litterbox_persistence"});
        public InputNumberEntity ServoControl => new InputNumberEntity(_app, new string[]{"input_number.servo_control"});
        public InputNumberEntity UpstairsLitterboxPersistence => new InputNumberEntity(_app, new string[]{"input_number.upstairs_litterbox_persistence"});
        public InputNumberEntity DownstairsLitterboxPersistence => new InputNumberEntity(_app, new string[]{"input_number.downstairs_litterbox_persistence"});
    }

    public partial class SunEntities
    {
        private readonly NetDaemonRxApp _app;
        public SunEntities(NetDaemonRxApp app)
        {
            _app = app;
        }

        public SunEntity Sun => new SunEntity(_app, new string[]{"sun.sun"});
    }

    public partial class NetdaemonEntities
    {
        private readonly NetDaemonRxApp _app;
        public NetdaemonEntities(NetDaemonRxApp app)
        {
            _app = app;
        }

        public NetdaemonEntity Status => new NetdaemonEntity(_app, new string[]{"netdaemon.status"});
    }

    public partial class AlertEntities
    {
        private readonly NetDaemonRxApp _app;
        public AlertEntities(NetDaemonRxApp app)
        {
            _app = app;
        }

        public AlertEntity DiningRoomWindowOpen => new AlertEntity(_app, new string[]{"alert.dining_room_window_open"});
        public AlertEntity WaterHeaterFlooding => new AlertEntity(_app, new string[]{"alert.water_heater_flooding"});
        public AlertEntity WasherClean => new AlertEntity(_app, new string[]{"alert.washer_clean"});
        public AlertEntity BalconyDoorOpen => new AlertEntity(_app, new string[]{"alert.balcony_door_open"});
        public AlertEntity BackyardDoorOpen => new AlertEntity(_app, new string[]{"alert.backyard_door_open"});
        public AlertEntity FrontDoorOpen => new AlertEntity(_app, new string[]{"alert.front_door_open"});
        public AlertEntity BackDoorOpen => new AlertEntity(_app, new string[]{"alert.back_door_open"});
        public AlertEntity KitchenSinkFlooding => new AlertEntity(_app, new string[]{"alert.kitchen_sink_flooding"});
    }

    public partial class ClimateEntities
    {
        private readonly NetDaemonRxApp _app;
        public ClimateEntities(NetDaemonRxApp app)
        {
            _app = app;
        }

        public ClimateEntity Sanyo => new ClimateEntity(_app, new string[]{"climate.sanyo"});
    }

    public partial class VacuumEntities
    {
        private readonly NetDaemonRxApp _app;
        public VacuumEntities(NetDaemonRxApp app)
        {
            _app = app;
        }

        public VacuumEntity Rockrobo => new VacuumEntity(_app, new string[]{"vacuum.rockrobo"});
    }

    public partial class WeatherEntities
    {
        private readonly NetDaemonRxApp _app;
        public WeatherEntities(NetDaemonRxApp app)
        {
            _app = app;
        }

        public WeatherEntity DarkSky => new WeatherEntity(_app, new string[]{"weather.dark_sky"});
        public WeatherEntity SmhiHome => new WeatherEntity(_app, new string[]{"weather.smhi_home"});
    }

    public partial class AlarmControlPanelEntities
    {
        private readonly NetDaemonRxApp _app;
        public AlarmControlPanelEntities(NetDaemonRxApp app)
        {
            _app = app;
        }

        public AlarmControlPanelEntity House => new AlarmControlPanelEntity(_app, new string[]{"alarm_control_panel.house"});
    }

    public partial class CounterEntities
    {
        private readonly NetDaemonRxApp _app;
        public CounterEntities(NetDaemonRxApp app)
        {
            _app = app;
        }

        public CounterEntity LitterboxDownstairsVisits => new CounterEntity(_app, new string[]{"counter.litterbox_downstairs_visits"});
        public CounterEntity AllLitterboxVisitsToday => new CounterEntity(_app, new string[]{"counter.all_litterbox_visits_today"});
        public CounterEntity LitterboxUpstairsVisits => new CounterEntity(_app, new string[]{"counter.litterbox_upstairs_visits"});
    }

    public partial class EntityControllerEntities
    {
        private readonly NetDaemonRxApp _app;
        public EntityControllerEntities(NetDaemonRxApp app)
        {
            _app = app;
        }

        public EntityControllerEntity YardLightNetControl => new EntityControllerEntity(_app, new string[]{"entity_controller.yard_light_net_control"});
        public EntityControllerEntity LightsOnRingControl => new EntityControllerEntity(_app, new string[]{"entity_controller.lights_on_ring_control"});
    }

    public partial class PersonEntities
    {
        private readonly NetDaemonRxApp _app;
        public PersonEntities(NetDaemonRxApp app)
        {
            _app = app;
        }

        public PersonEntity Stefan => new PersonEntity(_app, new string[]{"person.stefan"});
        public PersonEntity Isa => new PersonEntity(_app, new string[]{"person.isa"});
    }

    public partial class InputDatetimeEntities
    {
        private readonly NetDaemonRxApp _app;
        public InputDatetimeEntities(NetDaemonRxApp app)
        {
            _app = app;
        }

        public InputDatetimeEntity LastLaundryWorkout => new InputDatetimeEntity(_app, new string[]{"input_datetime.last_laundry_workout"});
        public InputDatetimeEntity LastWasherRunning => new InputDatetimeEntity(_app, new string[]{"input_datetime.last_washer_running"});
        public InputDatetimeEntity LastLaundryTowels => new InputDatetimeEntity(_app, new string[]{"input_datetime.last_laundry_towels"});
        public InputDatetimeEntity LastLaundryColor40 => new InputDatetimeEntity(_app, new string[]{"input_datetime.last_laundry_color_40"});
        public InputDatetimeEntity LastLaundryWhites60 => new InputDatetimeEntity(_app, new string[]{"input_datetime.last_laundry_whites_60"});
        public InputDatetimeEntity LastLaundryWhites40 => new InputDatetimeEntity(_app, new string[]{"input_datetime.last_laundry_whites_40"});
        public InputDatetimeEntity LastLaundryBedLinen => new InputDatetimeEntity(_app, new string[]{"input_datetime.last_laundry_bed_linen"});
        public InputDatetimeEntity LastLaundryColor60 => new InputDatetimeEntity(_app, new string[]{"input_datetime.last_laundry_color_60"});
    }

    public partial class ImageProcessingEntities
    {
        private readonly NetDaemonRxApp _app;
        public ImageProcessingEntities(NetDaemonRxApp app)
        {
            _app = app;
        }

        public ImageProcessingEntity DeepstackObjectSnapshotDownstairsLitterbox => new ImageProcessingEntity(_app, new string[]{"image_processing.deepstack_object_snapshot_downstairs_litterbox"});
        public ImageProcessingEntity DeepstackObjectSnapshotUpstairsLitterbox => new ImageProcessingEntity(_app, new string[]{"image_processing.deepstack_object_snapshot_upstairs_litterbox"});
    }

    public partial class ProximityEntities
    {
        private readonly NetDaemonRxApp _app;
        public ProximityEntities(NetDaemonRxApp app)
        {
            _app = app;
        }

        public ProximityEntity HomeIsa => new ProximityEntity(_app, new string[]{"proximity.home_isa"});
        public ProximityEntity HomeStefan => new ProximityEntity(_app, new string[]{"proximity.home_stefan"});
    }
}