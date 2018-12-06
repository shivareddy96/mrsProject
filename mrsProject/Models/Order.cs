using mrsProject.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace mrsProject.Models
{
    public class Order
    {
        public Int32 OrderID { get; set; }

        public Int32 OrderNumber { get; set; }

        public DateTime OrderDate { get; set; }

        [Display(Name = "Order Subtotal")]
        [DisplayFormat(DataFormatString = "{0:C}")]
        public Decimal OrderSubtotal
        {
            get { return OrderDetails.Sum(od => od.OrderExtendedPrice); }
        }

        [Display(Name = "Order Total")]
        [DisplayFormat(DataFormatString = "{0:C}")]
        public Decimal OrderTotal
        {
            get { return OrderSubtotal + ShippingCost; }
        }
        public Decimal ShippingCostFirstBook = 3.50m;

        public Decimal ShippingCostNextBook = 1.50m;
       
        public Int32 TotalQuantityBooks
        {
            get { return OrderDetails.Sum(od => od.OrderQuantity); }
        }
        [Display(Name = "Shipping Cost")]
        [DisplayFormat(DataFormatString = "{0:C}")]
        public Decimal ShippingCost
        {
            get
            {
                if (TotalQuantityBooks == 1)
                {
                    return ShippingCost = ShippingCostFirstBook;
                }
                else
                {
                    return ShippingCost = ShippingCostFirstBook + ShippingCostNextBook * (TotalQuantityBooks - 1);
                }
            }
            set { }
        }

        public String OrderNotes { get; set; }

        public String PaymentMethod { get; set; }

        public Boolean PendingOrder { get; set; }

        public AppUser user { get; set; }

        public List<OrderDetail> OrderDetails { get; set; }

        public Order()
        {
            if (OrderDetails == null)
            {
                OrderDetails = new List<OrderDetail>();
            }
            OrderDate = System.DateTime.Today;
            
        }
    }
}
