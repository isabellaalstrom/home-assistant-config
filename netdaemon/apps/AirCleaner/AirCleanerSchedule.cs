using System;
using System.Reactive.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using NetDaemon.Common.Reactive;
using System.Collections.Generic;

/// <summary>
///     Handles schedule for Air cleaner in bedroom
/// </summary>

public class AirCleanerSchedule : NetDaemonRxApp
{
    #region -- config properties --
    public string? AutoScript { get; set; }
    public string? QuietScript { get; set; }
    public string? TurboScript { get; set; }
    public int? AutoHour { get; set; }
    public int? QuietHour { get; set; }

    #endregion

    public override void Initialize()
    {
        var weekDays = new List<DayOfWeek>
            {
                DayOfWeek.Monday,
                DayOfWeek.Tuesday,
                DayOfWeek.Wednesday,
                DayOfWeek.Thursday,
                DayOfWeek.Friday
            };
        RunDaily("11:00:00", ()=>
        {
            if (weekDays.Contains(DateTime.Now.DayOfWeek))
            {
                 TurnOnAuto();
            }
        });
        RunDaily("21:00:00", ()=>
        {
            if (weekDays.Contains(DateTime.Now.DayOfWeek))
            {
                 TurnOnQuiet();
            }
        });

    }

    private void TurnOnAuto()
    {
        this.NotifyDiscord(DiscordChannel.Home, "Checking presence for turning air cleaner to auto.");
        Log($"Time for auto, checking presence.");
        if (!this.AnyoneHome())
        {
            CallService("script", "turn_on", new
            {
                entity_id = AutoScript
            });
            Log("Turning on quiet");
        }
        else
        {
            Log("Someone is home, so I won't turn on Auto.");
            this.NotifyDiscord(DiscordChannel.Home, "Someone is home, so I won't turn air cleaner to auto.");
        }
    }

    private void TurnOnQuiet()
    {
        this.NotifyDiscord(DiscordChannel.Home, "Turning air cleaner to quiet.");
        Log($"Time for quiet.");
        CallService("script", "turn_on", new
        {
            entity_id = QuietScript
        });
        Log("Turning on quiet");
    }
}