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
    public partial class CompanyForm : Form
    {
        public CompanyForm()
        {
            InitializeComponent();
        }

        CompanyDal _companyDal = new CompanyDal();
        FormGecis _frmGecis = new FormGecis();

        private void CompanyForm_Load(object sender, EventArgs e)
        {
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is MdiClient)
                    ctrl.BackColor = Color.LightSlateGray;    //ARKAPLANI BOYAMA KODU             

            }

            //FORM YÜKLENİRKEN DATAGRİDİ GÜNCELLE 

            dgCompany.DataSource = _companyDal.CompanyList();


        }

        private void btnCompanyFilter_Click(object sender, EventArgs e)
        {
            dgCompany.DataSource = _companyDal.CompanyFilterbyCount(Convert.ToInt32(NumCompanyEnDusuk.Value), Convert.ToInt32(NumCompanyEnBuyuk.Value));
        }

        private void tbxCompanyFilter_TextChanged(object sender, EventArgs e)
        {
            string aranan = tbxCompanyFilter.Text;
            dgCompany.DataSource = _companyDal.CompanyList().Where(p => p.Company.ToUpper().Contains(aranan.ToUpper())).ToList();
        }

        private void CompanyForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnCompanyAdd_Click(object sender, EventArgs e)
        {
            CompanyAdd _companyAdd = new CompanyAdd();
            _frmGecis.OperantFormPass(_companyAdd);
        }

        private void btnCompanyRefresh_Click(object sender, EventArgs e)
        {
            dgCompany.DataSource = _companyDal.CompanyList();
        }

        private void btnCompanyDelete_Click(object sender, EventArgs e)
        {
            CompanyDelete companyDelete = new CompanyDelete();
            _frmGecis.OperantFormPass(companyDelete);
        }

        private void btnCompanyUpdate_Click(object sender, EventArgs e)
        {
            CompanyUpdate companyUpdate = new CompanyUpdate();
            _frmGecis.OperantFormPass(companyUpdate);
        }

        private void cATEGORIESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CategoryForm categoryForm = new CategoryForm();
            _frmGecis.MainFormPass(categoryForm, this);
        }

        private void pRODUCTSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProductsForm productsForm = new ProductsForm();
            _frmGecis.MainFormPass(productsForm, this);
        }

        private void cUSTOMERSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CustomerForm customerForm = new CustomerForm();
            _frmGecis.MainFormPass(customerForm, this);
        }

        private void eMPLOYEESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EmployeesForm employeesForm = new EmployeesForm();
            _frmGecis.MainFormPass(employeesForm, this);
        }

        private void oRDERSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OrdersForm ordersForm = new OrdersForm();
            _frmGecis.MainFormPass(ordersForm,this);
            
        }
    }
}
