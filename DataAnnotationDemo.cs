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

        public void CustomerOrderDetails()
        {
            Console.WriteLine("Customer Details validation using Data Annoataion");

            Console.WriteLine("CustomerId");
            int CusId = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Name :");
            String CusName = Console.ReadLine();

            Console.WriteLine("Email");
            string email = Console.ReadLine();

            Console.WriteLine("PhoneNumber :");
            string phoneNumber = Console.ReadLine();

            Console.WriteLine("City");
            string CusCity = Console.ReadLine();

           Customer customer = new Customer { 

                CustomerId = CusId,
                CustomerName = CusName,
                CustomerCity = CusCity,
                CustomerEmail = email,
                CustomerPhone = phoneNumber
            };
            
            Console.WriteLine("Order details validation using Data Annatation.");
            Console.WriteLine("OrderId:");
            int OrderId = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("OrderDate :");
            DateTime dateTime = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("OrderAmount :");
            double amount;
            while (!double.TryParse(Console.ReadLine(), out amount))
            {
                Console.WriteLine("Invalid amount. Please enter a valid numeric value:");
            }


            Orders orders = new Orders {
                OrderId = OrderId,
                OrderDate = dateTime,
                TotalAmount = amount,
                CustomerId = customer.CustomerId,
                Customer = customer
            };

            customer.Orders.Add(orders);
            ValidateEntity(customer);
            ValidateEntity(orders);
        }

        public void ValidateEntity(Object obj)
        {
            var contex = new ValidationContext(obj);
            var result = new List<ValidationResult>();
            bool IsValid = Validator.TryValidateObject(obj, contex, result, true);

            if (IsValid)
            {
                Console.WriteLine(obj.ToString() + " data is valid");

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
