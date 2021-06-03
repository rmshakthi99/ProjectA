using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaWebAPIProject.Models
{
    public class CrustCartMapping
    {
        [Key]
        public int CrustCartId { get; set; }
        [ForeignKey("CartDetails")]
        public int CartId { get; set; }
        [ForeignKey("Crust")]
        public int CrustId { get; set; }
    }
}
