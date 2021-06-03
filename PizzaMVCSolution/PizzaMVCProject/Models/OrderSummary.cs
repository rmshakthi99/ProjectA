using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaMVCProject.Models
{
    public class OrderSummary
    {
        public int PizzaId { get; set; }
        public string PizzaName { get; set; }
        public int Amount { get; set; }
        public int TotalAmount { get; set; }
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string DeliveryAddress { get; set; }
        public string Email { get; set; }
        public string MobileNumber { get; set; }
        public int Quantity { get; set; }
        public string Crust { get; set; }
        public string Toppings { get; set; }

    }
}
