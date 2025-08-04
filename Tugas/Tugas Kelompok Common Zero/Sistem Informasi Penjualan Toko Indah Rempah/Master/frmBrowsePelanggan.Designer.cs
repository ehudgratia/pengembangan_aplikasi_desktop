
namespace Sistem_Informasi_Penjualan_Toko_Indah_Rempah.Master
{
    partial class frmBrowsePelanggan
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
            this.rdoNamaProduk = new System.Windows.Forms.RadioButton();
            this.rdoIDProduk = new System.Windows.Forms.RadioButton();
            this.chkActive = new System.Windows.Forms.CheckBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblCount = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdoNamaProduk);
            this.groupBox1.Controls.Add(this.rdoIDProduk);
            this.groupBox1.Controls.Add(this.btnRefresh);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.chkActive);
            this.groupBox1.Controls.Add(this.txtSearch);
            this.groupBox1.Location = new System.Drawing.Point(11, 11);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(408, 118);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search";
            // 
            // rdoNamaProduk
            // 
            this.rdoNamaProduk.AutoSize = true;
            this.rdoNamaProduk.Location = new System.Drawing.Point(134, 31);
            this.rdoNamaProduk.Margin = new System.Windows.Forms.Padding(2);
            this.rdoNamaProduk.Name = "rdoNamaProduk";
            this.rdoNamaProduk.Size = new System.Drawing.Size(107, 17);
            this.rdoNamaProduk.TabIndex = 6;
            this.rdoNamaProduk.TabStop = true;
            this.rdoNamaProduk.Text = "Nama Pelanggan";
            this.rdoNamaProduk.UseVisualStyleBackColor = true;
            // 
            // rdoIDProduk
            // 
            this.rdoIDProduk.AutoSize = true;
            this.rdoIDProduk.Location = new System.Drawing.Point(16, 31);
            this.rdoIDProduk.Margin = new System.Windows.Forms.Padding(2);
            this.rdoIDProduk.Name = "rdoIDProduk";
            this.rdoIDProduk.Size = new System.Drawing.Size(90, 17);
            this.rdoIDProduk.TabIndex = 5;
            this.rdoIDProduk.TabStop = true;
            this.rdoIDProduk.Text = "ID Pelanggan";
            this.rdoIDProduk.UseVisualStyleBackColor = true;
            // 
            // chkActive
            // 
            this.chkActive.AutoSize = true;
            this.chkActive.Location = new System.Drawing.Point(16, 87);
            this.chkActive.Margin = new System.Windows.Forms.Padding(2);
            this.chkActive.Name = "chkActive";
            this.chkActive.Size = new System.Drawing.Size(110, 17);
            this.chkActive.TabIndex = 2;
            this.chkActive.Text = "Show Active Only";
            this.chkActive.UseVisualStyleBackColor = true;
            // 
            // txtSearch
            // 
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearch.Location = new System.Drawing.Point(16, 58);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(2);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(273, 20);
            this.txtSearch.TabIndex = 1;
            // 
            // lblCount
            // 
            this.lblCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCount.Location = new System.Drawing.Point(379, 334);
            this.lblCount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(39, 27);
            this.lblCount.TabIndex = 12;
            this.lblCount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(333, 339);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Count";
            // 
            // dgvData
            // 
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Location = new System.Drawing.Point(11, 133);
            this.dgvData.Margin = new System.Windows.Forms.Padding(2);
            this.dgvData.Name = "dgvData";
            this.dgvData.RowHeadersWidth = 51;
            this.dgvData.RowTemplate.Height = 24;
            this.dgvData.Size = new System.Drawing.Size(408, 194);
            this.dgvData.TabIndex = 10;
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackgroundImage = global::Sistem_Informasi_Penjualan_Toko_Indah_Rempah.Properties.Resources.refresh;
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
            this.btnSearch.BackgroundImage = global::Sistem_Informasi_Penjualan_Toko_Indah_Rempah.Properties.Resources.search;
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearch.Location = new System.Drawing.Point(293, 49);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(40, 40);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // frmBrowsePelanggan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 372);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvData);
            this.Name = "frmBrowsePelanggan";
            this.Text = "Browse Pelanggan";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdoNamaProduk;
        private System.Windows.Forms.RadioButton rdoIDProduk;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.CheckBox chkActive;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvData;
    }
}