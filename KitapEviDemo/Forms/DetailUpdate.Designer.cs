namespace KitapEviDemo.Forms
{
    partial class DetailUpdate
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
            this.btnDetailUpdate = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.NumDetailUpdateQuantity = new System.Windows.Forms.NumericUpDown();
            this.numDetailUpdatePrice = new System.Windows.Forms.NumericUpDown();
            this.cbxDetailUpdateProduct = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.dgDetailUpdate = new System.Windows.Forms.DataGridView();
            this.gbxDetailAdd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumDetailUpdateQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDetailUpdatePrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgDetailUpdate)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxDetailAdd
            // 
            this.gbxDetailAdd.Controls.Add(this.dgDetailUpdate);
            this.gbxDetailAdd.Controls.Add(this.btnDetailUpdate);
            this.gbxDetailAdd.Controls.Add(this.label3);
            this.gbxDetailAdd.Controls.Add(this.label2);
            this.gbxDetailAdd.Controls.Add(this.NumDetailUpdateQuantity);
            this.gbxDetailAdd.Controls.Add(this.numDetailUpdatePrice);
            this.gbxDetailAdd.Controls.Add(this.cbxDetailUpdateProduct);
            this.gbxDetailAdd.Controls.Add(this.label1);
            this.gbxDetailAdd.Location = new System.Drawing.Point(0, 0);
            this.gbxDetailAdd.Name = "gbxDetailAdd";
            this.gbxDetailAdd.Size = new System.Drawing.Size(438, 607);
            this.gbxDetailAdd.TabIndex = 1;
            this.gbxDetailAdd.TabStop = false;
            this.gbxDetailAdd.Text = "Detay Güncelle";
            // 
            // btnDetailUpdate
            // 
            this.btnDetailUpdate.Location = new System.Drawing.Point(166, 388);
            this.btnDetailUpdate.Name = "btnDetailUpdate";
            this.btnDetailUpdate.Size = new System.Drawing.Size(121, 32);
            this.btnDetailUpdate.TabIndex = 6;
            this.btnDetailUpdate.Text = "Detay Güncelle";
            this.btnDetailUpdate.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(125, 346);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Adet :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(125, 286);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Fiyat :";
            // 
            // NumDetailUpdateQuantity
            // 
            this.NumDetailUpdateQuantity.Location = new System.Drawing.Point(166, 344);
            this.NumDetailUpdateQuantity.Name = "NumDetailUpdateQuantity";
            this.NumDetailUpdateQuantity.Size = new System.Drawing.Size(121, 20);
            this.NumDetailUpdateQuantity.TabIndex = 3;
            // 
            // numDetailUpdatePrice
            // 
            this.numDetailUpdatePrice.DecimalPlaces = 1;
            this.numDetailUpdatePrice.Location = new System.Drawing.Point(166, 284);
            this.numDetailUpdatePrice.Name = "numDetailUpdatePrice";
            this.numDetailUpdatePrice.Size = new System.Drawing.Size(121, 20);
            this.numDetailUpdatePrice.TabIndex = 2;
            // 
            // cbxDetailUpdateProduct
            // 
            this.cbxDetailUpdateProduct.FormattingEnabled = true;
            this.cbxDetailUpdateProduct.Location = new System.Drawing.Point(166, 224);
            this.cbxDetailUpdateProduct.Name = "cbxDetailUpdateProduct";
            this.cbxDetailUpdateProduct.Size = new System.Drawing.Size(121, 21);
            this.cbxDetailUpdateProduct.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(124, 227);
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
            // dgDetailUpdate
            // 
            this.dgDetailUpdate.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgDetailUpdate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDetailUpdate.Location = new System.Drawing.Point(12, 41);
            this.dgDetailUpdate.Name = "dgDetailUpdate";
            this.dgDetailUpdate.Size = new System.Drawing.Size(414, 150);
            this.dgDetailUpdate.TabIndex = 7;
            // 
            // DetailUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 455);
            this.Controls.Add(this.gbxDetailAdd);
            this.Name = "DetailUpdate";
            this.Text = "DetailUpdate";
            this.Load += new System.EventHandler(this.DetailUpdate_Load);
            this.gbxDetailAdd.ResumeLayout(false);
            this.gbxDetailAdd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumDetailUpdateQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDetailUpdatePrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgDetailUpdate)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxDetailAdd;
        private System.Windows.Forms.Button btnDetailUpdate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown NumDetailUpdateQuantity;
        private System.Windows.Forms.NumericUpDown numDetailUpdatePrice;
        private System.Windows.Forms.ComboBox cbxDetailUpdateProduct;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.DataGridView dgDetailUpdate;
    }
}