using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace mrsProject.Models

{
    
    public class AppUser : IdentityUser
    {


        public CardType CreditCard1Type { get; set; }
        public CardType CreditCard2Type { get; set; }
        public CardType CreditCard3Type { get; set; }

        public String FirstName { get; set; }
        
        public String LastName { get; set; }

        public Boolean ActiveStatus { get; set; }

        public String Address { get; set; }

        public String City { get; set; }

        public String State { get; set; }

        public String Zipcode { get; set; }
     
        public String CreditCard1 { get; set; }

        public String CreditCard2 { get; set; }

        public String CreditCard3 { get; set; }
        

        public String SeedPassword { get; set; }

        public String TempRole { get; set; }

        //Nav properties
        public List<Order> Orders { get; set; }

        [InverseProperty("Author")]
        public List<Review> ReviewsWritten { get; set; }

        [InverseProperty("Approver")]
        public List<Review> ReviewsApproved { get; set; }

    }
}
