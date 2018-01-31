using Nancy;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace MSCodeTemplate.Api.Modules
{
    public class DiagnosticsModule : NancyModule
    {
        public DiagnosticsModule()
            : base("api/diagnostics")
        {
            Get["/version", true] = async (_, ct) => await GetVersion();
        }

        private async Task<object> GetVersion()
        {
            System.Reflection.Assembly assembly = System.Reflection.Assembly.GetExecutingAssembly();
            FileVersionInfo fvi = FileVersionInfo.GetVersionInfo(assembly.Location);

            var appInfo = new { version = fvi.FileVersion, servername = System.Environment.MachineName };

            return appInfo;
        }
    }
}