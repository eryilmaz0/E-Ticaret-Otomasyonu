namespace KitapEviDemo
{
    partial class ProductsForm
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.pRODUCTSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cATEGORIESToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eMPLOYEESToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oRDERSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cOMPANIESToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cUSTOMERSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button3 = new System.Windows.Forms.Button();
            this.Productsgbx2 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.ResetFilterbtn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dg1 = new System.Windows.Forms.DataGridView();
            this.panelFilter = new System.Windows.Forms.Panel();
            this.Productgbx1 = new System.Windows.Forms.GroupBox();
            this.productCompanyComboBox = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.ProductFilterBtn = new System.Windows.Forms.Button();
            this.ProductSearchtbx = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ProductCombobox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.EnBuyukNumeric = new System.Windows.Forms.NumericUpDown();
            this.EnDusukNumeric = new System.Windows.Forms.NumericUpDown();
            this.panelButtons = new System.Windows.Forms.Panel();
            this.menuStrip2.SuspendLayout();
            this.Productsgbx2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg1)).BeginInit();
            this.panelFilter.SuspendLayout();
            this.Productgbx1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EnBuyukNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EnDusukNumeric)).BeginInit();
            this.panelButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip2
            // 
            this.menuStrip2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pRODUCTSToolStripMenuItem,
            this.cATEGORIESToolStripMenuItem,
            this.eMPLOYEESToolStripMenuItem,
            this.oRDERSToolStripMenuItem,
            this.cOMPANIESToolStripMenuItem,
            this.cUSTOMERSToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.menuStrip2.Size = new System.Drawing.Size(1176, 29);
            this.menuStrip2.TabIndex = 10;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // pRODUCTSToolStripMenuItem
            // 
            this.pRODUCTSToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pRODUCTSToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.pRODUCTSToolStripMenuItem.Name = "pRODUCTSToolStripMenuItem";
            this.pRODUCTSToolStripMenuItem.Size = new System.Drawing.Size(91, 23);
            this.pRODUCTSToolStripMenuItem.Text = "PRODUCTS";
            // 
            // cATEGORIESToolStripMenuItem
            // 
            this.cATEGORIESToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cATEGORIESToolStripMenuItem.Name = "cATEGORIESToolStripMenuItem";
            this.cATEGORIESToolStripMenuItem.Size = new System.Drawing.Size(99, 23);
            this.cATEGORIESToolStripMenuItem.Text = "CATEGORIES";
            this.cATEGORIESToolStripMenuItem.Click += new System.EventHandler(this.cATEGORIESToolStripMenuItem_Click);
            // 
            // eMPLOYEESToolStripMenuItem
            // 
            this.eMPLOYEESToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.eMPLOYEESToolStripMenuItem.Name = "eMPLOYEESToolStripMenuItem";
            this.eMPLOYEESToolStripMenuItem.Size = new System.Drawing.Size(96, 23);
            this.eMPLOYEESToolStripMenuItem.Text = "EMPLOYEES";
            this.eMPLOYEESToolStripMenuItem.Click += new System.EventHandler(this.eMPLOYEESToolStripMenuItem_Click);
            // 
            // oRDERSToolStripMenuItem
            // 
            this.oRDERSToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.oRDERSToolStripMenuItem.Name = "oRDERSToolStripMenuItem";
            this.oRDERSToolStripMenuItem.Size = new System.Drawing.Size(72, 23);
            this.oRDERSToolStripMenuItem.Text = "ORDERS";
            this.oRDERSToolStripMenuItem.Click += new System.EventHandler(this.oRDERSToolStripMenuItem_Click);
            // 
            // cOMPANIESToolStripMenuItem
            // 
            this.cOMPANIESToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cOMPANIESToolStripMenuItem.Name = "cOMPANIESToolStripMenuItem";
            this.cOMPANIESToolStripMenuItem.Size = new System.Drawing.Size(98, 23);
            this.cOMPANIESToolStripMenuItem.Text = "COMPANIES";
            this.cOMPANIESToolStripMenuItem.Click += new System.EventHandler(this.cOMPANIESToolStripMenuItem_Click);
            // 
            // cUSTOMERSToolStripMenuItem
            // 
            this.cUSTOMERSToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cUSTOMERSToolStripMenuItem.Name = "cUSTOMERSToolStripMenuItem";
            this.cUSTOMERSToolStripMenuItem.Size = new System.Drawing.Size(99, 23);
            this.cUSTOMERSToolStripMenuItem.Text = "CUSTOMERS";
            this.cUSTOMERSToolStripMenuItem.Click += new System.EventHandler(this.cUSTOMERSToolStripMenuItem_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(115, 0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(109, 34);
            this.button3.TabIndex = 1;
            this.button3.Text = "SİL";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Productsgbx2
            // 
            this.Productsgbx2.Controls.Add(this.button4);
            this.Productsgbx2.Controls.Add(this.ResetFilterbtn);
            this.Productsgbx2.Controls.Add(this.button3);
            this.Productsgbx2.Controls.Add(this.button2);
            this.Productsgbx2.Location = new System.Drawing.Point(3, 1);
            this.Productsgbx2.Name = "Productsgbx2";
            this.Productsgbx2.Size = new System.Drawing.Size(743, 34);
            this.Productsgbx2.TabIndex = 12;
            this.Productsgbx2.TabStop = false;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(231, 0);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(109, 34);
            this.button4.TabIndex = 2;
            this.button4.Text = "GÜNCELLE";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // ResetFilterbtn
            // 
            this.ResetFilterbtn.Location = new System.Drawing.Point(642, 0);
            this.ResetFilterbtn.Name = "ResetFilterbtn";
            this.ResetFilterbtn.Size = new System.Drawing.Size(104, 34);
            this.ResetFilterbtn.TabIndex = 12;
            this.ResetFilterbtn.Text = "YENİLE";
            this.ResetFilterbtn.UseVisualStyleBackColor = true;
            this.ResetFilterbtn.Click += new System.EventHandler(this.ResetFilterbtn_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(0, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(109, 34);
            this.button2.TabIndex = 0;
            this.button2.Text = "EKLE";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dg1
            // 
            this.dg1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dg1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg1.GridColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dg1.Location = new System.Drawing.Point(0, 229);
            this.dg1.Name = "dg1";
            this.dg1.Size = new System.Drawing.Size(746, 453);
            this.dg1.TabIndex = 15;
            // 
            // panelFilter
            // 
            this.panelFilter.Controls.Add(this.Productgbx1);
            this.panelFilter.Location = new System.Drawing.Point(0, 32);
            this.panelFilter.Name = "panelFilter";
            this.panelFilter.Size = new System.Drawing.Size(746, 150);
            this.panelFilter.TabIndex = 16;
            // 
            // Productgbx1
            // 
            this.Productgbx1.Controls.Add(this.productCompanyComboBox);
            this.Productgbx1.Controls.Add(this.label8);
            this.Productgbx1.Controls.Add(this.ProductFilterBtn);
            this.Productgbx1.Controls.Add(this.ProductSearchtbx);
            this.Productgbx1.Controls.Add(this.label7);
            this.Productgbx1.Controls.Add(this.label6);
            this.Productgbx1.Controls.Add(this.ProductCombobox);
            this.Productgbx1.Controls.Add(this.label5);
            this.Productgbx1.Controls.Add(this.label4);
            this.Productgbx1.Controls.Add(this.label3);
            this.Productgbx1.Controls.Add(this.label2);
            this.Productgbx1.Controls.Add(this.label1);
            this.Productgbx1.Controls.Add(this.EnBuyukNumeric);
            this.Productgbx1.Controls.Add(this.EnDusukNumeric);
            this.Productgbx1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Productgbx1.Location = new System.Drawing.Point(3, 3);
            this.Productgbx1.Name = "Productgbx1";
            this.Productgbx1.Size = new System.Drawing.Size(740, 144);
            this.Productgbx1.TabIndex = 11;
            this.Productgbx1.TabStop = false;
            this.Productgbx1.Text = "Ürün Filtrele";
            // 
            // productCompanyComboBox
            // 
            this.productCompanyComboBox.FormattingEnabled = true;
            this.productCompanyComboBox.Location = new System.Drawing.Point(315, 85);
            this.productCompanyComboBox.Name = "productCompanyComboBox";
            this.productCompanyComboBox.Size = new System.Drawing.Size(121, 21);
            this.productCompanyComboBox.TabIndex = 13;
            this.productCompanyComboBox.SelectedIndexChanged += new System.EventHandler(this.productCompanyComboBox_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(257, 88);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Firma :";
            // 
            // ProductFilterBtn
            // 
            this.ProductFilterBtn.Location = new System.Drawing.Point(94, 116);
            this.ProductFilterBtn.Name = "ProductFilterBtn";
            this.ProductFilterBtn.Size = new System.Drawing.Size(86, 23);
            this.ProductFilterBtn.TabIndex = 11;
            this.ProductFilterBtn.Text = "UYGULA";
            this.ProductFilterBtn.UseVisualStyleBackColor = true;
            this.ProductFilterBtn.Click += new System.EventHandler(this.ProductFilterBtn_Click);
            // 
            // ProductSearchtbx
            // 
            this.ProductSearchtbx.Location = new System.Drawing.Point(560, 54);
            this.ProductSearchtbx.Name = "ProductSearchtbx";
            this.ProductSearchtbx.Size = new System.Drawing.Size(126, 20);
            this.ProductSearchtbx.TabIndex = 10;
            this.ProductSearchtbx.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(489, 57);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Ürün Adı :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(489, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "İsme Göre";
            // 
            // ProductCombobox
            // 
            this.ProductCombobox.FormattingEnabled = true;
            this.ProductCombobox.Location = new System.Drawing.Point(315, 54);
            this.ProductCombobox.Name = "ProductCombobox";
            this.ProductCombobox.Size = new System.Drawing.Size(121, 21);
            this.ProductCombobox.TabIndex = 7;
            this.ProductCombobox.SelectedIndexChanged += new System.EventHandler(this.ProductCombobox_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(257, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Kategori :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(257, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Kategori - Şirkete Göre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Max :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Min :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Fiyata Göre ";
            // 
            // EnBuyukNumeric
            // 
            this.EnBuyukNumeric.Location = new System.Drawing.Point(94, 81);
            this.EnBuyukNumeric.Name = "EnBuyukNumeric";
            this.EnBuyukNumeric.Size = new System.Drawing.Size(86, 20);
            this.EnBuyukNumeric.TabIndex = 1;
            // 
            // EnDusukNumeric
            // 
            this.EnDusukNumeric.Location = new System.Drawing.Point(94, 55);
            this.EnDusukNumeric.Name = "EnDusukNumeric";
            this.EnDusukNumeric.Size = new System.Drawing.Size(86, 20);
            this.EnDusukNumeric.TabIndex = 0;
            // 
            // panelButtons
            // 
            this.panelButtons.Controls.Add(this.Productsgbx2);
            this.panelButtons.Location = new System.Drawing.Point(0, 188);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new System.Drawing.Size(748, 36);
            this.panelButtons.TabIndex = 18;
            // 
            // ProductsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1176, 694);
            this.Controls.Add(this.panelButtons);
            this.Controls.Add(this.panelFilter);
            this.Controls.Add(this.dg1);
            this.Controls.Add(this.menuStrip2);
            this.IsMdiContainer = true;
            this.Name = "ProductsForm";
            this.Text = "Proje Otomasyon";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ProductsForm_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.Productsgbx2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dg1)).EndInit();
            this.panelFilter.ResumeLayout(false);
            this.Productgbx1.ResumeLayout(false);
            this.Productgbx1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EnBuyukNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EnDusukNumeric)).EndInit();
            this.panelButtons.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem pRODUCTSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cATEGORIESToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eMPLOYEESToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oRDERSToolStripMenuItem;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox Productsgbx2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ToolStripMenuItem cOMPANIESToolStripMenuItem;
        private System.Windows.Forms.Button ResetFilterbtn;
        private System.Windows.Forms.DataGridView dg1;
        private System.Windows.Forms.Panel panelFilter;
        private System.Windows.Forms.GroupBox Productgbx1;
        private System.Windows.Forms.Button ProductFilterBtn;
        private System.Windows.Forms.TextBox ProductSearchtbx;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox ProductCombobox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown EnBuyukNumeric;
        private System.Windows.Forms.NumericUpDown EnDusukNumeric;
        private System.Windows.Forms.Panel panelButtons;
        private System.Windows.Forms.ComboBox productCompanyComboBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ToolStripMenuItem cUSTOMERSToolStripMenuItem;
    }
}

