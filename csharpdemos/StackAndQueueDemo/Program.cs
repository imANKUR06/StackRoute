using System;
using System.Collections.Generic;

namespace StackAndQueueDemo
{
    class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer { Id = 1, Name = "James", Salary = 5000 };
            Customer customer2 = new Customer { Id = 2, Name = "Tina", Salary = 8000 };
            Customer customer3 = new Customer { Id = 3, Name = "Tresa", Salary = 8000 };

            Stack<Customer> stackCustomers = new Stack<Customer>();
            stackCustomers.Push(customer1);
            stackCustomers.Push(customer2);
            stackCustomers.Push(customer3);

            //Take the data from the stack

            Customer c3 = stackCustomers.Pop();
            Console.WriteLine($"{c3.Id}-{c3.Name}");
            Console.WriteLine(stackCustomers.Count);

            foreach(Customer customer in stackCustomers)
            {
                Console.WriteLine($"{customer.Id}-{customer.Name}");
            }

            Console.WriteLine($"After perfroming foreach the stack count is {stackCustomers.Count}");

            Customer cust = stackCustomers.Peek();

            Console.WriteLine($"{cust.Id}-{cust.Name}");

        }
    }
}
