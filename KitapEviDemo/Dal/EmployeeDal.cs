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
    public class EmployeeDal
    {


        public List<EmployeeComboBoxListModel> EmployeeComboBox()
        {
            using(NorthwindContext db = new NorthwindContext())
            {
                var result = (from item in db.Employees
                              select new EmployeeComboBoxListModel
                              {
                                  EmployeeID = item.EmployeeID,
                                  Employee = item.FirstName + " " + item.LastName
                              }).ToList();

                return result;
            }
        }

        public List<EmployeeListModel> EmployeeList()
        {
            using(NorthwindContext db = new NorthwindContext())
            {
                var result = (from item in db.Employees
                              join item2 in db.Orders on item.EmployeeID equals item2.EmployeeID into g
                              select new EmployeeListModel
                              {
                                  EmployeeID = item.EmployeeID,
                                  Name = item.FirstName,
                                  LastName = item.LastName,
                                  City = item.City,
                                  Country = item.Country,
                                  Phone = item.HomePhone,
                                  NumberOfOrders = g.Count()
                              }).ToList();

                return result;
            }
        }


        public List<EmployeeListModel> EmployeeFilterbyCount(int x, int y)
        {
            using(NorthwindContext db = new NorthwindContext())
            {
                var result = (from item in db.Employees
                              join item2 in db.Orders on item.EmployeeID equals item2.EmployeeID into g
                              where g.Count() >= x && g.Count() <= y
                              orderby g.Count()
                              select new EmployeeListModel
                              {
                                  EmployeeID = item.EmployeeID,
                                  Name = item.FirstName,
                                  LastName = item.LastName,
                                  City = item.City,
                                  Country = item.Country,
                                  Phone = item.HomePhone,
                                  NumberOfOrders = g.Count()
                              }).ToList();

                return result;
            }
        }

        public void EmployeeAdd(Employee employee)
        {
            using (NorthwindContext db = new NorthwindContext())
            {
                db.Employees.Add(employee);
                MessageBox.Show("Personel Başarıyla Eklendi!");
                db.SaveChanges();
            }
        }


        public void EmployeeDelete(int id)
        {
            using (NorthwindContext db = new NorthwindContext())
            {
                var findEmployee = db.Employees.Find(id);
                db.Employees.Remove(findEmployee);
                MessageBox.Show("Personel Başarıyla Silindi!");
                db.SaveChanges();
            }
        }

        public void EmployeeUpdate(int id, Employee employee)
        {
            using(NorthwindContext db = new NorthwindContext())
            {
                var findEmployee = db.Employees.Find(id);
                findEmployee.FirstName = employee.FirstName;
                findEmployee.LastName = employee.LastName;
                findEmployee.City = employee.City;
                findEmployee.Country = employee.Country;
                findEmployee.HomePhone = employee.HomePhone;

                MessageBox.Show("Personel Başarıyla Güncellendi!");
                db.SaveChanges();
            }
        }
    }
}
