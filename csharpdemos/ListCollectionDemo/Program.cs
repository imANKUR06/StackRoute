using System;
using System.Collections;
using System.Collections.Generic;

namespace ListCollectionDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Array List Collection");

            ArrayList arrayList = new ArrayList();
            arrayList.Add(1);
            arrayList.Add("Test123");
            arrayList.Add(true);
            int firstElement =(int)arrayList[0];

            Console.WriteLine("Generic List Collection");

            //Collection if int data type
            List<int> numbers = new List<int>();
            numbers.Add(3); // Add method is used to add items to a list.
            numbers.Add(5);
            numbers.Add(11);

            //Collection if string data type
            List<string> countryList = new List<string> { "India", "UK" };
            


            foreach(int number in numbers)
            {
                Console.WriteLine(number);
            }

            foreach (string country in countryList) 
            { 
                Console.WriteLine(country); 
            }



        }
    }
}
