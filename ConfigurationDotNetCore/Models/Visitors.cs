using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ConfigurationDotNetCore.Models
{
    public class Visitors
    {
        [Key]
        public int VisitorID{ get; set; }
        public string Name { get; set; }
        public System.DateTime Date { get; set; }
        public System.TimeSpan TimeIn { get; set; }
        public System.TimeSpan TimeOut { get; set; }
        public string Relationship { get; set; }
        public string Cnic { get; set; }
        public int HostleAdmId { get; set; }
        public int HostelId { get; set; }

        public virtual Hostel Hostel { get; set; }
        public virtual HostelAdmission HostelAdmission { get; set; }
    }
}
