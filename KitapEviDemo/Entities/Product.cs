using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KitapEviDemo.Entities
{
    public class Product
    {
        public Product()
        {
            OrderDetails = new List<OrderDetail>();
        }

        [Key]
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public int CategoryID { get; set; }
        public string QuantityPerUnit { get; set; }
        public decimal Price { get; set; }
        public int CompanyID { get; set; }

        public Category Category { get; set; }  //bir ürünün bir kategorisi
        public Company Company { get; set; }    //bir ürün bir şirkete ait
        public List<OrderDetail> OrderDetails { get; set; }  //bir ürünün bir çok detayı
    }
}
