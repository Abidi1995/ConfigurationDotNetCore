using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConfigurationDotNetCore.Models
{
    public class Rooms//table for Rooms Entry
    {
        public int Id { get; set; }
        public string Floor { get; set; }
        public string Capacity { get; set;}
        public int RoomNo { get; set;}
        public int HostelId { get; set;}
    }
}
