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
    public partial class OrderAdd : Form
    {
        public OrderAdd()
        {
            InitializeComponent();
        }


        CustomerDal _customerDal = new CustomerDal();
        EmployeeDal _employeeDal = new EmployeeDal();
        OrderDal _orderDal = new OrderDal();

        private void checkboxAdres_CheckedChanged(object sender, EventArgs e)
        {
            if (checkboxAdres.Checked == true)
            {
                checkboxAdres.Text = "Müşterinin Adresi";
                tbxOrderAddCity.ReadOnly = true;
                tbxOrderAddCountry.ReadOnly = true;
                tbxOrderAddAdress.ReadOnly = true;
            }


            else
            {
                checkboxAdres.Text = "Aşağıdaki Adres";
                tbxOrderAddCity.ReadOnly = false;
                tbxOrderAddCountry.ReadOnly = false;
                tbxOrderAddAdress.ReadOnly = false;
            }
        }

        private void OrderAdd_Load(object sender, EventArgs e)
        {
            checkboxAdres.Checked = true;

            cmbxOrderAddCustomer.DataSource = _customerDal.CustomerComboBox();
            cmbxOrderAddCustomer.DisplayMember = "Customer";
            cmbxOrderAddCustomer.ValueMember = "CustomerID";

            cmbxOrderAddEmployee.DataSource = _employeeDal.EmployeeComboBox();
            cmbxOrderAddEmployee.DisplayMember = "Employee";
            cmbxOrderAddEmployee.ValueMember = "EmployeeID";

        }

        private void btnOrderAdd_Click(object sender, EventArgs e)
        {
            Order order = new Order();
            order.CustomerID = Convert.ToInt32(cmbxOrderAddCustomer.SelectedValue);   //CUSTOMER ID OLARAK CMBXDAN SEÇİLEN İD
            order.EmployeeID = Convert.ToInt32(cmbxOrderAddEmployee.SelectedValue);   //EMPLOYEE ID OLARAK CMBXDAN SEÇİLEN ID Yİ VERİLDİ
            order.OrderDate = DateTime.Now;                                           //SİPARİŞ TARİHİ ŞUAN OLARAK VERİLDİ

            if (checkboxAdres.Checked == true)
            {


                Customer getCustomer = _customerDal.CustomerChecked(OrdersForm.selectedID);

                order.ShipCity = getCustomer.City;
                order.ShipCountry = getCustomer.Country;
                order.ShipAdress = getCustomer.Adress;
                //TRUE İSE, İDSİNDEN MÜŞTERİYİ BUL, MEVCUT ADRES BİLGİLERİNİ BURAYA KOPYALA.

            }

            else
            {
                order.ShipCity = tbxOrderAddCity.Text;
                order.ShipCountry = tbxOrderAddCountry.Text;
                order.ShipAdress = tbxOrderAddAdress.Text;

                //FALSE İSE TEXTBOXLARA GİRİLEN ADRES BİLGİLERİNİ AL. SON OLARAK EKLEME İŞLEMİNİ YAPALIM.
            }

            if (MessageBox.Show("Sipariş Oluşturulsun miu", "Sipariş Oluşturuluyor...", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {


                _orderDal.OrderAdd(order);





            }
        }
    }
}