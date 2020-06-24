using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KitapEviDemo.Entities
{
    public class Employee
    {
        public Employee()
        {
            Orders = new List<Order>();
        }

        [Key]
        public int EmployeeID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Adress { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string HomePhone { get; set; }

        public List<Order> Orders { get; set; }  //bir personelin bir çok siparişi
    }
}
