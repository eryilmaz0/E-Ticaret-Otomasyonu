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
    public partial class ProductAdd : Form
    {
        public ProductAdd()
        {
            InitializeComponent();
        }

        ProductDal _productDal = new ProductDal();
        CategoryDal _categoryDal = new CategoryDal();
        CompanyDal _companyDal = new CompanyDal();

        private void ProductAdd_Load(object sender, EventArgs e)
        {
            ProductAddCatComboBox.DataSource = _categoryDal.CategoryList();
            ProductAddCatComboBox.DisplayMember = "Category";
            ProductAddCatComboBox.ValueMember = "CategoryID";

            ProductAddCompanyComboBox.DataSource = _companyDal.CompanyList();
            ProductAddCompanyComboBox.DisplayMember = "Company";
            ProductAddCompanyComboBox.ValueMember = "CompanyID";
        }

        private void ProductAddBtn_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Ürün eklensin mi?", "Ürün Ekleniyor...", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Product newProduct = new Product
                {
                    ProductName = ProductAddNametbx.Text.ToString(),
                    CategoryID = Convert.ToInt16(ProductAddCatComboBox.SelectedValue),
                    QuantityPerUnit = ProductAddQuantityTbx.Text.ToString(),
                    Price = Convert.ToDecimal(ProductAddPriceNumeric.Value),
                    CompanyID = Convert.ToInt16(ProductAddCompanyComboBox.SelectedValue)

                };

                _productDal.ProductAdd(newProduct);
            }
        }

       
    }
}


