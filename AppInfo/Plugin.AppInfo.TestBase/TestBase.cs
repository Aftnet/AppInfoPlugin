using Plugin.AppInfo.Abstractions;
using Xunit;

namespace Plugin.AppInfo.TestBase
{
    public abstract class TestBase
    {
        protected abstract IAppInfo GetTargetInstance();

        protected readonly IAppInfo Target;

        protected readonly string ExpectedDisplayName;
        protected readonly string ExpectedPackageName;
        protected readonly string ExpectedVersion;

        public TestBase(string expectedDisplayName, string expectedPackageName, string expectedVersion)
        {
            Target = GetTargetInstance();

            ExpectedDisplayName = expectedDisplayName;
            ExpectedPackageName = expectedPackageName;
            ExpectedVersion = expectedVersion;
        }

        [Fact]
        public void DisplayNameWorks()
        {
            Assert.Equal(ExpectedDisplayName, Target.DisplayName);
        }

        [Fact]
        public void PackageNameWorks()
        {
            Assert.Equal(ExpectedPackageName, Target.PackageName);
        }

        [Fact]
        public void VersionWorks()
        {
            Assert.Equal(ExpectedVersion, Target.Version);
        }
    }
}
