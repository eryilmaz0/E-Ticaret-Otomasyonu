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
    public partial class EmployeeUpdate : Form
    {
        public EmployeeUpdate()
        {
            InitializeComponent();
        }

        EmployeeDal _employeeDal = new EmployeeDal();
        private void EmployeeUpdate_Load(object sender, EventArgs e)
        {
            dgEmployeeUpdate.DataSource = _employeeDal.EmployeeList();
        }

        private void dgEmployeeUpdate_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            tbxEmployeeUpdateName.Text = dgEmployeeUpdate.CurrentRow.Cells[1].Value.ToString();
            tbxEmployeeUpdateLastname.Text = dgEmployeeUpdate.CurrentRow.Cells[2].Value.ToString();
            tbxEmployeeUpdateCity.Text = dgEmployeeUpdate.CurrentRow.Cells[3].Value.ToString();
            tbxEmployeeUpdateCountry.Text = dgEmployeeUpdate.CurrentRow.Cells[4].Value.ToString();
            tbxEmployeeUpdatePhone.Text = dgEmployeeUpdate.CurrentRow.Cells[5].Value.ToString();
        }

        private void btnEmployeeUpdate_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Personel Güncellensin mi?", "Personel Güncelleniyor...", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Employee employee = new Employee
                {
                    FirstName = tbxEmployeeUpdateName.Text,
                    LastName = tbxEmployeeUpdateLastname.Text,
                    City = tbxEmployeeUpdateCity.Text,
                    Country = tbxEmployeeUpdateCountry.Text,
                    HomePhone = tbxEmployeeUpdatePhone.Text
                };

                _employeeDal.EmployeeUpdate(Convert.ToInt32(dgEmployeeUpdate.CurrentRow.Cells[0].Value), employee);  //PERSONELİ GÜNCELLE
                dgEmployeeUpdate.DataSource = _employeeDal.EmployeeList();   //DATAGRİDİ GÜNCELLE
            }
        }
    }
    }
    
    
    

