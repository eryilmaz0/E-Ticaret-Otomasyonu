namespace KitapEviDemo.Forms
{
    partial class OrderUpdate
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
            this.gbxOrderUpdate = new System.Windows.Forms.GroupBox();
            this.btnOrderUpdate = new System.Windows.Forms.Button();
            this.dgOrderUpdate = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxOrderUpdateCity = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxOrderUpdateAdres = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbxOrderUpdateCountry = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.checkOrderUpdate = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblSelectedOrder = new System.Windows.Forms.Label();
            this.gbxOrderUpdate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgOrderUpdate)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxOrderUpdate
            // 
            this.gbxOrderUpdate.Controls.Add(this.lblSelectedOrder);
            this.gbxOrderUpdate.Controls.Add(this.label1);
            this.gbxOrderUpdate.Controls.Add(this.checkOrderUpdate);
            this.gbxOrderUpdate.Controls.Add(this.label6);
            this.gbxOrderUpdate.Controls.Add(this.btnOrderUpdate);
            this.gbxOrderUpdate.Controls.Add(this.tbxOrderUpdateCountry);
            this.gbxOrderUpdate.Controls.Add(this.label5);
            this.gbxOrderUpdate.Controls.Add(this.tbxOrderUpdateAdres);
            this.gbxOrderUpdate.Controls.Add(this.label3);
            this.gbxOrderUpdate.Controls.Add(this.tbxOrderUpdateCity);
            this.gbxOrderUpdate.Controls.Add(this.label2);
            this.gbxOrderUpdate.Controls.Add(this.dgOrderUpdate);
            this.gbxOrderUpdate.Location = new System.Drawing.Point(0, 0);
            this.gbxOrderUpdate.Name = "gbxOrderUpdate";
            this.gbxOrderUpdate.Size = new System.Drawing.Size(639, 594);
            this.gbxOrderUpdate.TabIndex = 1;
            this.gbxOrderUpdate.TabStop = false;
            this.gbxOrderUpdate.Text = "Müşteri Güncelle";
            // 
            // btnOrderUpdate
            // 
            this.btnOrderUpdate.Location = new System.Drawing.Point(257, 443);
            this.btnOrderUpdate.Name = "btnOrderUpdate";
            this.btnOrderUpdate.Size = new System.Drawing.Size(110, 31);
            this.btnOrderUpdate.TabIndex = 14;
            this.btnOrderUpdate.Text = "Sipariş Güncelle";
            this.btnOrderUpdate.UseVisualStyleBackColor = true;
            this.btnOrderUpdate.Click += new System.EventHandler(this.btnOrderUpdate_Click);
            // 
            // dgOrderUpdate
            // 
            this.dgOrderUpdate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgOrderUpdate.Location = new System.Drawing.Point(12, 51);
            this.dgOrderUpdate.Name = "dgOrderUpdate";
            this.dgOrderUpdate.Size = new System.Drawing.Size(594, 207);
            this.dgOrderUpdate.TabIndex = 0;
            this.dgOrderUpdate.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgOrderUpdate_CellMouseClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 334);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Şehir :";
            // 
            // tbxOrderUpdateCity
            // 
            this.tbxOrderUpdateCity.Location = new System.Drawing.Point(55, 331);
            this.tbxOrderUpdateCity.Name = "tbxOrderUpdateCity";
            this.tbxOrderUpdateCity.ReadOnly = true;
            this.tbxOrderUpdateCity.Size = new System.Drawing.Size(110, 20);
            this.tbxOrderUpdateCity.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(415, 334);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Adres :";
            // 
            // tbxOrderUpdateAdres
            // 
            this.tbxOrderUpdateAdres.Location = new System.Drawing.Point(461, 331);
            this.tbxOrderUpdateAdres.Name = "tbxOrderUpdateAdres";
            this.tbxOrderUpdateAdres.ReadOnly = true;
            this.tbxOrderUpdateAdres.Size = new System.Drawing.Size(110, 20);
            this.tbxOrderUpdateAdres.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(211, 334);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Ülke :";
            // 
            // tbxOrderUpdateCountry
            // 
            this.tbxOrderUpdateCountry.Location = new System.Drawing.Point(257, 331);
            this.tbxOrderUpdateCountry.Name = "tbxOrderUpdateCountry";
            this.tbxOrderUpdateCountry.ReadOnly = true;
            this.tbxOrderUpdateCountry.Size = new System.Drawing.Size(110, 20);
            this.tbxOrderUpdateCountry.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(211, 398);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(198, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Sipariş Tarihi Otomatik Güncellenecektir.";
            // 
            // checkOrderUpdate
            // 
            this.checkOrderUpdate.AutoSize = true;
            this.checkOrderUpdate.Checked = true;
            this.checkOrderUpdate.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkOrderUpdate.Location = new System.Drawing.Point(13, 285);
            this.checkOrderUpdate.Name = "checkOrderUpdate";
            this.checkOrderUpdate.Size = new System.Drawing.Size(202, 17);
            this.checkOrderUpdate.TabIndex = 16;
            this.checkOrderUpdate.Text = "Müşterinin Güncel Adresi İle Güncelle";
            this.checkOrderUpdate.UseVisualStyleBackColor = true;
            this.checkOrderUpdate.CheckedChanged += new System.EventHandler(this.checkOrderUpdate_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(254, 285);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Seçili Sipariş :";
            // 
            // lblSelectedOrder
            // 
            this.lblSelectedOrder.AutoSize = true;
            this.lblSelectedOrder.Location = new System.Drawing.Point(322, 286);
            this.lblSelectedOrder.Name = "lblSelectedOrder";
            this.lblSelectedOrder.Size = new System.Drawing.Size(16, 13);
            this.lblSelectedOrder.TabIndex = 18;
            this.lblSelectedOrder.Text = "---";
            // 
            // OrderUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 548);
            this.Controls.Add(this.gbxOrderUpdate);
            this.Name = "OrderUpdate";
            this.Text = "Sipariş Güncelle";
            this.Load += new System.EventHandler(this.OrderUpdate_Load);
            this.gbxOrderUpdate.ResumeLayout(false);
            this.gbxOrderUpdate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgOrderUpdate)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxOrderUpdate;
        private System.Windows.Forms.Button btnOrderUpdate;
        private System.Windows.Forms.DataGridView dgOrderUpdate;
        private System.Windows.Forms.TextBox tbxOrderUpdateCountry;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbxOrderUpdateAdres;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxOrderUpdateCity;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox checkOrderUpdate;
        private System.Windows.Forms.Label lblSelectedOrder;
        private System.Windows.Forms.Label label1;
    }
}