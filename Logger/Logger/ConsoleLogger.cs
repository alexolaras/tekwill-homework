using System;
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
            Console.WriteLine($"{message} was saved using console logger");
        }
        public void LogWarning(string message)
        {
            Console.WriteLine($"{message} warning with console logger");
        }
        public void LogError(string message)
        {
            Console.WriteLine($"{message} error with console logger");
        }
    }
}
