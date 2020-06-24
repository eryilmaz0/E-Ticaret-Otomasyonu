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
    public partial class OrderDetailsForm : Form
    {
        public OrderDetailsForm()
        {
            InitializeComponent();
        }


        

        OrderDetailDal _orderDetailDal = new OrderDetailDal();
        FormGecis _frmGecis = new FormGecis();
        private void OrderDetailsForm_Load(object sender, EventArgs e)
        {
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is MdiClient)
                    ctrl.BackColor = Color.LightSlateGray;    //ARKAPLANI BOYAMA KODU
            }

            dgOrderDetail.DataSource = _orderDetailDal.OrderDetailList(OrdersForm.selectedID);
            MessageBox.Show(OrdersForm.selectedID.ToString() + " Numarali sipariş seçildi.");
            
        }



        private void btnDetailListRefresh_Click(object sender, EventArgs e)
        {
            dgOrderDetail.DataSource = _orderDetailDal.OrderDetailList(OrdersForm.selectedID);
        }

        private void dgOrderDetail_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            
        }

        private void btnDetailAdd_Click(object sender, EventArgs e)
        {
            DetailAdd detailAdd = new DetailAdd();
            _frmGecis.OperantFormPass(detailAdd);
        }

        private void btnDetailDelete_Click(object sender, EventArgs e)
        {
            DetailDelete detailDelete = new DetailDelete();
            _frmGecis.OperantFormPass(detailDelete);
        }

        private void btnDetailUpdate_Click(object sender, EventArgs e)
        {
            DetailUpdate detailUpdate = new DetailUpdate();
            _frmGecis.OperantFormPass(detailUpdate);
        }
    }
}
