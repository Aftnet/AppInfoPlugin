using Plugin.AppInfo.Abstractions;
using Windows.ApplicationModel;

namespace Plugin.AppInfo
{
    /// <summary>
    /// Implementation for Feature
    /// </summary>
    public class AppInfoImplementation : IAppInfo
    {
        public string DisplayName
        {
            get
            {
#if(WINDOWS_UWP)
                return Package.Current.DisplayName;
#else
                return Package.Current.Id.Name;
#endif
            }
        }

        public string PackageName
        {
            get
            {
                return Package.Current.Id.Name;
            }
        }

        public string Version
        {
            get
            {
                var ver = Package.Current.Id.Version;
                return string.Format("{0}.{1}.{2}", ver.Major, ver.Minor, ver.Build);
            }
        }
    }
}