namespace KitapEviDemo.Forms
{
    partial class ProductUpdate
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
            this.ProductUpdatePriceNuneric = new System.Windows.Forms.NumericUpDown();
            this.tbxProductUpdateQuantity = new System.Windows.Forms.TextBox();
            this.cmbBoxproductUpdateCompany = new System.Windows.Forms.ComboBox();
            this.cmbBoxProductUpdateCat = new System.Windows.Forms.ComboBox();
            this.tbxProductUpdateName = new System.Windows.Forms.TextBox();
            this.btnProductUpdate = new System.Windows.Forms.Button();
            this.productUpdatedg = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.kdoawokawd = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ProductAddGbx.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductUpdatePriceNuneric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productUpdatedg)).BeginInit();
            this.SuspendLayout();
            // 
            // ProductAddGbx
            // 
            this.ProductAddGbx.Controls.Add(this.ProductUpdatePriceNuneric);
            this.ProductAddGbx.Controls.Add(this.tbxProductUpdateQuantity);
            this.ProductAddGbx.Controls.Add(this.cmbBoxproductUpdateCompany);
            this.ProductAddGbx.Controls.Add(this.cmbBoxProductUpdateCat);
            this.ProductAddGbx.Controls.Add(this.tbxProductUpdateName);
            this.ProductAddGbx.Controls.Add(this.btnProductUpdate);
            this.ProductAddGbx.Controls.Add(this.productUpdatedg);
            this.ProductAddGbx.Controls.Add(this.label5);
            this.ProductAddGbx.Controls.Add(this.label4);
            this.ProductAddGbx.Controls.Add(this.kdoawokawd);
            this.ProductAddGbx.Controls.Add(this.label2);
            this.ProductAddGbx.Controls.Add(this.label1);
            this.ProductAddGbx.Location = new System.Drawing.Point(0, 0);
            this.ProductAddGbx.Name = "ProductAddGbx";
            this.ProductAddGbx.Size = new System.Drawing.Size(637, 447);
            this.ProductAddGbx.TabIndex = 2;
            this.ProductAddGbx.TabStop = false;
            this.ProductAddGbx.Text = "Ürün Güncelle";
            
            // 
            // ProductUpdatePriceNuneric
            // 
            this.ProductUpdatePriceNuneric.DecimalPlaces = 2;
            this.ProductUpdatePriceNuneric.Location = new System.Drawing.Point(257, 321);
            this.ProductUpdatePriceNuneric.Name = "ProductUpdatePriceNuneric";
            this.ProductUpdatePriceNuneric.Size = new System.Drawing.Size(133, 20);
            this.ProductUpdatePriceNuneric.TabIndex = 23;
            // 
            // tbxProductUpdateQuantity
            // 
            this.tbxProductUpdateQuantity.Location = new System.Drawing.Point(257, 292);
            this.tbxProductUpdateQuantity.Name = "tbxProductUpdateQuantity";
            this.tbxProductUpdateQuantity.Size = new System.Drawing.Size(133, 20);
            this.tbxProductUpdateQuantity.TabIndex = 22;
            // 
            // cmbBoxproductUpdateCompany
            // 
            this.cmbBoxproductUpdateCompany.FormattingEnabled = true;
            this.cmbBoxproductUpdateCompany.Location = new System.Drawing.Point(257, 264);
            this.cmbBoxproductUpdateCompany.Name = "cmbBoxproductUpdateCompany";
            this.cmbBoxproductUpdateCompany.Size = new System.Drawing.Size(133, 21);
            this.cmbBoxproductUpdateCompany.TabIndex = 21;
            // 
            // cmbBoxProductUpdateCat
            // 
            this.cmbBoxProductUpdateCat.FormattingEnabled = true;
            this.cmbBoxProductUpdateCat.Location = new System.Drawing.Point(257, 234);
            this.cmbBoxProductUpdateCat.Name = "cmbBoxProductUpdateCat";
            this.cmbBoxProductUpdateCat.Size = new System.Drawing.Size(133, 21);
            this.cmbBoxProductUpdateCat.TabIndex = 20;
            // 
            // tbxProductUpdateName
            // 
            this.tbxProductUpdateName.Location = new System.Drawing.Point(257, 204);
            this.tbxProductUpdateName.Name = "tbxProductUpdateName";
            this.tbxProductUpdateName.Size = new System.Drawing.Size(133, 20);
            this.tbxProductUpdateName.TabIndex = 19;
            // 
            // btnProductUpdate
            // 
            this.btnProductUpdate.Location = new System.Drawing.Point(257, 361);
            this.btnProductUpdate.Name = "btnProductUpdate";
            this.btnProductUpdate.Size = new System.Drawing.Size(133, 34);
            this.btnProductUpdate.TabIndex = 18;
            this.btnProductUpdate.Text = "Ürünü Güncelle";
            this.btnProductUpdate.UseVisualStyleBackColor = true;
            this.btnProductUpdate.Click += new System.EventHandler(this.btnProductUpdate_Click);
            // 
            // productUpdatedg
            // 
            this.productUpdatedg.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.productUpdatedg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productUpdatedg.Location = new System.Drawing.Point(12, 19);
            this.productUpdatedg.Name = "productUpdatedg";
            this.productUpdatedg.Size = new System.Drawing.Size(603, 163);
            this.productUpdatedg.TabIndex = 17;
            this.productUpdatedg.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.productUpdatedg_CellMouseClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(212, 321);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Fiyat :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(212, 295);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Adet :";
            // 
            // kdoawokawd
            // 
            this.kdoawokawd.AutoSize = true;
            this.kdoawokawd.Location = new System.Drawing.Point(207, 264);
            this.kdoawokawd.Name = "kdoawokawd";
            this.kdoawokawd.Size = new System.Drawing.Size(40, 13);
            this.kdoawokawd.TabIndex = 7;
            this.kdoawokawd.Text = "Şirket :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(195, 234);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Kategori :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(190, 207);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Ürün Adı  :";
            // 
            // ProductUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 418);
            this.Controls.Add(this.ProductAddGbx);
            this.Name = "ProductUpdate";
            this.Text = "Ürün Güncelle";
            this.Load += new System.EventHandler(this.ProductUpdate_Load);
            this.ProductAddGbx.ResumeLayout(false);
            this.ProductAddGbx.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductUpdatePriceNuneric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productUpdatedg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox ProductAddGbx;
        private System.Windows.Forms.NumericUpDown ProductUpdatePriceNuneric;
        private System.Windows.Forms.TextBox tbxProductUpdateQuantity;
        private System.Windows.Forms.ComboBox cmbBoxproductUpdateCompany;
        private System.Windows.Forms.ComboBox cmbBoxProductUpdateCat;
        private System.Windows.Forms.TextBox tbxProductUpdateName;
        private System.Windows.Forms.Button btnProductUpdate;
        private System.Windows.Forms.DataGridView productUpdatedg;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label kdoawokawd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}