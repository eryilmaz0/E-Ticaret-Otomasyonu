using KitapEviDemo.Entities;
using KitapEviDemo.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KitapEviDemo
{
    public class CompanyDal
    {
        public List<CompanyListModel> CompanyComboBox()
        {
            using (NorthwindContext db = new NorthwindContext())
            {
                var result = (from item in db.Companies
                              select new CompanyListModel
                              {
                                  CompanyID = item.CompanyID,
                                  Company = item.CompanyName
                              }).ToList();

                return result;
            }

        }

        public List<CompanyMainListModel> CompanyList()
        {
            using(NorthwindContext db = new NorthwindContext())
            {
                var result = (from item in db.Companies
                              join item2 in db.Products on item.CompanyID equals item2.CompanyID into g
                              select new CompanyMainListModel
                              {
                                  CompanyID = item.CompanyID,
                                  Company = item.CompanyName,
                                  NumberOfProduct = g.Count()   //İTEM DEKİ COMPANY ID İTEM2 DEKİ COMPANY IDYE EŞİT OLANLARIN SAYISI
                              }).ToList();

                return result;
            }
        }


        public List<CompanyMainListModel> CompanyFilterbyCount(int x, int y)
        {
            using (NorthwindContext db = new NorthwindContext())
            {
                var result = (from item in db.Companies
                              join item2 in db.Products on item.CompanyID equals item2.CompanyID into g
                              where g.Count() >= x && g.Count() <= y
                              orderby g.Count()
                              select new CompanyMainListModel
                              {
                                  CompanyID = item.CompanyID,
                                  Company = item.CompanyName,
                                  NumberOfProduct = g.Count()
                              }).ToList();

                return result;
            }
        }

        public void CompanyAdd(Company company)
        {
            using (NorthwindContext db = new NorthwindContext())
            {
                db.Companies.Add(company);
                MessageBox.Show("Firma Başarıyla Eklendi!");
                db.SaveChanges();
            }
        }

        public void CompanyDelete(int id)
        {
            using(NorthwindContext db = new NorthwindContext())
            {
                var findCompany = db.Companies.Find(id);
                db.Companies.Remove(findCompany);
                MessageBox.Show("Firma Başarıyla Silindi!");
                db.SaveChanges();
            }
        }

        public void CompanyUpdate(int id, Company company)
        {
            using(NorthwindContext db = new NorthwindContext())
            {
                var findCompany = db.Companies.Find(id);
                findCompany.CompanyName = company.CompanyName;
                MessageBox.Show("Firma Başarıyla Güncellendi!");
                db.SaveChanges();
                

                
            }
        }
    }

   
}
