namespace KitapEviDemo.Forms
{
    partial class OrderDelete
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
            this.gbxOrderDelete = new System.Windows.Forms.GroupBox();
            this.btnOrderDelete = new System.Windows.Forms.Button();
            this.lblOrderDeleteAdress = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblOrderDeleteCountry = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblOrderDeleteDate = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblOrderDeleteEmployee = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblOrderDeleteCustomer = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgOrderDelete = new System.Windows.Forms.DataGridView();
            this.lblOrderDeleteCity = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.gbxOrderDelete.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgOrderDelete)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxOrderDelete
            // 
            this.gbxOrderDelete.Controls.Add(this.lblOrderDeleteCity);
            this.gbxOrderDelete.Controls.Add(this.label4);
            this.gbxOrderDelete.Controls.Add(this.btnOrderDelete);
            this.gbxOrderDelete.Controls.Add(this.lblOrderDeleteAdress);
            this.gbxOrderDelete.Controls.Add(this.label9);
            this.gbxOrderDelete.Controls.Add(this.lblOrderDeleteCountry);
            this.gbxOrderDelete.Controls.Add(this.label7);
            this.gbxOrderDelete.Controls.Add(this.lblOrderDeleteDate);
            this.gbxOrderDelete.Controls.Add(this.label5);
            this.gbxOrderDelete.Controls.Add(this.lblOrderDeleteEmployee);
            this.gbxOrderDelete.Controls.Add(this.label3);
            this.gbxOrderDelete.Controls.Add(this.lblOrderDeleteCustomer);
            this.gbxOrderDelete.Controls.Add(this.label1);
            this.gbxOrderDelete.Controls.Add(this.dgOrderDelete);
            this.gbxOrderDelete.Location = new System.Drawing.Point(0, 0);
            this.gbxOrderDelete.Name = "gbxOrderDelete";
            this.gbxOrderDelete.Size = new System.Drawing.Size(663, 453);
            this.gbxOrderDelete.TabIndex = 1;
            this.gbxOrderDelete.TabStop = false;
            this.gbxOrderDelete.Text = "Sipariş İptal";
            // 
            // btnOrderDelete
            // 
            this.btnOrderDelete.Location = new System.Drawing.Point(263, 278);
            this.btnOrderDelete.Name = "btnOrderDelete";
            this.btnOrderDelete.Size = new System.Drawing.Size(118, 34);
            this.btnOrderDelete.TabIndex = 11;
            this.btnOrderDelete.Text = "Sipariş İptal Et";
            this.btnOrderDelete.UseVisualStyleBackColor = true;
            this.btnOrderDelete.Click += new System.EventHandler(this.btnOrderDelete_Click);
            // 
            // lblOrderDeleteAdress
            // 
            this.lblOrderDeleteAdress.AutoSize = true;
            this.lblOrderDeleteAdress.Location = new System.Drawing.Point(440, 65);
            this.lblOrderDeleteAdress.Name = "lblOrderDeleteAdress";
            this.lblOrderDeleteAdress.Size = new System.Drawing.Size(16, 13);
            this.lblOrderDeleteAdress.TabIndex = 10;
            this.lblOrderDeleteAdress.Text = "---";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(394, 65);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "Adres :";
            // 
            // lblOrderDeleteCountry
            // 
            this.lblOrderDeleteCountry.AutoSize = true;
            this.lblOrderDeleteCountry.Location = new System.Drawing.Point(440, 34);
            this.lblOrderDeleteCountry.Name = "lblOrderDeleteCountry";
            this.lblOrderDeleteCountry.Size = new System.Drawing.Size(16, 13);
            this.lblOrderDeleteCountry.TabIndex = 8;
            this.lblOrderDeleteCountry.Text = "---";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(399, 34);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Ülke :";
            // 
            // lblOrderDeleteDate
            // 
            this.lblOrderDeleteDate.AutoSize = true;
            this.lblOrderDeleteDate.Location = new System.Drawing.Point(261, 34);
            this.lblOrderDeleteDate.Name = "lblOrderDeleteDate";
            this.lblOrderDeleteDate.Size = new System.Drawing.Size(16, 13);
            this.lblOrderDeleteDate.TabIndex = 6;
            this.lblOrderDeleteDate.Text = "---";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(227, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Tarih :";
            // 
            // lblOrderDeleteEmployee
            // 
            this.lblOrderDeleteEmployee.AutoSize = true;
            this.lblOrderDeleteEmployee.Location = new System.Drawing.Point(90, 65);
            this.lblOrderDeleteEmployee.Name = "lblOrderDeleteEmployee";
            this.lblOrderDeleteEmployee.Size = new System.Drawing.Size(16, 13);
            this.lblOrderDeleteEmployee.TabIndex = 4;
            this.lblOrderDeleteEmployee.Text = "---";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Personel :";
            // 
            // lblOrderDeleteCustomer
            // 
            this.lblOrderDeleteCustomer.AutoSize = true;
            this.lblOrderDeleteCustomer.Location = new System.Drawing.Point(83, 34);
            this.lblOrderDeleteCustomer.Name = "lblOrderDeleteCustomer";
            this.lblOrderDeleteCustomer.Size = new System.Drawing.Size(16, 13);
            this.lblOrderDeleteCustomer.TabIndex = 2;
            this.lblOrderDeleteCustomer.Text = "---";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Müşteri :";
            // 
            // dgOrderDelete
            // 
            this.dgOrderDelete.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgOrderDelete.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgOrderDelete.Location = new System.Drawing.Point(42, 81);
            this.dgOrderDelete.Name = "dgOrderDelete";
            this.dgOrderDelete.Size = new System.Drawing.Size(581, 150);
            this.dgOrderDelete.TabIndex = 0;
            this.dgOrderDelete.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgOrderDelete_CellMouseClick);
            // 
            // lblOrderDeleteCity
            // 
            this.lblOrderDeleteCity.AutoSize = true;
            this.lblOrderDeleteCity.Location = new System.Drawing.Point(261, 65);
            this.lblOrderDeleteCity.Name = "lblOrderDeleteCity";
            this.lblOrderDeleteCity.Size = new System.Drawing.Size(16, 13);
            this.lblOrderDeleteCity.TabIndex = 13;
            this.lblOrderDeleteCity.Text = "---";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(227, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Şehir :";
            // 
            // OrderDelete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 450);
            this.Controls.Add(this.gbxOrderDelete);
            this.Name = "OrderDelete";
            this.Text = "Sipariş İptal";
            this.Load += new System.EventHandler(this.OrderDelete_Load);
            this.gbxOrderDelete.ResumeLayout(false);
            this.gbxOrderDelete.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgOrderDelete)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxOrderDelete;
        private System.Windows.Forms.Button btnOrderDelete;
        private System.Windows.Forms.Label lblOrderDeleteAdress;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblOrderDeleteCountry;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblOrderDeleteDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblOrderDeleteEmployee;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblOrderDeleteCustomer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgOrderDelete;
        private System.Windows.Forms.Label lblOrderDeleteCity;
        private System.Windows.Forms.Label label4;
    }
}