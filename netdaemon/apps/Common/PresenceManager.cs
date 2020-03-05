using System;
using System.Threading.Tasks;
using JoySoftware.HomeAssistant.NetDaemon.Common;

/// <summary>
///     App docs
/// </summary>
public static class PresenceManager
{
    public static bool AnyoneHome(this NetDaemonApp app)
    {
        try
        {
            var isa_location = app.GetState("person.isa")?.State?.ToString()?.ToLower();

            var stefan_location = app.GetState("person.stefan")?.State?.ToString()?.ToLower();
            if (isa_location != null || stefan_location != null)
            {
                if (stefan_location == "home" || stefan_location == "just arrived"
                || isa_location == "home" || isa_location == "just arrived")
                {
                    return true;
                }
                else return false;
            }
            // return true if null, assume someone could be home
            app.Log($"A person returned null as location state, assuming someone is home.");
            return true;
        }
        catch (System.Exception e)
        {
            // return true if something goes wrong, assume someone could be home
            app.Log($"Error: {e}");
            return true;
        }
    }
}