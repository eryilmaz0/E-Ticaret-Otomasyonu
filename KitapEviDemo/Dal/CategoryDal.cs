using KitapEviDemo.Entities;
using KitapEviDemo.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KitapEviDemo
{
    public class CategoryDal
    {


        public List<CategoryMainListModel> CategoryList()
        {
            using(NorthwindContext db = new NorthwindContext())
            {
                var result = (from item in db.Categories
                              join item2 in db.Products on item.CategoryID equals item2.CategoryID into g
                              select new CategoryMainListModel
                              {
                                  CategoryID = item.CategoryID,
                                  Category = item.CategoryName,
                                  NumberOfProducts = g.Count()
                              }).ToList();

                return result;
            }
        }

        ProductDal _productDal = new ProductDal();

        public List<CategoryListModel> CategoryComboBox()
        {
            using (NorthwindContext db = new NorthwindContext())
            {
                var result = (from item in db.Categories
                              select new CategoryListModel
                              {
                                  CategoryID = item.CategoryID,
                                  Category = item.CategoryName
                              }).ToList();
                return result;
            }
        }

        

           

        public List<CategoryMainListModel> CategoryFilterbyCount(decimal x, decimal y)
        {
            using(NorthwindContext db = new NorthwindContext())
            {
                var result = (from item in db.Categories                            
                              join item2 in db.Products on item.CategoryID equals item2.CategoryID into g
                              where g.Count() >= x && g.Count() <= y
                              orderby g.Count()
                              select new CategoryMainListModel
                              {
                                  CategoryID = item.CategoryID,
                                  Category = item.CategoryName,
                                  NumberOfProducts = g.Count()
                              }).ToList();

                return result;
            }
        }

        public void CategoryAdd(Category category)
        {
            try
            {
                using (NorthwindContext db = new NorthwindContext())
                {
                    db.Categories.Add(category);
                    MessageBox.Show("Kategori Başarıyla Veritabanına Eklendi!");
                    db.SaveChanges();
                }
            }

            catch
            {
                MessageBox.Show("İşlem Başarısız. Tekrar Deneyin");
            }
        }

        public void CategoryDelete(int id)
        {
            try
            {
                using (NorthwindContext db = new NorthwindContext())
                {
                    var findCategory = db.Categories.Find(id);
                    db.Categories.Remove(findCategory);
                    MessageBox.Show("Kategori Başarıyla Silindi!");
                    db.SaveChanges();
                }
            }

            catch
            {
                MessageBox.Show("İşlem Başarısız. Tekrar Deneyin");
            }
        }

        public void CategoryUpdate(int id,Category category)
        {
            try
            {
                using (NorthwindContext db = new NorthwindContext())
                {
                    var findCategory = db.Categories.Find(id);

                    findCategory.CategoryName = category.CategoryName;
                    MessageBox.Show("Kategori Başarıyla Güncellendi!");
                    db.SaveChanges();
                }
            }

            catch
            {
                MessageBox.Show("İşlem Başarısız. Tekrar Deneyin");
            }
        }

        
       
            
        }


   
    


    }

    

    
