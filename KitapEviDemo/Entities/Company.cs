using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KitapEviDemo.Entities
{
    public class Company
    {
        public Company()
        {
            Products = new List<Product>();
        }

        public int CompanyID { get; set; }
        public string CompanyName { get; set; }

        public List<Product> Products { get; set; }
    }
}
