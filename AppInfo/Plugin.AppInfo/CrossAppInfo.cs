using Plugin.AppInfo.Abstractions;
using System;

namespace Plugin.AppInfo
{
    /// <summary>
    /// Cross platform AppInfo implemenations
    /// </summary>
    public class CrossAppInfo
    {
        static Lazy<IAppInfo> Implementation = new Lazy<IAppInfo>(() => CreateAppInfo(), System.Threading.LazyThreadSafetyMode.PublicationOnly);

        /// <summary>
        /// Current settings to use
        /// </summary>
        public static IAppInfo Current
        {
            get
            {
                var ret = Implementation.Value;
                if (ret == null)
                {
                    throw NotImplementedInReferenceAssembly();
                }
                return ret;
            }
        }

        static IAppInfo CreateAppInfo()
        {
#if PORTABLE
            return null;
#else
        return new AppInfoImplementation();
#endif
        }

        internal static Exception NotImplementedInReferenceAssembly()
        {
            return new NotImplementedException("This functionality is not implemented in the portable version of this assembly. You should reference the NuGet package from your main application project in order to reference the platform-specific implementation.");
        }
    }
}
