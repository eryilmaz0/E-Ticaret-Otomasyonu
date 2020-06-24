namespace KitapEviDemo.Forms
{
    partial class EmployeesForm
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
            this.cOMPANIESToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eMPLOYEESToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cATEGORIESToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pRODUCTSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelFilter = new System.Windows.Forms.Panel();
            this.tbxEmployeeFilterPhone = new System.Windows.Forms.GroupBox();
            this.tbxCustomerFilterPhone = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbxEmployeeFilterCity = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnEmployeesFilter = new System.Windows.Forms.Button();
            this.tbxEmployeeFilterName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.NumEmployeeEnBuyuk = new System.Windows.Forms.NumericUpDown();
            this.NumEmployeeEnDusuk = new System.Windows.Forms.NumericUpDown();
            this.dgEmployee = new System.Windows.Forms.DataGridView();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.oRDERSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cUSTOMERSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnEmployeeUpdate = new System.Windows.Forms.Button();
            this.btnEmployeeRefresh = new System.Windows.Forms.Button();
            this.btnEmployeeDelete = new System.Windows.Forms.Button();
            this.btnEmployeeAdd = new System.Windows.Forms.Button();
            this.Productsgbx2 = new System.Windows.Forms.GroupBox();
            this.panelButtons = new System.Windows.Forms.Panel();
            this.panelFilter.SuspendLayout();
            this.tbxEmployeeFilterPhone.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumEmployeeEnBuyuk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumEmployeeEnDusuk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgEmployee)).BeginInit();
            this.menuStrip2.SuspendLayout();
            this.Productsgbx2.SuspendLayout();
            this.panelButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // cOMPANIESToolStripMenuItem
            // 
            this.cOMPANIESToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cOMPANIESToolStripMenuItem.Name = "cOMPANIESToolStripMenuItem";
            this.cOMPANIESToolStripMenuItem.Size = new System.Drawing.Size(98, 23);
            this.cOMPANIESToolStripMenuItem.Text = "COMPANIES";
            this.cOMPANIESToolStripMenuItem.Click += new System.EventHandler(this.cOMPANIESToolStripMenuItem_Click);
            // 
            // eMPLOYEESToolStripMenuItem
            // 
            this.eMPLOYEESToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.eMPLOYEESToolStripMenuItem.Name = "eMPLOYEESToolStripMenuItem";
            this.eMPLOYEESToolStripMenuItem.Size = new System.Drawing.Size(96, 23);
            this.eMPLOYEESToolStripMenuItem.Text = "EMPLOYEES";
            // 
            // cATEGORIESToolStripMenuItem
            // 
            this.cATEGORIESToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cATEGORIESToolStripMenuItem.Name = "cATEGORIESToolStripMenuItem";
            this.cATEGORIESToolStripMenuItem.Size = new System.Drawing.Size(99, 23);
            this.cATEGORIESToolStripMenuItem.Text = "CATEGORIES";
            this.cATEGORIESToolStripMenuItem.Click += new System.EventHandler(this.cATEGORIESToolStripMenuItem_Click);
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
            // panelFilter
            // 
            this.panelFilter.Controls.Add(this.tbxEmployeeFilterPhone);
            this.panelFilter.Location = new System.Drawing.Point(0, 32);
            this.panelFilter.Name = "panelFilter";
            this.panelFilter.Size = new System.Drawing.Size(746, 150);
            this.panelFilter.TabIndex = 25;
            // 
            // tbxEmployeeFilterPhone
            // 
            this.tbxEmployeeFilterPhone.Controls.Add(this.tbxCustomerFilterPhone);
            this.tbxEmployeeFilterPhone.Controls.Add(this.label8);
            this.tbxEmployeeFilterPhone.Controls.Add(this.tbxEmployeeFilterCity);
            this.tbxEmployeeFilterPhone.Controls.Add(this.label4);
            this.tbxEmployeeFilterPhone.Controls.Add(this.label5);
            this.tbxEmployeeFilterPhone.Controls.Add(this.btnEmployeesFilter);
            this.tbxEmployeeFilterPhone.Controls.Add(this.tbxEmployeeFilterName);
            this.tbxEmployeeFilterPhone.Controls.Add(this.label7);
            this.tbxEmployeeFilterPhone.Controls.Add(this.label6);
            this.tbxEmployeeFilterPhone.Controls.Add(this.label3);
            this.tbxEmployeeFilterPhone.Controls.Add(this.label2);
            this.tbxEmployeeFilterPhone.Controls.Add(this.label1);
            this.tbxEmployeeFilterPhone.Controls.Add(this.NumEmployeeEnBuyuk);
            this.tbxEmployeeFilterPhone.Controls.Add(this.NumEmployeeEnDusuk);
            this.tbxEmployeeFilterPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxEmployeeFilterPhone.Location = new System.Drawing.Point(3, 3);
            this.tbxEmployeeFilterPhone.Name = "tbxEmployeeFilterPhone";
            this.tbxEmployeeFilterPhone.Size = new System.Drawing.Size(740, 144);
            this.tbxEmployeeFilterPhone.TabIndex = 11;
            this.tbxEmployeeFilterPhone.TabStop = false;
            this.tbxEmployeeFilterPhone.Text = "Personel Filtrele";
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
            // tbxEmployeeFilterCity
            // 
            this.tbxEmployeeFilterCity.Location = new System.Drawing.Point(537, 54);
            this.tbxEmployeeFilterCity.Name = "tbxEmployeeFilterCity";
            this.tbxEmployeeFilterCity.Size = new System.Drawing.Size(126, 20);
            this.tbxEmployeeFilterCity.TabIndex = 14;
            this.tbxEmployeeFilterCity.TextChanged += new System.EventHandler(this.tbxEmployeeFilterCity_TextChanged);
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
            // btnEmployeesFilter
            // 
            this.btnEmployeesFilter.Location = new System.Drawing.Point(94, 107);
            this.btnEmployeesFilter.Name = "btnEmployeesFilter";
            this.btnEmployeesFilter.Size = new System.Drawing.Size(86, 32);
            this.btnEmployeesFilter.TabIndex = 11;
            this.btnEmployeesFilter.Text = "UYGULA";
            this.btnEmployeesFilter.UseVisualStyleBackColor = true;
            this.btnEmployeesFilter.Click += new System.EventHandler(this.btnEmployeesFilter_Click);
            // 
            // tbxEmployeeFilterName
            // 
            this.tbxEmployeeFilterName.Location = new System.Drawing.Point(301, 55);
            this.tbxEmployeeFilterName.Name = "tbxEmployeeFilterName";
            this.tbxEmployeeFilterName.Size = new System.Drawing.Size(126, 20);
            this.tbxEmployeeFilterName.TabIndex = 10;
            this.tbxEmployeeFilterName.TextChanged += new System.EventHandler(this.tbxEmployeeFilterName_TextChanged);
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
            // NumEmployeeEnBuyuk
            // 
            this.NumEmployeeEnBuyuk.Location = new System.Drawing.Point(94, 81);
            this.NumEmployeeEnBuyuk.Name = "NumEmployeeEnBuyuk";
            this.NumEmployeeEnBuyuk.Size = new System.Drawing.Size(86, 20);
            this.NumEmployeeEnBuyuk.TabIndex = 1;
            // 
            // NumEmployeeEnDusuk
            // 
            this.NumEmployeeEnDusuk.Location = new System.Drawing.Point(94, 55);
            this.NumEmployeeEnDusuk.Name = "NumEmployeeEnDusuk";
            this.NumEmployeeEnDusuk.Size = new System.Drawing.Size(86, 20);
            this.NumEmployeeEnDusuk.TabIndex = 0;
            // 
            // dgEmployee
            // 
            this.dgEmployee.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgEmployee.GridColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dgEmployee.Location = new System.Drawing.Point(0, 229);
            this.dgEmployee.Name = "dgEmployee";
            this.dgEmployee.Size = new System.Drawing.Size(746, 453);
            this.dgEmployee.TabIndex = 24;
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
            this.menuStrip2.TabIndex = 23;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // oRDERSToolStripMenuItem
            // 
            this.oRDERSToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.oRDERSToolStripMenuItem.Name = "oRDERSToolStripMenuItem";
            this.oRDERSToolStripMenuItem.Size = new System.Drawing.Size(72, 23);
            this.oRDERSToolStripMenuItem.Text = "ORDERS";
            this.oRDERSToolStripMenuItem.Click += new System.EventHandler(this.oRDERSToolStripMenuItem_Click);
            // 
            // cUSTOMERSToolStripMenuItem
            // 
            this.cUSTOMERSToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cUSTOMERSToolStripMenuItem.Name = "cUSTOMERSToolStripMenuItem";
            this.cUSTOMERSToolStripMenuItem.Size = new System.Drawing.Size(99, 23);
            this.cUSTOMERSToolStripMenuItem.Text = "CUSTOMERS";
            this.cUSTOMERSToolStripMenuItem.Click += new System.EventHandler(this.cUSTOMERSToolStripMenuItem_Click);
            // 
            // btnEmployeeUpdate
            // 
            this.btnEmployeeUpdate.Location = new System.Drawing.Point(231, 0);
            this.btnEmployeeUpdate.Name = "btnEmployeeUpdate";
            this.btnEmployeeUpdate.Size = new System.Drawing.Size(109, 34);
            this.btnEmployeeUpdate.TabIndex = 2;
            this.btnEmployeeUpdate.Text = "GÜNCELLE";
            this.btnEmployeeUpdate.UseVisualStyleBackColor = true;
            this.btnEmployeeUpdate.Click += new System.EventHandler(this.btnEmployeeUpdate_Click);
            // 
            // btnEmployeeRefresh
            // 
            this.btnEmployeeRefresh.Location = new System.Drawing.Point(636, 0);
            this.btnEmployeeRefresh.Name = "btnEmployeeRefresh";
            this.btnEmployeeRefresh.Size = new System.Drawing.Size(104, 34);
            this.btnEmployeeRefresh.TabIndex = 12;
            this.btnEmployeeRefresh.Text = "YENİLE";
            this.btnEmployeeRefresh.UseVisualStyleBackColor = true;
            this.btnEmployeeRefresh.Click += new System.EventHandler(this.btnEmployeeRefresh_Click);
            // 
            // btnEmployeeDelete
            // 
            this.btnEmployeeDelete.Location = new System.Drawing.Point(115, 0);
            this.btnEmployeeDelete.Name = "btnEmployeeDelete";
            this.btnEmployeeDelete.Size = new System.Drawing.Size(109, 34);
            this.btnEmployeeDelete.TabIndex = 1;
            this.btnEmployeeDelete.Text = "SİL";
            this.btnEmployeeDelete.UseVisualStyleBackColor = true;
            this.btnEmployeeDelete.Click += new System.EventHandler(this.btnEmployeeDelete_Click);
            // 
            // btnEmployeeAdd
            // 
            this.btnEmployeeAdd.Location = new System.Drawing.Point(0, 0);
            this.btnEmployeeAdd.Name = "btnEmployeeAdd";
            this.btnEmployeeAdd.Size = new System.Drawing.Size(109, 34);
            this.btnEmployeeAdd.TabIndex = 0;
            this.btnEmployeeAdd.Text = "EKLE";
            this.btnEmployeeAdd.UseVisualStyleBackColor = true;
            this.btnEmployeeAdd.Click += new System.EventHandler(this.btnEmployeeAdd_Click);
            // 
            // Productsgbx2
            // 
            this.Productsgbx2.Controls.Add(this.btnEmployeeUpdate);
            this.Productsgbx2.Controls.Add(this.btnEmployeeRefresh);
            this.Productsgbx2.Controls.Add(this.btnEmployeeDelete);
            this.Productsgbx2.Controls.Add(this.btnEmployeeAdd);
            this.Productsgbx2.Location = new System.Drawing.Point(3, 1);
            this.Productsgbx2.Name = "Productsgbx2";
            this.Productsgbx2.Size = new System.Drawing.Size(743, 34);
            this.Productsgbx2.TabIndex = 12;
            this.Productsgbx2.TabStop = false;
            // 
            // panelButtons
            // 
            this.panelButtons.Controls.Add(this.Productsgbx2);
            this.panelButtons.Location = new System.Drawing.Point(0, 188);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new System.Drawing.Size(743, 36);
            this.panelButtons.TabIndex = 26;
            // 
            // EmployeesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelFilter);
            this.Controls.Add(this.dgEmployee);
            this.Controls.Add(this.menuStrip2);
            this.Controls.Add(this.panelButtons);
            this.IsMdiContainer = true;
            this.Name = "EmployeesForm";
            this.Text = "Personel";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EmplooyesForm_FormClosing);
            this.Load += new System.EventHandler(this.EmplooyesForm_Load);
            this.panelFilter.ResumeLayout(false);
            this.tbxEmployeeFilterPhone.ResumeLayout(false);
            this.tbxEmployeeFilterPhone.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumEmployeeEnBuyuk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumEmployeeEnDusuk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgEmployee)).EndInit();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.Productsgbx2.ResumeLayout(false);
            this.panelButtons.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem cOMPANIESToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eMPLOYEESToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cATEGORIESToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pRODUCTSToolStripMenuItem;
        private System.Windows.Forms.Panel panelFilter;
        private System.Windows.Forms.GroupBox tbxEmployeeFilterPhone;
        private System.Windows.Forms.TextBox tbxCustomerFilterPhone;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbxEmployeeFilterCity;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnEmployeesFilter;
        private System.Windows.Forms.TextBox tbxEmployeeFilterName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown NumEmployeeEnBuyuk;
        private System.Windows.Forms.NumericUpDown NumEmployeeEnDusuk;
        private System.Windows.Forms.DataGridView dgEmployee;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem oRDERSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cUSTOMERSToolStripMenuItem;
        private System.Windows.Forms.Button btnEmployeeUpdate;
        private System.Windows.Forms.Button btnEmployeeRefresh;
        private System.Windows.Forms.Button btnEmployeeDelete;
        private System.Windows.Forms.Button btnEmployeeAdd;
        private System.Windows.Forms.GroupBox Productsgbx2;
        private System.Windows.Forms.Panel panelButtons;
    }
}