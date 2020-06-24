using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KitapEviDemo.Entities
{
    public class Customer
    {
        public Customer()
        {
            Orders = new List<Order>();
        }

        [Key]
        public int CustomerID { get; set; }
        public string CustomerName { get; set; }
        public string CustomerLastname { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string Adress { get; set; }
        public string Phone { get; set; }

        public List<Order> Orders { get; set; }   //müşterilerin siparişleri
    }
}
