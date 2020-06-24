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
    public partial class CategoryForm : Form
    {
        public CategoryForm()
        {
            InitializeComponent();
        }

        ProductDal _productDal = new ProductDal();
        CategoryDal _categoryDal = new CategoryDal();
        CompanyDal _companyDal = new CompanyDal();
        FormGecis _frmGecis = new FormGecis();

        private void CategoryForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void pRODUCTSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProductsForm productsForm = new ProductsForm();
            _frmGecis.MainFormPass(productsForm, this);
        }

        private void CategoryForm_Load(object sender, EventArgs e)
        {
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is MdiClient)
                    ctrl.BackColor = Color.LightSlateGray;    //ARKAPLANI BOYAMA KODU             
                
            }

            Categorydg.DataSource = _categoryDal.CategoryList();



        }

        private void CategoryFilterBtn_Click(object sender, EventArgs e)
        {
            Categorydg.DataSource = _categoryDal.CategoryFilterbyCount(Convert.ToDecimal(CategoryEnKucukNum.Value), (Convert.ToDecimal(CategoryEnBuyukNum.Value)));
        }

        private void tbxCategoryFilter_TextChanged(object sender, EventArgs e)
        {
            string aranan = tbxCategoryFilter.Text;
            Categorydg.DataSource = _categoryDal.CategoryList().Where(p => p.Category.ToUpper().Contains(aranan.ToUpper())).ToList();
            
        }

        private void btnCategoryAdd_Click(object sender, EventArgs e)
        {
            CategoryAdd _categoryAdd = new CategoryAdd();
            _frmGecis.OperantFormPass(_categoryAdd);
        }

        private void btnCategoryReset_Click(object sender, EventArgs e)
        {
            Categorydg.DataSource = _categoryDal.CategoryList();
        }

        private void btnCategoryDelete_Click(object sender, EventArgs e)
        {
            CategoryDelete _categoryDelete = new CategoryDelete();
            _frmGecis.OperantFormPass(_categoryDelete);
        }

        private void btnCategoryUpdate_Click(object sender, EventArgs e)
        {
            CategoryUpdate _categoryUpdate = new CategoryUpdate();
            _frmGecis.OperantFormPass(_categoryUpdate);
        }

        private void cOMPANIESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CompanyForm companyForm = new CompanyForm();
            _frmGecis.MainFormPass(companyForm, this);
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
            _frmGecis.MainFormPass(ordersForm, this);
        }
    }
}
