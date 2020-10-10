
using System;
using System.Threading.Tasks;
using System.Reactive.Linq;
using NetDaemon.Common.Reactive;

/// <summary>
///     Handle turning off some features on cleaning day,
///     also turns on all lights and tries to figure out when cleaning is done.
/// </summary>

public class CleaningMode : NetDaemonRxApp
{
    public int MinutesSinceDoorOpened { get; set; }
    public override void Initialize()
    {
        Entity("sensor.unlocked_by")
        .StateChanges
        .Where(
            e => e.New?.State == "Cleaners"
        )
        .Subscribe(s => CleanersArrive());

        Entity("sensor.front_door")
        .StateChanges
        .Where(
            e => e.New?.State == "Open"
        )
        .Subscribe(s => DoorOpened());
    }

    private void DoorOpened()
    {
        this.NotifyDiscord(DiscordChannel.Home, "Front door opened, checking time.");
    
        var doorTime = State("sensor.front_door")?.LastUpdated;
        if (doorTime.HasValue)
        {
            this.NotifyDiscord(DiscordChannel.Home, $"Front door opened at {doorTime.Value}.");
            RunIn(new TimeSpan(0, 10, 0), () => CheckMotion(doorTime.Value));
            // Scheduler.RunIn(new TimeSpan(0, 5, 0), async () => await CheckMotion(doorTime.Value));
        }
    }

    private void CheckMotion(DateTime doorTime)
    {
        if (!this.AnyoneHome())
        {
            this.NotifyDiscord(DiscordChannel.Home, $"No one seems to be home, checking motion sensors.");
            var motionTime = State("sensor.house_motion")?.LastUpdated;
            if (motionTime.HasValue)
            {
                var utcMotionTime = motionTime.Value.ToUniversalTime();
                var utcDoorTime = doorTime.ToUniversalTime();
                if (utcMotionTime < utcDoorTime || (int)((utcMotionTime - utcDoorTime).TotalSeconds) < 60)
                {
                    this.NotifyDiscord(DiscordChannel.Home, $"No one should be in the house. Last motion was at {motionTime.Value} and last door opening was at {doorTime}");
                    this.NotifyIos("🚪 Door opened 5 mins ago", $"No one should be in the house. Last motion was at {motionTime.Value} and last door opening was at {doorTime}");
                    // script for cleaner leaving, turn off lights
                    // await CallService("script", "1587037128688");
                    // RunScript("1587037128688");
                }
                else
                    this.NotifyDiscord(DiscordChannel.Home, $"Someone seems to still be in the house. Last door opening was at {doorTime} and last motion was at {motionTime.Value}.");
                    this.NotifyIos("🚪 Door opened 5 mins ago", $"Someone seems to still be in the house. Last door opening was at {doorTime} and last motion was at {motionTime.Value}");
            }
        }
        else
            this.NotifyDiscord(DiscordChannel.Home, $"Someone is still home.");

        return;
    }


    private void CleanersArrive()
    {
        if (State("calendar.cleaning_day")?.State?.ToString() == "on")
        {
            if (!this.AnyoneHome())
                //script cleaner arriving, turn on lights
                // CallService("script", "1587035537523");
                RunScript("1587035537523");

            CallService("input_boolean", "turn_on", new
            {
                entity_id = "input_boolean.ec_lights_on_ring_control"
            });
            CallService("input_boolean", "turn_off", new
            {
                entity_id = "input_boolean.ad_litterboxes"
            });
            this.NotifyIos("Cleaning time!", "Cleaner has arrived");
        }
    }
}