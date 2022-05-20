using System;

namespace ClassDemo
{
    class Customer
    {
        string _firstName;
        string _lastName;

       public Customer() : this("No FirstName","No LastName")
        {

        }

       public Customer(string firstName,string lastName)
        {
            this._firstName = firstName;
            this._lastName = lastName;
        }

        public void PrintFullName()
        {
            Console.WriteLine($"Your full name is {_firstName},{_lastName}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Class Demo!!!");

            Customer customer = new Customer();            
            customer.PrintFullName();
        }
    }
}
