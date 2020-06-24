using KitapEviDemo.Entities;
using KitapEviDemo.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KitapEviDemo.Dal
{
   public class OrderDal
    {
        public List<OrderListModel> OrderList()
        {
            using(NorthwindContext db = new NorthwindContext())
            {
                var result = (from item in db.Orders
                              join item2 in db.Customers on item.CustomerID equals item2.CustomerID
                              join item3 in db.Employees on item.EmployeeID equals item3.EmployeeID
                              select new OrderListModel
                              {
                                  OrderID = item.OrderID,
                                  Customer = item2.CustomerName + " " +item2.CustomerLastname,
                                  Employee = item3.FirstName + " " +item3.LastName,
                                  ShipCity = item.ShipCity,
                                  ShipCountry = item.ShipCountry,
                                  ShipAdress = item.ShipAdress,
                                  OrderDate = item.OrderDate
                                  

                              }).ToList();

                return result;
            }
        }

        public void OrderAdd(Order order)
        {
            using(NorthwindContext db = new NorthwindContext())
            {
                try
                {
                    db.Orders.Add(order);
                    MessageBox.Show("Sipariş Başarıyla Oluşturuldu!");
                    db.SaveChanges();
                }

                catch
                {
                    MessageBox.Show("Bir Hata Oluştu.");
                }
                
            }
        }

        public void OrderDelete(int id)
        {
            using (NorthwindContext db = new NorthwindContext())
                try
                {
                    var result = db.Orders.Find(id);
                    db.Orders.Remove(result);
                    MessageBox.Show("Sipariş Başarıyla İptal Edildi!");
                    db.SaveChanges();
                }

                catch
                {
                    MessageBox.Show("Bir Hata Oluştu.");
                }
        }

        public Customer GetCustomerID(int orderid)
        {
            using(NorthwindContext db = new NorthwindContext())
            {
                Customer customerFind = db.Customers.Find(Convert.ToInt32(db.Orders.Find(orderid).CustomerID));  //CUSTOMER TABLOSUNDA BU İDDEKİ CUSTOMER'I, DEĞİŞKENE AT
                return customerFind;
            }
        }
        
        public void OrderUpdate(int id, Order order)
        {
            using (NorthwindContext db = new NorthwindContext())
            {
               Order findOrder = db.Orders.Find(id);
                findOrder.ShipCity = order.ShipCity;
                findOrder.ShipCountry = order.ShipCountry;
                findOrder.ShipAdress = order.ShipAdress;
                MessageBox.Show("Sipariş Başarıyla  Güncellendi!");
                db.SaveChanges();

            }
        }
    }
}
