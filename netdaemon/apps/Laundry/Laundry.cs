using System;
using NetDaemon.Common;
using NetDaemon.Common.Reactive;
using System.Reactive.Linq;

/// <summary>
///     Handles laundry, both washer and dryer. Notifications handled with alerts. Todo - set light state
/// </summary>

public class Laundry : NetDaemonRxApp
{
    public string? PowerSensor { get; set; }
    public string? InputSelect { get; set; }
    public string? HatchSensor { get; set; }
    public string? Light { get; set; }
    public string? Type { get; set; }

    private string? _Emoji;
    private EntityState? _LightState;

    public override void Initialize()
    {
        _Emoji = Type! == "Washer" ? "🧼" : "🧺";

        Entity(PowerSensor!)
        .StateChanges
        .Where(
            e => e.New?.ToStateBool() == true)
        .NDSameStateFor(TimeSpan.FromSeconds(90))
        .Subscribe(s => Running());

        Entity(PowerSensor!)
        .StateChanges
        .Where(
            e => e.New?.ToStateBool() == false)
        .NDSameStateFor(TimeSpan.FromSeconds(270))
        .Subscribe(s => Clean());

        Entity(HatchSensor!)
        .StateChanges
        .Where(
            e => e.New?.State == "on")
        .Subscribe(s => Emptied());
    }
    private void Running()
    {
        CallService("input_select", "select_option",
            new { entity_id = InputSelect, option = "Running" });

        this.NotifyDiscord(DiscordChannel.Home,
            $"{_Emoji} {Type!} running.");
    }
    private void Clean()
    {
        if (State(InputSelect!)?.ToLowerStateString() == "running")
        {
            CallService("input_select", "select_option",
                new { entity_id = InputSelect, option = "Clean" });
            this.NotifyDiscord(DiscordChannel.Home,
                $"{_Emoji} {Type!} clean.");

            // todo - If Isa home, get current light state, set light to color
        }
    }

    private void Emptied()
    {
        if (State(InputSelect!)?.ToLowerStateString() == "clean")
        {
            CallService("input_select", "select_option",
                new { entity_id = InputSelect, option = "Idle" });
            this.NotifyDiscord(DiscordChannel.Home,
                $"{_Emoji} {Type!} idle.");
            // todo - restore light state
        }
    }
}