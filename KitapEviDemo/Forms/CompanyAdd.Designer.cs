namespace KitapEviDemo.Forms
{
    partial class CompanyAdd
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
            this.companyAddGbx = new System.Windows.Forms.GroupBox();
            this.btnCompanyAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxCompanyAdd = new System.Windows.Forms.TextBox();
            this.companyAddGbx.SuspendLayout();
            this.SuspendLayout();
            // 
            // companyAddGbx
            // 
            this.companyAddGbx.Controls.Add(this.btnCompanyAdd);
            this.companyAddGbx.Controls.Add(this.label1);
            this.companyAddGbx.Controls.Add(this.tbxCompanyAdd);
            this.companyAddGbx.Location = new System.Drawing.Point(0, 0);
            this.companyAddGbx.Name = "companyAddGbx";
            this.companyAddGbx.Size = new System.Drawing.Size(337, 271);
            this.companyAddGbx.TabIndex = 1;
            this.companyAddGbx.TabStop = false;
            this.companyAddGbx.Text = "Firma Ekle";
            // 
            // btnCompanyAdd
            // 
            this.btnCompanyAdd.Location = new System.Drawing.Point(136, 147);
            this.btnCompanyAdd.Name = "btnCompanyAdd";
            this.btnCompanyAdd.Size = new System.Drawing.Size(114, 29);
            this.btnCompanyAdd.TabIndex = 2;
            this.btnCompanyAdd.Text = "Firma Ekle";
            this.btnCompanyAdd.UseVisualStyleBackColor = true;
            this.btnCompanyAdd.Click += new System.EventHandler(this.btnCompanyAdd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Firma Ekle :";
            // 
            // tbxCompanyAdd
            // 
            this.tbxCompanyAdd.Location = new System.Drawing.Point(136, 108);
            this.tbxCompanyAdd.Name = "tbxCompanyAdd";
            this.tbxCompanyAdd.Size = new System.Drawing.Size(114, 20);
            this.tbxCompanyAdd.TabIndex = 0;
            // 
            // CompanyAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 277);
            this.Controls.Add(this.companyAddGbx);
            this.Name = "CompanyAdd";
            this.Text = "Firma Ekle";
            this.companyAddGbx.ResumeLayout(false);
            this.companyAddGbx.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox companyAddGbx;
        private System.Windows.Forms.Button btnCompanyAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxCompanyAdd;
    }
}