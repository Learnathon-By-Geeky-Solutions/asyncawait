using CustomerOrderManagement.Models.EntityModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreSamples.Database
{
    public class CustomerOrderDbContext : DbContext
    {
        public CustomerOrderDbContext(DbContextOptions<CustomerOrderDbContext> options) : base(options)
        {
        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Product> Products { get; set; }

        public DbSet<CustomerCategory> CustomersCategories { get; set; }
        public DbSet<ProductCategory> ProductCategories { get; set; }

    }
}
