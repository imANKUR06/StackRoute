using System;

namespace DelegateExample
{
    delegate bool IsPromotable(Employee employee);
    class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
        public int Experience { get; set; }

        public void PromoteEmployee(Employee[] employees, IsPromotable isPromotable)
        {
            foreach(Employee employee in employees)
            {
                if (isPromotable(employee))
                {
                    Console.WriteLine($"{employee.Name} is promoted");
                }
            }
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Delegate Example");
            Console.WriteLine("******************************");

            Employee[] employeeList = new Employee[4];

            Employee employee = new Employee();          

            employeeList[0] = new Employee { Id = 1, Name = "James", Salary = 10000, Experience = 3 };
            employeeList[1] = new Employee { Id = 2, Name = "Tom", Salary = 4000, Experience = 2 };
            employeeList[2] = new Employee { Id = 3, Name = "Tina", Salary = 9000, Experience = 4 };
            employeeList[3] = new Employee { Id = 4, Name = "Derry", Salary = 19000, Experience = 10 };

            IsPromotable promotableDelegate = new IsPromotable(Promote);
            //Is promotable delagate is pointing to the Promote function.
            employee.PromoteEmployee(employeeList,promotableDelegate);



            

        }

        public static bool Promote(Employee employee)
        { 
            if(employee.Salary > 5000)
            {
                return true;
            }
            return false;
        }
    }
}
