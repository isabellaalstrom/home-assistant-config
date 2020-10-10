using System;
using System.Threading.Tasks;
using NetDaemon.Common.Reactive;
using System.Reactive.Linq;
using Netdaemon.Generated.Reactive;
using System.Dynamic;
/// <summary>
///     Handles scheduling of robot vacuuming. Going to the kitchen bin when full is handled in regular automation.
/// </summary>

public class Vacuum : GeneratedAppBase
{
    public override void Initialize()
    {
        RunDaily(
            "06:45:00", () => AskToSchedule());
        RunDaily(
            "10:00:00", () => AskToVacuum());
        RunDaily(
            "14:00:00", () => AskToVacuum());

        Entity(Isa.PersonEntity)
        .StateChanges
        .Where(
            e => e.New?.State?.ToString().ToLower() == "just left")
        .Subscribe(s => VacuumOnSchedule());

        Entity(Stefan.PersonEntity)
        .StateChanges
        .Where(
            e => e.New?.State?.ToString().ToLower() == "just left")
        .Subscribe(s => VacuumOnSchedule());

        Entity(Stefan.PersonEntity)
        .StateChanges
        .Where(
            e => e.New?.State?.ToString().ToLower() == "just arrived")
        .Subscribe(s => DockVacuum());

        EventChanges
        .Where(e => e.Event == IosEvent.EventType)
        .Subscribe(s =>
        {
            ScheduleCleaning(s.Data);
        });
    }

    private void AskToSchedule()
    {
        if (Calendar.CleaningDay.State == "off" && InputBoolean.WorkingFromHome.State == "off")
        {
            this.NotifyIos("🧹", "Do you want to vacuum today?", "", false, "vacuum", "vacuum");
            this.NotifyDiscord(DiscordChannel.Home, "🧹 Asking about scheduling vacuuming today.");
        }
        else if (Calendar.CleaningDay.State == "off" && InputBoolean.WorkingFromHome.State == "on")
        {
            this.NotifyIos("🧹", "Do you want to vacuum today?", "", false, "vacuum", "vacuum");
            this.NotifyDiscord(DiscordChannel.Home, "🧹 Asking about scheduling vacuuming today and also will ask later.");
        }
        else if (Calendar.CleaningDay.State == "on")
        {
            InputBoolean.VacuumDownstairsScheduled.TurnOff();
            InputBoolean.VacuumWhenHomeScheduled.TurnOff();
            this.NotifyDiscord(DiscordChannel.Home, "🧹 No robot vacuuming today - it's cleaning day.");
        }
    }
    private void AskToVacuum()
    {
        if (InputBoolean.VacuumWhenHomeScheduled.State == "on")
        {
            this.NotifyIos("🧹", "Do you want to vacuum now?", "", false, threadId: "vacuum", category: "vacuum_now");
            this.NotifyDiscord(DiscordChannel.Home, "🧹 Asking about vacuuming now.");
        }
    }

    private void ScheduleCleaning(dynamic? eventData)
    {
        if (eventData != null)
        {
            switch (eventData.actionName)
            {
                case (IosEvent.VACUUM):
                    InputBoolean.VacuumDownstairsScheduled.TurnOn();
                    this.NotifyDiscord(DiscordChannel.Home, "🧹 Scheduling vacuuming for when no one is home.");
                    break;
                case (IosEvent.VACUUM_ASK):
                    InputBoolean.VacuumDownstairsScheduled.TurnOn();
                    InputBoolean.VacuumWhenHomeScheduled.TurnOn();
                    this.NotifyDiscord(DiscordChannel.Home, "🧹 Asking about scheduling vacuuming today and also will ask later.");
                    break;
                case (IosEvent.VACUUM_STOP_ASKING):
                    InputBoolean.VacuumDownstairsScheduled.TurnOff();
                    this.NotifyDiscord(DiscordChannel.Home, "🧹 No vacuuming today.");
                    break;
                case (IosEvent.VACUUM_NOW):
                    InputBoolean.VacuumDownstairsScheduled.TurnOff();
                    InputBoolean.VacuumWhenHomeScheduled.TurnOff();
                    Vacuum.Rockrobo.Start();
                    this.NotifyDiscord(DiscordChannel.Home, "🧹 Vacuuming!");
                    break;
                case (IosEvent.VACUUM_NO):
                    InputBoolean.VacuumDownstairsScheduled.TurnOff();
                    InputBoolean.VacuumWhenHomeScheduled.TurnOff();
                    this.NotifyDiscord(DiscordChannel.Home, "🧹 No vacuuming today.");
                    break;
                default:
                    break;
            }
        }
    }

    private void VacuumOnSchedule()
    {
        if (!this.AnyoneHome())
        {
            if (InputBoolean.VacuumDownstairsScheduled.State == "on")
            {
                Vacuum.Rockrobo.Start();
                this.NotifyDiscord(DiscordChannel.Home, "🧹 Starting vacuuming.");
            }
            InputBoolean.VacuumDownstairsScheduled.TurnOff();
        }
    }

    private void DockVacuum()
    {
        if (Vacuum.Rockrobo.State == "cleaning")
        {
            Vacuum.Rockrobo.ReturnToBase();
            this.NotifyDiscord(DiscordChannel.Home, "🧹 Docking vacuum since Stefan got home.");
        }
        InputBoolean.VacuumDownstairsScheduled.TurnOff();
    }
}