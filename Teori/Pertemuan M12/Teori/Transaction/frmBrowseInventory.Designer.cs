
namespace Teori.Transaction
{
    partial class frmBrowseInventory
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
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nudQty = new System.Windows.Forms.NumericUpDown();
            this.cboQty = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rdoProductName = new System.Windows.Forms.RadioButton();
            this.rdoProductID = new System.Windows.Forms.RadioButton();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQty)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvData
            // 
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Location = new System.Drawing.Point(12, 133);
            this.dgvData.Margin = new System.Windows.Forms.Padding(2);
            this.dgvData.Name = "dgvData";
            this.dgvData.RowHeadersWidth = 51;
            this.dgvData.RowTemplate.Height = 24;
            this.dgvData.Size = new System.Drawing.Size(408, 194);
            this.dgvData.TabIndex = 13;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nudQty);
            this.groupBox1.Controls.Add(this.cboQty);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.rdoProductName);
            this.groupBox1.Controls.Add(this.rdoProductID);
            this.groupBox1.Controls.Add(this.btnRefresh);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.txtSearch);
            this.groupBox1.Location = new System.Drawing.Point(12, 11);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(408, 118);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search";
            // 
            // nudQty
            // 
            this.nudQty.Location = new System.Drawing.Point(105, 86);
            this.nudQty.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nudQty.Name = "nudQty";
            this.nudQty.Size = new System.Drawing.Size(89, 20);
            this.nudQty.TabIndex = 9;
            // 
            // cboQty
            // 
            this.cboQty.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboQty.FormattingEnabled = true;
            this.cboQty.Location = new System.Drawing.Point(47, 85);
            this.cboQty.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboQty.Name = "cboQty";
            this.cboQty.Size = new System.Drawing.Size(54, 21);
            this.cboQty.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Qty";
            // 
            // rdoProductName
            // 
            this.rdoProductName.AutoSize = true;
            this.rdoProductName.Location = new System.Drawing.Point(157, 31);
            this.rdoProductName.Margin = new System.Windows.Forms.Padding(2);
            this.rdoProductName.Name = "rdoProductName";
            this.rdoProductName.Size = new System.Drawing.Size(93, 17);
            this.rdoProductName.TabIndex = 6;
            this.rdoProductName.TabStop = true;
            this.rdoProductName.Text = "Product Name";
            this.rdoProductName.UseVisualStyleBackColor = true;
            // 
            // rdoProductID
            // 
            this.rdoProductID.AutoSize = true;
            this.rdoProductID.Location = new System.Drawing.Point(16, 31);
            this.rdoProductID.Margin = new System.Windows.Forms.Padding(2);
            this.rdoProductID.Name = "rdoProductID";
            this.rdoProductID.Size = new System.Drawing.Size(76, 17);
            this.rdoProductID.TabIndex = 5;
            this.rdoProductID.TabStop = true;
            this.rdoProductID.Text = "Product ID";
            this.rdoProductID.UseVisualStyleBackColor = true;
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackgroundImage = global::Teori.Properties.Resources.refresh;
            this.btnRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRefresh.Location = new System.Drawing.Point(337, 49);
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
            this.btnSearch.Location = new System.Drawing.Point(293, 49);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(40, 40);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(16, 58);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(2);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(270, 20);
            this.txtSearch.TabIndex = 1;
            // 
            // frmBrowseInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 339);
            this.Controls.Add(this.dgvData);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmBrowseInventory";
            this.Text = "Browse Inventory";
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQty)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown nudQty;
        private System.Windows.Forms.ComboBox cboQty;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rdoProductName;
        private System.Windows.Forms.RadioButton rdoProductID;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
    }
}