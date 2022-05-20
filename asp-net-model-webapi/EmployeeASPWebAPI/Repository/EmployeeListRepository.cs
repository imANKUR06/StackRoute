using EmployeeASPWebAPI.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeASPWebAPI.Repository
{
    public class EmployeeListRepository : IEmployeeRepository
    {
        List<Employee> _employeeList;

        public EmployeeListRepository()
        {
            _employeeList = new List<Employee>
            {
                new Employee { Id = 1, Name = "James", Email = "james@test.com" },
                new Employee { Id = 2, Name = "Tina", Email = "tina@test.com" }

            };
        }
        public List<Employee> GetEmployee()
        {
            return _employeeList;
        }
        public void AddEmployee(Employee employee)
        {
            employee.Id = _employeeList.Count > 0 ? _employeeList.Max(x => x.Id) + 1 : 1;
            _employeeList.Add(employee);
        }

        public Employee GetEmployeeById(int id)
        {
            Employee employee =  _employeeList.Find(e => e.Id == id);
            return employee;
        }

        public void EditEmployee(Employee employee)
        {
            Employee employeeToBeEdited = _employeeList.Find(x => x.Id == employee.Id);
            employeeToBeEdited.Name = employee.Name;
            employeeToBeEdited.Email = employee.Email;
        }

        public void DeleteEmployee(int id)
        {
            Employee employee = GetEmployeeById(id);
            _employeeList.Remove(employee);
        }
    }
}
