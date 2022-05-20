using InternalModifierClassLibrary;
using System;

namespace AccessModifierDemo
{
    class A : InternalDemo
    {
        public void ClassAMethod()
        {
            ID = 1;
        }
    }


    class Program 
    {
       
        static void Main(string[] args)
        {
            
        }
    }
}
