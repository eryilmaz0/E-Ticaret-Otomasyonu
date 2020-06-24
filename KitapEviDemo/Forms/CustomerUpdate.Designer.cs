namespace KitapEviDemo.Forms
{
    partial class CustomerUpdate
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
            this.gbxCustomerUpdate = new System.Windows.Forms.GroupBox();
            this.dgCustomerUpdate = new System.Windows.Forms.DataGridView();
            this.tbxCustomerUpdateName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxCustomerUpdateLastName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxCustomerUpdateCity = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxCustomerUpdateCountry = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxCustomerUpdateAdress = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbxCustomerUpdatePhone = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnCustomerUpdate = new System.Windows.Forms.Button();
            this.gbxCustomerUpdate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgCustomerUpdate)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxCustomerUpdate
            // 
            this.gbxCustomerUpdate.Controls.Add(this.btnCustomerUpdate);
            this.gbxCustomerUpdate.Controls.Add(this.tbxCustomerUpdatePhone);
            this.gbxCustomerUpdate.Controls.Add(this.label6);
            this.gbxCustomerUpdate.Controls.Add(this.tbxCustomerUpdateAdress);
            this.gbxCustomerUpdate.Controls.Add(this.label5);
            this.gbxCustomerUpdate.Controls.Add(this.tbxCustomerUpdateCountry);
            this.gbxCustomerUpdate.Controls.Add(this.label4);
            this.gbxCustomerUpdate.Controls.Add(this.tbxCustomerUpdateCity);
            this.gbxCustomerUpdate.Controls.Add(this.label3);
            this.gbxCustomerUpdate.Controls.Add(this.tbxCustomerUpdateLastName);
            this.gbxCustomerUpdate.Controls.Add(this.label2);
            this.gbxCustomerUpdate.Controls.Add(this.tbxCustomerUpdateName);
            this.gbxCustomerUpdate.Controls.Add(this.label1);
            this.gbxCustomerUpdate.Controls.Add(this.dgCustomerUpdate);
            this.gbxCustomerUpdate.Location = new System.Drawing.Point(0, 0);
            this.gbxCustomerUpdate.Name = "gbxCustomerUpdate";
            this.gbxCustomerUpdate.Size = new System.Drawing.Size(625, 594);
            this.gbxCustomerUpdate.TabIndex = 0;
            this.gbxCustomerUpdate.TabStop = false;
            this.gbxCustomerUpdate.Text = "Müşteri Güncelle";
            // 
            // dgCustomerUpdate
            // 
            this.dgCustomerUpdate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCustomerUpdate.Location = new System.Drawing.Point(12, 51);
            this.dgCustomerUpdate.Name = "dgCustomerUpdate";
            this.dgCustomerUpdate.Size = new System.Drawing.Size(594, 245);
            this.dgCustomerUpdate.TabIndex = 0;
            this.dgCustomerUpdate.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgCustomerUpdate_CellMouseClick);
            // 
            // tbxCustomerUpdateName
            // 
            this.tbxCustomerUpdateName.Location = new System.Drawing.Point(47, 333);
            this.tbxCustomerUpdateName.Name = "tbxCustomerUpdateName";
            this.tbxCustomerUpdateName.Size = new System.Drawing.Size(110, 20);
            this.tbxCustomerUpdateName.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 336);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ad :";
            // 
            // tbxCustomerUpdateLastName
            // 
            this.tbxCustomerUpdateLastName.Location = new System.Drawing.Point(230, 333);
            this.tbxCustomerUpdateLastName.Name = "tbxCustomerUpdateLastName";
            this.tbxCustomerUpdateLastName.Size = new System.Drawing.Size(110, 20);
            this.tbxCustomerUpdateLastName.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(181, 336);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Soyad :";
            // 
            // tbxCustomerUpdateCity
            // 
            this.tbxCustomerUpdateCity.Location = new System.Drawing.Point(443, 333);
            this.tbxCustomerUpdateCity.Name = "tbxCustomerUpdateCity";
            this.tbxCustomerUpdateCity.Size = new System.Drawing.Size(110, 20);
            this.tbxCustomerUpdateCity.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(400, 336);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Şehir :";
            // 
            // tbxCustomerUpdateCountry
            // 
            this.tbxCustomerUpdateCountry.Location = new System.Drawing.Point(47, 400);
            this.tbxCustomerUpdateCountry.Name = "tbxCustomerUpdateCountry";
            this.tbxCustomerUpdateCountry.Size = new System.Drawing.Size(110, 20);
            this.tbxCustomerUpdateCountry.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 403);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Ülke :";
            // 
            // tbxCustomerUpdateAdress
            // 
            this.tbxCustomerUpdateAdress.Location = new System.Drawing.Point(230, 400);
            this.tbxCustomerUpdateAdress.Name = "tbxCustomerUpdateAdress";
            this.tbxCustomerUpdateAdress.Size = new System.Drawing.Size(110, 20);
            this.tbxCustomerUpdateAdress.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(184, 403);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Adres :";
            // 
            // tbxCustomerUpdatePhone
            // 
            this.tbxCustomerUpdatePhone.Location = new System.Drawing.Point(443, 400);
            this.tbxCustomerUpdatePhone.Name = "tbxCustomerUpdatePhone";
            this.tbxCustomerUpdatePhone.Size = new System.Drawing.Size(110, 20);
            this.tbxCustomerUpdatePhone.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(388, 403);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Telefon :";
            // 
            // btnCustomerUpdate
            // 
            this.btnCustomerUpdate.Location = new System.Drawing.Point(230, 456);
            this.btnCustomerUpdate.Name = "btnCustomerUpdate";
            this.btnCustomerUpdate.Size = new System.Drawing.Size(110, 31);
            this.btnCustomerUpdate.TabIndex = 14;
            this.btnCustomerUpdate.Text = "Müşteri Güncelle";
            this.btnCustomerUpdate.UseVisualStyleBackColor = true;
            this.btnCustomerUpdate.Click += new System.EventHandler(this.btnCustomerUpdate_Click);
            // 
            // CustomerUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 598);
            this.Controls.Add(this.gbxCustomerUpdate);
            this.Name = "CustomerUpdate";
            this.Text = "Müşteri Güncelle";
            this.Load += new System.EventHandler(this.CustomerUpdate_Load);
            this.gbxCustomerUpdate.ResumeLayout(false);
            this.gbxCustomerUpdate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgCustomerUpdate)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxCustomerUpdate;
        private System.Windows.Forms.DataGridView dgCustomerUpdate;
        private System.Windows.Forms.TextBox tbxCustomerUpdatePhone;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbxCustomerUpdateAdress;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbxCustomerUpdateCountry;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbxCustomerUpdateCity;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxCustomerUpdateLastName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxCustomerUpdateName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCustomerUpdate;
    }
}