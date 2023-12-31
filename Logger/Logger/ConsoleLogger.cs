﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger
{
    internal class ConsoleLogger : ILogger
    {
        public void LogInformation(string message)
        {
            Console.WriteLine($"Log level - Information. {message}");
        }
        public void LogWarning(string message)
        {
            Console.WriteLine($"Log level - Warninig. {message}");
        }
        public void LogError(string message)
        {
            Console.WriteLine($"Log level - Error. {message}");
        }
    }
}
