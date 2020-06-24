namespace KitapEviDemo.Forms
{
    partial class EmployeeAdd
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
            this.gbxCustomerAdd = new System.Windows.Forms.GroupBox();
            this.btnEmployeeAdd = new System.Windows.Forms.Button();
            this.tbxEmployeeAddCountry = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxEmployeeAddCity = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxEmployeeAddLastname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxEmployeeAddName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbxEmployeeAddPhone = new System.Windows.Forms.TextBox();
            this.gbxCustomerAdd.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxCustomerAdd
            // 
            this.gbxCustomerAdd.Controls.Add(this.btnEmployeeAdd);
            this.gbxCustomerAdd.Controls.Add(this.tbxEmployeeAddPhone);
            this.gbxCustomerAdd.Controls.Add(this.label5);
            this.gbxCustomerAdd.Controls.Add(this.tbxEmployeeAddCountry);
            this.gbxCustomerAdd.Controls.Add(this.label4);
            this.gbxCustomerAdd.Controls.Add(this.tbxEmployeeAddCity);
            this.gbxCustomerAdd.Controls.Add(this.label3);
            this.gbxCustomerAdd.Controls.Add(this.tbxEmployeeAddLastname);
            this.gbxCustomerAdd.Controls.Add(this.label2);
            this.gbxCustomerAdd.Controls.Add(this.tbxEmployeeAddName);
            this.gbxCustomerAdd.Controls.Add(this.label1);
            this.gbxCustomerAdd.Location = new System.Drawing.Point(0, 0);
            this.gbxCustomerAdd.Name = "gbxCustomerAdd";
            this.gbxCustomerAdd.Size = new System.Drawing.Size(362, 409);
            this.gbxCustomerAdd.TabIndex = 1;
            this.gbxCustomerAdd.TabStop = false;
            this.gbxCustomerAdd.Text = "Personel Ekle";
            // 
            // btnEmployeeAdd
            // 
            this.btnEmployeeAdd.Location = new System.Drawing.Point(152, 300);
            this.btnEmployeeAdd.Name = "btnEmployeeAdd";
            this.btnEmployeeAdd.Size = new System.Drawing.Size(100, 36);
            this.btnEmployeeAdd.TabIndex = 12;
            this.btnEmployeeAdd.Text = "Personel Ekle";
            this.btnEmployeeAdd.UseVisualStyleBackColor = true;
            this.btnEmployeeAdd.Click += new System.EventHandler(this.btnEmployeeAdd_Click);
            // 
            // tbxEmployeeAddCountry
            // 
            this.tbxEmployeeAddCountry.Location = new System.Drawing.Point(152, 201);
            this.tbxEmployeeAddCountry.Name = "tbxEmployeeAddCountry";
            this.tbxEmployeeAddCountry.Size = new System.Drawing.Size(100, 20);
            this.tbxEmployeeAddCountry.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(111, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Ülke :";
            // 
            // tbxEmployeeAddCity
            // 
            this.tbxEmployeeAddCity.Location = new System.Drawing.Point(152, 152);
            this.tbxEmployeeAddCity.Name = "tbxEmployeeAddCity";
            this.tbxEmployeeAddCity.Size = new System.Drawing.Size(100, 20);
            this.tbxEmployeeAddCity.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(109, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Şehir :";
            // 
            // tbxEmployeeAddLastname
            // 
            this.tbxEmployeeAddLastname.Location = new System.Drawing.Point(152, 103);
            this.tbxEmployeeAddLastname.Name = "tbxEmployeeAddLastname";
            this.tbxEmployeeAddLastname.Size = new System.Drawing.Size(100, 20);
            this.tbxEmployeeAddLastname.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(103, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Soyad :";
            // 
            // tbxEmployeeAddName
            // 
            this.tbxEmployeeAddName.Location = new System.Drawing.Point(152, 54);
            this.tbxEmployeeAddName.Name = "tbxEmployeeAddName";
            this.tbxEmployeeAddName.Size = new System.Drawing.Size(100, 20);
            this.tbxEmployeeAddName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(120, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(97, 256);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Telefon :";
            // 
            // tbxEmployeeAddPhone
            // 
            this.tbxEmployeeAddPhone.Location = new System.Drawing.Point(152, 253);
            this.tbxEmployeeAddPhone.Name = "tbxEmployeeAddPhone";
            this.tbxEmployeeAddPhone.Size = new System.Drawing.Size(100, 20);
            this.tbxEmployeeAddPhone.TabIndex = 9;
            // 
            // EmployeeAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 368);
            this.Controls.Add(this.gbxCustomerAdd);
            this.Name = "EmployeeAdd";
            this.Text = "Personel Ekle";
            this.gbxCustomerAdd.ResumeLayout(false);
            this.gbxCustomerAdd.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxCustomerAdd;
        private System.Windows.Forms.Button btnEmployeeAdd;
        private System.Windows.Forms.TextBox tbxEmployeeAddCountry;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbxEmployeeAddCity;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxEmployeeAddLastname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxEmployeeAddName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxEmployeeAddPhone;
        private System.Windows.Forms.Label label5;
    }
}