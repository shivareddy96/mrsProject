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

        public String DiscountDescription { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public List<Order> Orders { get; set; }
    }
}
