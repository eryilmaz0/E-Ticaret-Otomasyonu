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
    public partial class CustomerForm : Form
    {
        public CustomerForm()
        {
            InitializeComponent();
        }

        CustomerDal _customerDal = new CustomerDal();
        FormGecis _frmGecis = new FormGecis();
        private void CustomerForm_Load(object sender, EventArgs e)
        {
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is MdiClient)
                    ctrl.BackColor = Color.LightSlateGray;    //ARKAPLANI BOYAMA KODU
            }

          dgCustomer.DataSource = _customerDal.CustomerList();

        }

        private void CustomerForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnCustomerFilter_Click(object sender, EventArgs e)
        {
            dgCustomer.DataSource = _customerDal.CustomerFilterbyOrder(Convert.ToInt32(NumCustomerEnDusuk.Value), Convert.ToInt32(NumCustomerEnBuyuk.Value));
            
        }

        private void tbxCustomerFilterName_TextChanged(object sender, EventArgs e)
        {
            string arananIsim = tbxCustomerFilterName.Text;
            dgCustomer.DataSource = _customerDal.CustomerList().Where(p => p.Name.ToUpper().Contains(arananIsim.ToUpper())).ToList();
        }

        private void tbxCustomerFilterPhone_TextChanged(object sender, EventArgs e)
        {
            string arananTelefon = tbxCustomerFilterPhone.Text;
            dgCustomer.DataSource = _customerDal.CustomerList().Where(p => p.Phone.Contains(arananTelefon)).ToList();
        }

        private void tbxCustomerFilterCity_TextChanged(object sender, EventArgs e)
        {
            string arananSehir = tbxCustomerFilterCity.Text;
            dgCustomer.DataSource = _customerDal.CustomerList().Where(p => p.City.ToUpper().Contains(arananSehir.ToUpper())).ToList();
        }

        private void btnCustomerRefresh_Click(object sender, EventArgs e)
        {
            dgCustomer.DataSource = _customerDal.CustomerList();  //YENİLE
        }

        private void btnCustomerAdd_Click(object sender, EventArgs e)
        {
            CustomerAdd customerAdd = new CustomerAdd();
            _frmGecis.OperantFormPass(customerAdd);
        }

        private void btnCustomerDelete_Click(object sender, EventArgs e)
        {
            CustomerDelete customerDelete = new CustomerDelete();
            _frmGecis.OperantFormPass(customerDelete);
        }

        private void btnCustomerUpdate_Click(object sender, EventArgs e)
        {
            CustomerUpdate customerUpdate = new CustomerUpdate();
            _frmGecis.OperantFormPass(customerUpdate);
        }

        private void pRODUCTSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProductsForm productsForm = new ProductsForm();
            _frmGecis.MainFormPass(productsForm, this);
;        }

        private void cATEGORIESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CategoryForm categoryForm = new CategoryForm();
            _frmGecis.MainFormPass(categoryForm,this);
        }

        private void cOMPANIESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CompanyForm companyForm = new CompanyForm();
            _frmGecis.MainFormPass(companyForm, this);
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
