using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vehicle_Repair_Management_WebAPI.DBContext;
using Vehicle_Repair_Management_WebAPI.Models;
using Vehicle_Repair_Management_WebAPI.ViewModel.Authentication;

namespace Vehicle_Repair_Management_WebAPI.Repository
{
    public class sqlRepository:IVehicleRepository
    {
        VehicleDBContext _vehicleDBContext;
        public sqlRepository(VehicleDBContext vehicleDBContext)
        {
            _vehicleDBContext = vehicleDBContext;
        }
        public void AddVehicle(Vehicle vehicle)
        {
            
            _vehicleDBContext.Vehicle.Add(vehicle);
            _vehicleDBContext.SaveChanges();
        }

        public void DeleteVehicle(int id)
        {

            _vehicleDBContext.Vehicle.Remove(GetVehicleById(id));
            _vehicleDBContext.SaveChanges();

        }

        public void EditVehicle(Vehicle vehicle)
        {
            var vehicleChanges = _vehicleDBContext.Vehicle.Attach(vehicle);
            vehicleChanges.State = Microsoft.EntityFrameworkCore.EntityState.Modified;

            _vehicleDBContext.SaveChanges();
        }


        public List<Vehicle> GetVehicle()
        {
            return _vehicleDBContext.Vehicle.ToList();
        }

        public Vehicle GetVehicleById(int id)
        {
            return _vehicleDBContext.Vehicle.FirstOrDefault(x => x.Id == id);
        }

        public IEnumerable<Vehicle> GetVehicleByName(string name)
        {
            var vehicle = _vehicleDBContext.Vehicle.Where(x => x.Name == name);
            return vehicle;
        }

    }
}
