using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace PizzaMVCProject.Models
{ 


    public class Customer
    {
        [Key]
        public int CustomerId { get; set; }
        
        public string CustomerName { get; set; }
        [Required(ErrorMessage = "Please Enter Customer Name")]
        public string DeliveryAddress { get; set; }
        [Required(ErrorMessage = "Please Enter Delivery Address")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Please Enter Email")]
        public string MobileNumber { get; set; }
        [Required(ErrorMessage = "Please Enter Mobile Number")]
        public DateTime Date{get;set;}

        public int Quantity { get; set; }
        [Required(ErrorMessage = "Please select Quantity")]
        public int TotalAmount { get; set; }
        public int PizzaAmount { get; set; }       
        public string Crust { get; set; }
        [Required(ErrorMessage = "Please Select Crust")]
        public string Toppings { get; set; }
        [Required(ErrorMessage = "Please select Toppings")]
        public int ToppingsAmount { get; set; }

    }
}

