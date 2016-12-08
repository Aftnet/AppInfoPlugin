using Foundation;
using Plugin.AppInfo.Abstractions;

namespace Plugin.AppInfo
{
    /// <summary>
    /// Implementation for AppInfo
    /// </summary>
    public class AppInfoImplementation : IAppInfo
    {
        private const string DisplayNameDictionaryKey = "CFBundleDisplayName";
        private const string BundleIdDictionaryKey = "CFBundleIdentifier";
        private const string VersionDictionaryKey = "CFBundleVersion";

        public string DisplayName
        {
            get
            {
                return GetAppInfoDictionaryValue(DisplayNameDictionaryKey);
            }
        }

        public string PackageName
        {
            get
            {
                return GetAppInfoDictionaryValue(BundleIdDictionaryKey);
            }
        }

        public string Version
        {
            get
            {
                return GetAppInfoDictionaryValue(VersionDictionaryKey);
            }
        }

        private string GetAppInfoDictionaryValue(string key)
        {
            var dictionary = NSBundle.MainBundle.InfoDictionary;
            var output = ((NSString)dictionary[key]).ToString();
            return output;
        }
    }
}