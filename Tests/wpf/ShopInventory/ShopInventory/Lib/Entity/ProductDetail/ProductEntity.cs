using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopInventory.Lib.Entity.ProductDetail
{
    public class ProductEntity
    {
        public int ID { get; set; }
        public String ProductID { get; set; }
        public String ProductName { get; set; }
        public String MRP { get; set; }
        public String Vat { get; set; }
        public String Discount { get; set; }
    }
}
