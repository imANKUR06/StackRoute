using System;

namespace DelegatesDemo
{
    //Delegates are pointers to functions.
    
    public delegate void HelloFunctionDelegate(string input);

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Delegates Demo");
            Console.WriteLine("*****************************");
            // Hello("GEP");

            HelloFunctionDelegate helloFunctionDelegate = new HelloFunctionDelegate(Hello);
            //helloFunctionDelegate can point only to functions that has got the similar signature as that HelloFunctionDelegate.
            //helloFunctionDelegate is pointing to the Hello method in line number 20.
            helloFunctionDelegate("GEP");

        }

        static  void Hello(string message)
        {
            Console.WriteLine($"Hello {message}");
        }
    }

    
}
