using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConfigurationDotNetCore.Models
{
    public class StudentAttendance
    {

        public int ID { get; set; }
        public DateTime AttendanceDate { get; set; }
        public int AdmissionID { get; set; }
        public double FineAmount { get; set; }
        public int AttendanceTypeID{ get; set; }
        public string UserID{ get; set; }
        public bool ? Sendmessage{ get; set; }
        public bool ? Manual{ get; set; }

        public virtual Admission Admission { get; set; }
       
        public virtual StudentAttendanceType StudentAttendanceType { get; set; }

    }
}
