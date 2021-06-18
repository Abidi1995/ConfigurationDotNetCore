using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConfigurationDotNetCore.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string StudentName { get; set; }
        public string RollNo { get; set;}
        public string Domicile { get; set;}
        public string Gender { get; set;}
        public string Email { get; set;}
        public string Address { get; set; }
        public string CNIC { get; set;}
        public string FatherName { get; set;}
        public string FatherCnic { get; set;}
        public string MotherName { get; set;}
        public string PresentAddress { get; set;}
        public string Qualification { get; set; }
        public string MobileNo { get; set;}
        public string FatherOccupation { get; set; }
       

    }
}