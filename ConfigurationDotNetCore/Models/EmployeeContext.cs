using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConfigurationDotNetCore.Models
{
    public class EmployeeContext : DbContext
    {
        public EmployeeContext(DbContextOptions<EmployeeContext> dbContextOptions) : base(dbContextOptions)//constructor


        {


        }

        public DbSet<Employee> Employees { get; set; }//Mapping

    }
}
