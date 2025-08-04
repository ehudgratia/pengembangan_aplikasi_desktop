
namespace Teori.Master
{
    partial class frmBrowseVendor
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdoVendorName = new System.Windows.Forms.RadioButton();
            this.rdoVendorID = new System.Windows.Forms.RadioButton();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.chkActive = new System.Windows.Forms.CheckBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblCount = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.btnSearch = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdoVendorName);
            this.groupBox1.Controls.Add(this.rdoVendorID);
            this.groupBox1.Controls.Add(this.btnRefresh);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.chkActive);
            this.groupBox1.Controls.Add(this.txtSearch);
            this.groupBox1.Location = new System.Drawing.Point(12, 13);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(408, 118);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search";
            // 
            // rdoVendorName
            // 
            this.rdoVendorName.AutoSize = true;
            this.rdoVendorName.Location = new System.Drawing.Point(134, 31);
            this.rdoVendorName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rdoVendorName.Name = "rdoVendorName";
            this.rdoVendorName.Size = new System.Drawing.Size(90, 17);
            this.rdoVendorName.TabIndex = 6;
            this.rdoVendorName.TabStop = true;
            this.rdoVendorName.Text = "Vendor Name";
            this.rdoVendorName.UseVisualStyleBackColor = true;
            // 
            // rdoVendorID
            // 
            this.rdoVendorID.AutoSize = true;
            this.rdoVendorID.Location = new System.Drawing.Point(16, 31);
            this.rdoVendorID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rdoVendorID.Name = "rdoVendorID";
            this.rdoVendorID.Size = new System.Drawing.Size(73, 17);
            this.rdoVendorID.TabIndex = 5;
            this.rdoVendorID.TabStop = true;
            this.rdoVendorID.Text = "Vendor ID";
            this.rdoVendorID.UseVisualStyleBackColor = true;
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackgroundImage = global::Teori.Properties.Resources.refresh;
            this.btnRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRefresh.Location = new System.Drawing.Point(336, 49);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(40, 40);
            this.btnRefresh.TabIndex = 4;
            this.btnRefresh.UseVisualStyleBackColor = true;
            // 
            // chkActive
            // 
            this.chkActive.AutoSize = true;
            this.chkActive.Location = new System.Drawing.Point(16, 87);
            this.chkActive.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkActive.Name = "chkActive";
            this.chkActive.Size = new System.Drawing.Size(110, 17);
            this.chkActive.TabIndex = 2;
            this.chkActive.Text = "Show Active Only";
            this.chkActive.UseVisualStyleBackColor = true;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(16, 58);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(268, 20);
            this.txtSearch.TabIndex = 1;
            // 
            // lblCount
            // 
            this.lblCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCount.Location = new System.Drawing.Point(381, 333);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(39, 27);
            this.lblCount.TabIndex = 16;
            this.lblCount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(333, 338);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Count";
            // 
            // dgvData
            // 
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Location = new System.Drawing.Point(12, 135);
            this.dgvData.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvData.Name = "dgvData";
            this.dgvData.RowHeadersWidth = 51;
            this.dgvData.RowTemplate.Height = 24;
            this.dgvData.Size = new System.Drawing.Size(408, 194);
            this.dgvData.TabIndex = 14;
            // 
            // btnSearch
            // 
            this.btnSearch.BackgroundImage = global::Teori.Properties.Resources.search;
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearch.Location = new System.Drawing.Point(290, 49);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(40, 40);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // frmBrowseVendor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 372);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvData);
            this.Name = "frmBrowseVendor";
            this.Text = "Browse Vendor";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdoVendorName;
        private System.Windows.Forms.RadioButton rdoVendorID;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.CheckBox chkActive;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvData;
    }
}