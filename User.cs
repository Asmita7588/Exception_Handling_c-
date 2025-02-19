using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exceptionDemo
{
    internal class User
    {
        [Required(ErrorMessage = "Name is required")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Name length should have minimum 3 letters")]
        public string Name { get; set; }

        [Range(18, 75, ErrorMessage = "Age should be between  18 and 75")]
        public int Age { get; set; }

        [EmailAddress(ErrorMessage = "Provide valid email input")]
        [RegularExpression("^[a-z0-9]+@[a-z]+\\.+[a-z]{2,}$")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Password is required")]
        [StringLength(20,MinimumLength = 8, ErrorMessage = "Password Length should be minimum 8 charcter")]
        public string Password { get; set; }
        

    }
}
