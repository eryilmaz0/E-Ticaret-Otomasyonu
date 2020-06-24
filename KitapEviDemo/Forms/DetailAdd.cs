using KitapEviDemo.Dal;
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
    public partial class DetailAdd : Form
    {
        public DetailAdd()
        {
            InitializeComponent();
        }

        ProductDal _productDal = new ProductDal();
        OrderDetailDal _orderDetailDal = new OrderDetailDal();

        private void DetailAdd_Load(object sender, EventArgs e)
        {
            cbxDetailAddProduct.DataSource = _productDal.ProductComboBox();
            cbxDetailAddProduct.DisplayMember = "Product";
            cbxDetailAddProduct.ValueMember = "ProductID";
        }



        private void cbxDetailAddProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                numDetailAddPrice.Text = "";
                NumDetailAddQuantity.Text = "1";
                numDetailAddPrice.Value = _productDal.ProductPrice(Convert.ToInt32(cbxDetailAddProduct.SelectedValue));

            }
            catch { }
        }

        private void NumDetailAddQuantity_ValueChanged(object sender, EventArgs e)
        {
            int adet = (int)NumDetailAddQuantity.Value;
            decimal fiyat = (decimal)_productDal.ProductPrice(Convert.ToInt32(cbxDetailAddProduct.SelectedValue));
            numDetailAddPrice.Value = adet * fiyat;
        }

        private void btnDetailAdd_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Sipariş Detayı Eklensin mi?", "Sipariş Detayı Ekleniyor...", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                int orderID = OrdersForm.selectedID;

                OrderDetail orderDetail = new OrderDetail
                {
                    OrderID = orderID,
                    ProductID = (int)cbxDetailAddProduct.SelectedValue,
                    UnitPrice = _productDal.ProductPrice((int)cbxDetailAddProduct.SelectedValue),
                    Quantity = (int)NumDetailAddQuantity.Value
                };

                 
                _orderDetailDal.OrderDetailAdd(orderDetail);  //DETAYI VERİTABANINA EKLE
                
                
                
                 


            }


        }
    }
}

