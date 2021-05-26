using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ConfigurationDotNetCore.Models
{
    public class Customer
    {
        [Key]
        public int Id{ get; set; }
        [Required(ErrorMessage ="Plz Enter Customer Name")]
        public string CustomerName{ get; set; }
        public string ContactNo { get; set; }
        public string Country { get; set; }
        public string Email { get; set; }
        public string Address{ get; set; }
        public string MobileNo{ get; set; }
    }
}
