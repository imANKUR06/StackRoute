using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceRealUsageDemo
{
    public class DBLogger :IApplicationLogger
    {
        public void LogInformation(string message)
        {
            Console.WriteLine($"DB Log Message is : {message}");
        }
    }
}
