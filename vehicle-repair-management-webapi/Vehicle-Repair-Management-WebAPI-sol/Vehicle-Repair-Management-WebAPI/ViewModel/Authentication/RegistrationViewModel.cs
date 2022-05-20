using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Vehicle_Repair_Management_WebAPI.ViewModel.Authentication
{
    public class RegistrationViewModel
    {
        [Required(ErrorMessage = "User Name is Mandatory")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Email is Mandatory")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Password is Mandatory")]
        public string Password { get; set; }

    }

}
