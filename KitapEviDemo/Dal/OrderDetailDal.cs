using KitapEviDemo.Entities;
using KitapEviDemo.Forms;
using KitapEviDemo.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KitapEviDemo.Dal
{
   public class OrderDetailDal
    {

        public List<OrderDetailListModel> OrderDetailList(int orderid)
        {
            using(NorthwindContext db = new NorthwindContext())
            {
                var result = (from item in db.OrderDetails
                              join item2 in db.Products on item.ProductID equals item2.ProductID
                              where item.OrderID == orderid
                              select new OrderDetailListModel
                              {
                                  DetailID = item.DetailID,
                                  OrderID = item.OrderID,
                                  Product = item2.ProductName,
                                  UnitPrice = item.UnitPrice,
                                  Quantity = item.Quantity,
                                  TotalPrice = item.UnitPrice * item.Quantity
                                  
                              }).ToList();

                return result;
            }
        }


        public void OrderDetailAdd(OrderDetail orderDetail)
        {
            using(NorthwindContext db = new NorthwindContext())
            {
                db.OrderDetails.Add(orderDetail);
                MessageBox.Show("Sipariş Detayı Başarıyla Eklendi!");
                db.SaveChanges();
            }
        }

        public void DetailDelete(int detailId)
        {
            using(NorthwindContext db = new NorthwindContext())
            {
                OrderDetail findDetail = db.OrderDetails.Find(detailId);  //VERİLEN IDDEN KAYITI BUL
                db.OrderDetails.Remove(findDetail);                       //VERİTABANINDAN SİL
                MessageBox.Show("Detay Başarıyla Silindi!");
                db.SaveChanges();
            }
        }
    }
}
