using EmployeeASPWebAPI.DBContext;
using EmployeeASPWebAPI.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeASPWebAPI.Repository
{
    public class SqlRepository : IEmployeeRepository
    {
        EmployeeDBContext _employeeDBContext;
        public SqlRepository(EmployeeDBContext employeeDBContext)
        {
            _employeeDBContext = employeeDBContext;
        }
        public void AddEmployee(Employee employee)
        {
            _employeeDBContext.Employee.Add(employee);
            _employeeDBContext.SaveChanges();
        }

        public void DeleteEmployee(int id)
        {
            
            _employeeDBContext.Employee.Remove(GetEmployeeById(id));
            _employeeDBContext.SaveChanges();
            //Employee employee = GetEmployeeById(id);
            //_employeeDBContext.Remove(employee);
        }

        public void EditEmployee(Employee employee)
        {
            var employeeChanges = _employeeDBContext.Employee.Attach(employee);
            employeeChanges.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            //Employee employeeToBeEdited = _employeeDBContext.Employee.FirstOrDefault(x => x.Id == employee.Id);
            //employeeToBeEdited.Name = employee.Name;
            //employeeToBeEdited.Email = employee.Email;
            _employeeDBContext.SaveChanges();
        }

        public List<Employee> GetEmployee()
        {
           return  _employeeDBContext.Employee.ToList();
        }

        public Employee GetEmployeeById(int id)
        {
            return _employeeDBContext.Employee.FirstOrDefault(x => x.Id == id);
        }
    }
}
