using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KitapEviDemo.Entities
{
    public class OrderDetail
    {
        [Key]
        public int DetailID { get; set; }
        public int OrderID { get; set; }
        public int ProductID { get; set; }
        public decimal UnitPrice { get; set; }
        public int Quantity { get; set; }
        public bool Discount { get; set; }

        public Order Order { get; set; }  //bir detay bir siparişe ait
        public Product Product { get; set; }  //bir detayın bir ürünü
    }
}
