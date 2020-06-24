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
    public partial class CategoryUpdate : Form
    {
        public CategoryUpdate()
        {
            InitializeComponent();
        }

        CategoryDal _categoryDal = new CategoryDal();
        FormGecis _frmGecis = new FormGecis();

        private void CategoryUpdate_Load(object sender, EventArgs e)
        {
            categoryUpdateDg.DataSource = _categoryDal.CategoryList();
        }

        private void categoryUpdateDg_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            tbxCategoryUpdate.Text = categoryUpdateDg.CurrentRow.Cells[1].Value.ToString();
        }

        private void btnCategoryUpdate_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Kategori Güncellensin mi?", "Kategori Güncelleniyor...", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
               
                Category _newCategory = new Category
                {
                    CategoryName = tbxCategoryUpdate.Text   //İSMİ GÜNCELLE
                };

                _categoryDal.CategoryUpdate(Convert.ToInt32(categoryUpdateDg.CurrentRow.Cells[0].Value),_newCategory);
            }
        }

      
    }
}
