namespace KitapEviDemo.Forms
{
    partial class CategoryDelete
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
            this.btnCategoryDelete = new System.Windows.Forms.Button();
            this.categoryDeleteDg = new System.Windows.Forms.DataGridView();
            this.lblCategoryCount = new System.Windows.Forms.Label();
            this.lblCategoryName = new System.Windows.Forms.Label();
            this.lbl20 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ProductAddGbx.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.categoryDeleteDg)).BeginInit();
            this.SuspendLayout();
            // 
            // ProductAddGbx
            // 
            this.ProductAddGbx.Controls.Add(this.btnCategoryDelete);
            this.ProductAddGbx.Controls.Add(this.categoryDeleteDg);
            this.ProductAddGbx.Controls.Add(this.lblCategoryCount);
            this.ProductAddGbx.Controls.Add(this.lblCategoryName);
            this.ProductAddGbx.Controls.Add(this.lbl20);
            this.ProductAddGbx.Controls.Add(this.label1);
            this.ProductAddGbx.Location = new System.Drawing.Point(0, 0);
            this.ProductAddGbx.Name = "ProductAddGbx";
            this.ProductAddGbx.Size = new System.Drawing.Size(648, 396);
            this.ProductAddGbx.TabIndex = 2;
            this.ProductAddGbx.TabStop = false;
            this.ProductAddGbx.Text = "Ürün Sil";
            // 
            // btnCategoryDelete
            // 
            this.btnCategoryDelete.Location = new System.Drawing.Point(248, 265);
            this.btnCategoryDelete.Name = "btnCategoryDelete";
            this.btnCategoryDelete.Size = new System.Drawing.Size(133, 34);
            this.btnCategoryDelete.TabIndex = 18;
            this.btnCategoryDelete.Text = "Kategori Sil";
            this.btnCategoryDelete.UseVisualStyleBackColor = true;
            this.btnCategoryDelete.Click += new System.EventHandler(this.btnCategoryDelete_Click);
            // 
            // categoryDeleteDg
            // 
            this.categoryDeleteDg.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.categoryDeleteDg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.categoryDeleteDg.Location = new System.Drawing.Point(40, 77);
            this.categoryDeleteDg.Name = "categoryDeleteDg";
            this.categoryDeleteDg.Size = new System.Drawing.Size(564, 163);
            this.categoryDeleteDg.TabIndex = 17;
            this.categoryDeleteDg.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.categoryDeleteDg_CellMouseClick);
            // 
            // lblCategoryCount
            // 
            this.lblCategoryCount.AutoSize = true;
            this.lblCategoryCount.Location = new System.Drawing.Point(418, 48);
            this.lblCategoryCount.Name = "lblCategoryCount";
            this.lblCategoryCount.Size = new System.Drawing.Size(16, 13);
            this.lblCategoryCount.TabIndex = 13;
            this.lblCategoryCount.Text = "---";
            // 
            // lblCategoryName
            // 
            this.lblCategoryName.AutoSize = true;
            this.lblCategoryName.Location = new System.Drawing.Point(257, 48);
            this.lblCategoryName.Name = "lblCategoryName";
            this.lblCategoryName.Size = new System.Drawing.Size(16, 13);
            this.lblCategoryName.TabIndex = 12;
            this.lblCategoryName.Text = "---";
            // 
            // lbl20
            // 
            this.lbl20.AutoSize = true;
            this.lbl20.Location = new System.Drawing.Point(355, 48);
            this.lbl20.Name = "lbl20";
            this.lbl20.Size = new System.Drawing.Size(66, 13);
            this.lbl20.TabIndex = 6;
            this.lbl20.Text = "Ürün Sayısı :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(203, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Ürün Adı  :";
            // 
            // CategoryDelete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 324);
            this.Controls.Add(this.ProductAddGbx);
            this.Name = "CategoryDelete";
            this.Text = "Kategori Sil";
            this.Load += new System.EventHandler(this.CategoryDelete_Load);
            this.ProductAddGbx.ResumeLayout(false);
            this.ProductAddGbx.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.categoryDeleteDg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox ProductAddGbx;
        private System.Windows.Forms.Button btnCategoryDelete;
        private System.Windows.Forms.DataGridView categoryDeleteDg;
        private System.Windows.Forms.Label lblCategoryCount;
        private System.Windows.Forms.Label lblCategoryName;
        private System.Windows.Forms.Label lbl20;
        private System.Windows.Forms.Label label1;
    }
}