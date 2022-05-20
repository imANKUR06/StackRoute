using System;
using System.IO;

namespace ExceptionHandlingDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader streamReader =null;
            try
            {
                try
                {

                    streamReader = new StreamReader(@"D:\Test123.txt");
                    Console.WriteLine(streamReader.ReadToEnd());

                    //string data = "abcd";
                    //int output = Convert.ToInt32(data);
                    int denominator = 5;
                    int numerator = 5;
                    int result = numerator / denominator;
                }

                catch (Exception e)
                {

                    throw new FileNotFoundException("The file does not exist",e);
                }
            }

            catch(Exception e)
            {

                if (e.InnerException != null)
                {
                    Console.WriteLine(e.InnerException.Message);
                }

                Console.WriteLine(e.Message);
            }

            finally
            {
                Console.WriteLine("Inside finally block");
                streamReader.Close();
            }



        }

            
        
    }
}
