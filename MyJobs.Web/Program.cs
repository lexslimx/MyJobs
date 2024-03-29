﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace MyJobs.Web
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }
        public static IHostBuilder CreateHostBuilder(string[] args) =>
   Host.CreateDefaultBuilder(args)
           .ConfigureLogging(logging =>
           {
               logging.ClearProviders();
               logging.AddConsole();
           })
       .ConfigureWebHostDefaults(webBuilder =>
       {
           webBuilder.ConfigureKestrel(serverOptions =>
           {
               // Set properties and call methods on options
           })
           .UseStartup<Startup>();
       });
    }
}
