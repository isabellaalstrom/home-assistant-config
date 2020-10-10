using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using NetDaemon.Common.Reactive;
using System.Reactive.Linq;

public class MotionSnapshot : NetDaemonRxApp
{
    public string? Alarm { get; set; }
    public string? FilePath { get; set; }
    public IEnumerable<string>? Cameras { get; set; }
    public override void Initialize()
    {
        InitializeMotionSnapshots();
    }

    private void InitializeMotionSnapshots()
    {
        if (Alarm != null && Cameras != null && FilePath != null)
        {
            Entity(Alarm)
            .StateChanges
            .Where(
                e => e.New?.State?.ToString().ToLower() == "triggered")
            .Subscribe(s => 
            {
                var time = DateTime.Now;
                foreach (var camera in Cameras)
                {
                    var dict = new Dictionary<string, IEnumerable<string>>();
                    dict.Add("images", new List<string> { FilePath.Replace("{camera}", camera) });
                    CallService("camera", "snapshot", new
                    {
                        entity_id = camera,
                        filename = FilePath.Replace("{camera}", camera)
                    });
                    this.NotifyDiscord(DiscordChannel.Camera, $"{time} - {camera}", dict);
                }
            });
        }
    }
}