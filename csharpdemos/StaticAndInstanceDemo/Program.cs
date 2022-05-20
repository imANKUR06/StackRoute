using System;

namespace StaticAndInstanceDemo
{
    class Circle
    {
        public static float _pi;
        int _radius;

        static Circle()
        {
            _pi = 3.141f;
            Console.WriteLine("Called Static Constructor");
        }
        public Circle(int radius)
        {
            this._radius = radius;
            Console.WriteLine("Called Instance Constructor");
        }

        public float CalculateArea()
        {
            return _pi * this._radius * this._radius;
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Static & Instance Demo");
            
            Circle c1 = new Circle(5);  
          
            Console.WriteLine($"The area of circle is {c1.CalculateArea()}");

            Circle c2 = new Circle(6);
            Console.WriteLine($"The area of circle is {c2.CalculateArea()}");
        }
    }
}
