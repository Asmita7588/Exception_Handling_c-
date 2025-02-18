using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exceptionDemo
{
    internal class CustomExceptionDemo
    {
       
        public void ValidateEmpId()
        {
            try
            {
                Console.WriteLine("Enter Employee Id in this format (EMP1)");
                string id = Console.ReadLine();

                Console.WriteLine("Enter Employee name : ");
                string name = Console.ReadLine();

                Employee emp = new Employee(id, name);

                Console.WriteLine("Employee Created : Id " + id + " " + " Emp Name = " + name);
            }
            catch (InvalidEmployeeIdException ex) { 
                Console.WriteLine("Error :" + ex.Message);
            }

        }
        
    }
}
