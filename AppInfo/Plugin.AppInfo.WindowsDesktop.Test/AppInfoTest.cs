using Plugin.AppInfo.Abstractions;
using System;
using System.Reflection;

namespace Plugin.AppInfo.WindowsDesktop.Test
{
    public class AppInfoTest : TestBase.TestBase
    {
        protected override IAppInfo GetTargetInstance()
        {
            return CrossAppInfo.Current;
        }

        public AppInfoTest() : base("Plugin.AppInfo.WindowsDesktop.Test", "Plugin.AppInfo.WindowsDesktop.Test, Version=1.2.3.4, Culture=neutral, PublicKeyToken=null", "1.2.3")
        {
            var assembly = Assembly.GetAssembly(typeof(AppInfoTest));
            SetEntryAssembly(assembly);
        }

        /// <summary>
        /// Allows setting the Entry Assembly when needed. 
        /// Use AssemblyUtilities.SetEntryAssembly() as first line in XNA ad hoc tests
        /// </summary>
        /// <param name="assembly">Assembly to set as entry assembly</param>
        public static void SetEntryAssembly(Assembly assembly)
        {
            AppDomainManager manager = new AppDomainManager();
            FieldInfo entryAssemblyfield = manager.GetType().GetField("m_entryAssembly", BindingFlags.Instance | BindingFlags.NonPublic);
            entryAssemblyfield.SetValue(manager, assembly);

            AppDomain domain = AppDomain.CurrentDomain;
            FieldInfo domainManagerField = domain.GetType().GetField("_domainManager", BindingFlags.Instance | BindingFlags.NonPublic);
            domainManagerField.SetValue(domain, manager);
        }
    }
}
