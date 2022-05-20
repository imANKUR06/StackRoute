using System;

namespace InhertinaceDemo2
{
    public class Employee 
    {
        public string FirstName = "FN";
        public string LastName = "LN";
        public virtual void PrintFullName()
        {
            Console.WriteLine($"{ FirstName},{LastName}");
        }
    }

    public class PartTimeEmployee : Employee
    {

        public override void PrintFullName()
        {
            
            Console.WriteLine($"{ FirstName},{LastName} - Part Time");
        }
        //public void PrintFullName()
        //
        //    Console.WriteLine($"{ FirstName},{LastName} - Part Time");
        //}
    }

    public class FullTimeEmployee : Employee
    {
        public override void PrintFullName()
        {
            Console.WriteLine($"{ FirstName},{LastName} - Full Time");
        }
    }
    

    public class TemporaryEmployee : Employee
    {
        public override void  PrintFullName()
        {
            Console.WriteLine($"{ FirstName},{LastName} - Temporary");
        }
    }


   
    class Program
    {
        static void Main(string[] args)
        {
            Employee[] employees = new Employee[4];
            employees[0] = new Employee();
            employees[1] = new PartTimeEmployee();
            employees[2] = new FullTimeEmployee();
            employees[3] = new TemporaryEmployee();

            //for(int i = 0; i <= employees.Length - 1; i++)
            //{
            //    employees[i].PrintFullName();
            //}

            foreach(Employee employee in employees)
            {
                employee.PrintFullName();
            }

           
            
        }


        static void Print(string message)
        {

        }

        static void Print(string message1,string message2)
        {

        }

       
    }
}
