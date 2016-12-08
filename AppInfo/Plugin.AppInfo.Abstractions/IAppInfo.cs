namespace Plugin.AppInfo.Abstractions
{
    /// <summary>
    /// Interface for AppInfo
    /// </summary>
    public interface IAppInfo
    {
        string DisplayName { get; }
        string PackageName { get; }
        string Version { get; }
    }
}
