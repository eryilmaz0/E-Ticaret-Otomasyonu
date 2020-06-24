using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KitapEviDemo.ViewModels
{
    public class OrderListModel
    {
        public int OrderID { get; set; }
        public string Customer { get; set; }
        public string Employee { get; set; }
        public DateTime OrderDate { get; set; }
        public string ShipCity { get; set; }
        public string ShipCountry { get; set; }
        public string ShipAdress { get; set; }
    }
}
