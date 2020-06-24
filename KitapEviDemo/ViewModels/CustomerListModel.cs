using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KitapEviDemo.ViewModels
{
    public class CustomerListModel
    {
        public int CustomerID { get; set; }
        public string Name { get; set; }
        public string Lastname { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public int NumberOfOrders { get; set; }
    }
}
