using System;

namespace GenericsDemo2
{
    class Demo<Tobject> where Tobject:class // It says that only reference types are allowed for 'Tobject'
    {
        public Tobject Data { get; set; }
    }

    class Customer
    {
        public int Id { get; set; }
    }


    class GenericCalculator<T> where T:struct // It says that only value types are allowed for 'T'.
    {
        public T Add(T number1,T number2)
        {
            dynamic firstNumber = number1;
            dynamic secondNumber = number2;

            return firstNumber + secondNumber;
        }
    }

    class Program
    {

        
        static void Main(string[] args)
        {
            Demo<Customer> demo1 = new Demo<Customer>();
            // Demo<int> demo2 = new Demo<int>();
            GenericCalculator<float> genericCalculator = new GenericCalculator<float>();
            Console.WriteLine(genericCalculator.Add(5.112f, 5.100f));
           


        }
    }
}
