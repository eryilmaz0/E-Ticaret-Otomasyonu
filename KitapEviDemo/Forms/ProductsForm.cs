using KitapEviDemo.Entities;
using KitapEviDemo.Forms;
using KitapEviDemo.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KitapEviDemo
{
    public partial class ProductsForm : Form
    {

       private void OpenForm(Form frm)
        {
            
            frm.Show();    //GELEN FORMU AÇ
            this.Hide();   //ÖNCEKİ FORMU KAPAT.
        }


        FormGecis frmgecis = new FormGecis();
        ProductDal _productDal = new ProductDal();
        CategoryDal _categoryDal = new CategoryDal();
        CompanyDal _companyDal = new CompanyDal();
        public ProductsForm()
        {
            InitializeComponent();
        }

        private static void OpenOperatorForm(Form frm)
        {

            frm.Show();   //ANA FORMU KAPATMA, KÜÇÜK FORMU ÜSTTE AÇ
        }


      


        private void Form1_Load(object sender, EventArgs e)
        {


                
            using (NorthwindContext db = new NorthwindContext())
            {
                ProductCombobox.DataSource = _categoryDal.CategoryComboBox();
                ProductCombobox.DisplayMember = "Category";
                ProductCombobox.ValueMember = "CategoryID";           //COMBOBOX SET KOMUTLARI

                productCompanyComboBox.DataSource = _companyDal.CompanyComboBox();
                productCompanyComboBox.DisplayMember = "Company";
                productCompanyComboBox.ValueMember = "CompanyID";
            };



            

            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is MdiClient)
                    ctrl.BackColor = Color.LightSlateGray;    //ARKAPLANI BOYAMA KODU
            }

            
            dg1.DataSource = _productDal.ProductsList().ToList();
 
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string aranan = ProductSearchtbx.Text;
            dg1.DataSource = _productDal.ProductsList().Where(p => p.ProductName.ToUpper().Contains(aranan.ToUpper())).ToList();
            
        }

        private void ResetFilterbtn_Click(object sender, EventArgs e)
        {
            using (NorthwindContext db = new NorthwindContext())
            {
                dg1.DataSource = _productDal.ProductsList().ToList();
            }
        }

        private void ProductCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {

            int id = ProductCombobox.SelectedIndex;
            try
            {
                dg1.DataSource = _productDal.productFilterbyCategory(Convert.ToInt32(ProductCombobox.SelectedValue));
            }


            catch
            {

            }

        }

        private void ProductFilterBtn_Click(object sender, EventArgs e)
        {
            try
            {
                dg1.DataSource = _productDal.ProductFilterByPrice(Convert.ToDecimal(EnDusukNumeric.Value), Convert.ToDecimal(EnBuyukNumeric.Value));
                //dg1.DataSource = _productDal.ProductsList().Where(p => p.Price < EnDusukNumeric.Value && p.Price > EnBuyukNumeric.Value).ToList();}
            }

            catch { }
        }
        private void ProductsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }     

        private void cATEGORIESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CategoryForm categoryForm = new CategoryForm();
            frmgecis.MainFormPass(categoryForm, this);
            
        }



        private void button3_Click(object sender, EventArgs e)
        {
            ProductDelete productDelete = new ProductDelete();
            frmgecis.OperantFormPass(productDelete);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ProductUpdate productUpdate = new ProductUpdate();
            frmgecis.OperantFormPass(productUpdate);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ProductAdd productAdd = new ProductAdd();
            frmgecis.OperantFormPass(productAdd);
        }

        private void productCompanyComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            try
            {
                dg1.DataSource = _productDal.ProductFilterbyCompany(Convert.ToInt16(productCompanyComboBox.SelectedValue));
            }

            catch
            {

            }
        }

        private void cOMPANIESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CompanyForm companyForm = new CompanyForm();
            frmgecis.MainFormPass(companyForm, this);
        }

        private void cUSTOMERSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CustomerForm customerForm = new CustomerForm();
            frmgecis.MainFormPass(customerForm, this);
        }

        private void eMPLOYEESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EmployeesForm employessForm = new EmployeesForm();
            frmgecis.MainFormPass(employessForm, this);
        }

        private void oRDERSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OrdersForm ordersForm = new OrdersForm();
            frmgecis.MainFormPass(ordersForm, this);

        }
    }
}
