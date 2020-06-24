namespace KitapEviDemo.Forms
{
    partial class CategoryUpdate
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCategoryUpdate = new System.Windows.Forms.Button();
            this.tbxCategoryUpdate = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.categoryUpdateDg = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.categoryUpdateDg)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCategoryUpdate);
            this.groupBox1.Controls.Add(this.tbxCategoryUpdate);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.categoryUpdateDg);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(622, 381);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kategori Güncelle";
            // 
            // btnCategoryUpdate
            // 
            this.btnCategoryUpdate.Location = new System.Drawing.Point(271, 263);
            this.btnCategoryUpdate.Name = "btnCategoryUpdate";
            this.btnCategoryUpdate.Size = new System.Drawing.Size(129, 27);
            this.btnCategoryUpdate.TabIndex = 3;
            this.btnCategoryUpdate.Text = "Kategori Güncelle";
            this.btnCategoryUpdate.UseVisualStyleBackColor = true;
            this.btnCategoryUpdate.Click += new System.EventHandler(this.btnCategoryUpdate_Click);
            // 
            // tbxCategoryUpdate
            // 
            this.tbxCategoryUpdate.Location = new System.Drawing.Point(271, 222);
            this.tbxCategoryUpdate.Name = "tbxCategoryUpdate";
            this.tbxCategoryUpdate.Size = new System.Drawing.Size(129, 20);
            this.tbxCategoryUpdate.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(171, 225);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Yeni Kategori Adı :";
            // 
            // categoryUpdateDg
            // 
            this.categoryUpdateDg.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.categoryUpdateDg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.categoryUpdateDg.Location = new System.Drawing.Point(69, 19);
            this.categoryUpdateDg.Name = "categoryUpdateDg";
            this.categoryUpdateDg.Size = new System.Drawing.Size(486, 150);
            this.categoryUpdateDg.TabIndex = 0;
            this.categoryUpdateDg.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.categoryUpdateDg_CellMouseClick);
            // 
            // CategoryUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 375);
            this.Controls.Add(this.groupBox1);
            this.Name = "CategoryUpdate";
            this.Text = "Kategori Güncelle";
            this.Load += new System.EventHandler(this.CategoryUpdate_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.categoryUpdateDg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCategoryUpdate;
        private System.Windows.Forms.TextBox tbxCategoryUpdate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView categoryUpdateDg;
    }
}