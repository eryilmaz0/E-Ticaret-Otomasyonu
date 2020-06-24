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
    public partial class OrderDelete : Form
    {
        public OrderDelete()
        {
            InitializeComponent();
        }


        OrderDal _orderDal = new OrderDal();
        private void OrderDelete_Load(object sender, EventArgs e)
        {
            dgOrderDelete.DataSource = _orderDal.OrderList();
        }

        private void dgOrderDelete_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            lblOrderDeleteCustomer.Text = dgOrderDelete.CurrentRow.Cells[1].Value.ToString();
            lblOrderDeleteEmployee.Text = dgOrderDelete.CurrentRow.Cells[2].Value.ToString();
            lblOrderDeleteDate.Text = dgOrderDelete.CurrentRow.Cells[3].Value.ToString();
            lblOrderDeleteCity.Text = dgOrderDelete.CurrentRow.Cells[4].Value.ToString();
            lblOrderDeleteCountry.Text = dgOrderDelete.CurrentRow.Cells[5].Value.ToString();
            lblOrderDeleteAdress.Text = dgOrderDelete.CurrentRow.Cells[6].Value.ToString();


        }

        private void btnOrderDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Sipariş İptal Edilsin mi?", "Sipariş İptal Ediliyor...", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                _orderDal.OrderDelete(Convert.ToInt32(dgOrderDelete.CurrentRow.Cells[0].Value));
                dgOrderDelete.DataSource = _orderDal.OrderList();
            }
        }
    }
}
