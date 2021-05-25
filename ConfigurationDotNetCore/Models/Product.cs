using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ConfigurationDotNetCore.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage ="Enter Product Name"),MaxLength(50)]
        public string ProductName { get; set; }
        public string SupplierName { get; set; }
        public string UnitPrice { get; set; }
        public int Stock { get; set; }
        public string ProductType { get; set; }
        public decimal PurchasePrice { get; set; }
        public decimal SalePrice { get; set; }

    }
}

