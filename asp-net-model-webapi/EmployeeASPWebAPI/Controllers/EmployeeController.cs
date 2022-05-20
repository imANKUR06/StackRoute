using EmployeeASPWebAPI.Model;
using EmployeeASPWebAPI.Repository;
using EmployeeASPWebAPI.ViewModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeASPWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        IEmployeeRepository _employeeRepository;
        public  EmployeeController(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;

        }
        [HttpGet]
        [Route("/api/Employee")]
        public IActionResult ListEmployee()
        {
            //int x = 0;
            //int y = 5 / x;
            var employee = _employeeRepository.GetEmployee();
            return Ok(employee);
        }

        [HttpGet]
        [Route("/api/Employee/{id}")]
        public IActionResult GetElementId(int id)
        {
            var employee = _employeeRepository.GetEmployeeById(id);
            if(employee == null)
            {
                return NotFound($"This {id} is not Present");
            }
            return Ok(employee);
        }
        
        [HttpPost]
        [Route("/api/employee/CreateEmployee")]
        public IActionResult CreateEmployee([FromBody]CreateEmployeeViewModel createEmployeeViewModel)
        {
            Employee employee = new Employee { Name = createEmployeeViewModel.Name, Email = createEmployeeViewModel.Email };
            _employeeRepository.AddEmployee(employee);
            return CreatedAtAction("GetElementId",new { id = employee.Id },employee);
        }
        [HttpPut]
        [Route("/api/employee/{id}")]
        public IActionResult UpdateEmployee(EditEmployeeViewModel editEmployeeViewModel,int id)
        {
            Employee employee = _employeeRepository.GetEmployeeById(id);
            if(employee == null)
            {
                return NotFound($"Employee with {id} Not found");
            }
            employee.Name = editEmployeeViewModel.Name;
            employee.Email = editEmployeeViewModel.Email;
            _employeeRepository.EditEmployee(employee);
            return Ok(employee);
        }

        [HttpDelete]
        [Route("/api/employee/{id}")]

        public IActionResult RemoveEmployee(int id)
        {
            Employee employee = _employeeRepository.GetEmployeeById(id);
            if (employee == null)
            {
                return NotFound($"Employee with {id} Not found");
            }
            _employeeRepository.DeleteEmployee(id);
            return Ok($"Employee with {id} was deleted");
        }




    }
}
