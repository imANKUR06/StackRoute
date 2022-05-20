using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceRealUsageDemo
{
    public class FileLogger :IApplicationLogger
    {
        public void LogInformation(string message)
        {
            Console.WriteLine($"File Log Message is : {message}");
        }
    }
}
