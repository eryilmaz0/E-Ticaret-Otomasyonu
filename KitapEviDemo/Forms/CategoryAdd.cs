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
    public partial class CategoryAdd : Form
    {
        public CategoryAdd()
        {
            InitializeComponent();
        }

        CategoryDal _categoryDal = new CategoryDal();
        

        private void CategoryAdd_Load(object sender, EventArgs e)
        {
            
        }

        private void btnCategoryAdd_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Kategori Eklensin mi?", "Kategori Ekleniyor...", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Category newCategory = new Category
                {
                    CategoryName = tbxCategoryAdd.Text,
                };

                _categoryDal.CategoryAdd(newCategory);
            }
        }
    }
}
