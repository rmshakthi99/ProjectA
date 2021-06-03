using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaWebAPIProject.Models
{
    public class CartDetail
    { 
        [Key]
        public int CartId { get; set; }
        [ForeignKey("Customer")]
        public int CustomerId { get; set; }
        public DateTime CartDate { get; set; }
        public float CartAmount { get; set; }

            
    
        
    }
}
