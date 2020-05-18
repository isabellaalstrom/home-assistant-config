using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using JoySoftware.HomeAssistant.NetDaemon.Common;

/// <summary>
///     App docs
/// </summary>
public class MotionSnapshot : NetDaemonApp
{
    public string? Alarm { get; set; }
    public string? FilePath { get; set; }
    public new IEnumerable<string>? Cameras { get; set; }
    public override Task InitializeAsync()
    {
        InitializeMotionSnapshots();
        return Task.CompletedTask;
    }

    private void InitializeMotionSnapshots()
    {
        if (Alarm != null && Cameras != null && FilePath != null)
        {
            Entity(Alarm).WhenStateChange(to: "triggered").Call(async (entityId, to, from) =>
            {
                var time = DateTime.Now;
                foreach (var camera in Cameras)
                {
                    var dict = new Dictionary<string, IEnumerable<string>>();
                    dict.Add("images", new List<string> { FilePath.Replace("{camera}", camera) });
                    await CallService("camera", "snapshot", new
                    {
                        entity_id = camera,
                        filename = FilePath.Replace("{camera}", camera)
                    });
                    await this.NotifyDiscord(DiscordChannel.Camera, $"{time} - {camera}", dict);
                }
            }).Execute();
        }
    }
}