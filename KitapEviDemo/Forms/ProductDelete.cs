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
    public partial class ProductDelete : Form
    {
        public ProductDelete()
        {
            InitializeComponent();
        }

        ProductDal _productDal = new ProductDal();
        private void ProductDelete_Load(object sender, EventArgs e)
        {
            productDeletedg.DataSource = _productDal.ProductsList();  //ÜRÜNLER VİEWMODELİNİ LİSTELE
            
        }

        private void productDeletedg_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            productDeleteNameLbl.Text = productDeletedg.CurrentRow.Cells[1].Value.ToString();
            productDeleteCatLbl.Text = productDeletedg.CurrentRow.Cells[2].Value.ToString();
            productDeleteCompanyLbl.Text = productDeletedg.CurrentRow.Cells[3].Value.ToString();
            productDeletePriceLbl.Text = productDeletedg.CurrentRow.Cells[4].Value.ToString();
            productDeleteQuantityLbl.Text = productDeletedg.CurrentRow.Cells[5].Value.ToString();

        }

        private void productDeleteButton_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Seçili Ürün Silinsin mi?", "Ürün Siliniyor...", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int silinecekID = Convert.ToInt32(productDeletedg.CurrentRow.Cells[0].Value);  //SEÇİLİ SATIRIN IDSİNİ DEĞİŞKENE AT
                _productDal.ProductDelete(silinecekID);
                productDeletedg.DataSource = _productDal.ProductsList();   //DATAGRİDİ GÜNCELLE
                //TBXLARI TEMİZLE
            }
            
                

        }

        
    }
}
