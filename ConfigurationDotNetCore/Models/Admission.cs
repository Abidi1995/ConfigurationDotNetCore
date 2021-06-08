using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConfigurationDotNetCore.Models
{
    public class Admission
    {
        public bool IsExpell { get; set; }
        public int ID { get; set; }
        public int ClassSectionID { get; set; }
        public int StudentID { get; set; }
        public decimal Session { get; set; }
        public int CampuseID { get; set; }
    }
}
