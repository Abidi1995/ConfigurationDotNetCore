using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ConfigurationDotNetCore.Models
{
    public class Company
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Plz Enter Company Name")]
        public string CompanyName { get; set; }
        [Required(ErrorMessage = "Plz Enter Registeration No Name")]
        public string RegisterationNo { get; set; }
        [Required(ErrorMessage = "Plz Enter Company Type")]
        public string CompanyType { get; set; }
        [Required(ErrorMessage = "Plz Enter Company Address")]
        public string Address { get; set; }
        [Required(ErrorMessage = "Plz Enter No of Employees")]
        public string NoOfEmployees { get; set; }
        [Required(ErrorMessage = "Plz Enter NtN No")]
        public string CompanyNtNnO { get; set; }
        [Required(ErrorMessage = "Plz Enter Company Website")]
        public String CompanyWebsite { get; set; }
    }
}
