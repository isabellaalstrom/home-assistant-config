using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using JoySoftware.HomeAssistant.NetDaemon.Common;

/// <summary>
///     App docs
/// </summary>
public static class NotificationManager
{
    public static Dictionary<string, IEnumerable<string>> Data = new Dictionary<string, IEnumerable<string>>();
    public async static void NotifyDiscord(
        this NetDaemonApp app,
        string channel,
        string message,
        bool mention = false)
    {
        await app.CallService("notify", "hass_discord", new
        {
            message = message,
            target = channel
        });
    }
    public async static void NotifyDiscord(
        this NetDaemonApp app,
        string channel,
        string message,
        Dictionary<string, IEnumerable<string>> data,
        bool mention = false)
    {
        await app.CallService("notify", "hass_discord", new
        {
            data = data,
            message = message,
            target = channel
        });
    }
}

public static class DiscordChannel
{
    public static string Camera = "515083002565623820";
    public static string Home = "510398531937501186";
}