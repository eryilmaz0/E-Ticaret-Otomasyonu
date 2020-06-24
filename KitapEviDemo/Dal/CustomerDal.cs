using KitapEviDemo.Entities;
using KitapEviDemo.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KitapEviDemo.Dal
{
    public class CustomerDal
    {

 

        public List<CustomerComboBoxListModel> CustomerComboBox()
        {
            using(NorthwindContext db = new NorthwindContext())
            {
                var result = (from item in db.Customers
                              select new CustomerComboBoxListModel
                              {
                                  CustomerID = item.CustomerID,
                                  Customer = item.CustomerName + " " + item.CustomerLastname
                              }).ToList();

                return result;
            }
        }

        public List<CustomerListModel> CustomerList()
        {
            using(NorthwindContext db = new NorthwindContext())
            {
                var result = (from item in db.Customers
                              join item2 in db.Orders on item.CustomerID equals item2.CustomerID into g
                              select new CustomerListModel
                              {
                                  CustomerID = item.CustomerID,
                                  Name = item.CustomerName,
                                  Lastname = item.CustomerLastname,
                                  City = item.City,
                                  Country = item.Country,
                                  Address = item.Adress,
                                  Phone = item.Phone,
                                  NumberOfOrders = g.Count()
                              }).ToList();

                return result;
            }
        }

        public List<CustomerListModel> CustomerFilterbyOrder(int x, int y)
        {
            using (NorthwindContext db = new NorthwindContext())
            {
                var result = (from item in db.Customers
                              join item2 in db.Orders on item.CustomerID equals item2.CustomerID into g
                              where g.Count() >= x && g.Count() <= y
                              orderby g.Count()
                              select new CustomerListModel
                              {
                                  CustomerID = item.CustomerID,
                                  Name = item.CustomerName,
                                  Lastname = item.CustomerLastname,
                                  City = item.City,
                                  Country = item.Country,
                                  Address = item.Adress,
                                  Phone = item.Phone,
                                  NumberOfOrders = g.Count()
                              }).ToList();

                return result;
            }
        }

        public void CustomerAdd(Customer customer)
        {
            try
            {
                using (NorthwindContext db = new NorthwindContext())
                {
                    db.Customers.Add(customer);
                    MessageBox.Show("Müşteri Başarıyla Eklendi!");
                    db.SaveChanges();
                }
            }
            catch
            {
                MessageBox.Show("Bir Hata Oluştu.");
            }
        }

        public void CustomerDelete(int id)
        {
            try
            {
                using (NorthwindContext db = new NorthwindContext())
                {
                    var findCustomer = db.Customers.Find(id);
                    db.Customers.Remove(findCustomer);
                    MessageBox.Show("Müşteri Başarıyla Silindi!");
                    db.SaveChanges();
                }
            }

            catch
            {
                MessageBox.Show("Bir hata oluştu.");
            }
        }


        public void CustomerUpdate(int id, Customer customer)
        {
            try {
                using (NorthwindContext db = new NorthwindContext())
                {
                    var findCustomer = db.Customers.Find(id);
                    findCustomer.CustomerName = customer.CustomerName;
                    findCustomer.CustomerLastname = customer.CustomerLastname;
                    findCustomer.City = customer.City;
                    findCustomer.Country = customer.Country;
                    findCustomer.Adress = customer.Adress;
                    findCustomer.Phone = customer.Phone;

                    MessageBox.Show("Müşteri Başarıyla Güncellendi!");
                    db.SaveChanges();
                }
            }

            catch
            {
                MessageBox.Show("Bir Hata Oluştu.");
            }
            }

       

        public Customer CustomerChecked(int customerid)
        {
            using(NorthwindContext db = new NorthwindContext())
            {
                Customer findCustomer = db.Customers.Find(customerid);
                return findCustomer;
            }
        }
    }
}
