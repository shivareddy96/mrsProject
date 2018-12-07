using mrsProject.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mrsProject.Models
{
    

    public class Discount
    {
        

        public Int32 DiscountID { get; set; }

        public String CouponCode { get; set; }

        public Decimal DiscountNum { get; set; }
        
        public DiscountDescription DiscountType { get; set; }

        public Boolean DiscountActive { get; set; }

        public Boolean DiscountDescription { get; set; }
        
        public List<Order> Orders { get; set; }
    }
}
