using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Reactive.Linq;
using NetDaemon.Common.Reactive;

/// <summary>
///     App docs
/// </summary>
public static class NotificationManager
{
    public static void NotifyIos(
    this NetDaemonRxApp app,
    string title,
    string message,
    string notifier = "",
    bool onlyIfHome = false,
    string threadId = "home-assistant",
    string category = "",
    bool critical = false,
    string imageUrl = "")
    {
        var isHome = app.State("person.isa")?.State?.ToString()?.ToLower() == "home"
            || app.State("person.isa")?.State?.ToString()?.ToLower() == "just arrived";
        if (!onlyIfHome || (onlyIfHome && isHome))
        {
            // object sound = "";
            var contentType = "";
            var hideThumbnail = "";
            var entityId = "";

            if (!string.IsNullOrWhiteSpace(entityId))
            {
                contentType = "jpeg";
                category = "camera";
                hideThumbnail = "";
            }
            // if (critical)
            // {
            //     sound = new Dictionary<string, object>
            //     {
            //         ["name"] = "default",
            //         ["critical"] = 1,
            //         ["volume"] = 1.0
            //     };
            // }

            var data = new Dictionary<string, object>
            {
                ["title"] = title,
                ["message"] = message,
                ["data"] = new Dictionary<string, object>
                {
                    ["attachment"] = new Dictionary<string, object>
                    {
                        ["url"] = imageUrl,
                        ["content-type"] = contentType,
                        ["hide-thumbnail"] = hideThumbnail
                    },
                    ["push"] = new Dictionary<string, object>
                    {
                        ["thread-id"] = threadId,
                        ["badge"] = 0,
                        // ["sound"] = sound,
                        ["category"] = category
                    },
                    ["entity_id"] = entityId
                }
            };
            if (string.IsNullOrWhiteSpace(notifier))
            {
                app.CallService("notify", Isa.IosNotifier, data);
            }
            else
            {
                app.CallService("notify", notifier, data);
            }
        }
    }
    public static void NotifyDiscord(
        this NetDaemonRxApp app,
        string channel,
        string message,
        bool mention = false)
    {
        app.CallService("notify", "hass_discord", new
        {
            message = message,
            target = channel
        });
    }
    public static void NotifyDiscord(
        this NetDaemonRxApp app,
        string channel,
        string message,
        Dictionary<string, IEnumerable<string>> data,
        bool mention = false)
    {
        app.CallService("notify", "hass_discord", new
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
    public static string Alarm = "515083002565623820";
    public static string Krisinfo = "532525430125625345";
    public static string Monitor = "547346452125450240";
    public static string System = "510402538898718728";
    public static string Cats = "665694350373683210";
}
