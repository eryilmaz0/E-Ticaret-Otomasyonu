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
    public partial class OrderUpdate : Form
    {
        public OrderUpdate()
        {
            InitializeComponent();
        }

        OrderDal _orderDal = new OrderDal();

        private void OrderUpdate_Load(object sender, EventArgs e)
        {
            dgOrderUpdate.DataSource = _orderDal.OrderList();
            checkOrderUpdate.Checked = true;
        }

        private void dgOrderUpdate_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            tbxOrderUpdateCity.Text = dgOrderUpdate.CurrentRow.Cells[4].Value.ToString();
            tbxOrderUpdateCountry.Text = dgOrderUpdate.CurrentRow.Cells[5].Value.ToString();
            tbxOrderUpdateAdres.Text = dgOrderUpdate.CurrentRow.Cells[6].Value.ToString();
            lblSelectedOrder.Text = dgOrderUpdate.CurrentRow.Cells[0].Value.ToString();
        }

        private void btnOrderUpdate_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Sipariş Güncellensin mi?", "Sipariş Güncelleniyor...", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Order order = new Order();
                order.OrderDate = DateTime.Now;   //SİPARİŞ TARİHİNİ OTOMATİK GÜNCELLE
                if(checkOrderUpdate.Checked == true)
                {
                   Customer ownerCustomer = _orderDal.GetCustomerID(Convert.ToInt32(dgOrderUpdate.CurrentRow.Cells[0].Value));  //SEÇİLİ SİPARİŞİN IDSİNİ METHOTA YOLLA
                    order.ShipCity = ownerCustomer.City;
                    order.ShipCountry = ownerCustomer.Country;
                    order.ShipAdress = ownerCustomer.Adress;
                    //OTOMATİK ADRES GÜNCELLEMESİ, ÇEKİLEN MÜŞTERİNİN ADRES BİLGİLERİYLE YAPILDI
                }

                else
                {
                    //OTOMATİK YAPILMAZSA, YENİ ADRES BİLGİLERİ EL İLE GİRİLİRSE
                    order.ShipCity = tbxOrderUpdateCity.Text;
                    order.ShipCountry = tbxOrderUpdateCountry.Text;
                    order.ShipAdress = tbxOrderUpdateAdres.Text;
                }

                _orderDal.OrderUpdate(Convert.ToInt32(dgOrderUpdate.CurrentRow.Cells[0].Value), order);  //SİPARİŞİ GÜNCELLE
                dgOrderUpdate.DataSource = _orderDal.OrderList();                                        //DATAGRİDİ GÜNCELLE.

            }
        }

        private void checkOrderUpdate_CheckedChanged(object sender, EventArgs e)
        {
            if(checkOrderUpdate.Checked == true)
            {
                tbxOrderUpdateAdres.ReadOnly = true;
                tbxOrderUpdateCity.ReadOnly = true;
                tbxOrderUpdateCountry.ReadOnly = true;
            }

            else
            {
                tbxOrderUpdateAdres.ReadOnly = false;
                tbxOrderUpdateCity.ReadOnly = false;
                tbxOrderUpdateCountry.ReadOnly = false;
            }
        }
    }
}
