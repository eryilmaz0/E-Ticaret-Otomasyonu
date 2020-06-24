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
    public partial class CompanyAdd : Form
    {
        public CompanyAdd()
        {
            InitializeComponent();
        }

        CompanyDal _companyDal = new CompanyDal();

        private void btnCompanyAdd_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Firma Eklensin mi?", "Firma Ekleniyor...", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Company company = new Company
                {
                    CompanyName = tbxCompanyAdd.Text
                };

                _companyDal.CompanyAdd(company);
                
               
            }
        }
    }
}
