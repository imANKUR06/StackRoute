using System;

namespace IntroductionToCsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("What is your name?");
            //string user = Console.ReadLine();
            //Console.WriteLine("Hello " + user);

            //Built in Datatypes
            //bool isValid = true;     

            //int firstnumber = 10;
            //float secondnumber = 123.222F;
            //double thirdnumber = 123456.111d;

            //Console.WriteLine("The max value of an integer is  " + int.MaxValue);
            //Console.WriteLine("The min value of an integer is  " + int.MinValue);
            //Console.WriteLine("Size of an inetger is " + sizeof(int));
            //string userName = "James";

            //Casting demo
            double input = 10.22d;
            int output = (int)input;
            Console.WriteLine(output);
            int output1 = Convert.ToInt32(input);

            Console.WriteLine("Simple calculator addition demo");
            Console.WriteLine("Enter first number ");
            int firstNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number ");
            int secondNumber = Convert.ToInt32(Console.ReadLine());
            int result = firstNumber + secondNumber;
            Console.WriteLine("Result = " + result);
            Console.WriteLine($"The sum of {firstNumber} and {secondNumber} is {firstNumber+secondNumber}");










        }
    }
}
