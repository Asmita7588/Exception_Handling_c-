using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exceptionDemo
{
    internal class Orders
    {

        [Required(ErrorMessage =" order Id is required")]
        public int OrderId { get; set; }
        [Required(ErrorMessage =" Order Date is required")]
        [DataType(DataType.Date)]
        public DateTime OrderDate { get; set; }

        [Required(ErrorMessage = "Total amount is required")]
        [Range(1.0, 50000.00, ErrorMessage = "Total amount must be at least {0:F2}.")]
        public double TotalAmount { get; set; }

        [Required(ErrorMessage = "Customer ID is required.")]
        public int CustomerId { get; set; }
        
        public Customer Customer { get; set; }

    }
}
