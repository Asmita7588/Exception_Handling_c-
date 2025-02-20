using System;
using System.ComponentModel.DataAnnotations;


using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exceptionDemo
{
    internal class Customer
    {
        [Required(ErrorMessage ="Customer Id Is required")]
        public int CustomerId { get; set; }
        [Required(ErrorMessage = "Customer name is reqired")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = " customer name length should be grater than 3 char")]
        public string CustomerName { get; set; } = string.Empty;
        [Required(ErrorMessage = "email is required")]
        [EmailAddress(ErrorMessage ="invalid email input")]
        public string CustomerEmail { get; set; }
        [Required (ErrorMessage ="Phone number is required")]
        [RegularExpression(@"^[0-9]{10}$", ErrorMessage = "Phone number should match this pattern @^[0-9]{10}$")]
        public string CustomerPhone { get; set; } = string.Empty;
        [Required(ErrorMessage ="City is required")]
        [StringLength(maximumLength:50 , MinimumLength = 3, ErrorMessage = "City length should be between 3 and 50")]
        public string CustomerCity { get; set; } = string.Empty;

        public List<Orders> Orders { get; set; } = new List<Orders>();

    }
}
