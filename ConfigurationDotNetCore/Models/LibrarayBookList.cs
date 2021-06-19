using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ConfigurationDotNetCore.Models
{
    public class LibrarayBookList
    {
        [Key]
        public int LibrayBookListID{ get; set; }
        public string AccessionNo{ get; set; }
        public string ClassificationNo{ get; set; }
        public string Title{ get; set; }
        public string Author { get; set;}
        public string Publisher { get; set; }
        public string Edition { get; set;}
        public string Subject { get; set; }
        public DateTime YearOfPublishing { get; set;}
        public string VolumeNo { get; set;}
        public string Language { get; set; }
        public string Source { get; set;}
        public string Pages { get; set;}
        public string PresentPosition { get; set;}
        public bool IsIssuable{ get; set; }
        public string Remarks { get; set; }
        public DateTime EntryDate{ get; set; }
        public DateTime TranslatorCorner{ get; set; }
    }
}
