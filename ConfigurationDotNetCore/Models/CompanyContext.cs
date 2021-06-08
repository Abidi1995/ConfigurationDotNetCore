using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConfigurationDotNetCore.Models
{
    public class CompanyContext : DbContext
    {
        public CompanyContext(DbContextOptions<CompanyContext> Options) : base(Options)//constructor


        {


        }

        public DbSet<Employee> Employees { get; set; }//Mapping tables
        public DbSet<Company> Companies { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductDetails> ProductDetails { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Orders> Orders { get; set; }
        public DbSet<OrderDetails> OrderDetails { get; set; }
        public DbSet<Sales> Sales { get; set; }
        public DbSet<Purchases> Purchases { get; set; }
        public DbSet<Shippers> Shippers { get; set; }
        public DbSet<Suppliers> Suppliers { get; set; }
        public DbSet<Library> Libraries { get; set;}
        public DbSet<LibrarayBookList> LibrarayBookLists { get; set; }
        public DbSet<LibraryBookRecord> LibraryBookRecords { get; set; }
        public DbSet<LibraryIssuedBook> LibraryIssuedBooks { get; set; }
        public DbSet<LibraryIssuedBooksToStaff> LibraryIssuedBooksToStaffs { get; set; }
        public DbSet<Hostel> Hostels { get; set; }
        public DbSet<Rooms> Rooms { get; set; }
        public DbSet<Visitors> Visitors { get; set; }
        public DbSet<Admission> Admissions { get; set;}

             
    }
}
