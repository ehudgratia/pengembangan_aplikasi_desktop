using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Project_UAS
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        SqlConnection con;
        string constr;
        SqlDataAdapter da;
        SqlCommand cmd;
        string query;
        DataSet ds;

        private void Koneksi()
        {
            try
            {
                constr = "Data source = localhost; Initial Catalog = UAS; Integrated Security = true";
                con = new SqlConnection(constr);
                con.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LoadDataLapDaftarPelanggan()
        {
            ds = new DataSet();
            query = "SELECT * FROM Pelanggan";
            cmd = new SqlCommand(query, con);
            da = new SqlDataAdapter(cmd);
            da.Fill(ds, "Pelanggan");
        }

        private void LoadDataLapDaftarMenu()
        {
            ds = new DataSet();
            query = "SELECT * FROM Menu";
            cmd = new SqlCommand(query, con);
            da = new SqlDataAdapter(cmd);
            da.Fill(ds, "Menu");
        }

        private void LoadDataLapDaftarMeja()
        {
            ds = new DataSet();
            query = "SELECT * FROM Meja";
            cmd = new SqlCommand(query, con);
            da = new SqlDataAdapter(cmd);
            da.Fill(ds, "Meja");
        }

        private void LoadDataLapSales()
        {
            ds = new DataSet();
            query = "SELECT sh.SalesID, sh.SalesDate, sh.IDPelanggan, p.NamaPelanggan, p.Alamat, p.NoHP, p.JenisPelanggan, sd.IDMenu, m.NamaMenu, sd.Qty, m.Harga FROM SalesHeader sh INNER JOIN SalesDetail sd ON sh.SalesID = sd.SalesID INNER JOIN Pelanggan p ON sh.IDPelanggan = p.IDPelanggan INNER JOIN Menu m ON sd.IDMenu = m.IDMenu";
            cmd = new SqlCommand(query, con);
            da = new SqlDataAdapter(cmd);
            da.Fill(ds, "Sales");
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            Koneksi();
            this.IsMdiContainer = true; //frmMain sebagai Container (dapat menampung form lain)
            //this.WindowState = FormWindowState.Maximized; //Tampilan Full Layar
            stbWaktu.Text = DateTime.Now.ToString(); //Tampilkan waktu saat ini
            timWaktu.Interval = 1000; //1 detik
            timWaktu.Enabled = true; //Nyalakan waktu

        }

        private void timWaktu_Tick(object sender, EventArgs e)
        {
            stbWaktu.Text = DateTime.Now.ToString(); //Tampilkan waktu saat ini
        }

        private void mnuMasterPelanggan_Click(object sender, EventArgs e)
        {
            Master.frmPelanggan masterProduct = new Master.frmPelanggan();
            masterProduct.MdiParent = this;
            masterProduct.Show();
        }

        private void mnuMasterMenu_Click(object sender, EventArgs e)
        {
            Master.frmMenu masterMenu = new Master.frmMenu();
            masterMenu.MdiParent = this;
            masterMenu.Show();
        }

        private void mnuMasterMeja_Click(object sender, EventArgs e)
        {
            Master.frmMeja masterMeja = new Master.frmMeja();
            masterMeja.MdiParent = this;
            masterMeja.Show();
        }

        private void mnuTransaksiPenjualan_Click(object sender, EventArgs e)
        {
            Transaksi.frmTransaksi transaksiPenjualan = new Transaksi.frmTransaksi();
            transaksiPenjualan.MdiParent = this;
            transaksiPenjualan.Show();
        }

        private void mnuLaporanDaftarPelanggan_Click(object sender, EventArgs e)
        {
            Laporan.crLaporanDaftarPelanggan crDaftarPelanggan = new Laporan.crLaporanDaftarPelanggan();
            Laporan.frmCrViewer viewer = new Laporan.frmCrViewer();
            LoadDataLapDaftarPelanggan();
            crDaftarPelanggan.SetDataSource(ds);
            viewer.crystalReportViewer1.ReportSource = crDaftarPelanggan;
            viewer.WindowState = FormWindowState.Maximized;
            viewer.Show();

        }

        private void mnuLaporanDaftarMenu_Click(object sender, EventArgs e)
        {
            Laporan.crLaporanDaftarMenu crDaftarMenu = new Laporan.crLaporanDaftarMenu();
            Laporan.frmCrViewer viewer = new Laporan.frmCrViewer();
            LoadDataLapDaftarMenu();
            crDaftarMenu.SetDataSource(ds);
            viewer.crystalReportViewer1.ReportSource = crDaftarMenu;
            viewer.WindowState = FormWindowState.Maximized;
            viewer.Show();
        }

        private void mnuLaporanDaftarMeja_Click(object sender, EventArgs e)
        {
            Laporan.crLaporanDaftarMeja crDaftarMeja = new Laporan.crLaporanDaftarMeja();
            Laporan.frmCrViewer viewer = new Laporan.frmCrViewer();
            LoadDataLapDaftarMeja();
            crDaftarMeja.SetDataSource(ds);
            viewer.crystalReportViewer1.ReportSource = crDaftarMeja;
            viewer.WindowState = FormWindowState.Maximized;
            viewer.Show();
        }

        private void mnuLaporanPenjualan_Click(object sender, EventArgs e)
        {
            Laporan.crLapSales crLapSales = new Laporan.crLapSales();
            Laporan.frmCrViewer viewer = new Laporan.frmCrViewer();
            LoadDataLapSales();
            crLapSales.SetDataSource(ds);
            viewer.crystalReportViewer1.ReportSource = crLapSales;
            viewer.WindowState = FormWindowState.Maximized;
            viewer.Show();
        }

        private void mnuLaporanStrukPembayaran_Click(object sender, EventArgs e)
        {
            Laporan.crStrukPembayaran crStrukPembayaran = new Laporan.crStrukPembayaran();
            Laporan.frmCrViewer viewer = new Laporan.frmCrViewer();
            LoadDataLapSales();
            crStrukPembayaran.SetDataSource(ds);
            viewer.crystalReportViewer1.ReportSource = crStrukPembayaran;
            viewer.WindowState = FormWindowState.Maximized;
            viewer.Show();
        }
    }
}
