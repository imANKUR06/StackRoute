using System;

namespace InheritanceDemo
{
    public class Employee
    {
         public string FirstName;
         public string LastName;
        public void PrintFullName()
        {

        }
    }

    public class FullTimeEmployee : Employee
    {
        public float YearlySalary;
    }

    public class PartTimeEmployee : Employee
    {
        public float HourlySalary;
    }

    public class ParentClass
    {
        public ParentClass()
        {
            Console.WriteLine("I am parent class constructor");
        }

        public ParentClass(string message)
        {
            Console.WriteLine(message);
        }
    }

    public class ChildClass : ParentClass
    {
        public ChildClass(): base("Child class controlling parent class constructor")
        {
            Console.WriteLine("I am child class constructor");
        }

       

    }

    public class ChilldofChildClass : ChildClass
    {

    }


   

    class Program 
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inheritance Demo");
            //FullTimeEmployee fullTimeEmployee = new FullTimeEmployee();  
            //PartTimeEmployee partTimeEmployee = new PartTimeEmployee();

            ChildClass childClass = new ChildClass();


            Employee employee = new FullTimeEmployee();

            /*
               1. Child class is a specialization of base class.
               2. Base classess are automatically instantiated before child class.
               3. Parent class constructor executes before child class constructor.
               4. It is possible to assign an instance of child class to a parent class variable.
               5. It is not possible to assign an instance of parent class to a child class variable.
             */





        }
    }
}
