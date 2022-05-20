using System;
using System.Collections.Generic;

namespace DictionaryDemo
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

            Dictionary<int, Customer> customerDictionary = new Dictionary<int, Customer>();
            customerDictionary.Add(customer1.Id, customer1);
            customerDictionary.Add(customer2.Id, customer2);
            customerDictionary.Add(customer3.Id, customer3);

            //Read Data from dictionary

            Customer customerWithId1 = customerDictionary[1];
            Console.WriteLine($"{customerWithId1.Id}- {customerWithId1.Name}");

            //Display all dictionary values

            foreach(KeyValuePair<int,Customer> customerKeyValuePair in customerDictionary)
            {
                Console.WriteLine($"Key - {customerKeyValuePair.Key}");
                Console.WriteLine($"Value is {customerKeyValuePair.Value.Id} -{customerKeyValuePair.Value.Name}");
            }

        }
    }
}
