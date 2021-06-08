using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConfigurationDotNetCore.Models
{
    public class HostelAttendance
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public int AttendanceTypeId { get; set; }
        public int HostelId { get; set; }
        public int HostleAdmId { get; set; }

        public virtual Hostel Hostel { get; set; }
        public virtual HostelAdmission HostelAdmission { get; set; }
        public virtual StudentAttendanceType StudentAttendanceType { get; set; }
    }
}
