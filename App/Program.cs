using System.Diagnostics;
using System.IO;
using System.Linq;
using System.ServiceProcess;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Hosting.WindowsServices;

namespace App
{
    class Program
    {
        static async Task Main(string[] args)
        {
            isService = !(Debugger.IsAttached || args.Contains("--console"));
            IWebHost host = CreateWebHostBuilder(args).Build();

            if (isService)
            {
                var hostService = new WebHostService(host);
                ServiceBase.Run(hostService);
            }
            else
            {
                await host.RunAsync();
            }
        }

        private static string pathToContentRoot;
        private static bool isService;

        public static string PathToContentRoot
        {
            get
            {
                if (pathToContentRoot != null)
                {
                    return pathToContentRoot;
                }

                pathToContentRoot = Directory.GetCurrentDirectory();
                if (isService)
                {
                    var pathToExe = Process.GetCurrentProcess().MainModule.FileName;
                    pathToContentRoot = Path.GetDirectoryName(pathToExe);
                }

                return pathToContentRoot;
            }
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseContentRoot(PathToContentRoot)
                .UseStartup<Startup>();
    }
}