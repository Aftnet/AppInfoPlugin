using Plugin.AppInfo.Abstractions;
using System.Reflection;

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
                return GetAssemblyName().Name;
            }
        }

        public string PackageName
        {
            get
            {
                return GetAssemblyName().FullName;
            }
        }

        public string Version
        {
            get
            {
                var ver = GetAssemblyName().Version;
                return string.Format("{0}.{1}.{2}", ver.Major, ver.Minor, ver.Build);
            }
        }

        private AssemblyName GetAssemblyName()
        {
            var output = Assembly.GetEntryAssembly().GetName();
            return output;
        }
    }
}