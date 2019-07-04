﻿using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Collections.Concurrent;
using System.Text;
using System.Xml;

namespace WebStore.Logger
{
    public class Log4NetLoggerProvider : ILoggerProvider
    {
        private readonly string _configurationFile;
        private readonly ConcurrentDictionary<string,Log4NetLogger> _Loggers 
            = new ConcurrentDictionary<string, Log4NetLogger>();

        public Log4NetLoggerProvider(string configurationFile)
        {
            _configurationFile = configurationFile;
        }

        public ILogger CreateLogger(string categoryName)
        {
            return _Loggers.GetOrAdd(categoryName, category =>
            {
                var xml = new XmlDocument();
                var file_name = _configurationFile;
                xml.Load(file_name);
                return new Log4NetLogger(category, xml["log4net"]);
            });
        }

        public void Dispose()
        {
            _Loggers.Clear();
        }
    }
}
