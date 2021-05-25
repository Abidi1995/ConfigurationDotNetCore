using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConfigurationDotNetCore.Models
{
    public class CompanyContext : DbContext
    {
        public CompanyContext(DbContextOptions<CompanyContext> dbContextOptions) : base(dbContextOptions)//constructor


        {


        }

        public DbSet<Employee> Employees { get; set; }//Mapping
        public DbSet<Company> Companies { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductDetails> ProductDetails { get; set; }
        public DbSet<Customer> Customers { get; set; }
    }
}
