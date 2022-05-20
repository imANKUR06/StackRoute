using System;

namespace InterfaceDemo
{
    interface ICustomer
    {
        void Print();
        void Print(string message);
    }

    interface ICorporateCustomer
    {
        void log(string message);
    }

    class Customer : ICustomer,ICorporateCustomer
    {
        public void log(string message)
        {
            Console.WriteLine(message);
        }

        public  void Print()
        {
            Console.WriteLine("Inside Print");
        }

        public void Print(string message)
        {
            Console.WriteLine(message);
        }
    }

   
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();
            customer.Print();
            // ICustomer iCustomer = new ICustomer();

            ICorporateCustomer customer1 = new Customer();
            customer1.log("Test");
           

            
           


        }
    }
}
