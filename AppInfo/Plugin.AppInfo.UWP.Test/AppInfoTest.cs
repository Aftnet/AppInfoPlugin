using Plugin.AppInfo.Abstractions;

namespace Plugin.AppInfo.UWP.Test
{
    public class AppInfoTest : TestBase.TestBase
    {
        protected override IAppInfo GetTargetInstance()
        {
            return CrossAppInfo.Current;
        }

        public AppInfoTest() : base("AppInfo Plugin Test", "b625c3df-2810-4ae3-b366-9d2264e6a783", "1.2.3")
        {

        }
    }
}
