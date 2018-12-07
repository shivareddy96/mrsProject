using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace mrsProject.Models
{
    public class Review
    {
        public Int32 ReviewID { get; set; }

        [StringLength(maximumLength:5, ErrorMessage = "The Rating must be in between 1-5.", MinimumLength = 1)]        
        [Display(Name = "Rating")]        
        public Decimal Rating { get; set; }

        public Boolean? Approved { get; set; }

        [StringLength(maximumLength:100, ErrorMessage = "The Review must be under 100 characters.", MinimumLength = 1)]
        [Display(Name = "Review")]
        public String ReviewDescription { get; set; }

        public Boolean Pending { get; set; }

        public AppUser Author { get; set; }

        public AppUser Approver { get; set; }

        public Book book { get; set; }

        public Review()
        {
            Pending = true;
            Approved = null;
        }
    }
}
