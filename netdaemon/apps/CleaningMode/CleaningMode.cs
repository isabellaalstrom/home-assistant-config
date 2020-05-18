
using System;
using System.Threading.Tasks;
using JoySoftware.HomeAssistant.NetDaemon.Common;

/// <summary>
///     App docs
/// </summary>
public class CleaningMode : NetDaemonApp
{
    public int MinutesSinceDoorOpened { get; set; }
    public override Task InitializeAsync()
    {
        Entity("sensor.unlocked_by").WhenStateChange(to: "Cleaners").Call(async (entityId, to, from) => await CleanersArrive(entityId, to, from)).Execute();

        Entity("sensor.front_door").WhenStateChange(to: "Open").Call(async (entityId, to, from) => await DoorOpened(entityId, to, from)).Execute();
        return Task.CompletedTask;
    }

    private async Task DoorOpened(string entityId, EntityState? to, EntityState? from)
    {
        await this.NotifyDiscord(DiscordChannel.Home, "Front door opened, checking time.");
    
        var doorTime = GetState("sensor.front_door")?.LastUpdated;
        if (doorTime.HasValue)
        {
            await this.NotifyDiscord(DiscordChannel.Home, $"Front door opened at {doorTime.Value}.");
            Scheduler.RunIn(new TimeSpan(0, 10, 0), async () => await CheckMotion(doorTime.Value));
            // Scheduler.RunIn(new TimeSpan(0, 5, 0), async () => await CheckMotion(doorTime.Value));
        }
    }

    private async Task CheckMotion(DateTime doorTime)
    {
        if (!this.AnyoneHome())
        {
            await this.NotifyDiscord(DiscordChannel.Home, $"No one seems to be home, checking motion sensors.");
            var motionTime = GetState("sensor.house_motion")?.LastUpdated;
            if (motionTime.HasValue)
            {
                var utcMotionTime = motionTime.Value.ToUniversalTime();
                var utcDoorTime = doorTime.ToUniversalTime();
                if (utcMotionTime < utcDoorTime || (int)((utcMotionTime - utcDoorTime).TotalSeconds) < 60)
                {
                    await this.NotifyDiscord(DiscordChannel.Home, $"No one should be in the house. Last motion was at {motionTime.Value} and last door opening was at {doorTime}");
                    await this.NotifyIos("🚪 Door opened 5 mins ago", $"No one should be in the house. Last motion was at {motionTime.Value} and last door opening was at {doorTime}");
                    // script for cleaner leaving, turn off lights
                    // await CallService("script", "1587037128688");
                }
                else
                    await this.NotifyDiscord(DiscordChannel.Home, $"Someone seems to still be in the house. Last door opening was at {doorTime} and last motion was at {motionTime.Value}.");
                    await this.NotifyIos("🚪 Door opened 5 mins ago", $"Someone seems to still be in the house. Last door opening was at {doorTime} and last motion was at {motionTime.Value}");
            }
        }
        else
            await this.NotifyDiscord(DiscordChannel.Home, $"Someone is still home.");

        return;
    }

    private async Task CleanersArrive(string entityId, EntityState? to, EntityState? from)
    {
        if (GetState("calendar.cleaning_day")?.State?.ToString() == "on")
        {
            if (!this.AnyoneHome())
                //script cleaner arriving, turn on lights
                await CallService("script", "1587035537523");

            await CallService("input_boolean", "turn_on", new
            {
                entity_id = "input_boolean.ec_lights_on_ring_control"
            });
            await CallService("input_boolean", "turn_off", new
            {
                entity_id = "input_boolean.ad_litterboxes"
            });
            await this.NotifyIos("Cleaning time!", "Cleaner has arrived");
        }
    }
}