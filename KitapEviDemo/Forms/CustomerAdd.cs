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
    public partial class CustomerAdd : Form
    {
        public CustomerAdd()
        {
            InitializeComponent();
        }

        CustomerDal _customerDal = new CustomerDal();

        private void btnCustomerAdd_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Müşteri Eklensin mi?", "Müşteri Ekleniyor...", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                Customer customer = new Customer
                {
                    CustomerName = tbxCustomerAddAd.Text,
                    CustomerLastname = tbxCustomerAddSoyad.Text,
                    City = tbxCustomerAddCountry.Text,
                    Country = tbxCustomerAddCountry.Text,
                    Adress = tbxCustomerAddAdres.Text,
                    Phone = tbxCustomerAddTel.Text

                };

                _customerDal.CustomerAdd(customer);
                
                
            }
        }
    }
}
