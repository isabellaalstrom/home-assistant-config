using System;
using System.Threading.Tasks;
using JoySoftware.HomeAssistant.NetDaemon.Common;

/// <summary>
///     App docs
/// </summary>
public class Vacuum : NetDaemonApp
{
    private string Roborock = "vacuum.roborock";
    private string Roomba = "vacuum.roomba";
    private string DownstairsScheduler = "input_boolean.vacuum_downstairs_scheduled";
    private string UpstairsScheduler = "input_boolean.vacuum_upstairs_scheduled";

    public override Task InitializeAsync()
    {

        Scheduler.RunDaily(
            "06:45:00", () => AskToSchedule());

        Entity(Isa.PersonEntity)
            .WhenStateChange((n, o) =>
            o?.State?.ToString().ToLower() == "just left")
            .Call(VacuumOnSchedule).Execute();
        Entity(Stefan.PersonEntity)
            .WhenStateChange((n, o) =>
            o?.State?.ToString().ToLower() == "just left")
            .Call(VacuumOnSchedule).Execute();

        Event(IosEvent.EventType).Call((eventType, eventData) => ScheduleCleaning(eventData)).Execute();


        return Task.CompletedTask;
    }

    private async Task AskToSchedule()
    {
        if(GetState("calendar.cleaning_day")?.State?.ToString()?.ToLower() == "off")
        {
            await this.NotifyIos("🧹", "Where do you want to vacuum today?", "", false, "vacuum", "vacuum");
            await this.NotifyDiscord(DiscordChannel.Home, "🧹 Asking about scheduling vacuuming today.");
        }
        else {
            await this.NotifyDiscord(DiscordChannel.Home, "🧹 No robot vacuuming today - it's cleaning day.");
        }
    }

    private async Task ScheduleCleaning(dynamic? eventData)
    {
        if (eventData != null)
        {
            switch (eventData.actionName)
            {
                case (IosEvent.VACUUM_UPSTAIRS):
                    await Entity(UpstairsScheduler).TurnOn().ExecuteAsync();
                    await Entity(DownstairsScheduler).TurnOff().ExecuteAsync();
                    await this.NotifyDiscord(DiscordChannel.Home, "🧹 Scheduling vacuuming upstairs.");
                    break;
                case (IosEvent.VACUUM_DOWNSTAIRS):
                    await Entity(DownstairsScheduler).TurnOn().ExecuteAsync();
                    await Entity(UpstairsScheduler).TurnOff().ExecuteAsync();
                    await this.NotifyDiscord(DiscordChannel.Home, "🧹 Scheduling vacuuming downstairs.");
                    break;
                case (IosEvent.VACUUM_BOTH):
                    await Entity(UpstairsScheduler).TurnOn().ExecuteAsync();
                    await Entity(DownstairsScheduler).TurnOn().ExecuteAsync();
                    await this.NotifyDiscord(DiscordChannel.Home, "🧹 Scheduling vacuuming downstairs and upstairs.");
                    break;
                case (IosEvent.VACUUM_STOP_ASKING):
                    await Entity(UpstairsScheduler).TurnOff().ExecuteAsync();
                    await Entity(DownstairsScheduler).TurnOff().ExecuteAsync();
                    await this.NotifyDiscord(DiscordChannel.Home, "🧹 No scheduled vacuuming today.");
                    break;
                default:
                    break;
            }
        }
    }

    private async Task VacuumOnSchedule(string entityId, EntityState? newState, EntityState? oldState)
    {
        if (!this.AnyoneHome())
        {
            if(GetState(DownstairsScheduler)?.State?.ToString()?.ToLower() == "on")
            {
                await CallService("vacuum", "start", new
                {
                    entity_id = Roborock
                });
                await this.NotifyDiscord(DiscordChannel.Home, "🧹 Starting vacuum downstairs.");
            }
            if(GetState(UpstairsScheduler)?.State?.ToString()?.ToLower() == "on")
            {
                await CallService("vacuum", "start", new
                {
                    entity_id = Roomba
                });
                await this.NotifyDiscord(DiscordChannel.Home, "🧹 Starting vacuum upstairs.");
            }
            await Entity(UpstairsScheduler).TurnOff().ExecuteAsync();
            await Entity(DownstairsScheduler).TurnOff().ExecuteAsync();
        }
    }
}