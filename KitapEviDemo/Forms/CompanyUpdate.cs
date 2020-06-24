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
    public partial class CompanyUpdate : Form
    {
        public CompanyUpdate()
        {
            InitializeComponent();
        }

        CompanyDal _companyDal = new CompanyDal();

        private void CompanyUpdate_Load(object sender, EventArgs e)
        {
            dgCompanyUpdate.DataSource = _companyDal.CompanyList();
        }

        private void dgCompanyUpdate_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            tbxCompanyUpdate.Text = dgCompanyUpdate.CurrentRow.Cells[1].Value.ToString();
        }

        private void btnCompanyUpdate_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Firma Güncellensin mi?", "Firma Güncelleniyor...", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Company company = new Company
                {
                    CompanyName = tbxCompanyUpdate.Text
                };

                _companyDal.CompanyUpdate(Convert.ToInt32(dgCompanyUpdate.CurrentRow.Cells[0].Value), company);
                dgCompanyUpdate.DataSource = _companyDal.CompanyList();
            }
        }
    }
}
