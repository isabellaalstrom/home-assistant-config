using NetDaemon.Common;

/// <summary>
///     App docs
/// </summary>
public static class NetDaemonExtensions
{
    public static string? ToLowerStateString(this EntityState entityState)
    {
        if(entityState?.State != null)
            return entityState.State.ToString().ToLower();
        else return null;
    }
    public static bool? ToStateBool(this EntityState entityState)
    {
        if(entityState?.State != null)
            if(bool.TryParse(entityState.State, out bool stateBool))
                return stateBool;
            else return null;
        else return null;
    }
}
