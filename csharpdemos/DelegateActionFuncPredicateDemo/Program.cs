using System;

namespace DelegateActionFuncPredicateDemo
{
    delegate void PrintDelegate();
    class Program
    {
        static void Main(string[] args)
        {
            // Old way of calling Delegate

            PrintDelegate printDelegate = new PrintDelegate(DisplayMessage);
            printDelegate();

            //New way of calling delegate using Action delegate

            //Return type of an Action delegate is always void.
            // Action delegate example without any parameters
            Action displayAction = DisplayMessage;
            displayAction();

            Action<string> displayMessageAction = PrintMessage;
            displayMessageAction("Test input");

            Action<int, int> additionDelegate = Addition;
            additionDelegate(5,5);

            Action<int, int, int> adding3NumberDelegate = Addition;
            adding3NumberDelegate(5, 5, 5);

            //**************************************************************************

            //Func Delegate
            // Func delegate has a return type and it takes different arguments as inputs.
            //The last parameter represents the output data type in a func delegate.

            Func<int, int, int> funcAddition = Sum;
            int result = funcAddition(5, 5);

            //Predicate Delegate
            // The return type of predicate delegate is always a boolean.

            Predicate<string> predicateDelegate = IsValid;
            predicateDelegate("Test123");

            Func<string, bool> funcDemodelegate = IsValid;
            funcDemodelegate("Test123");

        }

        static void DisplayMessage()
        {
            Console.WriteLine("Inside display message");
        }

        static void PrintMessage(string message)
        {
            Console.WriteLine(message);
        }

        static void Addition(int firstNumber,int secondNumber )
        {
            Console.WriteLine($"Result is {firstNumber + secondNumber}");
        }

        static void Addition(int firstNumber, int secondNumber,int thirdNumber)
        {
            Console.WriteLine($"Result is {firstNumber + secondNumber}");
        }

        static int Sum(int firstNumber, int secondNumber)
        {
            return firstNumber + secondNumber;
        }

        static bool IsValid(string message)
        {
            if (!string.IsNullOrEmpty(message))
            {
                return true;
            }

            return false;
        }
    }
}
