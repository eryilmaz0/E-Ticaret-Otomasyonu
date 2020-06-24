namespace KitapEviDemo.Forms
{
    partial class EmployeeUpdate
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
            this.gbxEmployeeUpdate = new System.Windows.Forms.GroupBox();
            this.btnEmployeeUpdate = new System.Windows.Forms.Button();
            this.tbxEmployeeUpdatePhone = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbxEmployeeUpdateCountry = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxEmployeeUpdateCity = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxEmployeeUpdateLastname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxEmployeeUpdateName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgEmployeeUpdate = new System.Windows.Forms.DataGridView();
            this.gbxEmployeeUpdate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgEmployeeUpdate)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxEmployeeUpdate
            // 
            this.gbxEmployeeUpdate.Controls.Add(this.btnEmployeeUpdate);
            this.gbxEmployeeUpdate.Controls.Add(this.tbxEmployeeUpdatePhone);
            this.gbxEmployeeUpdate.Controls.Add(this.label5);
            this.gbxEmployeeUpdate.Controls.Add(this.tbxEmployeeUpdateCountry);
            this.gbxEmployeeUpdate.Controls.Add(this.label4);
            this.gbxEmployeeUpdate.Controls.Add(this.tbxEmployeeUpdateCity);
            this.gbxEmployeeUpdate.Controls.Add(this.label3);
            this.gbxEmployeeUpdate.Controls.Add(this.tbxEmployeeUpdateLastname);
            this.gbxEmployeeUpdate.Controls.Add(this.label2);
            this.gbxEmployeeUpdate.Controls.Add(this.tbxEmployeeUpdateName);
            this.gbxEmployeeUpdate.Controls.Add(this.label1);
            this.gbxEmployeeUpdate.Controls.Add(this.dgEmployeeUpdate);
            this.gbxEmployeeUpdate.Location = new System.Drawing.Point(0, 0);
            this.gbxEmployeeUpdate.Name = "gbxEmployeeUpdate";
            this.gbxEmployeeUpdate.Size = new System.Drawing.Size(625, 594);
            this.gbxEmployeeUpdate.TabIndex = 1;
            this.gbxEmployeeUpdate.TabStop = false;
            this.gbxEmployeeUpdate.Text = "Personel Güncelle";
            // 
            // btnEmployeeUpdate
            // 
            this.btnEmployeeUpdate.Location = new System.Drawing.Point(230, 456);
            this.btnEmployeeUpdate.Name = "btnEmployeeUpdate";
            this.btnEmployeeUpdate.Size = new System.Drawing.Size(110, 31);
            this.btnEmployeeUpdate.TabIndex = 14;
            this.btnEmployeeUpdate.Text = "Personel Güncelle";
            this.btnEmployeeUpdate.UseVisualStyleBackColor = true;
            this.btnEmployeeUpdate.Click += new System.EventHandler(this.btnEmployeeUpdate_Click);
            // 
            // tbxEmployeeUpdatePhone
            // 
            this.tbxEmployeeUpdatePhone.Location = new System.Drawing.Point(230, 400);
            this.tbxEmployeeUpdatePhone.Name = "tbxEmployeeUpdatePhone";
            this.tbxEmployeeUpdatePhone.Size = new System.Drawing.Size(110, 20);
            this.tbxEmployeeUpdatePhone.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(175, 403);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Telefon :";
            // 
            // tbxEmployeeUpdateCountry
            // 
            this.tbxEmployeeUpdateCountry.Location = new System.Drawing.Point(47, 400);
            this.tbxEmployeeUpdateCountry.Name = "tbxEmployeeUpdateCountry";
            this.tbxEmployeeUpdateCountry.Size = new System.Drawing.Size(110, 20);
            this.tbxEmployeeUpdateCountry.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 403);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Ülke :";
            // 
            // tbxEmployeeUpdateCity
            // 
            this.tbxEmployeeUpdateCity.Location = new System.Drawing.Point(443, 333);
            this.tbxEmployeeUpdateCity.Name = "tbxEmployeeUpdateCity";
            this.tbxEmployeeUpdateCity.Size = new System.Drawing.Size(110, 20);
            this.tbxEmployeeUpdateCity.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(400, 336);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Şehir :";
            // 
            // tbxEmployeeUpdateLastname
            // 
            this.tbxEmployeeUpdateLastname.Location = new System.Drawing.Point(230, 333);
            this.tbxEmployeeUpdateLastname.Name = "tbxEmployeeUpdateLastname";
            this.tbxEmployeeUpdateLastname.Size = new System.Drawing.Size(110, 20);
            this.tbxEmployeeUpdateLastname.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(181, 336);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Soyad :";
            // 
            // tbxEmployeeUpdateName
            // 
            this.tbxEmployeeUpdateName.Location = new System.Drawing.Point(47, 333);
            this.tbxEmployeeUpdateName.Name = "tbxEmployeeUpdateName";
            this.tbxEmployeeUpdateName.Size = new System.Drawing.Size(110, 20);
            this.tbxEmployeeUpdateName.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 336);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ad :";
            // 
            // dgEmployeeUpdate
            // 
            this.dgEmployeeUpdate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgEmployeeUpdate.Location = new System.Drawing.Point(12, 35);
            this.dgEmployeeUpdate.Name = "dgEmployeeUpdate";
            this.dgEmployeeUpdate.Size = new System.Drawing.Size(594, 245);
            this.dgEmployeeUpdate.TabIndex = 0;
            this.dgEmployeeUpdate.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgEmployeeUpdate_CellMouseClick);
            // 
            // EmployeeUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 513);
            this.Controls.Add(this.gbxEmployeeUpdate);
            this.Name = "EmployeeUpdate";
            this.Text = "Personel Güncelle";
            this.Load += new System.EventHandler(this.EmployeeUpdate_Load);
            this.gbxEmployeeUpdate.ResumeLayout(false);
            this.gbxEmployeeUpdate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgEmployeeUpdate)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxEmployeeUpdate;
        private System.Windows.Forms.Button btnEmployeeUpdate;
        private System.Windows.Forms.TextBox tbxEmployeeUpdatePhone;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbxEmployeeUpdateCountry;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbxEmployeeUpdateCity;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxEmployeeUpdateLastname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxEmployeeUpdateName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgEmployeeUpdate;
    }
}