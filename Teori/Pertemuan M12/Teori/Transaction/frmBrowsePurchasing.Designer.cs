
namespace Teori.Transaction
{
    partial class frmBrowsePurchasing
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
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dtp = new System.Windows.Forms.DateTimePicker();
            this.rdoVendorName = new System.Windows.Forms.RadioButton();
            this.rdoPurchaseID = new System.Windows.Forms.RadioButton();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Purchase Date";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dateTimePicker2);
            this.groupBox1.Controls.Add(this.dtp);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.rdoVendorName);
            this.groupBox1.Controls.Add(this.rdoPurchaseID);
            this.groupBox1.Controls.Add(this.btnRefresh);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.txtSearch);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(408, 118);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(235, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "to";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(257, 84);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(119, 20);
            this.dateTimePicker2.TabIndex = 9;
            // 
            // dtp
            // 
            this.dtp.Location = new System.Drawing.Point(113, 84);
            this.dtp.Name = "dtp";
            this.dtp.Size = new System.Drawing.Size(119, 20);
            this.dtp.TabIndex = 8;
            // 
            // rdoVendorName
            // 
            this.rdoVendorName.AutoSize = true;
            this.rdoVendorName.Location = new System.Drawing.Point(134, 31);
            this.rdoVendorName.Margin = new System.Windows.Forms.Padding(2);
            this.rdoVendorName.Name = "rdoVendorName";
            this.rdoVendorName.Size = new System.Drawing.Size(90, 17);
            this.rdoVendorName.TabIndex = 6;
            this.rdoVendorName.TabStop = true;
            this.rdoVendorName.Text = "Vendor Name";
            this.rdoVendorName.UseVisualStyleBackColor = true;
            // 
            // rdoPurchaseID
            // 
            this.rdoPurchaseID.AutoSize = true;
            this.rdoPurchaseID.Location = new System.Drawing.Point(16, 31);
            this.rdoPurchaseID.Margin = new System.Windows.Forms.Padding(2);
            this.rdoPurchaseID.Name = "rdoPurchaseID";
            this.rdoPurchaseID.Size = new System.Drawing.Size(84, 17);
            this.rdoPurchaseID.TabIndex = 5;
            this.rdoPurchaseID.TabStop = true;
            this.rdoPurchaseID.Text = "Purchase ID";
            this.rdoPurchaseID.UseVisualStyleBackColor = true;
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackgroundImage = global::Teori.Properties.Resources.refresh;
            this.btnRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRefresh.Location = new System.Drawing.Point(336, 40);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(2);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(40, 40);
            this.btnRefresh.TabIndex = 4;
            this.btnRefresh.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            this.btnSearch.BackgroundImage = global::Teori.Properties.Resources.search;
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearch.Location = new System.Drawing.Point(290, 40);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(40, 40);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(16, 56);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(2);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(262, 20);
            this.txtSearch.TabIndex = 1;
            // 
            // dgvData
            // 
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Location = new System.Drawing.Point(12, 138);
            this.dgvData.Margin = new System.Windows.Forms.Padding(2);
            this.dgvData.Name = "dgvData";
            this.dgvData.RowHeadersWidth = 51;
            this.dgvData.RowTemplate.Height = 24;
            this.dgvData.Size = new System.Drawing.Size(408, 194);
            this.dgvData.TabIndex = 15;
            // 
            // frmBrowsePurchasing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 344);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvData);
            this.Name = "frmBrowsePurchasing";
            this.Text = "Browse Purchasing";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dtp;
        private System.Windows.Forms.RadioButton rdoVendorName;
        private System.Windows.Forms.RadioButton rdoPurchaseID;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridView dgvData;
    }
}