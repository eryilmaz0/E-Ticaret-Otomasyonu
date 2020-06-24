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
    public partial class ProductUpdate : Form
    {
        public ProductUpdate()
        {
            InitializeComponent();
        }

       

        ProductDal _productDal = new ProductDal();
        CategoryDal _categoryDal = new CategoryDal();
        CompanyDal _companyDal = new CompanyDal();

        private void ComboBoxCategory()
        {
            cmbBoxProductUpdateCat.DataSource = _categoryDal.CategoryList();
            cmbBoxProductUpdateCat.DisplayMember = "Category";
            cmbBoxProductUpdateCat.ValueMember = "CategoryID";
        }

        private void ComboBoxCompany()
        {
            cmbBoxproductUpdateCompany.DataSource = _companyDal.CompanyList();
            cmbBoxproductUpdateCompany.DisplayMember = "Company";
            cmbBoxproductUpdateCompany.ValueMember = "CompanyID";
        }

        private void ProductUpdate_Load(object sender, EventArgs e)
        {
            productUpdatedg.DataSource = _productDal.ProductsList();
            ProductUpdatePriceNuneric.Text = "";
        }

        private void productUpdatedg_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            tbxProductUpdateName.Text = productUpdatedg.CurrentRow.Cells[1].Value.ToString();
            ComboBoxCategory();
            ComboBoxCompany();
            tbxProductUpdateQuantity.Text = productUpdatedg.CurrentRow.Cells[5].Value.ToString();
            ProductUpdatePriceNuneric.Value =Convert.ToDecimal(productUpdatedg.CurrentRow.Cells[4].Value);

        }

        private void btnProductUpdate_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seçili Ürün Güncellensin mi?", "Ürün Güncelleniyor...", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                

                Product product = new Product
                {
                    ProductName = tbxProductUpdateName.Text,
                    CategoryID = Convert.ToInt16(cmbBoxProductUpdateCat.SelectedValue),
                    CompanyID = Convert.ToInt16(cmbBoxproductUpdateCompany.SelectedValue),    //GÜNCEL VERİLERLE NESNE OLUŞTUR
                    Price = Convert.ToDecimal(ProductUpdatePriceNuneric.Value),
                    QuantityPerUnit = tbxProductUpdateQuantity.Text
                };

                _productDal.ProductUpdate(Convert.ToInt32(productUpdatedg.CurrentRow.Cells[0].Value), product);    //ID İLE NESNEYİ UPDATE FONKSİYONUNA YOLLA
                productUpdatedg.DataSource = _productDal.ProductsList();   //DATAGRİDİ GÜNCELLE
            }

        }

       
    }
}
