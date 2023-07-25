using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger
{
    internal interface ILogger
    {
        public void LogInformation(string message);
        public void LogWarning(string message);
        public void LogError(string message);
    }
}
