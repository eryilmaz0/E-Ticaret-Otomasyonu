namespace KitapEviDemo.Forms
{
    partial class CategoryAdd
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
            this.categoryAddgbx = new System.Windows.Forms.GroupBox();
            this.tbxCategoryAdd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCategoryAdd = new System.Windows.Forms.Button();
            this.categoryAddgbx.SuspendLayout();
            this.SuspendLayout();
            // 
            // categoryAddgbx
            // 
            this.categoryAddgbx.Controls.Add(this.btnCategoryAdd);
            this.categoryAddgbx.Controls.Add(this.label1);
            this.categoryAddgbx.Controls.Add(this.tbxCategoryAdd);
            this.categoryAddgbx.Location = new System.Drawing.Point(0, 0);
            this.categoryAddgbx.Name = "categoryAddgbx";
            this.categoryAddgbx.Size = new System.Drawing.Size(337, 271);
            this.categoryAddgbx.TabIndex = 0;
            this.categoryAddgbx.TabStop = false;
            this.categoryAddgbx.Text = "Kategori Ekle";
            // 
            // tbxCategoryAdd
            // 
            this.tbxCategoryAdd.Location = new System.Drawing.Point(136, 108);
            this.tbxCategoryAdd.Name = "tbxCategoryAdd";
            this.tbxCategoryAdd.Size = new System.Drawing.Size(114, 20);
            this.tbxCategoryAdd.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kategori Ekle :";
            // 
            // btnCategoryAdd
            // 
            this.btnCategoryAdd.Location = new System.Drawing.Point(136, 147);
            this.btnCategoryAdd.Name = "btnCategoryAdd";
            this.btnCategoryAdd.Size = new System.Drawing.Size(114, 29);
            this.btnCategoryAdd.TabIndex = 2;
            this.btnCategoryAdd.Text = "Kategori Ekle";
            this.btnCategoryAdd.UseVisualStyleBackColor = true;
            this.btnCategoryAdd.Click += new System.EventHandler(this.btnCategoryAdd_Click);
            // 
            // CategoryAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 264);
            this.Controls.Add(this.categoryAddgbx);
            this.Name = "CategoryAdd";
            this.Text = "CategoryAdd";
            this.Load += new System.EventHandler(this.CategoryAdd_Load);
            this.categoryAddgbx.ResumeLayout(false);
            this.categoryAddgbx.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox categoryAddgbx;
        private System.Windows.Forms.Button btnCategoryAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxCategoryAdd;
    }
}