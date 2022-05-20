using System;

namespace PropertiesDemo
{
    class Student
    {
        string firstName;       
        int passMark = 35;



        // AUto implemented property

        public string LastName
        {
            get;
            set;
        }


        public int PassMark
        {
            get
            {
                return passMark;
            }
        }

        public string FirstName
        {
            get
            {
                return firstName;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("First name should not be empty or null");
                }
                firstName = value;
            }
        }
        
    }
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Student student = new Student();
                student.FirstName = "";
               
                Console.WriteLine(student.PassMark);
            }

            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
           

        }
    }
}
