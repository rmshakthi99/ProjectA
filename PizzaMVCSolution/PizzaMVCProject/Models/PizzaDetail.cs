using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaMVCProject.Models
{
    public class PizzaDetail
    {
      
        public int PizzaId { get; set; }
        public string PizzaName { get; set; }
        public string Pizza { get; set; }
        public string VegOrNv { get; set; }
        public string Description { get; set; }
        public float Amount { get; set; }
        

    }

}

