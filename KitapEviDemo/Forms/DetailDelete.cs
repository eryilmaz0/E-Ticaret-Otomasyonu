using KitapEviDemo.Dal;
using KitapEviDemo.Entities;
using KitapEviDemo.ViewModels;
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
    public partial class DetailDelete : Form
    {
        public DetailDelete()
        {
            InitializeComponent();
        }

        OrderDetailDal _orderDetailDal = new OrderDetailDal();
        private void DetailDelete_Load(object sender, EventArgs e)
        {
            dgDetailDelete.DataSource = _orderDetailDal.OrderDetailList(OrdersForm.selectedID);
        }

        private void dgDetailDelete_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            lblDetailDeleteProduct.Text = dgDetailDelete.CurrentRow.Cells[2].Value.ToString();
            lblDetailDeletePrice.Text = dgDetailDelete.CurrentRow.Cells[3].Value.ToString();
            lblDetailDeleteQuantity.Text = dgDetailDelete.CurrentRow.Cells[4].Value.ToString();

        }

        private void btnDetailDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Detay Silinsin mi?", "Detay Siliniyor...", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                _orderDetailDal.DetailDelete((int)dgDetailDelete.CurrentRow.Cells[0].Value);
            }
        }
    }
}
