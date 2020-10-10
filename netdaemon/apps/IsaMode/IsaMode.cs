using System;
using System.Threading.Tasks;
using System.Reactive.Linq;
using NetDaemon.Common.Reactive;

public class IsaMode : NetDaemonRxApp
{
    private string IsaHomeEntity = "input_boolean.isa_mode";
    public override void Initialize()
    {
        Entity(Isa.PersonEntity)
        .StateChanges
        .Where(
            e => e.New?.State?.ToString().ToLower() == "just arrived"
            || e.New?.State?.ToString().ToLower() == "home")
        .Subscribe(s => CheckPresenceStatus());

        Entity(Stefan.PersonEntity)
        .StateChanges
        .Where(
            e => e.New?.State?.ToString().ToLower() == "just left"
            || e.New?.State?.ToString().ToLower() == "away")
        .Subscribe(s => CheckPresenceStatus());
    }

    private void CheckPresenceStatus()
    {
        Log("Checking presence for Isa mode!");
        if (!this.StefanHome() && this.IsaHome())
        {
            Log("Isa is home and Stefan is not");
            var isa_mode = State(IsaHomeEntity);
            if (isa_mode?.State == "off")
            {
                Log("Ask about home alone");
                this.NotifyIos("👧🏻 Home alone!", "Turn on mode?", "", false, "isa-mode", "isa_mode");

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
