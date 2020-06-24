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
    public partial class CustomerUpdate : Form
    {
        public CustomerUpdate()
        {
            InitializeComponent();
        }

        CustomerDal _customerDal = new CustomerDal();

        private void CustomerUpdate_Load(object sender, EventArgs e)
        {
            dgCustomerUpdate.DataSource = _customerDal.CustomerList();
        }

        private void dgCustomerUpdate_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            tbxCustomerUpdateName.Text = dgCustomerUpdate.CurrentRow.Cells[1].Value.ToString();
            tbxCustomerUpdateLastName.Text = dgCustomerUpdate.CurrentRow.Cells[2].Value.ToString();
            tbxCustomerUpdateCity.Text = dgCustomerUpdate.CurrentRow.Cells[3].Value.ToString();
            tbxCustomerUpdateCountry.Text = dgCustomerUpdate.CurrentRow.Cells[4].Value.ToString();
            tbxCustomerUpdateAdress.Text = dgCustomerUpdate.CurrentRow.Cells[5].Value.ToString();
            tbxCustomerUpdatePhone.Text = dgCustomerUpdate.CurrentRow.Cells[6].Value.ToString();
        }

        private void btnCustomerUpdate_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Müşteri Güncellensin mi?", "Müşteri Güncelleniyor...", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Customer customer = new Customer
                {
                    CustomerName = tbxCustomerUpdateName.Text,
                    CustomerLastname = tbxCustomerUpdateLastName.Text,
                    City = tbxCustomerUpdateCity.Text,
                    Country = tbxCustomerUpdateCountry.Text,
                    Adress = tbxCustomerUpdateAdress.Text,
                    Phone = tbxCustomerUpdatePhone.Text
                };

                _customerDal.CustomerUpdate(Convert.ToInt32(dgCustomerUpdate.CurrentRow.Cells[0].Value), customer); //MÜŞTERİYİ GÜNCELLE
                dgCustomerUpdate.DataSource = _customerDal.CustomerList();  //DATAGRİDİ GÜNCELLE

            }
        }
    }
}
