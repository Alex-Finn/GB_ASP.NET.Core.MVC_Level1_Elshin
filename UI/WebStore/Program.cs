﻿using log4net;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Xml;
using WebStore.DAL.Context;
using WebStore.Data;

namespace WebStore
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var log4net_config_xml = new XmlDocument();
            var config_file_name = "log4net.config";
            log4net_config_xml.Load(config_file_name);
            var repository = LogManager.CreateRepository(
                Assembly.GetEntryAssembly(),
                typeof(log4net.Repository.Hierarchy.Hierarchy));

            log4net.Config.XmlConfigurator.Configure(repository, log4net_config_xml["log4net"]);

            log4net.ILog log = log4net.LogManager.GetLogger(typeof(Program));
            log.Info("Запуск приложения...");

            CreateWebHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
            .UseStartup<Startup>();
    }
}
