namespace KitapEviDemo.Forms
{
    partial class CustomerForm
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
            this.cUSTOMERSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelButtons = new System.Windows.Forms.Panel();
            this.Productsgbx2 = new System.Windows.Forms.GroupBox();
            this.btnCustomerUpdate = new System.Windows.Forms.Button();
            this.btnCustomerRefresh = new System.Windows.Forms.Button();
            this.btnCustomerDelete = new System.Windows.Forms.Button();
            this.btnCustomerAdd = new System.Windows.Forms.Button();
            this.CustomerGbx = new System.Windows.Forms.GroupBox();
            this.tbxCustomerFilterPhone = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbxCustomerFilterCity = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCustomerFilter = new System.Windows.Forms.Button();
            this.tbxCustomerFilterName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.NumCustomerEnBuyuk = new System.Windows.Forms.NumericUpDown();
            this.NumCustomerEnDusuk = new System.Windows.Forms.NumericUpDown();
            this.panelFilter = new System.Windows.Forms.Panel();
            this.dgCustomer = new System.Windows.Forms.DataGridView();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.pRODUCTSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cATEGORIESToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eMPLOYEESToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oRDERSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cOMPANIESToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelButtons.SuspendLayout();
            this.Productsgbx2.SuspendLayout();
            this.CustomerGbx.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumCustomerEnBuyuk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumCustomerEnDusuk)).BeginInit();
            this.panelFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgCustomer)).BeginInit();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // cUSTOMERSToolStripMenuItem
            // 
            this.cUSTOMERSToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cUSTOMERSToolStripMenuItem.Name = "cUSTOMERSToolStripMenuItem";
            this.cUSTOMERSToolStripMenuItem.Size = new System.Drawing.Size(99, 23);
            this.cUSTOMERSToolStripMenuItem.Text = "CUSTOMERS";
            // 
            // panelButtons
            // 
            this.panelButtons.Controls.Add(this.Productsgbx2);
            this.panelButtons.Location = new System.Drawing.Point(0, 191);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new System.Drawing.Size(748, 36);
            this.panelButtons.TabIndex = 22;
            // 
            // Productsgbx2
            // 
            this.Productsgbx2.Controls.Add(this.btnCustomerUpdate);
            this.Productsgbx2.Controls.Add(this.btnCustomerRefresh);
            this.Productsgbx2.Controls.Add(this.btnCustomerDelete);
            this.Productsgbx2.Controls.Add(this.btnCustomerAdd);
            this.Productsgbx2.Location = new System.Drawing.Point(3, 1);
            this.Productsgbx2.Name = "Productsgbx2";
            this.Productsgbx2.Size = new System.Drawing.Size(743, 34);
            this.Productsgbx2.TabIndex = 12;
            this.Productsgbx2.TabStop = false;
            // 
            // btnCustomerUpdate
            // 
            this.btnCustomerUpdate.Location = new System.Drawing.Point(231, 0);
            this.btnCustomerUpdate.Name = "btnCustomerUpdate";
            this.btnCustomerUpdate.Size = new System.Drawing.Size(109, 34);
            this.btnCustomerUpdate.TabIndex = 2;
            this.btnCustomerUpdate.Text = "GÜNCELLE";
            this.btnCustomerUpdate.UseVisualStyleBackColor = true;
            this.btnCustomerUpdate.Click += new System.EventHandler(this.btnCustomerUpdate_Click);
            // 
            // btnCustomerRefresh
            // 
            this.btnCustomerRefresh.Location = new System.Drawing.Point(642, 0);
            this.btnCustomerRefresh.Name = "btnCustomerRefresh";
            this.btnCustomerRefresh.Size = new System.Drawing.Size(104, 34);
            this.btnCustomerRefresh.TabIndex = 12;
            this.btnCustomerRefresh.Text = "YENİLE";
            this.btnCustomerRefresh.UseVisualStyleBackColor = true;
            this.btnCustomerRefresh.Click += new System.EventHandler(this.btnCustomerRefresh_Click);
            // 
            // btnCustomerDelete
            // 
            this.btnCustomerDelete.Location = new System.Drawing.Point(115, 0);
            this.btnCustomerDelete.Name = "btnCustomerDelete";
            this.btnCustomerDelete.Size = new System.Drawing.Size(109, 34);
            this.btnCustomerDelete.TabIndex = 1;
            this.btnCustomerDelete.Text = "SİL";
            this.btnCustomerDelete.UseVisualStyleBackColor = true;
            this.btnCustomerDelete.Click += new System.EventHandler(this.btnCustomerDelete_Click);
            // 
            // btnCustomerAdd
            // 
            this.btnCustomerAdd.Location = new System.Drawing.Point(0, 0);
            this.btnCustomerAdd.Name = "btnCustomerAdd";
            this.btnCustomerAdd.Size = new System.Drawing.Size(109, 34);
            this.btnCustomerAdd.TabIndex = 0;
            this.btnCustomerAdd.Text = "EKLE";
            this.btnCustomerAdd.UseVisualStyleBackColor = true;
            this.btnCustomerAdd.Click += new System.EventHandler(this.btnCustomerAdd_Click);
            // 
            // CustomerGbx
            // 
            this.CustomerGbx.Controls.Add(this.tbxCustomerFilterPhone);
            this.CustomerGbx.Controls.Add(this.label8);
            this.CustomerGbx.Controls.Add(this.tbxCustomerFilterCity);
            this.CustomerGbx.Controls.Add(this.label4);
            this.CustomerGbx.Controls.Add(this.label5);
            this.CustomerGbx.Controls.Add(this.btnCustomerFilter);
            this.CustomerGbx.Controls.Add(this.tbxCustomerFilterName);
            this.CustomerGbx.Controls.Add(this.label7);
            this.CustomerGbx.Controls.Add(this.label6);
            this.CustomerGbx.Controls.Add(this.label3);
            this.CustomerGbx.Controls.Add(this.label2);
            this.CustomerGbx.Controls.Add(this.label1);
            this.CustomerGbx.Controls.Add(this.NumCustomerEnBuyuk);
            this.CustomerGbx.Controls.Add(this.NumCustomerEnDusuk);
            this.CustomerGbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CustomerGbx.Location = new System.Drawing.Point(3, 3);
            this.CustomerGbx.Name = "CustomerGbx";
            this.CustomerGbx.Size = new System.Drawing.Size(740, 144);
            this.CustomerGbx.TabIndex = 11;
            this.CustomerGbx.TabStop = false;
            this.CustomerGbx.Text = "Müşteri Filtrele";
            // 
            // tbxCustomerFilterPhone
            // 
            this.tbxCustomerFilterPhone.Location = new System.Drawing.Point(301, 80);
            this.tbxCustomerFilterPhone.Name = "tbxCustomerFilterPhone";
            this.tbxCustomerFilterPhone.Size = new System.Drawing.Size(126, 20);
            this.tbxCustomerFilterPhone.TabIndex = 17;
            this.tbxCustomerFilterPhone.TextChanged += new System.EventHandler(this.tbxCustomerFilterPhone_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(246, 83);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Telefon :";
            // 
            // tbxCustomerFilterCity
            // 
            this.tbxCustomerFilterCity.Location = new System.Drawing.Point(537, 54);
            this.tbxCustomerFilterCity.Name = "tbxCustomerFilterCity";
            this.tbxCustomerFilterCity.Size = new System.Drawing.Size(126, 20);
            this.tbxCustomerFilterCity.TabIndex = 14;
            this.tbxCustomerFilterCity.TextChanged += new System.EventHandler(this.tbxCustomerFilterCity_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(494, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Şehir :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(476, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Şehire Göre";
            // 
            // btnCustomerFilter
            // 
            this.btnCustomerFilter.Location = new System.Drawing.Point(94, 107);
            this.btnCustomerFilter.Name = "btnCustomerFilter";
            this.btnCustomerFilter.Size = new System.Drawing.Size(86, 32);
            this.btnCustomerFilter.TabIndex = 11;
            this.btnCustomerFilter.Text = "UYGULA";
            this.btnCustomerFilter.UseVisualStyleBackColor = true;
            this.btnCustomerFilter.Click += new System.EventHandler(this.btnCustomerFilter_Click);
            // 
            // tbxCustomerFilterName
            // 
            this.tbxCustomerFilterName.Location = new System.Drawing.Point(301, 55);
            this.tbxCustomerFilterName.Name = "tbxCustomerFilterName";
            this.tbxCustomerFilterName.Size = new System.Drawing.Size(126, 20);
            this.tbxCustomerFilterName.TabIndex = 10;
            this.tbxCustomerFilterName.TextChanged += new System.EventHandler(this.tbxCustomerFilterName_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(264, 58);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "İsim :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(241, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "İsme-Telefona Göre";
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
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Sipariş Sayısına Göre";
            // 
            // NumCustomerEnBuyuk
            // 
            this.NumCustomerEnBuyuk.Location = new System.Drawing.Point(94, 81);
            this.NumCustomerEnBuyuk.Name = "NumCustomerEnBuyuk";
            this.NumCustomerEnBuyuk.Size = new System.Drawing.Size(86, 20);
            this.NumCustomerEnBuyuk.TabIndex = 1;
            // 
            // NumCustomerEnDusuk
            // 
            this.NumCustomerEnDusuk.Location = new System.Drawing.Point(94, 55);
            this.NumCustomerEnDusuk.Name = "NumCustomerEnDusuk";
            this.NumCustomerEnDusuk.Size = new System.Drawing.Size(86, 20);
            this.NumCustomerEnDusuk.TabIndex = 0;
            // 
            // panelFilter
            // 
            this.panelFilter.Controls.Add(this.CustomerGbx);
            this.panelFilter.Location = new System.Drawing.Point(0, 35);
            this.panelFilter.Name = "panelFilter";
            this.panelFilter.Size = new System.Drawing.Size(746, 150);
            this.panelFilter.TabIndex = 21;
            // 
            // dgCustomer
            // 
            this.dgCustomer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCustomer.GridColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dgCustomer.Location = new System.Drawing.Point(0, 232);
            this.dgCustomer.Name = "dgCustomer";
            this.dgCustomer.Size = new System.Drawing.Size(746, 453);
            this.dgCustomer.TabIndex = 20;
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
            this.cOMPANIESToolStripMenuItem.Click += new System.EventHandler(this.cOMPANIESToolStripMenuItem_Click);
            // 
            // CustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelButtons);
            this.Controls.Add(this.panelFilter);
            this.Controls.Add(this.dgCustomer);
            this.Controls.Add(this.menuStrip2);
            this.IsMdiContainer = true;
            this.Name = "CustomerForm";
            this.Text = "CustomerForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CustomerForm_FormClosing);
            this.Load += new System.EventHandler(this.CustomerForm_Load);
            this.panelButtons.ResumeLayout(false);
            this.Productsgbx2.ResumeLayout(false);
            this.CustomerGbx.ResumeLayout(false);
            this.CustomerGbx.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumCustomerEnBuyuk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumCustomerEnDusuk)).EndInit();
            this.panelFilter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgCustomer)).EndInit();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem cUSTOMERSToolStripMenuItem;
        private System.Windows.Forms.Panel panelButtons;
        private System.Windows.Forms.GroupBox Productsgbx2;
        private System.Windows.Forms.Button btnCustomerUpdate;
        private System.Windows.Forms.Button btnCustomerRefresh;
        private System.Windows.Forms.Button btnCustomerDelete;
        private System.Windows.Forms.Button btnCustomerAdd;
        private System.Windows.Forms.GroupBox CustomerGbx;
        private System.Windows.Forms.Button btnCustomerFilter;
        private System.Windows.Forms.TextBox tbxCustomerFilterName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown NumCustomerEnBuyuk;
        private System.Windows.Forms.NumericUpDown NumCustomerEnDusuk;
        private System.Windows.Forms.Panel panelFilter;
        private System.Windows.Forms.DataGridView dgCustomer;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem pRODUCTSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cATEGORIESToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eMPLOYEESToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oRDERSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cOMPANIESToolStripMenuItem;
        private System.Windows.Forms.TextBox tbxCustomerFilterCity;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbxCustomerFilterPhone;
        private System.Windows.Forms.Label label8;
    }
}