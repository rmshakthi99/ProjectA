using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaMVCProject.Models
{
    public class Order
    {
        public int OrderId { get; set; }       
        public int CustomerId { get; set; }
        public int PizzaId { get; set; }
        public int TotalAmount { get; set; }
        public DateTime OrderDate { get; set; }

    }
}
