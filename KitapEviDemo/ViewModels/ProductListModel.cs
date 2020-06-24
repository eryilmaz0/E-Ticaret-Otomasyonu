using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KitapEviDemo.ViewModels
{
    public class ProductListModel
    {
        
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public string Category { get; set; }
        public string Company { get; set; }
        public decimal Price { get; set; }
        public string QuantityPerUnit { get; set; }
    }
}
