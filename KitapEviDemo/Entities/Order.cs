using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KitapEviDemo.Entities
{
    public class Order
    {
        public Order()
        {
            OrderDetails = new List<OrderDetail>();
        }

        [Key]
        public int OrderID { get; set; }
        public int CustomerID { get; set; }
        public int EmployeeID { get; set; }
        public DateTime OrderDate { get; set; }
        public string ShipCity { get; set; }
        public string ShipCountry { get; set; }
        public string ShipAdress { get; set; }

        public Customer Customer { get; set; }  //bir siparişin bir müşterisi
        public Employee Employee { get; set; }  //bir ürünü götüren bir personel
        public List<OrderDetail> OrderDetails { get; set; }  //bir siparişin bir çok detayı
    }
}
