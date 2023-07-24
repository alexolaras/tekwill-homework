using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Logger
{
    internal class FileLogger : ILogger
    {
        private string filePath;

        public FileLogger(string filePath)
        {
            this.filePath = filePath;
        }

        public void LogInformation(string message)
        {
            LogMessage($"{message} info with file logger");
        }
        public void LogWarning(string message)
        {
            LogMessage($"{message} warning with file logger");
        }
        public void LogError(string message)
        {
            LogMessage($"{message} error with file logger");
        }
        private void LogMessage(string message)
        {
            try
            {
                string logEntry = $"{DateTime.Now:yyyy-MM-dd HH:mm:ss} {message}";

                using (StreamWriter writer = new StreamWriter(filePath, true))
                {
                    writer.WriteLine(logEntry);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Failed to log message: {ex.Message}");
            }
        }
    }
}

