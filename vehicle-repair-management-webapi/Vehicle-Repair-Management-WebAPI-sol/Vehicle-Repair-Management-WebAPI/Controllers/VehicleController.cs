using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vehicle_Repair_Management_WebAPI.Models;
using Vehicle_Repair_Management_WebAPI.Repository;
using Vehicle_Repair_Management_WebAPI.ViewModel;
using Vehicle_Repair_Management_WebAPI.ViewModel.Authentication;
using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;

namespace Vehicle_Repair_Management_WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class VehicleController : ControllerBase
    {
        IVehicleRepository _vehicleRepository;
        //added for username
       

        public VehicleController(IVehicleRepository ivehicleRepository)
        {
            _vehicleRepository = ivehicleRepository;
            
        }


        [HttpGet]
        [Route("/api/Vehicle")]
        public IActionResult ListVehicle()
        {
            var vehicle = _vehicleRepository.GetVehicle();
            return Ok(vehicle);
        }

        [HttpGet]
        [Route("/api/Vehicle/{id}")]
        public IActionResult GetVehicleId(int id)
        {
            var vehicle = _vehicleRepository.GetVehicleById(id);
            //if (vehicle == null)
            //{
               // return NotFound($"This {id} is not Present");
            //}
            return Ok(vehicle);
        }
        //[Authorize]
        [HttpPost]
        [Route("/api/Vehicle/CreateVehicle")]
        public IActionResult CreateVehicle( VehicleAddViewModel vehicleAddViewModel)
        {

            
            //var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            Vehicle vehicle = new Vehicle { Name = vehicleAddViewModel.Name,
            Type = vehicleAddViewModel.Type,
            Category = vehicleAddViewModel.Category,
            Complaint = vehicleAddViewModel.Complaint,
            Date = DateTime.Now,
            Cost = vehicleAddViewModel.Cost,
            Username = vehicleAddViewModel.Username
            
            };
            _vehicleRepository.AddVehicle(vehicle);
            return CreatedAtAction("GetVehicleId", new { id = vehicle.Id }, vehicle);
        }

        //[Authorize]
        [HttpPut]
        [Route("/api/Vehicle/{id}")]
        public IActionResult UpdateVehicle(VehicleEditViewModel vehicleEditViewModel, int id)
        {
            Vehicle vehicle = _vehicleRepository.GetVehicleById(id);
            if (vehicle == null)
            {
                return NotFound($"Vehicle with {id} Not found");
            }
            vehicle.Name = vehicleEditViewModel.Name;
            vehicle.Type = vehicleEditViewModel.Type;
            vehicle.Category = vehicleEditViewModel.Category;
            vehicle.Complaint = vehicleEditViewModel.Complaint;
            vehicle.Date = DateTime.Now;
            vehicle.Cost = vehicleEditViewModel.Cost;
            vehicle.Username = vehicleEditViewModel.Username;
            _vehicleRepository.EditVehicle(vehicle);
            return Ok(vehicle);
        }

        //[Authorize]
        [HttpDelete]
        [Route("/api/Vehicle/{id}")]

        public IActionResult RemoveVehicle(int id)
        {
            Vehicle vehicle = _vehicleRepository.GetVehicleById(id);
            if (vehicle == null)
            {
                return NotFound($"Vehicle with {id} Not found");
            }
            _vehicleRepository.DeleteVehicle(id);
            return Ok($"Vehicle with {id} was deleted");
        }


        [HttpGet]
        //getvehicleByname
        [Route("/api/Vehicle/getvehicle/{name}")]
        public IActionResult GetVehiclebyNameWithA(string name)
        {
            IEnumerable<Vehicle> vehicle = _vehicleRepository.GetVehicleByName(name);
            if (vehicle == null)
            {
                return NotFound($"No Vehicles is in DataBase ");
            }

            return Ok(vehicle);
        }


    }
}
