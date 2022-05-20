using System;
using System.Collections.Generic;
using System.Text;

namespace InternalModifierClassLibrary
{
    public class InternalDemo
    {
          protected internal  int ID;
    }

    class Demo 
    {
        void Print()
        {
           
            InternalDemo demo = new InternalDemo();
            
        }
    }
}
