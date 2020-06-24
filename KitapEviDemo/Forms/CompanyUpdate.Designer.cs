namespace KitapEviDemo.Forms
{
    partial class CompanyUpdate
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
            this.companyUpdategbx = new System.Windows.Forms.GroupBox();
            this.btnCompanyUpdate = new System.Windows.Forms.Button();
            this.tbxCompanyUpdate = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgCompanyUpdate = new System.Windows.Forms.DataGridView();
            this.companyUpdategbx.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgCompanyUpdate)).BeginInit();
            this.SuspendLayout();
            // 
            // companyUpdategbx
            // 
            this.companyUpdategbx.Controls.Add(this.btnCompanyUpdate);
            this.companyUpdategbx.Controls.Add(this.tbxCompanyUpdate);
            this.companyUpdategbx.Controls.Add(this.label1);
            this.companyUpdategbx.Controls.Add(this.dgCompanyUpdate);
            this.companyUpdategbx.Location = new System.Drawing.Point(0, 0);
            this.companyUpdategbx.Name = "companyUpdategbx";
            this.companyUpdategbx.Size = new System.Drawing.Size(622, 381);
            this.companyUpdategbx.TabIndex = 1;
            this.companyUpdategbx.TabStop = false;
            this.companyUpdategbx.Text = "Firma Güncelle";
            // 
            // btnCompanyUpdate
            // 
            this.btnCompanyUpdate.Location = new System.Drawing.Point(271, 263);
            this.btnCompanyUpdate.Name = "btnCompanyUpdate";
            this.btnCompanyUpdate.Size = new System.Drawing.Size(129, 27);
            this.btnCompanyUpdate.TabIndex = 3;
            this.btnCompanyUpdate.Text = "Firmayı Güncelle";
            this.btnCompanyUpdate.UseVisualStyleBackColor = true;
            this.btnCompanyUpdate.Click += new System.EventHandler(this.btnCompanyUpdate_Click);
            // 
            // tbxCompanyUpdate
            // 
            this.tbxCompanyUpdate.Location = new System.Drawing.Point(271, 222);
            this.tbxCompanyUpdate.Name = "tbxCompanyUpdate";
            this.tbxCompanyUpdate.Size = new System.Drawing.Size(129, 20);
            this.tbxCompanyUpdate.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(185, 225);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Yeni Firma Adı :";
            // 
            // dgCompanyUpdate
            // 
            this.dgCompanyUpdate.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgCompanyUpdate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCompanyUpdate.Location = new System.Drawing.Point(69, 19);
            this.dgCompanyUpdate.Name = "dgCompanyUpdate";
            this.dgCompanyUpdate.Size = new System.Drawing.Size(486, 150);
            this.dgCompanyUpdate.TabIndex = 0;
            this.dgCompanyUpdate.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgCompanyUpdate_CellMouseClick);
            // 
            // CompanyUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 360);
            this.Controls.Add(this.companyUpdategbx);
            this.Name = "CompanyUpdate";
            this.Text = "CompanyUpdate";
            this.Load += new System.EventHandler(this.CompanyUpdate_Load);
            this.companyUpdategbx.ResumeLayout(false);
            this.companyUpdategbx.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgCompanyUpdate)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox companyUpdategbx;
        private System.Windows.Forms.Button btnCompanyUpdate;
        private System.Windows.Forms.TextBox tbxCompanyUpdate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgCompanyUpdate;
    }
}