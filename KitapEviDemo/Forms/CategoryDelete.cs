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
    public partial class CategoryDelete : Form
    {
        public CategoryDelete()
        {
            InitializeComponent();
        }

        CategoryDal _categoryDal = new CategoryDal();
        FormGecis _frmGecis = new FormGecis();

        private void CategoryDelete_Load(object sender, EventArgs e)
        {
           categoryDeleteDg.DataSource =  _categoryDal.CategoryList();
        }

        private void categoryDeleteDg_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
       
            lblCategoryName.Text = categoryDeleteDg.CurrentRow.Cells[1].Value.ToString();
            lblCategoryCount.Text = categoryDeleteDg.CurrentRow.Cells[2].Value.ToString();
        }

        private void btnCategoryDelete_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Kategori Silinsin mi?", "Kategori Siliniyor...", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                _categoryDal.CategoryDelete(Convert.ToInt32(categoryDeleteDg.CurrentRow.Cells[0].Value));   //KATEGORİYİ SİL
               categoryDeleteDg.DataSource = _categoryDal.CategoryList();   //DATAGRİDİ GÜNCELLE
            }
        }
    }
}
