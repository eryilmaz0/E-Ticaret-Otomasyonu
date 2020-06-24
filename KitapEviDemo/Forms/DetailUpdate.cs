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
    public partial class DetailUpdate : Form
    {
        public DetailUpdate()
        {
            InitializeComponent();
        }

        OrderDetailDal _orderDetailDal = new OrderDetailDal();

        private void DetailUpdate_Load(object sender, EventArgs e)
        {
            dgDetailUpdate.DataSource = _orderDetailDal.OrderDetailList(OrdersForm.selectedID);
        }
    }
}
