using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConfigurationDotNetCore.Models
{
    public class StudentAttendanceType
    {

        public int ID { get; set; }
        public string AttendanceName { get; set; }
        public double Fine { get; set; }
        public string Code { get; set; }
        public virtual ICollection<StudentAttendance> StudentAttendances { get; set; }
        public virtual ICollection<HostelAdmission> HostelAdmissions { get; set; }
    }
}
