
namespace Project_UAS
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.timWaktu = new System.Windows.Forms.Timer(this.components);
            this.stbMain = new System.Windows.Forms.StatusStrip();
            this.stbWaktu = new System.Windows.Forms.ToolStripStatusLabel();
            this.mnuLaporanDaftarMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuLaporan = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuLaporanDaftarPelanggan = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuLaporanDaftarMeja = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuLaporanPenjualan = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuLaporanStrukPembayaran = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTransaksiPenjualan = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTransaksi = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMasterMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMasterMeja = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMasterPelanggan = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMaster = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMain = new System.Windows.Forms.MenuStrip();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.stbMain.SuspendLayout();
            this.mnuMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // timWaktu
            // 
            this.timWaktu.Tick += new System.EventHandler(this.timWaktu_Tick);
            // 
            // stbMain
            // 
            this.stbMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stbWaktu});
            this.stbMain.Location = new System.Drawing.Point(0, 545);
            this.stbMain.Name = "stbMain";
            this.stbMain.Size = new System.Drawing.Size(1006, 22);
            this.stbMain.TabIndex = 3;
            this.stbMain.Text = "statusStrip1";
            // 
            // stbWaktu
            // 
            this.stbWaktu.Name = "stbWaktu";
            this.stbWaktu.Size = new System.Drawing.Size(118, 17);
            this.stbWaktu.Text = "toolStripStatusLabel1";
            // 
            // mnuLaporanDaftarMenu
            // 
            this.mnuLaporanDaftarMenu.Image = global::Project_UAS.Properties.Resources.Menu;
            this.mnuLaporanDaftarMenu.Name = "mnuLaporanDaftarMenu";
            this.mnuLaporanDaftarMenu.Size = new System.Drawing.Size(214, 56);
            this.mnuLaporanDaftarMenu.Text = "Daftar Menu";
            this.mnuLaporanDaftarMenu.Click += new System.EventHandler(this.mnuLaporanDaftarMenu_Click);
            // 
            // mnuLaporan
            // 
            this.mnuLaporan.BackColor = System.Drawing.Color.Transparent;
            this.mnuLaporan.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuLaporanDaftarPelanggan,
            this.mnuLaporanDaftarMeja,
            this.mnuLaporanDaftarMenu,
            this.mnuLaporanPenjualan,
            this.mnuLaporanStrukPembayaran});
            this.mnuLaporan.Image = ((System.Drawing.Image)(resources.GetObject("mnuLaporan.Image")));
            this.mnuLaporan.Name = "mnuLaporan";
            this.mnuLaporan.Size = new System.Drawing.Size(112, 56);
            this.mnuLaporan.Text = "Laporan";
            // 
            // mnuLaporanDaftarPelanggan
            // 
            this.mnuLaporanDaftarPelanggan.Image = global::Project_UAS.Properties.Resources.Pelanggan;
            this.mnuLaporanDaftarPelanggan.Name = "mnuLaporanDaftarPelanggan";
            this.mnuLaporanDaftarPelanggan.Size = new System.Drawing.Size(214, 56);
            this.mnuLaporanDaftarPelanggan.Text = "Daftar Pelanggan";
            this.mnuLaporanDaftarPelanggan.Click += new System.EventHandler(this.mnuLaporanDaftarPelanggan_Click);
            // 
            // mnuLaporanDaftarMeja
            // 
            this.mnuLaporanDaftarMeja.Image = global::Project_UAS.Properties.Resources.Meja;
            this.mnuLaporanDaftarMeja.Name = "mnuLaporanDaftarMeja";
            this.mnuLaporanDaftarMeja.Size = new System.Drawing.Size(214, 56);
            this.mnuLaporanDaftarMeja.Text = "Daftar Meja";
            this.mnuLaporanDaftarMeja.Click += new System.EventHandler(this.mnuLaporanDaftarMeja_Click);
            // 
            // mnuLaporanPenjualan
            // 
            this.mnuLaporanPenjualan.Image = global::Project_UAS.Properties.Resources.sales;
            this.mnuLaporanPenjualan.Name = "mnuLaporanPenjualan";
            this.mnuLaporanPenjualan.Size = new System.Drawing.Size(214, 56);
            this.mnuLaporanPenjualan.Text = "Penjualan";
            this.mnuLaporanPenjualan.Click += new System.EventHandler(this.mnuLaporanPenjualan_Click);
            // 
            // mnuLaporanStrukPembayaran
            // 
            this.mnuLaporanStrukPembayaran.Image = global::Project_UAS.Properties.Resources.StrukPembayaran;
            this.mnuLaporanStrukPembayaran.Name = "mnuLaporanStrukPembayaran";
            this.mnuLaporanStrukPembayaran.Size = new System.Drawing.Size(214, 56);
            this.mnuLaporanStrukPembayaran.Text = "Struk Pembayaran";
            this.mnuLaporanStrukPembayaran.Click += new System.EventHandler(this.mnuLaporanStrukPembayaran_Click);
            // 
            // mnuTransaksiPenjualan
            // 
            this.mnuTransaksiPenjualan.Image = global::Project_UAS.Properties.Resources.sales;
            this.mnuTransaksiPenjualan.Name = "mnuTransaksiPenjualan";
            this.mnuTransaksiPenjualan.Size = new System.Drawing.Size(126, 22);
            this.mnuTransaksiPenjualan.Text = "Penjualan";
            this.mnuTransaksiPenjualan.Click += new System.EventHandler(this.mnuTransaksiPenjualan_Click);
            // 
            // mnuTransaksi
            // 
            this.mnuTransaksi.BackColor = System.Drawing.Color.Transparent;
            this.mnuTransaksi.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuTransaksiPenjualan});
            this.mnuTransaksi.Image = global::Project_UAS.Properties.Resources.transaction;
            this.mnuTransaksi.Name = "mnuTransaksi";
            this.mnuTransaksi.Size = new System.Drawing.Size(116, 56);
            this.mnuTransaksi.Text = "Transaksi";
            // 
            // mnuMasterMenu
            // 
            this.mnuMasterMenu.Image = global::Project_UAS.Properties.Resources.Menu;
            this.mnuMasterMenu.Name = "mnuMasterMenu";
            this.mnuMasterMenu.Size = new System.Drawing.Size(130, 22);
            this.mnuMasterMenu.Text = "Menu";
            this.mnuMasterMenu.Click += new System.EventHandler(this.mnuMasterMenu_Click);
            // 
            // mnuMasterMeja
            // 
            this.mnuMasterMeja.Image = global::Project_UAS.Properties.Resources.Meja;
            this.mnuMasterMeja.Name = "mnuMasterMeja";
            this.mnuMasterMeja.Size = new System.Drawing.Size(130, 22);
            this.mnuMasterMeja.Text = "Meja";
            this.mnuMasterMeja.Click += new System.EventHandler(this.mnuMasterMeja_Click);
            // 
            // mnuMasterPelanggan
            // 
            this.mnuMasterPelanggan.Image = global::Project_UAS.Properties.Resources.Pelanggan;
            this.mnuMasterPelanggan.Name = "mnuMasterPelanggan";
            this.mnuMasterPelanggan.Size = new System.Drawing.Size(130, 22);
            this.mnuMasterPelanggan.Text = "Pelanggan";
            this.mnuMasterPelanggan.Click += new System.EventHandler(this.mnuMasterPelanggan_Click);
            // 
            // mnuMaster
            // 
            this.mnuMaster.BackColor = System.Drawing.Color.Transparent;
            this.mnuMaster.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuMasterPelanggan,
            this.mnuMasterMeja,
            this.mnuMasterMenu});
            this.mnuMaster.Image = global::Project_UAS.Properties.Resources.master;
            this.mnuMaster.ImageTransparentColor = System.Drawing.Color.Teal;
            this.mnuMaster.Name = "mnuMaster";
            this.mnuMaster.Size = new System.Drawing.Size(105, 56);
            this.mnuMaster.Text = "Master";
            // 
            // mnuMain
            // 
            this.mnuMain.AutoSize = false;
            this.mnuMain.BackgroundImage = global::Project_UAS.Properties.Resources.Background;
            this.mnuMain.ImageScalingSize = new System.Drawing.Size(50, 50);
            this.mnuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuMaster,
            this.mnuTransaksi,
            this.mnuLaporan});
            this.mnuMain.Location = new System.Drawing.Point(0, 0);
            this.mnuMain.Name = "mnuMain";
            this.mnuMain.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.mnuMain.Size = new System.Drawing.Size(1006, 60);
            this.mnuMain.TabIndex = 2;
            this.mnuMain.Text = "menuStrip1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Project_UAS.Properties.Resources.Ayam_Geprek_Santuy__1_;
            this.pictureBox1.Location = new System.Drawing.Point(347, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(659, 60);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Project_UAS.Properties.Resources.Background;
            this.ClientSize = new System.Drawing.Size(1006, 567);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.stbMain);
            this.Controls.Add(this.mnuMain);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.stbMain.ResumeLayout(false);
            this.stbMain.PerformLayout();
            this.mnuMain.ResumeLayout(false);
            this.mnuMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timWaktu;
        private System.Windows.Forms.StatusStrip stbMain;
        private System.Windows.Forms.ToolStripStatusLabel stbWaktu;
        private System.Windows.Forms.ToolStripMenuItem mnuLaporanDaftarMenu;
        private System.Windows.Forms.ToolStripMenuItem mnuLaporan;
        private System.Windows.Forms.ToolStripMenuItem mnuTransaksiPenjualan;
        private System.Windows.Forms.ToolStripMenuItem mnuTransaksi;
        private System.Windows.Forms.ToolStripMenuItem mnuMasterMenu;
        private System.Windows.Forms.ToolStripMenuItem mnuMasterMeja;
        private System.Windows.Forms.ToolStripMenuItem mnuMasterPelanggan;
        private System.Windows.Forms.ToolStripMenuItem mnuMaster;
        private System.Windows.Forms.ToolStripMenuItem mnuLaporanDaftarPelanggan;
        private System.Windows.Forms.ToolStripMenuItem mnuLaporanDaftarMeja;
        private System.Windows.Forms.ToolStripMenuItem mnuLaporanPenjualan;
        private System.Windows.Forms.ToolStripMenuItem mnuLaporanStrukPembayaran;
        public System.Windows.Forms.MenuStrip mnuMain;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

