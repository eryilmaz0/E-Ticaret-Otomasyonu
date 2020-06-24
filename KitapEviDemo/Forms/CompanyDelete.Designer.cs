namespace KitapEviDemo.Forms
{
    partial class CompanyDelete
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
            this.CompanyGbx1 = new System.Windows.Forms.GroupBox();
            this.btnCompanyDelete = new System.Windows.Forms.Button();
            this.dgCompanyDelete = new System.Windows.Forms.DataGridView();
            this.lblCompanyDeleteCount = new System.Windows.Forms.Label();
            this.lblCompanyDeleteName = new System.Windows.Forms.Label();
            this.lbl20 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CompanyGbx1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgCompanyDelete)).BeginInit();
            this.SuspendLayout();
            // 
            // CompanyGbx1
            // 
            this.CompanyGbx1.Controls.Add(this.btnCompanyDelete);
            this.CompanyGbx1.Controls.Add(this.dgCompanyDelete);
            this.CompanyGbx1.Controls.Add(this.lblCompanyDeleteCount);
            this.CompanyGbx1.Controls.Add(this.lblCompanyDeleteName);
            this.CompanyGbx1.Controls.Add(this.lbl20);
            this.CompanyGbx1.Controls.Add(this.label1);
            this.CompanyGbx1.Location = new System.Drawing.Point(0, 0);
            this.CompanyGbx1.Name = "CompanyGbx1";
            this.CompanyGbx1.Size = new System.Drawing.Size(648, 396);
            this.CompanyGbx1.TabIndex = 3;
            this.CompanyGbx1.TabStop = false;
            this.CompanyGbx1.Text = "Firma Sil";
            // 
            // btnCompanyDelete
            // 
            this.btnCompanyDelete.Location = new System.Drawing.Point(248, 265);
            this.btnCompanyDelete.Name = "btnCompanyDelete";
            this.btnCompanyDelete.Size = new System.Drawing.Size(133, 34);
            this.btnCompanyDelete.TabIndex = 18;
            this.btnCompanyDelete.Text = "Firmayı Sil";
            this.btnCompanyDelete.UseVisualStyleBackColor = true;
            this.btnCompanyDelete.Click += new System.EventHandler(this.btnCompanyDelete_Click);
            // 
            // dgCompanyDelete
            // 
            this.dgCompanyDelete.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgCompanyDelete.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCompanyDelete.Location = new System.Drawing.Point(40, 77);
            this.dgCompanyDelete.Name = "dgCompanyDelete";
            this.dgCompanyDelete.Size = new System.Drawing.Size(564, 163);
            this.dgCompanyDelete.TabIndex = 17;
            this.dgCompanyDelete.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgCompanyDelete_CellMouseClick);
            // 
            // lblCompanyDeleteCount
            // 
            this.lblCompanyDeleteCount.AutoSize = true;
            this.lblCompanyDeleteCount.Location = new System.Drawing.Point(418, 48);
            this.lblCompanyDeleteCount.Name = "lblCompanyDeleteCount";
            this.lblCompanyDeleteCount.Size = new System.Drawing.Size(16, 13);
            this.lblCompanyDeleteCount.TabIndex = 13;
            this.lblCompanyDeleteCount.Text = "---";
            // 
            // lblCompanyDeleteName
            // 
            this.lblCompanyDeleteName.AutoSize = true;
            this.lblCompanyDeleteName.Location = new System.Drawing.Point(257, 48);
            this.lblCompanyDeleteName.Name = "lblCompanyDeleteName";
            this.lblCompanyDeleteName.Size = new System.Drawing.Size(16, 13);
            this.lblCompanyDeleteName.TabIndex = 12;
            this.lblCompanyDeleteName.Text = "---";
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
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Firma Adı :";
            // 
            // CompanyDelete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 393);
            this.Controls.Add(this.CompanyGbx1);
            this.Name = "CompanyDelete";
            this.Text = "CompanyDelete";
            this.Load += new System.EventHandler(this.CompanyDelete_Load);
            this.CompanyGbx1.ResumeLayout(false);
            this.CompanyGbx1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgCompanyDelete)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox CompanyGbx1;
        private System.Windows.Forms.Button btnCompanyDelete;
        private System.Windows.Forms.DataGridView dgCompanyDelete;
        private System.Windows.Forms.Label lblCompanyDeleteCount;
        private System.Windows.Forms.Label lblCompanyDeleteName;
        private System.Windows.Forms.Label lbl20;
        private System.Windows.Forms.Label label1;
    }
}