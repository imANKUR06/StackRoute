using System;

namespace InterfaceRealUsageDemo
{

    class Logging
    {
        IApplicationLogger logger;
        public Logging(IApplicationLogger applicationLogger)
        {
            logger = applicationLogger;
        }

        public void LogData(string message)
        {
            logger.LogInformation(message);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            IApplicationLogger logger = new DBLogger();
            

            Logging logging = new Logging(logger);

            logging.LogData("Sample test data");
           
        }
    }
}
