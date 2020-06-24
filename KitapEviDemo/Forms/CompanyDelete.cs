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
    public partial class CompanyDelete : Form
    {
        public CompanyDelete()
        {
            InitializeComponent();
        }

        CompanyDal _companyDal = new CompanyDal();
        private void CompanyDelete_Load(object sender, EventArgs e)
        {
            dgCompanyDelete.DataSource = _companyDal.CompanyList();
        }

        private void dgCompanyDelete_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            lblCompanyDeleteName.Text = dgCompanyDelete.CurrentRow.Cells[1].Value.ToString();
            lblCompanyDeleteCount.Text = dgCompanyDelete.CurrentRow.Cells[2].Value.ToString();
        }

        private void btnCompanyDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Firma Silinsin mi?", "Firma Siliniyor...", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                _companyDal.CompanyDelete(Convert.ToInt32(dgCompanyDelete.CurrentRow.Cells[0].Value));
                dgCompanyDelete.DataSource = _companyDal.CompanyList();
            }
        }
    }
}
