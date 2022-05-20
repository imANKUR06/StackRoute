using System;

namespace IntParseDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 10;
            Console.WriteLine("Int Parsing!");

            string firstInput = "$";

            if(int.TryParse(firstInput, out int choice))
            {

            }

            

            Console.WriteLine(choice);
            choice = 6;
            Console.WriteLine(choice);
           
            
          
           // int output = int.Parse(firstInput);
        }


       
    }
}
