using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vehicle_Repair_Management_WebAPI.Models;
using Vehicle_Repair_Management_WebAPI.ViewModel.Authentication;

namespace Vehicle_Repair_Management_WebAPI.Repository
{
    public interface IVehicleRepository
    {
        List<Vehicle> GetVehicle();
        void AddVehicle(Vehicle vehicle);
        Vehicle GetVehicleById(int id);
        IEnumerable<Vehicle> GetVehicleByName(string name);
        void EditVehicle(Vehicle vehicle);
        
        void DeleteVehicle(int id);
        
    }
}
