using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConfigurationDotNetCore.Models
{
    public class Library
    {
        public int LibraryID{ get; set; }
        public string LibraryName{ get; set; }
        public string Code { get; set;}
        public DateTime OpeningTime { get; set; }
        public DateTime ClosingTime { get; set; }

    }
}
