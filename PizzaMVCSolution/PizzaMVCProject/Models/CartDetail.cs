using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaMVCProject.Models
{
    public class CartDetail
    {
        public int CartId { get; set; } 
        public int CustomerId { get; set; }
        public DateTime CartDate { get; set; }
        public float CartAmount { get; set; }

    }
}
