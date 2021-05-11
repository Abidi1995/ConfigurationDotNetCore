using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ConfigurationDotNetCore.Models
{
    public class Employee
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int EmployeeId{ get; set; }
        public  string EmployeeFullName { get; set; }
        public string FatherName { get; set; }
        public string Email{ get; set; }
        public DateTime DateOfBirth{ get; set; }
        public string Address{ get; set; }
        public string Mobile{ get; set; }
        public  decimal Salary { get; set; }
        public string Shift { get; set; }
        public string Notes{ get; set; }
        public int Age{ get; set; }
    }
}
