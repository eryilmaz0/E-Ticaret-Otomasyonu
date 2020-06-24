namespace KitapEviDemo.Forms
{
    partial class CompanyForm
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
            this.panelButtons = new System.Windows.Forms.Panel();
            this.Productsgbx2 = new System.Windows.Forms.GroupBox();
            this.btnCompanyUpdate = new System.Windows.Forms.Button();
            this.btnCompanyRefresh = new System.Windows.Forms.Button();
            this.btnCompanyDelete = new System.Windows.Forms.Button();
            this.btnCompanyAdd = new System.Windows.Forms.Button();
            this.panelFilter = new System.Windows.Forms.Panel();
            this.CompanyGbx1 = new System.Windows.Forms.GroupBox();
            this.btnCompanyFilter = new System.Windows.Forms.Button();
            this.tbxCompanyFilter = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.NumCompanyEnBuyuk = new System.Windows.Forms.NumericUpDown();
            this.NumCompanyEnDusuk = new System.Windows.Forms.NumericUpDown();
            this.dgCompany = new System.Windows.Forms.DataGridView();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.pRODUCTSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cATEGORIESToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eMPLOYEESToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oRDERSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cOMPANIESToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cUSTOMERSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelButtons.SuspendLayout();
            this.Productsgbx2.SuspendLayout();
            this.panelFilter.SuspendLayout();
            this.CompanyGbx1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumCompanyEnBuyuk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumCompanyEnDusuk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgCompany)).BeginInit();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelButtons
            // 
            this.panelButtons.Controls.Add(this.Productsgbx2);
            this.panelButtons.Location = new System.Drawing.Point(0, 188);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new System.Drawing.Size(748, 36);
            this.panelButtons.TabIndex = 22;
            // 
            // Productsgbx2
            // 
            this.Productsgbx2.Controls.Add(this.btnCompanyUpdate);
            this.Productsgbx2.Controls.Add(this.btnCompanyRefresh);
            this.Productsgbx2.Controls.Add(this.btnCompanyDelete);
            this.Productsgbx2.Controls.Add(this.btnCompanyAdd);
            this.Productsgbx2.Location = new System.Drawing.Point(3, 1);
            this.Productsgbx2.Name = "Productsgbx2";
            this.Productsgbx2.Size = new System.Drawing.Size(743, 34);
            this.Productsgbx2.TabIndex = 12;
            this.Productsgbx2.TabStop = false;
            // 
            // btnCompanyUpdate
            // 
            this.btnCompanyUpdate.Location = new System.Drawing.Point(231, 0);
            this.btnCompanyUpdate.Name = "btnCompanyUpdate";
            this.btnCompanyUpdate.Size = new System.Drawing.Size(109, 34);
            this.btnCompanyUpdate.TabIndex = 2;
            this.btnCompanyUpdate.Text = "GÜNCELLE";
            this.btnCompanyUpdate.UseVisualStyleBackColor = true;
            this.btnCompanyUpdate.Click += new System.EventHandler(this.btnCompanyUpdate_Click);
            // 
            // btnCompanyRefresh
            // 
            this.btnCompanyRefresh.Location = new System.Drawing.Point(642, 0);
            this.btnCompanyRefresh.Name = "btnCompanyRefresh";
            this.btnCompanyRefresh.Size = new System.Drawing.Size(104, 34);
            this.btnCompanyRefresh.TabIndex = 12;
            this.btnCompanyRefresh.Text = "YENİLE";
            this.btnCompanyRefresh.UseVisualStyleBackColor = true;
            this.btnCompanyRefresh.Click += new System.EventHandler(this.btnCompanyRefresh_Click);
            // 
            // btnCompanyDelete
            // 
            this.btnCompanyDelete.Location = new System.Drawing.Point(115, 0);
            this.btnCompanyDelete.Name = "btnCompanyDelete";
            this.btnCompanyDelete.Size = new System.Drawing.Size(109, 34);
            this.btnCompanyDelete.TabIndex = 1;
            this.btnCompanyDelete.Text = "SİL";
            this.btnCompanyDelete.UseVisualStyleBackColor = true;
            this.btnCompanyDelete.Click += new System.EventHandler(this.btnCompanyDelete_Click);
            // 
            // btnCompanyAdd
            // 
            this.btnCompanyAdd.Location = new System.Drawing.Point(0, 0);
            this.btnCompanyAdd.Name = "btnCompanyAdd";
            this.btnCompanyAdd.Size = new System.Drawing.Size(109, 34);
            this.btnCompanyAdd.TabIndex = 0;
            this.btnCompanyAdd.Text = "EKLE";
            this.btnCompanyAdd.UseVisualStyleBackColor = true;
            this.btnCompanyAdd.Click += new System.EventHandler(this.btnCompanyAdd_Click);
            // 
            // panelFilter
            // 
            this.panelFilter.Controls.Add(this.CompanyGbx1);
            this.panelFilter.Location = new System.Drawing.Point(0, 32);
            this.panelFilter.Name = "panelFilter";
            this.panelFilter.Size = new System.Drawing.Size(746, 150);
            this.panelFilter.TabIndex = 21;
            // 
            // CompanyGbx1
            // 
            this.CompanyGbx1.Controls.Add(this.btnCompanyFilter);
            this.CompanyGbx1.Controls.Add(this.tbxCompanyFilter);
            this.CompanyGbx1.Controls.Add(this.label7);
            this.CompanyGbx1.Controls.Add(this.label6);
            this.CompanyGbx1.Controls.Add(this.label3);
            this.CompanyGbx1.Controls.Add(this.label2);
            this.CompanyGbx1.Controls.Add(this.label1);
            this.CompanyGbx1.Controls.Add(this.NumCompanyEnBuyuk);
            this.CompanyGbx1.Controls.Add(this.NumCompanyEnDusuk);
            this.CompanyGbx1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CompanyGbx1.Location = new System.Drawing.Point(3, 3);
            this.CompanyGbx1.Name = "CompanyGbx1";
            this.CompanyGbx1.Size = new System.Drawing.Size(740, 144);
            this.CompanyGbx1.TabIndex = 11;
            this.CompanyGbx1.TabStop = false;
            this.CompanyGbx1.Text = "Şirket Filtrele";
            // 
            // btnCompanyFilter
            // 
            this.btnCompanyFilter.Location = new System.Drawing.Point(94, 107);
            this.btnCompanyFilter.Name = "btnCompanyFilter";
            this.btnCompanyFilter.Size = new System.Drawing.Size(86, 32);
            this.btnCompanyFilter.TabIndex = 11;
            this.btnCompanyFilter.Text = "UYGULA";
            this.btnCompanyFilter.UseVisualStyleBackColor = true;
            this.btnCompanyFilter.Click += new System.EventHandler(this.btnCompanyFilter_Click);
            // 
            // tbxCompanyFilter
            // 
            this.tbxCompanyFilter.Location = new System.Drawing.Point(323, 54);
            this.tbxCompanyFilter.Name = "tbxCompanyFilter";
            this.tbxCompanyFilter.Size = new System.Drawing.Size(126, 20);
            this.tbxCompanyFilter.TabIndex = 10;
            this.tbxCompanyFilter.TextChanged += new System.EventHandler(this.tbxCompanyFilter_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(263, 57);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Ürün Adı :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(263, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "İsme Göre";
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
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ürün Sayısına Göre";
            // 
            // NumCompanyEnBuyuk
            // 
            this.NumCompanyEnBuyuk.Location = new System.Drawing.Point(94, 81);
            this.NumCompanyEnBuyuk.Name = "NumCompanyEnBuyuk";
            this.NumCompanyEnBuyuk.Size = new System.Drawing.Size(86, 20);
            this.NumCompanyEnBuyuk.TabIndex = 1;
            // 
            // NumCompanyEnDusuk
            // 
            this.NumCompanyEnDusuk.Location = new System.Drawing.Point(94, 55);
            this.NumCompanyEnDusuk.Name = "NumCompanyEnDusuk";
            this.NumCompanyEnDusuk.Size = new System.Drawing.Size(86, 20);
            this.NumCompanyEnDusuk.TabIndex = 0;
            // 
            // dgCompany
            // 
            this.dgCompany.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgCompany.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCompany.GridColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dgCompany.Location = new System.Drawing.Point(0, 229);
            this.dgCompany.Name = "dgCompany";
            this.dgCompany.Size = new System.Drawing.Size(746, 453);
            this.dgCompany.TabIndex = 20;
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
            this.menuStrip2.Size = new System.Drawing.Size(800, 29);
            this.menuStrip2.TabIndex = 19;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // pRODUCTSToolStripMenuItem
            // 
            this.pRODUCTSToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pRODUCTSToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.pRODUCTSToolStripMenuItem.Name = "pRODUCTSToolStripMenuItem";
            this.pRODUCTSToolStripMenuItem.Size = new System.Drawing.Size(91, 23);
            this.pRODUCTSToolStripMenuItem.Text = "PRODUCTS";
            this.pRODUCTSToolStripMenuItem.Click += new System.EventHandler(this.pRODUCTSToolStripMenuItem_Click);
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
            // 
            // cUSTOMERSToolStripMenuItem
            // 
            this.cUSTOMERSToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cUSTOMERSToolStripMenuItem.Name = "cUSTOMERSToolStripMenuItem";
            this.cUSTOMERSToolStripMenuItem.Size = new System.Drawing.Size(99, 23);
            this.cUSTOMERSToolStripMenuItem.Text = "CUSTOMERS";
            this.cUSTOMERSToolStripMenuItem.Click += new System.EventHandler(this.cUSTOMERSToolStripMenuItem_Click);
            // 
            // CompanyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelButtons);
            this.Controls.Add(this.panelFilter);
            this.Controls.Add(this.dgCompany);
            this.Controls.Add(this.menuStrip2);
            this.IsMdiContainer = true;
            this.Name = "CompanyForm";
            this.Text = "CompanyForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CompanyForm_FormClosing);
            this.Load += new System.EventHandler(this.CompanyForm_Load);
            this.panelButtons.ResumeLayout(false);
            this.Productsgbx2.ResumeLayout(false);
            this.panelFilter.ResumeLayout(false);
            this.CompanyGbx1.ResumeLayout(false);
            this.CompanyGbx1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumCompanyEnBuyuk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumCompanyEnDusuk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgCompany)).EndInit();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelButtons;
        private System.Windows.Forms.GroupBox Productsgbx2;
        private System.Windows.Forms.Button btnCompanyUpdate;
        private System.Windows.Forms.Button btnCompanyRefresh;
        private System.Windows.Forms.Button btnCompanyDelete;
        private System.Windows.Forms.Button btnCompanyAdd;
        private System.Windows.Forms.Panel panelFilter;
        private System.Windows.Forms.DataGridView dgCompany;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem pRODUCTSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cATEGORIESToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eMPLOYEESToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oRDERSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cOMPANIESToolStripMenuItem;
        private System.Windows.Forms.GroupBox CompanyGbx1;
        private System.Windows.Forms.Button btnCompanyFilter;
        private System.Windows.Forms.TextBox tbxCompanyFilter;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown NumCompanyEnBuyuk;
        private System.Windows.Forms.NumericUpDown NumCompanyEnDusuk;
        private System.Windows.Forms.ToolStripMenuItem cUSTOMERSToolStripMenuItem;
    }
}