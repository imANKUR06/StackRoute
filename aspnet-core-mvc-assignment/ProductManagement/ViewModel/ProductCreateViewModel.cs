using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProductManagement.ViewModel
{
    public class ProductCreateViewModel
    {
        [Required (ErrorMessage ="Please Enter Name first"),MinLength(5,ErrorMessage ="Name Length should be atleast 5")]
        public string Name { get; set; }
        public string Description { get; set; }
        [Required (ErrorMessage ="Please Enter Amount First")]
        public double Amount { get; set; }
    }
}
