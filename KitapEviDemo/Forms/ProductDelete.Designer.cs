namespace KitapEviDemo.Forms
{
    partial class ProductDelete
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
            this.ProductAddGbx = new System.Windows.Forms.GroupBox();
            this.productDeleteButton = new System.Windows.Forms.Button();
            this.productDeletedg = new System.Windows.Forms.DataGridView();
            this.productDeletePriceLbl = new System.Windows.Forms.Label();
            this.productDeleteQuantityLbl = new System.Windows.Forms.Label();
            this.productDeleteCompanyLbl = new System.Windows.Forms.Label();
            this.productDeleteCatLbl = new System.Windows.Forms.Label();
            this.productDeleteNameLbl = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.kdoawokawd = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ProductAddGbx.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productDeletedg)).BeginInit();
            this.SuspendLayout();
            // 
            // ProductAddGbx
            // 
            this.ProductAddGbx.Controls.Add(this.productDeleteButton);
            this.ProductAddGbx.Controls.Add(this.productDeletedg);
            this.ProductAddGbx.Controls.Add(this.productDeletePriceLbl);
            this.ProductAddGbx.Controls.Add(this.productDeleteQuantityLbl);
            this.ProductAddGbx.Controls.Add(this.productDeleteCompanyLbl);
            this.ProductAddGbx.Controls.Add(this.productDeleteCatLbl);
            this.ProductAddGbx.Controls.Add(this.productDeleteNameLbl);
            this.ProductAddGbx.Controls.Add(this.label5);
            this.ProductAddGbx.Controls.Add(this.label4);
            this.ProductAddGbx.Controls.Add(this.kdoawokawd);
            this.ProductAddGbx.Controls.Add(this.label2);
            this.ProductAddGbx.Controls.Add(this.label1);
            this.ProductAddGbx.Location = new System.Drawing.Point(0, 0);
            this.ProductAddGbx.Name = "ProductAddGbx";
            this.ProductAddGbx.Size = new System.Drawing.Size(697, 357);
            this.ProductAddGbx.TabIndex = 1;
            this.ProductAddGbx.TabStop = false;
            this.ProductAddGbx.Text = "Ürün Sil";
            // 
            // productDeleteButton
            // 
            this.productDeleteButton.Location = new System.Drawing.Point(248, 265);
            this.productDeleteButton.Name = "productDeleteButton";
            this.productDeleteButton.Size = new System.Drawing.Size(133, 34);
            this.productDeleteButton.TabIndex = 18;
            this.productDeleteButton.Text = "Ürünü Sil";
            this.productDeleteButton.UseVisualStyleBackColor = true;
            this.productDeleteButton.Click += new System.EventHandler(this.productDeleteButton_Click);
            // 
            // productDeletedg
            // 
            this.productDeletedg.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.productDeletedg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productDeletedg.Location = new System.Drawing.Point(40, 77);
            this.productDeletedg.Name = "productDeletedg";
            this.productDeletedg.Size = new System.Drawing.Size(564, 163);
            this.productDeletedg.TabIndex = 17;
            this.productDeletedg.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.productDeletedg_CellMouseClick);
            // 
            // productDeletePriceLbl
            // 
            this.productDeletePriceLbl.AutoSize = true;
            this.productDeletePriceLbl.Location = new System.Drawing.Point(552, 37);
            this.productDeletePriceLbl.Name = "productDeletePriceLbl";
            this.productDeletePriceLbl.Size = new System.Drawing.Size(16, 13);
            this.productDeletePriceLbl.TabIndex = 16;
            this.productDeletePriceLbl.Text = "---";
            // 
            // productDeleteQuantityLbl
            // 
            this.productDeleteQuantityLbl.AutoSize = true;
            this.productDeleteQuantityLbl.Location = new System.Drawing.Point(443, 37);
            this.productDeleteQuantityLbl.Name = "productDeleteQuantityLbl";
            this.productDeleteQuantityLbl.Size = new System.Drawing.Size(16, 13);
            this.productDeleteQuantityLbl.TabIndex = 15;
            this.productDeleteQuantityLbl.Text = "---";
            // 
            // productDeleteCompanyLbl
            // 
            this.productDeleteCompanyLbl.AutoSize = true;
            this.productDeleteCompanyLbl.Location = new System.Drawing.Point(332, 37);
            this.productDeleteCompanyLbl.Name = "productDeleteCompanyLbl";
            this.productDeleteCompanyLbl.Size = new System.Drawing.Size(16, 13);
            this.productDeleteCompanyLbl.TabIndex = 14;
            this.productDeleteCompanyLbl.Text = "---";
            // 
            // productDeleteCatLbl
            // 
            this.productDeleteCatLbl.AutoSize = true;
            this.productDeleteCatLbl.Location = new System.Drawing.Point(216, 37);
            this.productDeleteCatLbl.Name = "productDeleteCatLbl";
            this.productDeleteCatLbl.Size = new System.Drawing.Size(16, 13);
            this.productDeleteCatLbl.TabIndex = 13;
            this.productDeleteCatLbl.Text = "---";
            // 
            // productDeleteNameLbl
            // 
            this.productDeleteNameLbl.AutoSize = true;
            this.productDeleteNameLbl.Location = new System.Drawing.Point(101, 37);
            this.productDeleteNameLbl.Name = "productDeleteNameLbl";
            this.productDeleteNameLbl.Size = new System.Drawing.Size(16, 13);
            this.productDeleteNameLbl.TabIndex = 12;
            this.productDeleteNameLbl.Text = "---";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(520, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Fiyat :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(411, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Adet :";
            // 
            // kdoawokawd
            // 
            this.kdoawokawd.AutoSize = true;
            this.kdoawokawd.Location = new System.Drawing.Point(295, 37);
            this.kdoawokawd.Name = "kdoawokawd";
            this.kdoawokawd.Size = new System.Drawing.Size(40, 13);
            this.kdoawokawd.TabIndex = 7;
            this.kdoawokawd.Text = "Şirket :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(167, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Kategori :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Ürün Adı  :";
            // 
            // ProductDelete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 320);
            this.Controls.Add(this.ProductAddGbx);
            this.Name = "ProductDelete";
            this.Text = "Ürün Sil";
            this.Load += new System.EventHandler(this.ProductDelete_Load);
            this.ProductAddGbx.ResumeLayout(false);
            this.ProductAddGbx.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productDeletedg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox ProductAddGbx;
        private System.Windows.Forms.Button productDeleteButton;
        private System.Windows.Forms.DataGridView productDeletedg;
        private System.Windows.Forms.Label productDeletePriceLbl;
        private System.Windows.Forms.Label productDeleteQuantityLbl;
        private System.Windows.Forms.Label productDeleteCompanyLbl;
        private System.Windows.Forms.Label productDeleteCatLbl;
        private System.Windows.Forms.Label productDeleteNameLbl;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label kdoawokawd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}