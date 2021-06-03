﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaWebAPIProject.Models
{
    public class PizzaCartMapping
    {
        [Key]
        public int PizzaCartId { get; set; }

        [ForeignKey("CartDetails")]
        public int CartId { get; set; }
        [ForeignKey("PizzaDetails")]
        public int PizzaId { get; set; }
        public int Quantity { get; set; }

    }
}
