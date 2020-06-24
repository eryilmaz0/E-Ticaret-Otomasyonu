namespace KitapEviDemo.Forms
{
    partial class OrderDetailsForm
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
            this.gbxOrderDetails = new System.Windows.Forms.GroupBox();
            this.dgOrderDetail = new System.Windows.Forms.DataGridView();
            this.entityCommand1 = new System.Data.Entity.Core.EntityClient.EntityCommand();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDetailAdd = new System.Windows.Forms.Button();
            this.btnDetailDelete = new System.Windows.Forms.Button();
            this.btnDetailUpdate = new System.Windows.Forms.Button();
            this.gbxOrderDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgOrderDetail)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxOrderDetails
            // 
            this.gbxOrderDetails.Controls.Add(this.dgOrderDetail);
            this.gbxOrderDetails.Location = new System.Drawing.Point(0, 0);
            this.gbxOrderDetails.Name = "gbxOrderDetails";
            this.gbxOrderDetails.Size = new System.Drawing.Size(639, 212);
            this.gbxOrderDetails.TabIndex = 0;
            this.gbxOrderDetails.TabStop = false;
            this.gbxOrderDetails.Text = "Sipariş Detayları";
            // 
            // dgOrderDetail
            // 
            this.dgOrderDetail.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgOrderDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgOrderDetail.Location = new System.Drawing.Point(26, 19);
            this.dgOrderDetail.Name = "dgOrderDetail";
            this.dgOrderDetail.Size = new System.Drawing.Size(575, 193);
            this.dgOrderDetail.TabIndex = 0;
            this.dgOrderDetail.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgOrderDetail_CellMouseClick);
            // 
            // entityCommand1
            // 
            this.entityCommand1.CommandTimeout = 0;
            this.entityCommand1.CommandTree = null;
            this.entityCommand1.Connection = null;
            this.entityCommand1.EnablePlanCaching = true;
            this.entityCommand1.Transaction = null;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnDetailUpdate);
            this.panel1.Controls.Add(this.btnDetailDelete);
            this.panel1.Controls.Add(this.btnDetailAdd);
            this.panel1.Location = new System.Drawing.Point(26, 218);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(575, 49);
            this.panel1.TabIndex = 2;
            // 
            // btnDetailAdd
            // 
            this.btnDetailAdd.Location = new System.Drawing.Point(3, 0);
            this.btnDetailAdd.Name = "btnDetailAdd";
            this.btnDetailAdd.Size = new System.Drawing.Size(130, 49);
            this.btnDetailAdd.TabIndex = 0;
            this.btnDetailAdd.Text = "Detay Ekle";
            this.btnDetailAdd.UseVisualStyleBackColor = true;
            this.btnDetailAdd.Click += new System.EventHandler(this.btnDetailAdd_Click);
            // 
            // btnDetailDelete
            // 
            this.btnDetailDelete.Location = new System.Drawing.Point(224, 0);
            this.btnDetailDelete.Name = "btnDetailDelete";
            this.btnDetailDelete.Size = new System.Drawing.Size(130, 49);
            this.btnDetailDelete.TabIndex = 1;
            this.btnDetailDelete.Text = "Detay Sil";
            this.btnDetailDelete.UseVisualStyleBackColor = true;
            this.btnDetailDelete.Click += new System.EventHandler(this.btnDetailDelete_Click);
            // 
            // btnDetailUpdate
            // 
            this.btnDetailUpdate.Location = new System.Drawing.Point(445, 0);
            this.btnDetailUpdate.Name = "btnDetailUpdate";
            this.btnDetailUpdate.Size = new System.Drawing.Size(130, 49);
            this.btnDetailUpdate.TabIndex = 2;
            this.btnDetailUpdate.Text = "Detay Güncelle";
            this.btnDetailUpdate.UseVisualStyleBackColor = true;
            this.btnDetailUpdate.Click += new System.EventHandler(this.btnDetailUpdate_Click);
            // 
            // OrderDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 328);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gbxOrderDetails);
            this.Name = "OrderDetailsForm";
            this.Text = "Sipariş Detayları";
            this.Load += new System.EventHandler(this.OrderDetailsForm_Load);
            this.gbxOrderDetails.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgOrderDetail)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxOrderDetails;
        private System.Windows.Forms.DataGridView dgOrderDetail;
        private System.Data.Entity.Core.EntityClient.EntityCommand entityCommand1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnDetailUpdate;
        private System.Windows.Forms.Button btnDetailDelete;
        private System.Windows.Forms.Button btnDetailAdd;
    }
}