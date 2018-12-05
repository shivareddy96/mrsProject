using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mrsProject.Models
{
    public class Review
    {
        public Int32 ReviewID { get; set; }

        public Decimal Rating { get; set; }

        public Boolean Approved { get; set; }

        public String ReviewDescription { get; set; }

        public AppUser Author { get; set; }

        public AppUser Approver { get; set; }

        public Book book { get; set; }
    }
}
