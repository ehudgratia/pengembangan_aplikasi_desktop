
namespace Project_UAS.Transaksi
{
    partial class frmCariTransaksi
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
            this.rdoSalesID = new System.Windows.Forms.RadioButton();
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
            this.groupBox1.Controls.Add(this.rdoSalesID);
            this.groupBox1.Controls.Add(this.btnRefresh);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.txtSearch);
            this.groupBox1.Location = new System.Drawing.Point(11, 11);
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
            this.label2.Location = new System.Drawing.Point(19, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Sales Date";
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
            // rdoSalesID
            // 
            this.rdoSalesID.AutoSize = true;
            this.rdoSalesID.Location = new System.Drawing.Point(16, 31);
            this.rdoSalesID.Margin = new System.Windows.Forms.Padding(2);
            this.rdoSalesID.Name = "rdoSalesID";
            this.rdoSalesID.Size = new System.Drawing.Size(65, 17);
            this.rdoSalesID.TabIndex = 5;
            this.rdoSalesID.TabStop = true;
            this.rdoSalesID.Text = "Sales ID";
            this.rdoSalesID.UseVisualStyleBackColor = true;
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackgroundImage = global::Project_UAS.Properties.Resources.refresh;
            this.btnRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRefresh.Location = new System.Drawing.Point(336, 40);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(2);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(40, 40);
            this.btnRefresh.TabIndex = 4;
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackgroundImage = global::Project_UAS.Properties.Resources.search;
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearch.Location = new System.Drawing.Point(290, 40);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(40, 40);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
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
            this.dgvData.Location = new System.Drawing.Point(11, 137);
            this.dgvData.Margin = new System.Windows.Forms.Padding(2);
            this.dgvData.Name = "dgvData";
            this.dgvData.RowHeadersWidth = 51;
            this.dgvData.RowTemplate.Height = 24;
            this.dgvData.Size = new System.Drawing.Size(408, 194);
            this.dgvData.TabIndex = 15;
            this.dgvData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvData_CellClick);
            // 
            // frmCariTransaksi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 337);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvData);
            this.Name = "frmCariTransaksi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cari Transaksi";
            this.Load += new System.EventHandler(this.frmCariTransaksi_Load);
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
        private System.Windows.Forms.RadioButton rdoSalesID;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridView dgvData;
    }
}