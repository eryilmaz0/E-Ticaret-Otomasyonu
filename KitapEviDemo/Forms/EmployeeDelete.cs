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
    public partial class EmployeeDelete : Form
    {
        public EmployeeDelete()
        {
            InitializeComponent();
        }

        EmployeeDal _employeeDal = new EmployeeDal();
        private void EmployeeDelete_Load(object sender, EventArgs e)
        {
            dgEmployeeDelete.DataSource = _employeeDal.EmployeeList();
        }

        private void btnEmployeeDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Personel Silinsin mi?", "Personel Siliniyor...", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                _employeeDal.EmployeeDelete(Convert.ToInt32(dgEmployeeDelete.CurrentRow.Cells[0].Value));   //VERİLEN İDDEKİ PERSONELİ SİL
                dgEmployeeDelete.DataSource = _employeeDal.EmployeeList();  //DATAGRİDİ GÜNCELLE
            }
        }

        private void dgEmployeeDelete_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            lblEmployeeDeleteName.Text = dgEmployeeDelete.CurrentRow.Cells[1].Value.ToString();
            lblEmployeeDeleteLastname.Text = dgEmployeeDelete.CurrentRow.Cells[2].Value.ToString();
            lblEmployeeDeleteCity.Text = dgEmployeeDelete.CurrentRow.Cells[3].Value.ToString();
            lblEmployeeDeleteCountry.Text = dgEmployeeDelete.CurrentRow.Cells[4].Value.ToString();
            lblEmployeeDeletePhone.Text = dgEmployeeDelete.CurrentRow.Cells[5].Value.ToString();


        }
    }
}
