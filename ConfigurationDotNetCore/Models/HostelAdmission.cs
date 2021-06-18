using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConfigurationDotNetCore.Models
{
    public class HostelAdmission
    {
        public int HostelAdmissionId { get; set; }
        public int RoomId { get; set; }
        public int HostelId { get; set; }
        public int AdmissionId { get; set;}
        public int Fee { get; set; }
        public bool IsExpel { get; set; }
        public virtual Admission Admission { get; set; }
        public virtual Hostel Hostel { get; set; }
        public virtual Rooms Rooms{ get; set; }
        public virtual ICollection<HostelAttendance> HostelAttendances { get; set; }

    }
}
