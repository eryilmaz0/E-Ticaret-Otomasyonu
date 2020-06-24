namespace KitapEviDemo.Forms
{
    partial class OrderAdd
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbxOrderAdd = new System.Windows.Forms.GroupBox();
            this.btnOrderAdd = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbxOrderAddEmployee = new System.Windows.Forms.ComboBox();
            this.cmbxOrderAddCustomer = new System.Windows.Forms.ComboBox();
            this.checkboxAdres = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxOrderAddCity = new System.Windows.Forms.TextBox();
            this.tbxOrderAddCountry = new System.Windows.Forms.TextBox();
            this.tbxOrderAddAdress = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.gbxOrderAdd.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxOrderAdd
            // 
            this.gbxOrderAdd.Controls.Add(this.label7);
            this.gbxOrderAdd.Controls.Add(this.label6);
            this.gbxOrderAdd.Controls.Add(this.label5);
            this.gbxOrderAdd.Controls.Add(this.tbxOrderAddAdress);
            this.gbxOrderAdd.Controls.Add(this.tbxOrderAddCountry);
            this.gbxOrderAdd.Controls.Add(this.tbxOrderAddCity);
            this.gbxOrderAdd.Controls.Add(this.label4);
            this.gbxOrderAdd.Controls.Add(this.checkboxAdres);
            this.gbxOrderAdd.Controls.Add(this.btnOrderAdd);
            this.gbxOrderAdd.Controls.Add(this.label3);
            this.gbxOrderAdd.Controls.Add(this.label2);
            this.gbxOrderAdd.Controls.Add(this.cmbxOrderAddEmployee);
            this.gbxOrderAdd.Controls.Add(this.cmbxOrderAddCustomer);
            this.gbxOrderAdd.Location = new System.Drawing.Point(0, 0);
            this.gbxOrderAdd.Name = "gbxOrderAdd";
            this.gbxOrderAdd.Size = new System.Drawing.Size(347, 376);
            this.gbxOrderAdd.TabIndex = 1;
            this.gbxOrderAdd.TabStop = false;
            this.gbxOrderAdd.Text = "Sipariş Oluştur";
            // 
            // btnOrderAdd
            // 
            this.btnOrderAdd.Location = new System.Drawing.Point(117, 273);
            this.btnOrderAdd.Name = "btnOrderAdd";
            this.btnOrderAdd.Size = new System.Drawing.Size(121, 32);
            this.btnOrderAdd.TabIndex = 11;
            this.btnOrderAdd.Text = "Sipariş Oluştur";
            this.btnOrderAdd.UseVisualStyleBackColor = true;
            this.btnOrderAdd.Click += new System.EventHandler(this.btnOrderAdd_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Personel :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Müşteri :";
            // 
            // cmbxOrderAddEmployee
            // 
            this.cmbxOrderAddEmployee.FormattingEnabled = true;
            this.cmbxOrderAddEmployee.Location = new System.Drawing.Point(117, 79);
            this.cmbxOrderAddEmployee.Name = "cmbxOrderAddEmployee";
            this.cmbxOrderAddEmployee.Size = new System.Drawing.Size(122, 21);
            this.cmbxOrderAddEmployee.TabIndex = 2;
            // 
            // cmbxOrderAddCustomer
            // 
            this.cmbxOrderAddCustomer.FormattingEnabled = true;
            this.cmbxOrderAddCustomer.Location = new System.Drawing.Point(118, 43);
            this.cmbxOrderAddCustomer.Name = "cmbxOrderAddCustomer";
            this.cmbxOrderAddCustomer.Size = new System.Drawing.Size(121, 21);
            this.cmbxOrderAddCustomer.TabIndex = 1;
            // 
            // checkboxAdres
            // 
            this.checkboxAdres.AutoSize = true;
            this.checkboxAdres.Checked = true;
            this.checkboxAdres.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkboxAdres.Location = new System.Drawing.Point(118, 119);
            this.checkboxAdres.Name = "checkboxAdres";
            this.checkboxAdres.Size = new System.Drawing.Size(106, 17);
            this.checkboxAdres.TabIndex = 12;
            this.checkboxAdres.Text = "Müşterinin Adresi";
            this.checkboxAdres.UseVisualStyleBackColor = true;
            this.checkboxAdres.CheckedChanged += new System.EventHandler(this.checkboxAdres_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(72, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Adres :";
            // 
            // tbxOrderAddCity
            // 
            this.tbxOrderAddCity.Location = new System.Drawing.Point(117, 155);
            this.tbxOrderAddCity.Name = "tbxOrderAddCity";
            this.tbxOrderAddCity.ReadOnly = true;
            this.tbxOrderAddCity.Size = new System.Drawing.Size(121, 20);
            this.tbxOrderAddCity.TabIndex = 14;
            // 
            // tbxOrderAddCountry
            // 
            this.tbxOrderAddCountry.Location = new System.Drawing.Point(118, 193);
            this.tbxOrderAddCountry.Name = "tbxOrderAddCountry";
            this.tbxOrderAddCountry.ReadOnly = true;
            this.tbxOrderAddCountry.Size = new System.Drawing.Size(121, 20);
            this.tbxOrderAddCountry.TabIndex = 15;
            // 
            // tbxOrderAddAdress
            // 
            this.tbxOrderAddAdress.Location = new System.Drawing.Point(118, 230);
            this.tbxOrderAddAdress.Name = "tbxOrderAddAdress";
            this.tbxOrderAddAdress.ReadOnly = true;
            this.tbxOrderAddAdress.Size = new System.Drawing.Size(122, 20);
            this.tbxOrderAddAdress.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(75, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Şehir :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(77, 196);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Ülke :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(72, 233);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Adres :";
            // 
            // OrderAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 362);
            this.Controls.Add(this.gbxOrderAdd);
            this.Name = "OrderAdd";
            this.Text = "Sipariş Oluştur";
            this.Load += new System.EventHandler(this.OrderAdd_Load);
            this.gbxOrderAdd.ResumeLayout(false);
            this.gbxOrderAdd.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxOrderAdd;
        private System.Windows.Forms.Button btnOrderAdd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbxOrderAddEmployee;
        private System.Windows.Forms.ComboBox cmbxOrderAddCustomer;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbxOrderAddAdress;
        private System.Windows.Forms.TextBox tbxOrderAddCountry;
        private System.Windows.Forms.TextBox tbxOrderAddCity;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkboxAdres;
    }
}