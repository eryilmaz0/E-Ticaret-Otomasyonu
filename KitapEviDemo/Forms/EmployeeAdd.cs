using KitapEviDemo.Dal;
using KitapEviDemo.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KitapEviDemo.Forms
{
    public partial class EmployeeAdd : Form
    {
        public EmployeeAdd()
        {
            InitializeComponent();
        }


        EmployeeDal _employeeDal = new EmployeeDal();
        private void btnEmployeeAdd_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Personel Eklensin mi?", "Personel Ekleniyor...", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Employee employee = new Employee
                {
                    FirstName = tbxEmployeeAddName.Text,
                    LastName = tbxEmployeeAddLastname.Text,
                    City = tbxEmployeeAddCity.Text,
                    Country = tbxEmployeeAddCountry.Text,
                    HomePhone = tbxEmployeeAddPhone.Text

                };

                _employeeDal.EmployeeAdd(employee);
                
            }
        }
    }
}
