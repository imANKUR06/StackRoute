using System;

namespace GenericsDemo
{
    class Demo<Tobject>
    {
        public Tobject Data { get; set; }
    }

    class GepKeyValuePair<TKey, TValue>
    {
        public TKey Key { get; set; }
        public TValue Value {get;set;}
    }

   
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Generics Demo");


            Demo<string> demo1 = new Demo<string>();
            demo1.Data = "Hello";

            Demo<int> demo2 = new Demo<int>();
            demo2.Data = 1;

            GepKeyValuePair<int, string> gepKeyValuePair = new GepKeyValuePair<int, string>();
            gepKeyValuePair.Key = 1;
            gepKeyValuePair.Value = "GEP";

          

        }
    }
}
