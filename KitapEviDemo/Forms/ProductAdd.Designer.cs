namespace KitapEviDemo.Forms
{
    partial class ProductAdd
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
            this.ProductAddBtn = new System.Windows.Forms.Button();
            this.ProductAddQuantityTbx = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ProductAddPriceNumeric = new System.Windows.Forms.NumericUpDown();
            this.ProductAddCompanyComboBox = new System.Windows.Forms.ComboBox();
            this.ProductAddCatComboBox = new System.Windows.Forms.ComboBox();
            this.ProductAddNametbx = new System.Windows.Forms.TextBox();
            this.ProductAddGbx.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductAddPriceNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // ProductAddGbx
            // 
            this.ProductAddGbx.Controls.Add(this.ProductAddBtn);
            this.ProductAddGbx.Controls.Add(this.ProductAddQuantityTbx);
            this.ProductAddGbx.Controls.Add(this.label5);
            this.ProductAddGbx.Controls.Add(this.label4);
            this.ProductAddGbx.Controls.Add(this.label3);
            this.ProductAddGbx.Controls.Add(this.label2);
            this.ProductAddGbx.Controls.Add(this.label1);
            this.ProductAddGbx.Controls.Add(this.ProductAddPriceNumeric);
            this.ProductAddGbx.Controls.Add(this.ProductAddCompanyComboBox);
            this.ProductAddGbx.Controls.Add(this.ProductAddCatComboBox);
            this.ProductAddGbx.Controls.Add(this.ProductAddNametbx);
            this.ProductAddGbx.Location = new System.Drawing.Point(2, 3);
            this.ProductAddGbx.Name = "ProductAddGbx";
            this.ProductAddGbx.Size = new System.Drawing.Size(370, 347);
            this.ProductAddGbx.TabIndex = 0;
            this.ProductAddGbx.TabStop = false;
            this.ProductAddGbx.Text = "Ürün Ekle";
            // 
            // ProductAddBtn
            // 
            this.ProductAddBtn.Location = new System.Drawing.Point(122, 290);
            this.ProductAddBtn.Name = "ProductAddBtn";
            this.ProductAddBtn.Size = new System.Drawing.Size(119, 32);
            this.ProductAddBtn.TabIndex = 11;
            this.ProductAddBtn.Text = "Ürünü Ekle";
            this.ProductAddBtn.UseVisualStyleBackColor = true;
            this.ProductAddBtn.Click += new System.EventHandler(this.ProductAddBtn_Click);
            // 
            // ProductAddQuantityTbx
            // 
            this.ProductAddQuantityTbx.Location = new System.Drawing.Point(121, 188);
            this.ProductAddQuantityTbx.Name = "ProductAddQuantityTbx";
            this.ProductAddQuantityTbx.Size = new System.Drawing.Size(122, 20);
            this.ProductAddQuantityTbx.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(86, 246);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Fiyat";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(86, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Adet";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(81, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Şirket";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Kategori";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Ürün Adı ";
            // 
            // ProductAddPriceNumeric
            // 
            this.ProductAddPriceNumeric.DecimalPlaces = 1;
            this.ProductAddPriceNumeric.Location = new System.Drawing.Point(121, 244);
            this.ProductAddPriceNumeric.Name = "ProductAddPriceNumeric";
            this.ProductAddPriceNumeric.Size = new System.Drawing.Size(122, 20);
            this.ProductAddPriceNumeric.TabIndex = 4;
            // 
            // ProductAddCompanyComboBox
            // 
            this.ProductAddCompanyComboBox.FormattingEnabled = true;
            this.ProductAddCompanyComboBox.Location = new System.Drawing.Point(121, 136);
            this.ProductAddCompanyComboBox.Name = "ProductAddCompanyComboBox";
            this.ProductAddCompanyComboBox.Size = new System.Drawing.Size(122, 21);
            this.ProductAddCompanyComboBox.TabIndex = 2;
            // 
            // ProductAddCatComboBox
            // 
            this.ProductAddCatComboBox.FormattingEnabled = true;
            this.ProductAddCatComboBox.Location = new System.Drawing.Point(121, 82);
            this.ProductAddCatComboBox.Name = "ProductAddCatComboBox";
            this.ProductAddCatComboBox.Size = new System.Drawing.Size(121, 21);
            this.ProductAddCatComboBox.TabIndex = 1;
            // 
            // ProductAddNametbx
            // 
            this.ProductAddNametbx.Location = new System.Drawing.Point(121, 30);
            this.ProductAddNametbx.Name = "ProductAddNametbx";
            this.ProductAddNametbx.Size = new System.Drawing.Size(122, 20);
            this.ProductAddNametbx.TabIndex = 0;
            // 
            // ProductAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 351);
            this.Controls.Add(this.ProductAddGbx);
            this.Name = "ProductAdd";
            this.Text = "Ürün Ekle";
            this.Load += new System.EventHandler(this.ProductAdd_Load);
            this.ProductAddGbx.ResumeLayout(false);
            this.ProductAddGbx.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductAddPriceNumeric)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox ProductAddGbx;
        private System.Windows.Forms.ComboBox ProductAddCompanyComboBox;
        private System.Windows.Forms.ComboBox ProductAddCatComboBox;
        private System.Windows.Forms.TextBox ProductAddNametbx;
        private System.Windows.Forms.Button ProductAddBtn;
        private System.Windows.Forms.TextBox ProductAddQuantityTbx;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown ProductAddPriceNumeric;
    }
}