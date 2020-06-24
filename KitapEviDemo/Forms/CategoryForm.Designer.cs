namespace KitapEviDemo.Forms
{
    partial class CategoryForm
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
            this.btnCategoryUpdate = new System.Windows.Forms.Button();
            this.btnCategoryReset = new System.Windows.Forms.Button();
            this.btnCategoryDelete = new System.Windows.Forms.Button();
            this.btnCategoryAdd = new System.Windows.Forms.Button();
            this.CategoryFilterBtn = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CategoryEnBuyukNum = new System.Windows.Forms.NumericUpDown();
            this.CategoryEnKucukNum = new System.Windows.Forms.NumericUpDown();
            this.Categorygbx1 = new System.Windows.Forms.GroupBox();
            this.tbxCategoryFilter = new System.Windows.Forms.TextBox();
            this.Categorydg = new System.Windows.Forms.DataGridView();
            this.cOMPANIESToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oRDERSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eMPLOYEESToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cATEGORIESToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pRODUCTSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelFilter = new System.Windows.Forms.Panel();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.cUSTOMERSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelButtons.SuspendLayout();
            this.Productsgbx2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CategoryEnBuyukNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CategoryEnKucukNum)).BeginInit();
            this.Categorygbx1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Categorydg)).BeginInit();
            this.panelFilter.SuspendLayout();
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
            this.Productsgbx2.Controls.Add(this.btnCategoryUpdate);
            this.Productsgbx2.Controls.Add(this.btnCategoryReset);
            this.Productsgbx2.Controls.Add(this.btnCategoryDelete);
            this.Productsgbx2.Controls.Add(this.btnCategoryAdd);
            this.Productsgbx2.Location = new System.Drawing.Point(3, 1);
            this.Productsgbx2.Name = "Productsgbx2";
            this.Productsgbx2.Size = new System.Drawing.Size(743, 34);
            this.Productsgbx2.TabIndex = 12;
            this.Productsgbx2.TabStop = false;
            // 
            // btnCategoryUpdate
            // 
            this.btnCategoryUpdate.Location = new System.Drawing.Point(231, 0);
            this.btnCategoryUpdate.Name = "btnCategoryUpdate";
            this.btnCategoryUpdate.Size = new System.Drawing.Size(109, 34);
            this.btnCategoryUpdate.TabIndex = 2;
            this.btnCategoryUpdate.Text = "GÜNCELLE";
            this.btnCategoryUpdate.UseVisualStyleBackColor = true;
            this.btnCategoryUpdate.Click += new System.EventHandler(this.btnCategoryUpdate_Click);
            // 
            // btnCategoryReset
            // 
            this.btnCategoryReset.Location = new System.Drawing.Point(642, 0);
            this.btnCategoryReset.Name = "btnCategoryReset";
            this.btnCategoryReset.Size = new System.Drawing.Size(104, 34);
            this.btnCategoryReset.TabIndex = 12;
            this.btnCategoryReset.Text = "YENİLE";
            this.btnCategoryReset.UseVisualStyleBackColor = true;
            this.btnCategoryReset.Click += new System.EventHandler(this.btnCategoryReset_Click);
            // 
            // btnCategoryDelete
            // 
            this.btnCategoryDelete.Location = new System.Drawing.Point(115, 0);
            this.btnCategoryDelete.Name = "btnCategoryDelete";
            this.btnCategoryDelete.Size = new System.Drawing.Size(109, 34);
            this.btnCategoryDelete.TabIndex = 1;
            this.btnCategoryDelete.Text = "SİL";
            this.btnCategoryDelete.UseVisualStyleBackColor = true;
            this.btnCategoryDelete.Click += new System.EventHandler(this.btnCategoryDelete_Click);
            // 
            // btnCategoryAdd
            // 
            this.btnCategoryAdd.Location = new System.Drawing.Point(0, 0);
            this.btnCategoryAdd.Name = "btnCategoryAdd";
            this.btnCategoryAdd.Size = new System.Drawing.Size(109, 34);
            this.btnCategoryAdd.TabIndex = 0;
            this.btnCategoryAdd.Text = "EKLE";
            this.btnCategoryAdd.UseVisualStyleBackColor = true;
            this.btnCategoryAdd.Click += new System.EventHandler(this.btnCategoryAdd_Click);
            // 
            // CategoryFilterBtn
            // 
            this.CategoryFilterBtn.Location = new System.Drawing.Point(94, 116);
            this.CategoryFilterBtn.Name = "CategoryFilterBtn";
            this.CategoryFilterBtn.Size = new System.Drawing.Size(86, 23);
            this.CategoryFilterBtn.TabIndex = 11;
            this.CategoryFilterBtn.Text = "UYGULA";
            this.CategoryFilterBtn.UseVisualStyleBackColor = true;
            this.CategoryFilterBtn.Click += new System.EventHandler(this.CategoryFilterBtn_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(261, 57);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Ürün Adı :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(261, 23);
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
            // CategoryEnBuyukNum
            // 
            this.CategoryEnBuyukNum.Location = new System.Drawing.Point(94, 81);
            this.CategoryEnBuyukNum.Name = "CategoryEnBuyukNum";
            this.CategoryEnBuyukNum.Size = new System.Drawing.Size(86, 20);
            this.CategoryEnBuyukNum.TabIndex = 1;
            // 
            // CategoryEnKucukNum
            // 
            this.CategoryEnKucukNum.Location = new System.Drawing.Point(94, 55);
            this.CategoryEnKucukNum.Name = "CategoryEnKucukNum";
            this.CategoryEnKucukNum.Size = new System.Drawing.Size(86, 20);
            this.CategoryEnKucukNum.TabIndex = 0;
            // 
            // Categorygbx1
            // 
            this.Categorygbx1.Controls.Add(this.tbxCategoryFilter);
            this.Categorygbx1.Controls.Add(this.CategoryFilterBtn);
            this.Categorygbx1.Controls.Add(this.label7);
            this.Categorygbx1.Controls.Add(this.label6);
            this.Categorygbx1.Controls.Add(this.label3);
            this.Categorygbx1.Controls.Add(this.label2);
            this.Categorygbx1.Controls.Add(this.label1);
            this.Categorygbx1.Controls.Add(this.CategoryEnBuyukNum);
            this.Categorygbx1.Controls.Add(this.CategoryEnKucukNum);
            this.Categorygbx1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Categorygbx1.Location = new System.Drawing.Point(3, 3);
            this.Categorygbx1.Name = "Categorygbx1";
            this.Categorygbx1.Size = new System.Drawing.Size(740, 144);
            this.Categorygbx1.TabIndex = 11;
            this.Categorygbx1.TabStop = false;
            this.Categorygbx1.Text = "Kategori Filtrele";
            // 
            // tbxCategoryFilter
            // 
            this.tbxCategoryFilter.Location = new System.Drawing.Point(321, 54);
            this.tbxCategoryFilter.Name = "tbxCategoryFilter";
            this.tbxCategoryFilter.Size = new System.Drawing.Size(125, 20);
            this.tbxCategoryFilter.TabIndex = 12;
            this.tbxCategoryFilter.TextChanged += new System.EventHandler(this.tbxCategoryFilter_TextChanged);
            // 
            // Categorydg
            // 
            this.Categorydg.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Categorydg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Categorydg.GridColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Categorydg.Location = new System.Drawing.Point(0, 229);
            this.Categorydg.Name = "Categorydg";
            this.Categorydg.Size = new System.Drawing.Size(746, 453);
            this.Categorydg.TabIndex = 20;
            // 
            // cOMPANIESToolStripMenuItem
            // 
            this.cOMPANIESToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cOMPANIESToolStripMenuItem.Name = "cOMPANIESToolStripMenuItem";
            this.cOMPANIESToolStripMenuItem.Size = new System.Drawing.Size(98, 23);
            this.cOMPANIESToolStripMenuItem.Text = "COMPANIES";
            this.cOMPANIESToolStripMenuItem.Click += new System.EventHandler(this.cOMPANIESToolStripMenuItem_Click);
            // 
            // oRDERSToolStripMenuItem
            // 
            this.oRDERSToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.oRDERSToolStripMenuItem.Name = "oRDERSToolStripMenuItem";
            this.oRDERSToolStripMenuItem.Size = new System.Drawing.Size(72, 23);
            this.oRDERSToolStripMenuItem.Text = "ORDERS";
            this.oRDERSToolStripMenuItem.Click += new System.EventHandler(this.oRDERSToolStripMenuItem_Click);
            // 
            // eMPLOYEESToolStripMenuItem
            // 
            this.eMPLOYEESToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.eMPLOYEESToolStripMenuItem.Name = "eMPLOYEESToolStripMenuItem";
            this.eMPLOYEESToolStripMenuItem.Size = new System.Drawing.Size(96, 23);
            this.eMPLOYEESToolStripMenuItem.Text = "EMPLOYEES";
            this.eMPLOYEESToolStripMenuItem.Click += new System.EventHandler(this.eMPLOYEESToolStripMenuItem_Click);
            // 
            // cATEGORIESToolStripMenuItem
            // 
            this.cATEGORIESToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cATEGORIESToolStripMenuItem.Name = "cATEGORIESToolStripMenuItem";
            this.cATEGORIESToolStripMenuItem.Size = new System.Drawing.Size(99, 23);
            this.cATEGORIESToolStripMenuItem.Text = "CATEGORIES";
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
            this.panelFilter.Controls.Add(this.Categorygbx1);
            this.panelFilter.Location = new System.Drawing.Point(0, 32);
            this.panelFilter.Name = "panelFilter";
            this.panelFilter.Size = new System.Drawing.Size(746, 150);
            this.panelFilter.TabIndex = 21;
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
            this.menuStrip2.Size = new System.Drawing.Size(960, 29);
            this.menuStrip2.TabIndex = 19;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // cUSTOMERSToolStripMenuItem
            // 
            this.cUSTOMERSToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cUSTOMERSToolStripMenuItem.Name = "cUSTOMERSToolStripMenuItem";
            this.cUSTOMERSToolStripMenuItem.Size = new System.Drawing.Size(99, 23);
            this.cUSTOMERSToolStripMenuItem.Text = "CUSTOMERS";
            this.cUSTOMERSToolStripMenuItem.Click += new System.EventHandler(this.cUSTOMERSToolStripMenuItem_Click);
            // 
            // CategoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 450);
            this.Controls.Add(this.panelButtons);
            this.Controls.Add(this.Categorydg);
            this.Controls.Add(this.panelFilter);
            this.Controls.Add(this.menuStrip2);
            this.IsMdiContainer = true;
            this.Name = "CategoryForm";
            this.Text = "CategoryForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CategoryForm_FormClosing);
            this.Load += new System.EventHandler(this.CategoryForm_Load);
            this.panelButtons.ResumeLayout(false);
            this.Productsgbx2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CategoryEnBuyukNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CategoryEnKucukNum)).EndInit();
            this.Categorygbx1.ResumeLayout(false);
            this.Categorygbx1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Categorydg)).EndInit();
            this.panelFilter.ResumeLayout(false);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelButtons;
        private System.Windows.Forms.GroupBox Productsgbx2;
        private System.Windows.Forms.Button btnCategoryUpdate;
        private System.Windows.Forms.Button btnCategoryReset;
        private System.Windows.Forms.Button btnCategoryDelete;
        private System.Windows.Forms.Button btnCategoryAdd;
        private System.Windows.Forms.Button CategoryFilterBtn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown CategoryEnBuyukNum;
        private System.Windows.Forms.NumericUpDown CategoryEnKucukNum;
        private System.Windows.Forms.GroupBox Categorygbx1;
        private System.Windows.Forms.DataGridView Categorydg;
        private System.Windows.Forms.ToolStripMenuItem cOMPANIESToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oRDERSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eMPLOYEESToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cATEGORIESToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pRODUCTSToolStripMenuItem;
        private System.Windows.Forms.Panel panelFilter;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.TextBox tbxCategoryFilter;
        private System.Windows.Forms.ToolStripMenuItem cUSTOMERSToolStripMenuItem;
    }
}