using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exceptionDemo
{
    internal class DataAnnotationDemo
    {
        public void UserDetails()
        {
            Console.WriteLine("User input validation using Data annotation.");
            Console.WriteLine("Name :");
            String name = Console.ReadLine();

            Console.WriteLine("Age :");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Email :");
            string email = Console.ReadLine();

            Console.WriteLine("Password :");
            String Password = Console.ReadLine();

            User user = new User
            {
                Name = name,
                Age = age,
                Email = email,
                Password = Password
            };

            var contex = new ValidationContext(user);
            var result = new List<ValidationResult>();
            bool IsValid = Validator.TryValidateObject(user, contex, result, true);

            if (IsValid)
            {
                Console.WriteLine("User data is valid");

            }
            else
            {
                Console.WriteLine("---------validation Errors------------");
                foreach (var error in result)
                {
                    Console.WriteLine($"-{error.ErrorMessage}");
                }
            }

        }
    }
}
