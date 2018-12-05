using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mrsProject.Models
{
    public enum ReorderStatus { Manual, Automatic }

    public class Inventory
    {
        public Int32 InventoryID { get; set; }

        public Decimal ReorderPrice { get; set; }

        public Int32 InventoryQuantity { get; set; }

        public Int32 ReorderPoint { get; set; }

        public List<AppUser> Users { get; set; }

        public List<Book> Books { get; set; }
    }
}
