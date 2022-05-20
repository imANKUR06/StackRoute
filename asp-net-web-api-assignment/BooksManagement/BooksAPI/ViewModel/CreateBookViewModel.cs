using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BooksAPI.ViewModel
{
    public class CreateBookViewModel
    {
        [Required(ErrorMessage = "Book Name is mandatory")]
        [MaxLength(20, ErrorMessage = "Maximum Length of Book name is 20 characters")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Book Description is mandatory")]
        [MaxLength(50, ErrorMessage = "Maximum Length of Book Description is 50 characters")]
        public string Description { get; set; }

        public double Amount { get; set; }

        [Required(ErrorMessage = "Book Author is mandatory")]
        [MaxLength(30, ErrorMessage = "Maximum Length of name is 30 characters")]
        public string Author { get; set; }
    }
}
