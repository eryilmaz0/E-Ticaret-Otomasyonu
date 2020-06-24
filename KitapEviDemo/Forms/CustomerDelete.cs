using KitapEviDemo.Dal;
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
    public partial class CustomerDelete : Form
    {
        public CustomerDelete()
        {
            InitializeComponent();
        }

        CustomerDal _customerDal = new CustomerDal();

        private void dgCustomerDelete_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            lblCustomerDeleteAd.Text = dgCustomerDelete.CurrentRow.Cells[1].Value.ToString();
            lblCustomerDeleteSoyad.Text = dgCustomerDelete.CurrentRow.Cells[2].Value.ToString();
            lblCustomerDeleteCity.Text = dgCustomerDelete.CurrentRow.Cells[3].Value.ToString();
            lblCustomerDeleteCountry.Text = dgCustomerDelete.CurrentRow.Cells[4].Value.ToString();
            lblCustomerDeletePhone.Text = dgCustomerDelete.CurrentRow.Cells[6].Value.ToString();
        }

        private void CustomerDelete_Load(object sender, EventArgs e)
        {
            dgCustomerDelete.DataSource = _customerDal.CustomerList();
        }

        private void btnCustomerDelete_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Müşteri Silinsin mi?", "Müşteri Siliniyor...", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                _customerDal.CustomerDelete(Convert.ToInt32(dgCustomerDelete.CurrentRow.Cells[0].Value));
                dgCustomerDelete.DataSource = _customerDal.CustomerList();
            }
        }
    }
}
