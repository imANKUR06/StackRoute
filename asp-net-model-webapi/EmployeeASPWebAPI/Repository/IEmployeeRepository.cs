using EmployeeASPWebAPI.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeASPWebAPI.Repository
{
    public interface IEmployeeRepository
    {
        List<Employee> GetEmployee();
        void AddEmployee(Employee employee);
        Employee GetEmployeeById(int id);

         void EditEmployee(Employee employee);
        void DeleteEmployee(int id);
    }
}
