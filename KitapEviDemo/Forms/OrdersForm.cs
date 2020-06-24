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
    public partial class OrdersForm : Form
    {
        public OrdersForm()
        {
            InitializeComponent();
        }


        public static int selectedID = 0;

        OrderDal _orderDal = new OrderDal();
        FormGecis _frmGecis = new FormGecis();

        private void OrdersForm_Load(object sender, EventArgs e)
        {
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is MdiClient)
                    ctrl.BackColor = Color.LightSlateGray;    //ARKAPLANI BOYAMA KODU             

            }

            dgOrder.DataSource = _orderDal.OrderList();
        }

        private void btnEmployeeAdd_Click(object sender, EventArgs e)
        {
            OrderAdd orderAdd = new OrderAdd();
            _frmGecis.OperantFormPass(orderAdd);
        }

        private void btnEmployeeRefresh_Click(object sender, EventArgs e)
        {
            dgOrder.DataSource = _orderDal.OrderList();
        }

        private void btnEmployeeDelete_Click(object sender, EventArgs e)
        {
            OrderDelete orderDelete = new OrderDelete();
            _frmGecis.OperantFormPass(orderDelete);
        }

        private void btnEmployeeUpdate_Click(object sender, EventArgs e)
        {
            OrderUpdate orderUpdate = new OrderUpdate();
            _frmGecis.OperantFormPass(orderUpdate);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OrderDetailsForm orderDetailsForm = new OrderDetailsForm();
            _frmGecis.OperantFormPass(orderDetailsForm);
            
        }

        private void dgOrder_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            selectedID = Convert.ToInt32(dgOrder.CurrentRow.Cells[0].Value);  //BİR KAYIT SEÇİLDİĞİNDE İDSİNİ SAKLA
        }

        private void tbxOrderFilterbyCustomer_TextChanged(object sender, EventArgs e)
        {
            string findCustomer = tbxOrderFilterbyCustomer.Text;
            dgOrder.DataSource = _orderDal.OrderList().Where(p => p.Customer.ToUpper().Contains(findCustomer.ToUpper())).ToList();
        }

        private void gbxOrderFilterbyEmployee_TextChanged(object sender, EventArgs e)
        {
            string findEmployee = tbxOrderfilterbyEmployee.Text;
            dgOrder.DataSource = _orderDal.OrderList().Where(p => p.Employee.ToUpper().Contains(findEmployee.ToUpper())).ToList();
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

        private void eMPLOYEESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EmployeesForm employeesForm = new EmployeesForm();
            _frmGecis.MainFormPass(employeesForm, this);
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
    }
}
