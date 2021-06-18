using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConfigurationDotNetCore.Models
{
    public class Hostel
    {
        public int HostelId { get; set; }
        public string HostelName { get; set; }
        public string TotalRooms { get; set; }
        public string TotalStudents { get; set; }
        public string Location{ get; set; }
        public int CampusId { get; set; }
    }
}
