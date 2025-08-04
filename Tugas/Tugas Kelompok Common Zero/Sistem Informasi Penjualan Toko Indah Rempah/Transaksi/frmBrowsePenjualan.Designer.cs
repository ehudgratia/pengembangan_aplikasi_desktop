
namespace Sistem_Informasi_Penjualan_Toko_Indah_Rempah.Transaksi
{
    partial class frmBrowsePenjualan
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
            this.label1 = new System.Windows.Forms.Label();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.rdoNamaPelanggan = new System.Windows.Forms.RadioButton();
            this.rdoIDPenjualan = new System.Windows.Forms.RadioButton();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dtpTo);
            this.groupBox1.Controls.Add(this.dtpFrom);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.rdoNamaPelanggan);
            this.groupBox1.Controls.Add(this.rdoIDPenjualan);
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
            // dtpTo
            // 
            this.dtpTo.Location = new System.Drawing.Point(257, 84);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(119, 20);
            this.dtpTo.TabIndex = 9;
            // 
            // dtpFrom
            // 
            this.dtpFrom.Location = new System.Drawing.Point(113, 84);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(119, 20);
            this.dtpFrom.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Tanggal Penjualan";
            // 
            // rdoNamaPelanggan
            // 
            this.rdoNamaPelanggan.AutoSize = true;
            this.rdoNamaPelanggan.Location = new System.Drawing.Point(134, 31);
            this.rdoNamaPelanggan.Margin = new System.Windows.Forms.Padding(2);
            this.rdoNamaPelanggan.Name = "rdoNamaPelanggan";
            this.rdoNamaPelanggan.Size = new System.Drawing.Size(107, 17);
            this.rdoNamaPelanggan.TabIndex = 6;
            this.rdoNamaPelanggan.TabStop = true;
            this.rdoNamaPelanggan.Text = "Nama Pelanggan";
            this.rdoNamaPelanggan.UseVisualStyleBackColor = true;
            // 
            // rdoIDPenjualan
            // 
            this.rdoIDPenjualan.AutoSize = true;
            this.rdoIDPenjualan.Location = new System.Drawing.Point(16, 31);
            this.rdoIDPenjualan.Margin = new System.Windows.Forms.Padding(2);
            this.rdoIDPenjualan.Name = "rdoIDPenjualan";
            this.rdoIDPenjualan.Size = new System.Drawing.Size(86, 17);
            this.rdoIDPenjualan.TabIndex = 5;
            this.rdoIDPenjualan.TabStop = true;
            this.rdoIDPenjualan.Text = "ID Penjualan";
            this.rdoIDPenjualan.UseVisualStyleBackColor = true;
            // 
            // btnRefresh
            // 
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
            // frmBrowsePenjualan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 344);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvData);
            this.Name = "frmBrowsePenjualan";
            this.Text = "frmBrowsePenjualan";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rdoNamaPelanggan;
        private System.Windows.Forms.RadioButton rdoIDPenjualan;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridView dgvData;
    }
}