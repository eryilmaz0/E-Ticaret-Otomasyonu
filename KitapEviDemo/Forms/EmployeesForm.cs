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
    public partial class EmployeesForm : Form
    {
        public EmployeesForm()
        {
            InitializeComponent();
        }

        FormGecis _frmGecis = new FormGecis();
        EmployeeDal _employeeDal = new EmployeeDal();


        private void EmplooyesForm_Load(object sender, EventArgs e)
        {
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is MdiClient)
                    ctrl.BackColor = Color.LightSlateGray;    //ARKAPLANI BOYAMA KODU             

            }


            dgEmployee.DataSource = _employeeDal.EmployeeList();
        }

        private void EmplooyesForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnEmployeesFilter_Click(object sender, EventArgs e)
        {
            dgEmployee.DataSource = _employeeDal.EmployeeFilterbyCount(Convert.ToInt32(NumEmployeeEnDusuk.Value), Convert.ToInt32(NumEmployeeEnBuyuk.Value));
        }

        private void tbxEmployeeFilterName_TextChanged(object sender, EventArgs e)
        {
            string findName = tbxEmployeeFilterName.Text;
            dgEmployee.DataSource = _employeeDal.EmployeeList().Where(p => p.Name.ToUpper().Contains(findName.ToUpper())).ToList();
        }

        private void tbxCustomerFilterPhone_TextChanged(object sender, EventArgs e)
        {
            string findPhone = tbxCustomerFilterPhone.Text;
            dgEmployee.DataSource = _employeeDal.EmployeeList().Where(p => p.Phone.Contains(findPhone)).ToList();
        }

        private void tbxEmployeeFilterCity_TextChanged(object sender, EventArgs e)
        {
            string findCity = tbxEmployeeFilterCity.Text;
            dgEmployee.DataSource = _employeeDal.EmployeeList().Where(p => p.City.ToUpper().Contains(findCity.ToUpper())).ToList();
        }

        private void btnEmployeeRefresh_Click(object sender, EventArgs e)
        {
            dgEmployee.DataSource = _employeeDal.EmployeeList();
        }

        private void btnEmployeeAdd_Click(object sender, EventArgs e)
        {
            EmployeeAdd employeeAdd = new EmployeeAdd();
            _frmGecis.OperantFormPass(employeeAdd);
        }

        private void btnEmployeeDelete_Click(object sender, EventArgs e)
        {
            EmployeeDelete employeeDelete = new EmployeeDelete();
            _frmGecis.OperantFormPass(employeeDelete);
            
        }

        private void btnEmployeeUpdate_Click(object sender, EventArgs e)
        {
            EmployeeUpdate employeeUpdate = new EmployeeUpdate();
            _frmGecis.OperantFormPass(employeeUpdate);
        }

        private void pRODUCTSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProductsForm productsForm = new ProductsForm();
            _frmGecis.MainFormPass(productsForm, this);
        }

        private void cATEGORIESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CategoryForm categoryForm = new CategoryForm();
            _frmGecis.MainFormPass(categoryForm, this);
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

        private void oRDERSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OrdersForm ordersForm = new OrdersForm();
            _frmGecis.MainFormPass(ordersForm, this);
        }
    }
}
