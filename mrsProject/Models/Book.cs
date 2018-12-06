using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mrsProject.Models
{
    public enum SortOptions { Title, Author, NumPurchased, New, Old, Rated }
    public class Book
    {
        public Int32 BookID { get; set; }

        public Int32 BookUniqueID { get; set; }

        public String Title { get; set; }

        public String Author { get; set; }

        public Boolean ItemInStock { get; set; }

        public Int32 NumPurchased { get; set; }

        public Int32 NumInStock { get; set; }

        public Decimal SimpleRating { get; set; }

        public DateTime LastOrderDate { get; set; }

        public Boolean ActiveStatus { get; set; }

        public Decimal Price { get; set; }

        public Decimal Cost { get; set; }

        public Int32 ReOrder { get; set; }

        public String BookDescription { get; set; }

        public DateTime PublicationDate { get; set; }

        //Add Genre and run a migration

        public List<Review> Reviews { get; set; }

        public List<OrderDetail> OrderDetails { get; set; }

        public Inventory Inventory { get; set; }

        public Genre Genre {get; set;}

        public Book()
        {
            if (Reviews == null)
            {
                Reviews = new List<Review>();
            }

            if (OrderDetails == null)
            {
                OrderDetails = new List<OrderDetail>();
            }

        }
    }
}
