using System;
using System.Collections.Generic;
using System.Linq;

namespace ListCollectionDemo2
{
    class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
    }
    class Program
    {

        static List<Customer> customerList = new List<Customer>();
        static void Main(string[] args)
        {

            Customer customer1 = new Customer { Id = 1, Name = "James", Salary = 5000 };
            Customer customer2 = new Customer { Id = 2, Name = "Tina", Salary = 8000 };
            Customer customer3 = new Customer { Id = 3, Name = "Tresa", Salary = 8000 };

            customerList.Add(customer1);
            customerList.Add(customer2);
            customerList.Add(customer3);

            //1. Print all customers in customer list
            foreach (Customer customer in customerList)
            {
                Console.WriteLine($"{customer.Id} - {customer.Name} - {customer.Salary}");
            }

            //2. Display customer details whose name starts with 'T'.

           List<Customer> customerNameThatStartsWithTList= customerList.FindAll(c => c.Name.StartsWith('T'));
            foreach(Customer customer in customerNameThatStartsWithTList)
            {
                Console.WriteLine($"{customer.Id} - {customer.Name} - {customer.Salary}");
            }

            //2. Display customer details whose name salary >6000
            List<Customer> customerSalaryGreaterThan6KList = customerList.FindAll(c => c.Salary>6000);
            foreach (Customer customer in customerSalaryGreaterThan6KList)
            {
                Console.WriteLine($"{customer.Id} - {customer.Name} - {customer.Salary}");
            }

            Console.WriteLine(customerList.Contains(customer1));

            // Find the length of a list
            Console.WriteLine(customerList.Count);

            //Max function demo
            customerList.Max(e => e.Salary);
            //Min function
            customerList.Min(e => e.Salary);
            //Average salary.
            customerList.Average(e => e.Salary);

            // Scenario : Id must start with 100 & auto increment.
            customer1.Id = customerList.Count==0 ?100:customerList.Max(e => e.Id) + 1;

            //Remove a customer with a specific customer id in the customerList

            Customer tobeDeletedCustimer =customerList.Find(c => c.Id == 1);          
            customerList.Remove(tobeDeletedCustimer);

           
            


            /*
              Find
              FindAll,
              Max
              Min
              Average
              Where
              Remove
              Removeall
             */


        }

        static void AddCustomer()
        {
            Customer customer = new Customer();
            Console.WriteLine("Enter Customer Id");
            customer.Id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Customer Name");
            customer.Name = Console.ReadLine();
            Console.WriteLine("Enter Customer Salary");
            customer.Salary = Convert.ToInt32(Console.ReadLine());
            customerList.Add(customer);
        }
    }
}
