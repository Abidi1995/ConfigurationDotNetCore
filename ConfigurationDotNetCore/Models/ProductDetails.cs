using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ConfigurationDotNetCore.Models
{
    public class ProductDetails
    { 
    
        [Key]
        public int ProductCode{ get; set; }
        public string MoreDescriptions{ get; set; }
        public byte[] Picture{ get; set; }
        public string Comments{ get; set; }
    }
}
