using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConfigurationDotNetCore.Models
{
    public class LibraryBookRecord
    {
        public int ID { get; set; }
        public int LibraryId { get; set; }
        public int LibraryBookListId { get; set; }
        public string ShelfNo { get; set; }
        public DateTime EntryDate { get; set; }
        public string UserId { get; set; }
        public bool IsDeleted { get; set; }
        public bool IsActive { get; set; }
    }
}
