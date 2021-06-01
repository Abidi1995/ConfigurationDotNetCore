using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConfigurationDotNetCore.Models
{
    public class Orders
    {
        public int OrderID { get; set; }
        public ICollection<Customer> Customers{ get; set; }
        public int Id { get; set; }
        public ICollection<Employee> Employees { get; set; }
        public int EmployeeId { get; set; }
        public DateTime OrderDate { get; set; }
        public int ShipperID { get; set; }

    }
}
