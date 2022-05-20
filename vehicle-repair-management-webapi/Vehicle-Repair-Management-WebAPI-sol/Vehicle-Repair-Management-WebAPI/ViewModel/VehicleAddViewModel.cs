using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Vehicle_Repair_Management_WebAPI.ViewModel
{
    public class VehicleAddViewModel
    {
        [Required(ErrorMessage = "Vehicle name is mandatory.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Vehicle type is mandatory.")]
        public string Type { get; set; }

        [Required(ErrorMessage = "Vehicle category is mandatory.")]
        public string Category { get; set; }

        [Required(ErrorMessage = "Complaint is mandatory.")]
        public string Complaint { get; set; }

        [Required(ErrorMessage = "Date is mandatory.")]
        public DateTime Date { get; set; }

        [Required(ErrorMessage = "Repair cost is mandatory.")]
        public double? Cost { get; set; }

        [Required(ErrorMessage = "Username is mandatory.")]
        public string Username { get; set; }
    }
}
