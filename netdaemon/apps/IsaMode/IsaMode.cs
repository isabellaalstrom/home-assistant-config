using System;
using System.Threading.Tasks;
using JoySoftware.HomeAssistant.NetDaemon.Common;

/// <summary>
///     App docs
/// </summary>
public class IsaMode : NetDaemonApp
{
    private string IsaHomeEntity = "input_boolean.isa_mode";
    public override Task InitializeAsync()
    {
        Entity(Isa.PersonEntity)
            .WhenStateChange((n, o) =>
            n?.State?.ToString().ToLower() == "just arrived"
            || n?.State?.ToString().ToLower() == "home")
            .Call(CheckPresenceStatus).Execute();
        Entity(Stefan.PersonEntity)
            .WhenStateChange((n, o) =>
            n?.State?.ToString().ToLower() == "just left"
            || n?.State?.ToString().ToLower() == "away")
            .Call(CheckPresenceStatus).Execute();

        return Task.CompletedTask;
    }
    private async Task CheckPresenceStatus(string entityId, EntityState? newState, EntityState? oldState)
    {
        Log("Checking presence for Isa mode!");
        if (!this.StefanHome() && this.IsaHome())
        {
            Log("Isa is home and Stefan is not");
            var isa_mode = GetState(IsaHomeEntity);
            if (isa_mode?.State == "off")
            {
                Log("Ask about home alone");
                await this.NotifyIos("👧🏻 Home alone!", "Turn on mode?", "", false, "isa-mode", "isa_mode");

                // await CallService("input_boolean", "turn_on", new
                // {
                //     entity_id = IsaHomeEntity
                // });
            }
            else
                Log("Isa mode already on");
        }
    }
}
