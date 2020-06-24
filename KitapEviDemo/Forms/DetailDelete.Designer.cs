namespace KitapEviDemo.Forms
{
    partial class DetailDelete
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
            this.dgDetailDelete = new System.Windows.Forms.DataGridView();
            this.lblDetailDeleteQuantity = new System.Windows.Forms.Label();
            this.lblDetailDeletePrice = new System.Windows.Forms.Label();
            this.lblDetailDeleteProduct = new System.Windows.Forms.Label();
            this.btnDetailDelete = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.gbxDetailAdd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDetailDelete)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxDetailAdd
            // 
            this.gbxDetailAdd.Controls.Add(this.dgDetailDelete);
            this.gbxDetailAdd.Controls.Add(this.lblDetailDeleteQuantity);
            this.gbxDetailAdd.Controls.Add(this.lblDetailDeletePrice);
            this.gbxDetailAdd.Controls.Add(this.lblDetailDeleteProduct);
            this.gbxDetailAdd.Controls.Add(this.btnDetailDelete);
            this.gbxDetailAdd.Controls.Add(this.label3);
            this.gbxDetailAdd.Controls.Add(this.label2);
            this.gbxDetailAdd.Controls.Add(this.label1);
            this.gbxDetailAdd.Location = new System.Drawing.Point(0, 0);
            this.gbxDetailAdd.Name = "gbxDetailAdd";
            this.gbxDetailAdd.Size = new System.Drawing.Size(472, 451);
            this.gbxDetailAdd.TabIndex = 1;
            this.gbxDetailAdd.TabStop = false;
            this.gbxDetailAdd.Text = "Detay Sil";
            // 
            // dgDetailDelete
            // 
            this.dgDetailDelete.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgDetailDelete.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDetailDelete.Location = new System.Drawing.Point(29, 19);
            this.dgDetailDelete.Name = "dgDetailDelete";
            this.dgDetailDelete.Size = new System.Drawing.Size(414, 150);
            this.dgDetailDelete.TabIndex = 10;
            this.dgDetailDelete.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgDetailDelete_CellMouseClick);
            // 
            // lblDetailDeleteQuantity
            // 
            this.lblDetailDeleteQuantity.AutoSize = true;
            this.lblDetailDeleteQuantity.Location = new System.Drawing.Point(232, 275);
            this.lblDetailDeleteQuantity.Name = "lblDetailDeleteQuantity";
            this.lblDetailDeleteQuantity.Size = new System.Drawing.Size(16, 13);
            this.lblDetailDeleteQuantity.TabIndex = 9;
            this.lblDetailDeleteQuantity.Text = "---";
            // 
            // lblDetailDeletePrice
            // 
            this.lblDetailDeletePrice.AutoSize = true;
            this.lblDetailDeletePrice.Location = new System.Drawing.Point(232, 245);
            this.lblDetailDeletePrice.Name = "lblDetailDeletePrice";
            this.lblDetailDeletePrice.Size = new System.Drawing.Size(16, 13);
            this.lblDetailDeletePrice.TabIndex = 8;
            this.lblDetailDeletePrice.Text = "---";
            // 
            // lblDetailDeleteProduct
            // 
            this.lblDetailDeleteProduct.AutoSize = true;
            this.lblDetailDeleteProduct.Location = new System.Drawing.Point(232, 216);
            this.lblDetailDeleteProduct.Name = "lblDetailDeleteProduct";
            this.lblDetailDeleteProduct.Size = new System.Drawing.Size(16, 13);
            this.lblDetailDeleteProduct.TabIndex = 7;
            this.lblDetailDeleteProduct.Text = "---";
            // 
            // btnDetailDelete
            // 
            this.btnDetailDelete.Location = new System.Drawing.Point(179, 320);
            this.btnDetailDelete.Name = "btnDetailDelete";
            this.btnDetailDelete.Size = new System.Drawing.Size(90, 32);
            this.btnDetailDelete.TabIndex = 6;
            this.btnDetailDelete.Text = "Detay Sil";
            this.btnDetailDelete.UseVisualStyleBackColor = true;
            this.btnDetailDelete.Click += new System.EventHandler(this.btnDetailDelete_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(191, 275);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Adet :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(191, 245);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Fiyat :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(190, 216);
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
            // DetailDelete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 388);
            this.Controls.Add(this.gbxDetailAdd);
            this.Name = "DetailDelete";
            this.Text = "DetailDelete";
            this.Load += new System.EventHandler(this.DetailDelete_Load);
            this.gbxDetailAdd.ResumeLayout(false);
            this.gbxDetailAdd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDetailDelete)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox gbxDetailAdd;
        private System.Windows.Forms.Button btnDetailDelete;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label lblDetailDeleteQuantity;
        private System.Windows.Forms.Label lblDetailDeletePrice;
        private System.Windows.Forms.Label lblDetailDeleteProduct;
        private System.Windows.Forms.DataGridView dgDetailDelete;
    }
}