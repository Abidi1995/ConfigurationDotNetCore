using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConfigurationDotNetCore.Models
{
    public class LibraryIssuedBooksToStaff
    {
        public int ID { get; set; }
        public int LibraryBookRecordId { get; set; }
        public decimal StaffID { get; set; }
        public DateTime IssuedDate { get; set; }
        public DateTime DueDate { get; set; }
        public string UserID { get; set; }
        public DateTime ReturnDate { get; set; }
        public string BookCondition { get; set; }
        public string Remarks { get; set; }
    }
}
