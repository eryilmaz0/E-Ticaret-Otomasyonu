namespace KitapEviDemo.Forms
{
    partial class OrdersForm
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
            this.dgOrder = new System.Windows.Forms.DataGridView();
            this.oRDERSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.pRODUCTSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cATEGORIESToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eMPLOYEESToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cOMPANIESToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cUSTOMERSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tbxOrderfilterbyEmployee = new System.Windows.Forms.TextBox();
            this.btnEmployeeUpdate = new System.Windows.Forms.Button();
            this.btnEmployeeRefresh = new System.Windows.Forms.Button();
            this.btnEmployeeDelete = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbxOrderFilterbyCustomer = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnEmployeeAdd = new System.Windows.Forms.Button();
            this.panelButtons = new System.Windows.Forms.Panel();
            this.Productsgbx2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.gbxOrderFilter = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panelFilter = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgOrder)).BeginInit();
            this.menuStrip2.SuspendLayout();
            this.panelButtons.SuspendLayout();
            this.Productsgbx2.SuspendLayout();
            this.gbxOrderFilter.SuspendLayout();
            this.panelFilter.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgOrder
            // 
            this.dgOrder.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgOrder.GridColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dgOrder.Location = new System.Drawing.Point(0, 229);
            this.dgOrder.Name = "dgOrder";
            this.dgOrder.Size = new System.Drawing.Size(746, 453);
            this.dgOrder.TabIndex = 28;
            this.dgOrder.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgOrder_CellMouseClick);
            // 
            // oRDERSToolStripMenuItem
            // 
            this.oRDERSToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.oRDERSToolStripMenuItem.Name = "oRDERSToolStripMenuItem";
            this.oRDERSToolStripMenuItem.Size = new System.Drawing.Size(72, 23);
            this.oRDERSToolStripMenuItem.Text = "ORDERS";
            
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
            this.menuStrip2.TabIndex = 27;
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
            // tbxOrderfilterbyEmployee
            // 
            this.tbxOrderfilterbyEmployee.Location = new System.Drawing.Point(303, 59);
            this.tbxOrderfilterbyEmployee.Name = "tbxOrderfilterbyEmployee";
            this.tbxOrderfilterbyEmployee.Size = new System.Drawing.Size(126, 20);
            this.tbxOrderfilterbyEmployee.TabIndex = 14;
            this.tbxOrderfilterbyEmployee.TextChanged += new System.EventHandler(this.gbxOrderFilterbyEmployee_TextChanged);
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(260, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "İsim :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(260, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Personele Göre";
            // 
            // tbxOrderFilterbyCustomer
            // 
            this.tbxOrderFilterbyCustomer.Location = new System.Drawing.Point(67, 60);
            this.tbxOrderFilterbyCustomer.Name = "tbxOrderFilterbyCustomer";
            this.tbxOrderFilterbyCustomer.Size = new System.Drawing.Size(126, 20);
            this.tbxOrderFilterbyCustomer.TabIndex = 10;
            this.tbxOrderFilterbyCustomer.TextChanged += new System.EventHandler(this.tbxOrderFilterbyCustomer_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(30, 63);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "İsim :";
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
            // panelButtons
            // 
            this.panelButtons.Controls.Add(this.Productsgbx2);
            this.panelButtons.Location = new System.Drawing.Point(0, 188);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new System.Drawing.Size(743, 36);
            this.panelButtons.TabIndex = 30;
            // 
            // Productsgbx2
            // 
            this.Productsgbx2.Controls.Add(this.button1);
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(346, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 36);
            this.button1.TabIndex = 13;
            this.button1.Text = "DETAY";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Müşteriye Göre";
            // 
            // gbxOrderFilter
            // 
            this.gbxOrderFilter.Controls.Add(this.label1);
            this.gbxOrderFilter.Controls.Add(this.label3);
            this.gbxOrderFilter.Controls.Add(this.comboBox1);
            this.gbxOrderFilter.Controls.Add(this.tbxOrderfilterbyEmployee);
            this.gbxOrderFilter.Controls.Add(this.label4);
            this.gbxOrderFilter.Controls.Add(this.label5);
            this.gbxOrderFilter.Controls.Add(this.tbxOrderFilterbyCustomer);
            this.gbxOrderFilter.Controls.Add(this.label7);
            this.gbxOrderFilter.Controls.Add(this.label6);
            this.gbxOrderFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbxOrderFilter.Location = new System.Drawing.Point(3, 3);
            this.gbxOrderFilter.Name = "gbxOrderFilter";
            this.gbxOrderFilter.Size = new System.Drawing.Size(740, 144);
            this.gbxOrderFilter.TabIndex = 11;
            this.gbxOrderFilter.TabStop = false;
            this.gbxOrderFilter.Text = "Sipariş Filtrele";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(500, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Tarihe Göre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(500, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Tarih :";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(543, 60);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(126, 21);
            this.comboBox1.TabIndex = 18;
            // 
            // panelFilter
            // 
            this.panelFilter.Controls.Add(this.gbxOrderFilter);
            this.panelFilter.Location = new System.Drawing.Point(0, 32);
            this.panelFilter.Name = "panelFilter";
            this.panelFilter.Size = new System.Drawing.Size(746, 150);
            this.panelFilter.TabIndex = 29;
            // 
            // OrdersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgOrder);
            this.Controls.Add(this.menuStrip2);
            this.Controls.Add(this.panelButtons);
            this.Controls.Add(this.panelFilter);
            this.IsMdiContainer = true;
            this.Name = "OrdersForm";
            this.Text = "Sipariş";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.OrdersForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgOrder)).EndInit();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.panelButtons.ResumeLayout(false);
            this.Productsgbx2.ResumeLayout(false);
            this.gbxOrderFilter.ResumeLayout(false);
            this.gbxOrderFilter.PerformLayout();
            this.panelFilter.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgOrder;
        private System.Windows.Forms.ToolStripMenuItem oRDERSToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem pRODUCTSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cATEGORIESToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eMPLOYEESToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cOMPANIESToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cUSTOMERSToolStripMenuItem;
        private System.Windows.Forms.TextBox tbxOrderfilterbyEmployee;
        private System.Windows.Forms.Button btnEmployeeUpdate;
        private System.Windows.Forms.Button btnEmployeeRefresh;
        private System.Windows.Forms.Button btnEmployeeDelete;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbxOrderFilterbyCustomer;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnEmployeeAdd;
        private System.Windows.Forms.Panel panelButtons;
        private System.Windows.Forms.GroupBox Productsgbx2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox gbxOrderFilter;
        private System.Windows.Forms.Panel panelFilter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
    }
}