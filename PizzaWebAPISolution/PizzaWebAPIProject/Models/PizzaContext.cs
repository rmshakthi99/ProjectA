using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaWebAPIProject.Models
{
    public class PizzaContext :DbContext
    {
        public PizzaContext() : base()
        {

        }
        public PizzaContext(DbContextOptions<PizzaContext> options) : base(options)
        { }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer("server=SHAKTHI-RM\\SQLEXPRESS;database=dbPizza;trusted_connection=true;");
        //}
        public DbSet<PizzaDetail> PizzaDetails { get; set; }
        public DbSet<Customer> Customers { get; set; }
            
        public DbSet<Order> Order { get; set; }
        

    }
}

