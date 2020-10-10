using System;
using System.Collections.Generic;
using NetDaemon.Common.Reactive;
using System.Reactive.Linq;

/// <summary>
///     Will handle automatic arming and disarming alarm - now only test
/// </summary>
    public class AlarmHandler : NetDaemonRxApp
    {
        public string? Alarm { get; set; }
        public string? AlarmCode { get; set; }
        public string? XiaomiGatewayMac { get; set; }
        public string? CleaningDayCalendar { get; set; }
        public IEnumerable<string>? AlarmLights { get; set; }

        public override void Initialize()
        {
            Entity(Isa.PersonEntity)
            .StateChanges
            .Subscribe(s => CheckPresence());
            Entity(Stefan.PersonEntity)
            .StateChanges
            .Subscribe(s => CheckPresence());
        }

        private void CheckPresence()
        {
            Log(Microsoft.Extensions.Logging.LogLevel.Information,
                "Presence changed, checking to possibly take action with alarm");
            if (this.AnyoneJustArrived())
            {
                this.NotifyDiscord(DiscordChannel.Alarm, "🚻 Someone just got home.");
                Disarm();
            }
            else if (!this.AnyoneHome())
            {
                this.NotifyDiscord(DiscordChannel.Alarm, "🚷 Presence changed, but no one is home.");

                if (State(CleaningDayCalendar!)?.State?.ToString().ToLower() == "on")
                    ArmHome();
                else ArmAway();
            }
        }

        private void Disarm()
        {
            this.NotifyDiscord(DiscordChannel.Alarm, "NetDaemon would disarm");
            if (State(Alarm!)?.State?.ToString().ToLower() != AlarmState.ArmedHome)
            {

            }
        }

        private void ArmHome()
        {
            this.NotifyDiscord(DiscordChannel.Alarm, "NetDaemon would arm home");
        }

        private void ArmAway()
        {
            this.NotifyDiscord(DiscordChannel.Alarm, "NetDaemon would arm away");
        }
    }

    public static class AlarmState
    {
        public static string ArmedHome = "armed_home";
        public static string ArmedAway = "armed_away";
        public static string Disarmed = "disarmed";
        public static string ArmedPerimeter = "armed_night";

    }