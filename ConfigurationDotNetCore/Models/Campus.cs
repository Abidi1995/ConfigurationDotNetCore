using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConfigurationDotNetCore.Models
{
    public class Campus
    {
        public int ID { get; set; }
        public string CampusName { get; set; }
        public string MailingName { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Mobile { get; set; }
        public string EmailId { get; set; }
        public string Web { get; set; }
    }
}
