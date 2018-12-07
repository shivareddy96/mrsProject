using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace mrsProject.Models
{
    public class OrderDetail
    {
        public Int32 OrderDetailID { get; set; }

        [Range(1, 1000, ErrorMessage = "Quantity must be between 1 and 1000")]
        public Int32 OrderQuantity { get; set; }

        public Decimal OrderDetailPrice { get; set; }

        public Decimal OrderExtendedPrice { get; set; }

        public Order Order { get; set; }

        public Book Book { get; set; }
    }
}
