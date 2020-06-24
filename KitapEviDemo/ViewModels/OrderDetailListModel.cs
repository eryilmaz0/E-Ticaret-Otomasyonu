using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KitapEviDemo.ViewModels
{
   public class OrderDetailListModel
    {
        public int DetailID { get; set; }
        public int OrderID { get; set; }
        public string Product { get; set; }
        public decimal UnitPrice { get; set; }
        public int Quantity { get; set; }
        public decimal TotalPrice { get; set; }

    }
}
