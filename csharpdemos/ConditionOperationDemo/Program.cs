using System;

namespace ConditionOperationDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //if/else
            Console.WriteLine("Enter a number");
            int enteredNumber = Convert.ToInt32(Console.ReadLine());

            if(enteredNumber > 100)
            {
                Console.WriteLine("Number is greater than 100");
            }
           
            else
            {
                Console.WriteLine("Number is less than 100");
            }

            int currentDay = 1;

            switch (currentDay)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;

                default:
                    Console.WriteLine("Invalid day");
                    break;
            }

            //Loops

            int x = 10;
            while (x>=0)
            {
                if (x % 2 == 0)
                {
                    Console.WriteLine(x);
                }
                x = x - 1;
            }



            



        }
    }
}
