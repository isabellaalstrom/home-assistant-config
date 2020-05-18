using System;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using JoySoftware.HomeAssistant.NetDaemon.Common;
using System.Collections.Generic;

public class AirCleanerSchedule : NetDaemonApp
{
    #region -- config properties --
    public string? AutoScript { get; set; }
    public string? QuietScript { get; set; }
    public string? TurboScript { get; set; }
    public int? AutoHour { get; set; }
    public int? QuietHour { get; set; }

    #endregion

    public override Task InitializeAsync()
    {
        if (!CheckConfig())
            return Task.CompletedTask;

        Scheduler.RunDaily(
            "11:00:00",
            new List<DayOfWeek>
            {
                DayOfWeek.Monday,
                DayOfWeek.Tuesday,
                DayOfWeek.Wednesday,
                DayOfWeek.Thursday,
                DayOfWeek.Friday
            },
            () => TurnOnAuto());

        Scheduler.RunDaily(
            "21:00:00",
            new List<DayOfWeek>
            {
                DayOfWeek.Monday,
                DayOfWeek.Tuesday,
                DayOfWeek.Wednesday,
                DayOfWeek.Thursday,
                DayOfWeek.Friday
            },
            () => TurnOnQuiet());

        // No async so return completed task
        return Task.CompletedTask;
    }

    private async Task TurnOnAuto()
    {
        await this.NotifyDiscord(DiscordChannel.Home, "Checking presence for turning air cleaner to auto.");
        Log($"Time for auto, checking presence.");
        if (!this.AnyoneHome())
        {
            await CallService("script", "turn_on", new
            {
                entity_id = AutoScript
            });
            Log("Turning on quiet");
        }
        else
        {
            Log("Someone is home, so I won't turn on Auto.");
            await this.NotifyDiscord(DiscordChannel.Home, "Someone is home, so I won't turn air cleaner to auto.");
        }
    }

    private async Task TurnOnQuiet()
    {
        await this.NotifyDiscord(DiscordChannel.Home, "Turning air cleaner to quiet.");
        Log($"Time for quiet.");
        await CallService("script", "turn_on", new
        {
            entity_id = QuietScript
        });
        Log("Turning on quiet");
    }

    private bool CheckConfig()
    {
        if (this.QuietScript == null ||
            this.AutoScript == null ||
            this.TurboScript == null)
            return false;

        return true;
    }
}