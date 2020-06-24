namespace KitapEviDemo.Forms
{
    partial class DetailAdd
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
            this.components = new System.ComponentModel.Container();
            this.gbxDetailAdd = new System.Windows.Forms.GroupBox();
            this.btnDetailAdd = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.NumDetailAddQuantity = new System.Windows.Forms.NumericUpDown();
            this.numDetailAddPrice = new System.Windows.Forms.NumericUpDown();
            this.cbxDetailAddProduct = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.gbxDetailAdd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumDetailAddQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDetailAddPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxDetailAdd
            // 
            this.gbxDetailAdd.Controls.Add(this.btnDetailAdd);
            this.gbxDetailAdd.Controls.Add(this.label3);
            this.gbxDetailAdd.Controls.Add(this.label2);
            this.gbxDetailAdd.Controls.Add(this.NumDetailAddQuantity);
            this.gbxDetailAdd.Controls.Add(this.numDetailAddPrice);
            this.gbxDetailAdd.Controls.Add(this.cbxDetailAddProduct);
            this.gbxDetailAdd.Controls.Add(this.label1);
            this.gbxDetailAdd.Location = new System.Drawing.Point(0, 0);
            this.gbxDetailAdd.Name = "gbxDetailAdd";
            this.gbxDetailAdd.Size = new System.Drawing.Size(333, 281);
            this.gbxDetailAdd.TabIndex = 0;
            this.gbxDetailAdd.TabStop = false;
            this.gbxDetailAdd.Text = "Detay Ekle";
            // 
            // btnDetailAdd
            // 
            this.btnDetailAdd.Location = new System.Drawing.Point(120, 220);
            this.btnDetailAdd.Name = "btnDetailAdd";
            this.btnDetailAdd.Size = new System.Drawing.Size(121, 32);
            this.btnDetailAdd.TabIndex = 6;
            this.btnDetailAdd.Text = "Detay Ekle";
            this.btnDetailAdd.UseVisualStyleBackColor = true;
            this.btnDetailAdd.Click += new System.EventHandler(this.btnDetailAdd_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(79, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Adet :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(79, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Fiyat :";
            // 
            // NumDetailAddQuantity
            // 
            this.NumDetailAddQuantity.Location = new System.Drawing.Point(120, 176);
            this.NumDetailAddQuantity.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.NumDetailAddQuantity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumDetailAddQuantity.Name = "NumDetailAddQuantity";
            this.NumDetailAddQuantity.Size = new System.Drawing.Size(121, 20);
            this.NumDetailAddQuantity.TabIndex = 3;
            this.NumDetailAddQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumDetailAddQuantity.ValueChanged += new System.EventHandler(this.NumDetailAddQuantity_ValueChanged);
            // 
            // numDetailAddPrice
            // 
            this.numDetailAddPrice.DecimalPlaces = 2;
            this.numDetailAddPrice.Location = new System.Drawing.Point(120, 116);
            this.numDetailAddPrice.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numDetailAddPrice.Name = "numDetailAddPrice";
            this.numDetailAddPrice.ReadOnly = true;
            this.numDetailAddPrice.Size = new System.Drawing.Size(121, 20);
            this.numDetailAddPrice.TabIndex = 2;
            // 
            // cbxDetailAddProduct
            // 
            this.cbxDetailAddProduct.FormattingEnabled = true;
            this.cbxDetailAddProduct.Location = new System.Drawing.Point(120, 56);
            this.cbxDetailAddProduct.Name = "cbxDetailAddProduct";
            this.cbxDetailAddProduct.Size = new System.Drawing.Size(121, 21);
            this.cbxDetailAddProduct.TabIndex = 1;
            this.cbxDetailAddProduct.SelectedIndexChanged += new System.EventHandler(this.cbxDetailAddProduct_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ürün :";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // DetailAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 276);
            this.Controls.Add(this.gbxDetailAdd);
            this.Name = "DetailAdd";
            this.Text = "Detay Ekle";
            this.Load += new System.EventHandler(this.DetailAdd_Load);
            this.gbxDetailAdd.ResumeLayout(false);
            this.gbxDetailAdd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumDetailAddQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDetailAddPrice)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxDetailAdd;
        private System.Windows.Forms.ComboBox cbxDetailAddProduct;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numDetailAddPrice;
        private System.Windows.Forms.Button btnDetailAdd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown NumDetailAddQuantity;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}