using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vehicle_Repair_Management_WebAPI.Models;

namespace Vehicle_Repair_Management_WebAPI.DBContext
{
    public class VehicleDBContext:IdentityDbContext
    {
        public VehicleDBContext(DbContextOptions<VehicleDBContext> options) : base(options)
        {

        }
        public DbSet<Vehicle> Vehicle { get; set; }
    }
}
