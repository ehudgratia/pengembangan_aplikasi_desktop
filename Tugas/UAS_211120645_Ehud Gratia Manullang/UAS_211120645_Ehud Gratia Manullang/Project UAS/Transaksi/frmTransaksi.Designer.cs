
namespace Project_UAS.Transaksi
{
    partial class frmTransaksi
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPenjualan = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSearchNoMeja = new System.Windows.Forms.Button();
            this.btnDeleteHeader = new System.Windows.Forms.Button();
            this.btnSaveHeader = new System.Windows.Forms.Button();
            this.lblPelangganDesc = new System.Windows.Forms.Label();
            this.btnCariPelanggan = new System.Windows.Forms.Button();
            this.lblNoMeja = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblIDPelanggan = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpSalesDate = new System.Windows.Forms.DateTimePicker();
            this.btnCariSalesID = new System.Windows.Forms.Button();
            this.txtSalesID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.lblHarga = new System.Windows.Forms.Label();
            this.nudQty = new System.Windows.Forms.NumericUpDown();
            this.lblNamaMenu = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnBrowseProduct = new System.Windows.Forms.Button();
            this.lblIDMenu = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tabPembayaran = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabPenjualan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQty)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPenjualan);
            this.tabControl1.Controls.Add(this.tabPembayaran);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(634, 419);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPenjualan
            // 
            this.tabPenjualan.Controls.Add(this.label8);
            this.tabPenjualan.Controls.Add(this.dgvData);
            this.tabPenjualan.Controls.Add(this.groupBox1);
            this.tabPenjualan.Controls.Add(this.lblTotal);
            this.tabPenjualan.Controls.Add(this.groupBox2);
            this.tabPenjualan.Location = new System.Drawing.Point(4, 22);
            this.tabPenjualan.Name = "tabPenjualan";
            this.tabPenjualan.Padding = new System.Windows.Forms.Padding(3);
            this.tabPenjualan.Size = new System.Drawing.Size(626, 393);
            this.tabPenjualan.TabIndex = 0;
            this.tabPenjualan.Text = "Penjualan";
            this.tabPenjualan.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(349, 355);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 13);
            this.label8.TabIndex = 40;
            this.label8.Text = "Grand Total";
            // 
            // dgvData
            // 
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Location = new System.Drawing.Point(266, 168);
            this.dgvData.Margin = new System.Windows.Forms.Padding(2);
            this.dgvData.Name = "dgvData";
            this.dgvData.RowHeadersWidth = 51;
            this.dgvData.RowTemplate.Height = 24;
            this.dgvData.Size = new System.Drawing.Size(350, 172);
            this.dgvData.TabIndex = 39;
            this.dgvData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvData_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSearchNoMeja);
            this.groupBox1.Controls.Add(this.btnDeleteHeader);
            this.groupBox1.Controls.Add(this.btnSaveHeader);
            this.groupBox1.Controls.Add(this.lblPelangganDesc);
            this.groupBox1.Controls.Add(this.btnCariPelanggan);
            this.groupBox1.Controls.Add(this.lblNoMeja);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lblIDPelanggan);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dtpSalesDate);
            this.groupBox1.Controls.Add(this.btnCariSalesID);
            this.groupBox1.Controls.Add(this.txtSalesID);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(8, 6);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(608, 156);
            this.groupBox1.TabIndex = 37;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Purchase Header";
            // 
            // btnSearchNoMeja
            // 
            this.btnSearchNoMeja.BackgroundImage = global::Project_UAS.Properties.Resources.search;
            this.btnSearchNoMeja.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearchNoMeja.Location = new System.Drawing.Point(509, 126);
            this.btnSearchNoMeja.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearchNoMeja.Name = "btnSearchNoMeja";
            this.btnSearchNoMeja.Size = new System.Drawing.Size(20, 20);
            this.btnSearchNoMeja.TabIndex = 12;
            this.btnSearchNoMeja.UseVisualStyleBackColor = true;
            this.btnSearchNoMeja.Click += new System.EventHandler(this.btnSearchNoMeja_Click);
            // 
            // btnDeleteHeader
            // 
            this.btnDeleteHeader.BackgroundImage = global::Project_UAS.Properties.Resources.delete;
            this.btnDeleteHeader.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDeleteHeader.Location = new System.Drawing.Point(555, 106);
            this.btnDeleteHeader.Margin = new System.Windows.Forms.Padding(2);
            this.btnDeleteHeader.Name = "btnDeleteHeader";
            this.btnDeleteHeader.Size = new System.Drawing.Size(40, 40);
            this.btnDeleteHeader.TabIndex = 11;
            this.btnDeleteHeader.UseVisualStyleBackColor = true;
            this.btnDeleteHeader.Click += new System.EventHandler(this.btnDeleteHeader_Click);
            // 
            // btnSaveHeader
            // 
            this.btnSaveHeader.BackgroundImage = global::Project_UAS.Properties.Resources.save2;
            this.btnSaveHeader.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSaveHeader.Location = new System.Drawing.Point(555, 30);
            this.btnSaveHeader.Margin = new System.Windows.Forms.Padding(2);
            this.btnSaveHeader.Name = "btnSaveHeader";
            this.btnSaveHeader.Size = new System.Drawing.Size(40, 40);
            this.btnSaveHeader.TabIndex = 10;
            this.btnSaveHeader.Click += new System.EventHandler(this.btnSaveHeader_Click);
            // 
            // lblPelangganDesc
            // 
            this.lblPelangganDesc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPelangganDesc.Location = new System.Drawing.Point(320, 57);
            this.lblPelangganDesc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPelangganDesc.Name = "lblPelangganDesc";
            this.lblPelangganDesc.Size = new System.Drawing.Size(208, 67);
            this.lblPelangganDesc.TabIndex = 9;
            // 
            // btnCariPelanggan
            // 
            this.btnCariPelanggan.BackgroundImage = global::Project_UAS.Properties.Resources.search;
            this.btnCariPelanggan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCariPelanggan.Location = new System.Drawing.Point(511, 30);
            this.btnCariPelanggan.Margin = new System.Windows.Forms.Padding(2);
            this.btnCariPelanggan.Name = "btnCariPelanggan";
            this.btnCariPelanggan.Size = new System.Drawing.Size(20, 20);
            this.btnCariPelanggan.TabIndex = 8;
            this.btnCariPelanggan.UseVisualStyleBackColor = true;
            this.btnCariPelanggan.Click += new System.EventHandler(this.btnCariPelanggan_Click);
            // 
            // lblNoMeja
            // 
            this.lblNoMeja.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNoMeja.Location = new System.Drawing.Point(397, 126);
            this.lblNoMeja.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNoMeja.Name = "lblNoMeja";
            this.lblNoMeja.Size = new System.Drawing.Size(111, 20);
            this.lblNoMeja.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(337, 131);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "No Meja";
            // 
            // lblIDPelanggan
            // 
            this.lblIDPelanggan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblIDPelanggan.Location = new System.Drawing.Point(417, 30);
            this.lblIDPelanggan.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIDPelanggan.Name = "lblIDPelanggan";
            this.lblIDPelanggan.Size = new System.Drawing.Size(90, 20);
            this.lblIDPelanggan.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(317, 30);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "ID Pelanggan";
            // 
            // dtpSalesDate
            // 
            this.dtpSalesDate.Location = new System.Drawing.Point(108, 53);
            this.dtpSalesDate.Margin = new System.Windows.Forms.Padding(2);
            this.dtpSalesDate.Name = "dtpSalesDate";
            this.dtpSalesDate.Size = new System.Drawing.Size(135, 20);
            this.dtpSalesDate.TabIndex = 5;
            // 
            // btnCariSalesID
            // 
            this.btnCariSalesID.BackgroundImage = global::Project_UAS.Properties.Resources.search;
            this.btnCariSalesID.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCariSalesID.Location = new System.Drawing.Point(209, 28);
            this.btnCariSalesID.Margin = new System.Windows.Forms.Padding(2);
            this.btnCariSalesID.Name = "btnCariSalesID";
            this.btnCariSalesID.Size = new System.Drawing.Size(20, 20);
            this.btnCariSalesID.TabIndex = 4;
            this.btnCariSalesID.UseVisualStyleBackColor = true;
            this.btnCariSalesID.Click += new System.EventHandler(this.btnCariSalesID_Click);
            // 
            // txtSalesID
            // 
            this.txtSalesID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSalesID.Location = new System.Drawing.Point(108, 28);
            this.txtSalesID.Margin = new System.Windows.Forms.Padding(2);
            this.txtSalesID.Name = "txtSalesID";
            this.txtSalesID.Size = new System.Drawing.Size(98, 20);
            this.txtSalesID.TabIndex = 2;
            this.txtSalesID.TextChanged += new System.EventHandler(this.txtSalesID_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 57);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sales Date";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sales ID";
            // 
            // lblTotal
            // 
            this.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTotal.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(426, 346);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(190, 36);
            this.lblTotal.TabIndex = 41;
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnDelete);
            this.groupBox2.Controls.Add(this.btnEdit);
            this.groupBox2.Controls.Add(this.btnAdd);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.lblSubtotal);
            this.groupBox2.Controls.Add(this.lblHarga);
            this.groupBox2.Controls.Add(this.nudQty);
            this.groupBox2.Controls.Add(this.lblNamaMenu);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.btnBrowseProduct);
            this.groupBox2.Controls.Add(this.lblIDMenu);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Location = new System.Drawing.Point(8, 167);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(253, 199);
            this.groupBox2.TabIndex = 38;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Purchase Detail";
            // 
            // btnDelete
            // 
            this.btnDelete.BackgroundImage = global::Project_UAS.Properties.Resources.delete;
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDelete.Location = new System.Drawing.Point(215, 162);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(30, 30);
            this.btnDelete.TabIndex = 41;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackgroundImage = global::Project_UAS.Properties.Resources.edit;
            this.btnEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEdit.Location = new System.Drawing.Point(185, 162);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(2);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(30, 30);
            this.btnEdit.TabIndex = 40;
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackgroundImage = global::Project_UAS.Properties.Resources.add;
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAdd.Location = new System.Drawing.Point(155, 162);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(30, 30);
            this.btnAdd.TabIndex = 39;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(17, 129);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(46, 13);
            this.label17.TabIndex = 38;
            this.label17.Text = "Subtotal";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(17, 103);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(36, 13);
            this.label16.TabIndex = 37;
            this.label16.Text = "Harga";
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSubtotal.Location = new System.Drawing.Point(108, 128);
            this.lblSubtotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(121, 20);
            this.lblSubtotal.TabIndex = 35;
            // 
            // lblHarga
            // 
            this.lblHarga.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblHarga.Location = new System.Drawing.Point(108, 103);
            this.lblHarga.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHarga.Name = "lblHarga";
            this.lblHarga.Size = new System.Drawing.Size(121, 20);
            this.lblHarga.TabIndex = 34;
            // 
            // nudQty
            // 
            this.nudQty.Location = new System.Drawing.Point(108, 78);
            this.nudQty.Margin = new System.Windows.Forms.Padding(2);
            this.nudQty.Name = "nudQty";
            this.nudQty.Size = new System.Drawing.Size(97, 20);
            this.nudQty.TabIndex = 33;
            this.nudQty.ValueChanged += new System.EventHandler(this.nudQty_ValueChanged);
            // 
            // lblNamaMenu
            // 
            this.lblNamaMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNamaMenu.Location = new System.Drawing.Point(108, 52);
            this.lblNamaMenu.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNamaMenu.Name = "lblNamaMenu";
            this.lblNamaMenu.Size = new System.Drawing.Size(121, 20);
            this.lblNamaMenu.TabIndex = 31;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(17, 82);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(23, 13);
            this.label11.TabIndex = 30;
            this.label11.Text = "Qty";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(17, 55);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 13);
            this.label9.TabIndex = 29;
            this.label9.Text = "Nama Menu";
            // 
            // btnBrowseProduct
            // 
            this.btnBrowseProduct.BackgroundImage = global::Project_UAS.Properties.Resources.search;
            this.btnBrowseProduct.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBrowseProduct.Location = new System.Drawing.Point(209, 28);
            this.btnBrowseProduct.Margin = new System.Windows.Forms.Padding(2);
            this.btnBrowseProduct.Name = "btnBrowseProduct";
            this.btnBrowseProduct.Size = new System.Drawing.Size(20, 20);
            this.btnBrowseProduct.TabIndex = 28;
            this.btnBrowseProduct.UseVisualStyleBackColor = true;
            this.btnBrowseProduct.Click += new System.EventHandler(this.btnBrowseProduct_Click);
            // 
            // lblIDMenu
            // 
            this.lblIDMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblIDMenu.Location = new System.Drawing.Point(108, 29);
            this.lblIDMenu.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIDMenu.Name = "lblIDMenu";
            this.lblIDMenu.Size = new System.Drawing.Size(97, 20);
            this.lblIDMenu.TabIndex = 27;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(17, 30);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "ID Menu";
            // 
            // tabPembayaran
            // 
            this.tabPembayaran.Location = new System.Drawing.Point(4, 22);
            this.tabPembayaran.Name = "tabPembayaran";
            this.tabPembayaran.Padding = new System.Windows.Forms.Padding(3);
            this.tabPembayaran.Size = new System.Drawing.Size(626, 393);
            this.tabPembayaran.TabIndex = 1;
            this.tabPembayaran.Text = "Pembayaran";
            this.tabPembayaran.UseVisualStyleBackColor = true;
            // 
            // frmTransaksi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 419);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmTransaksi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Transaksi";
            this.Load += new System.EventHandler(this.frmTransaksi_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPenjualan.ResumeLayout(false);
            this.tabPenjualan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQty)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPenjualan;
        public System.Windows.Forms.Label label8;
        public System.Windows.Forms.DataGridView dgvData;
        public System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.Button btnSearchNoMeja;
        public System.Windows.Forms.Button btnDeleteHeader;
        public System.Windows.Forms.Button btnSaveHeader;
        public System.Windows.Forms.Label lblPelangganDesc;
        public System.Windows.Forms.Button btnCariPelanggan;
        public System.Windows.Forms.Label lblNoMeja;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label lblIDPelanggan;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.DateTimePicker dtpSalesDate;
        public System.Windows.Forms.Button btnCariSalesID;
        public System.Windows.Forms.TextBox txtSalesID;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label lblTotal;
        public System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.Button btnDelete;
        public System.Windows.Forms.Button btnEdit;
        public System.Windows.Forms.Button btnAdd;
        public System.Windows.Forms.Label label17;
        public System.Windows.Forms.Label label16;
        public System.Windows.Forms.Label lblSubtotal;
        public System.Windows.Forms.Label lblHarga;
        public System.Windows.Forms.NumericUpDown nudQty;
        public System.Windows.Forms.Label lblNamaMenu;
        public System.Windows.Forms.Label label11;
        public System.Windows.Forms.Label label9;
        public System.Windows.Forms.Button btnBrowseProduct;
        public System.Windows.Forms.Label lblIDMenu;
        public System.Windows.Forms.Label label10;
        private System.Windows.Forms.TabPage tabPembayaran;
    }
}