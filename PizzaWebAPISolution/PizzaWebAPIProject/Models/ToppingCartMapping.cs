using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaWebAPIProject.Models
{
    public class ToppingCartMapping
    {
        [Key]
        public int ToppingCartId{get;set;}

        [ForeignKey("CartDetails")]
        public int CartId { get; set; }
        [ForeignKey("Toppings")]
        public int ToppingsId { get; set; }
        public int Quantity { get; set; }

    }
}
