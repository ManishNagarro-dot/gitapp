using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace gitapp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                webBuilder.ConfigureAppConfiguration(config =>
                {
                    var settings = config.Build();
                    config.AddAzureAppConfiguration("Endpoint=https://appconfig007.azconfig.io;Id=Iqm2-l0-s0:6qvuHt+GsBOX2QiNBiIT;Secret=csmGADMzwwhRl8BuvZpHcd6e/QZidK0Z9XEmIaW19p4=");
                }).UseStartup<Startup>());
                
    }
}
