using KitapEviDemo.Entities;
using KitapEviDemo.ViewModels;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.XPath;

namespace KitapEviDemo
{
    public class ProductDal
    {

        public List<ProductListModel> ProductsList()
        {
            using (NorthwindContext db = new NorthwindContext())
            {
                var result = (from item in db.Products
                              join item2 in db.Categories on item.CategoryID equals item2.CategoryID
                              join item3 in db.Companies on item.CompanyID equals item3.CompanyID
                              select new ProductListModel
                              {
                                  ProductID = item.ProductID,
                                  ProductName = item.ProductName,
                                  Category = item2.CategoryName,
                                  Company = item3.CompanyName,
                                  Price = item.Price,
                                  QuantityPerUnit = item.QuantityPerUnit

                              }).ToList();

                return result;

            }


        }


        public List<ProductListModel> productFilterbyCategory(int id)
        {
            using (NorthwindContext db = new NorthwindContext())
            {
                var result = (from item in db.Products
                              join item2 in db.Categories on item.CategoryID equals item2.CategoryID
                              join item3 in db.Companies on item.CompanyID equals item3.CompanyID
                              where item.CategoryID == id

                              select new ProductListModel
                              {
                                  ProductID = item.ProductID,
                                  ProductName = item.ProductName,
                                  Category = item2.CategoryName,
                                  Company = item3.CompanyName,
                                  Price = item.Price,
                                  QuantityPerUnit = item.QuantityPerUnit
                              }).ToList();

                return result;
            }
        }

        public List<ProductListModel> ProductFilterbyCompany(int id)
        {
            using(NorthwindContext db = new NorthwindContext())
            {
                var result = (from item in db.Products
                              join item2 in db.Categories on item.CategoryID equals item2.CategoryID
                              join item3 in db.Companies on item.CompanyID equals item3.CompanyID
                              where item.CompanyID == id
                              select new ProductListModel
                              {
                                  ProductName = item.ProductName,
                                  Category = item2.CategoryName,
                                  Company = item3.CompanyName,
                                  Price = item.Price,
                                  QuantityPerUnit = item.QuantityPerUnit
                              }).ToList();

                return result;
            }
        }

        public List<ProductListModel> ProductFilterByPrice(decimal x, decimal y)
        {
            using (NorthwindContext db = new NorthwindContext())
            {
                var result = (from item in db.Products
                              join item2 in db.Categories on item.CategoryID equals item2.CategoryID
                              join item3 in db.Companies on item.CompanyID equals item3.CompanyID
                              where item.Price >= x && item.Price <= y
                              orderby item.Price
                              select new ProductListModel
                              {
                                  ProductID = item.ProductID,
                                  ProductName = item.ProductName,
                                  Category = item2.CategoryName,
                                  Company = item3.CompanyName,
                                  Price = item.Price,
                                  QuantityPerUnit = item.QuantityPerUnit
                              }).ToList();

                return result;
            }


        }

        public void ProductAdd(Product product)
        {
            using (NorthwindContext db = new NorthwindContext())
            {
                try
                {
                    db.Products.Add(product);
                    MessageBox.Show("Ürün Başarıyla Eklendi!");
                    db.SaveChanges();
                }

                catch
                {
                    MessageBox.Show("Lütfen Tüm alanları doldurunuz.");
                }
            }

        }

        public void ProductDelete(int id)
        {
            using (NorthwindContext db = new NorthwindContext())
            {
                try
                {
                    var findProduct = db.Products.Find(id);
                    db.Products.Remove(findProduct);
                    MessageBox.Show("Ürün Başarıyla Silindi!");
                    db.SaveChanges();
                }

                catch
                {
                    MessageBox.Show("Birşeyler Yanlış Gitti.");
                    ;
                }
            }

            
        }

        public void ProductUpdate(int id,Product product)
        {
            using(NorthwindContext db = new NorthwindContext())
            {
                var findProduct = db.Products.Find(id);   //ÜRÜNÜ BULDUN. ŞİMDİ GELEN NESNEYE GÖRE GÜNCELLE
                findProduct.ProductName = product.ProductName;
                findProduct.CategoryID = product.CategoryID;
                findProduct.CompanyID = product.CompanyID;
                findProduct.Price = product.Price;
                findProduct.QuantityPerUnit = product.QuantityPerUnit;
                MessageBox.Show("Ürün Başarıyla Güncellendi!");
                db.SaveChanges();

            }
        }

        public List<ProductComboBoxListModel> ProductComboBox()
        {
            using(NorthwindContext db = new NorthwindContext())
            {
                var result = (from item in db.Products
                              join item2 in db.Companies on item.CompanyID equals item2.CompanyID
                              select new ProductComboBoxListModel
                              {
                                  ProductID = item.ProductID,
                                  Product = item.ProductName + " - " +item2.CompanyName
                                  
                                  
                              }).ToList();

                return result;
            }
        }

        public decimal ProductPrice(int productid)
        {
            using(NorthwindContext db = new NorthwindContext())
            {
                return db.Products.Find(productid).Price;

            }
        }

        
        }
    }

