using Android.App;
using Android.Content.PM;
using Plugin.AppInfo.Abstractions;

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
                var context = Application.Context;
                var applicationInfo = context.ApplicationInfo;
                var stringId = applicationInfo.LabelRes;
                return stringId == 0 ? applicationInfo.NonLocalizedLabel.ToString() : context.GetString(stringId);
            }
        }

        public string PackageName
        {
            get
            {
                return GetPackageInfo().PackageName;
            }
        }

        public string Version
        {
            get
            {
                return GetPackageInfo().VersionName;
            }
        }

        private PackageInfo GetPackageInfo()
        {
            var context = Application.Context;
            var output = context.PackageManager.GetPackageInfo(context.PackageName, 0);
            return output;
        }
    }
}