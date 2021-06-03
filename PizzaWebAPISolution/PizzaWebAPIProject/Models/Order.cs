using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaWebAPIProject.Models
{
    public class Order
    {
        [Key]
        public int OrderId { get; set; }
        [ForeignKey("Customers")]       
        public int CustomerId { get; set; }
        [ForeignKey("PizzaDetails")]
        public int PizzaId { get; set; }
        public DateTime OrderDate { get; set; }
        public int TotalAmount { get; set; }


    }
}
