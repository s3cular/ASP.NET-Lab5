using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
//Make sure the following packages are installed via the nu get package manager.
using Microsoft.EntityFrameworkCore;

namespace ASP.NET_Lab5.Models
{
    public class CustomerContext : DbContext
    {
        // Constructor for CustomerContext
        public CustomerContext(DbContextOptions<CustomerContext> options) : base(options)
        {

        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<OrderItems> OrderItems { get; set; }
       
    }
}
