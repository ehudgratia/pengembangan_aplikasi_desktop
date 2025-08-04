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

namespace Project_UAS.Transaksi
{
    public partial class frmCariTransaksi : Form
    {
        public frmCariTransaksi()
        {
            InitializeComponent();
        }

        Transaksi.frmTransaksi transaksiSales;
        
        public frmCariTransaksi(Transaksi.frmTransaksi transaksiSales)
        {
            InitializeComponent();
            this.transaksiSales = transaksiSales;
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

        private void LoadData()
        {
            ds = new DataSet();
            query = "SELECT sh.SalesID, sh.SalesDate, P.IDPelanggan, P.NamaPelanggan, P.Alamat, P.NoHP, M.NoMeja,  sh.Total FROM SalesHeader sh INNER JOIN Pelanggan P ON sh.IDPelanggan = P.IDPelanggan INNER JOIN Meja M ON sh.NoMeja = M.NoMeja";
            cmd = new SqlCommand(query, con);
            da = new SqlDataAdapter(cmd);
            da.Fill(ds, "JoinShPM");
        }

        private void SearchData()
        {

            ds = new DataSet();
            if (rdoSalesID.Checked)
            {
                query = "SELECT sh.SalesID, sh.SalesDate, P.IDPelanggan, P.NamaPelanggan, P.Alamat, P.NoHP, M.NoMeja,  sh.Total FROM SalesHeader sh INNER JOIN Pelanggan P ON sh.IDPelanggan = P.IDPelanggan INNER JOIN Meja M ON sh.NoMeja = M.NoMeja LIKE '%" + txtSearch.Text + "%' AND ph.PurchaseDate BETWEEN '" + dtpFrom.Value.ToString("dd MMMM yyyy") + "' AND '" + dtpTo.Value.ToString("dd MMMM yyyy") + "'";
            }
            else if (rdoNamaPelanggan.Checked)
            {
                query = "SELECT sh.SalesID, sh.SalesDate, P.IDPelanggan, P.NamaPelanggan, P.Alamat, P.NoHP, M.NoMeja,  sh.Total FROM SalesHeader sh INNER JOIN Pelanggan P ON sh.IDPelanggan = P.IDPelanggan INNER JOIN Meja M ON sh.NoMeja = M.NoMeja LIKE '%" + txtSearch.Text + "%' AND ph.PurchaseDate BETWEEN '" + dtpFrom.Value.ToString("dd MMMM yyyy") + "' AND '" + dtpTo.Value.ToString("dd MMMM yyyy") + "'";
            }
            cmd = new SqlCommand(query, con);
            da = new SqlDataAdapter(cmd);
            da.Fill(ds, "JoinShPM");
        }

        private void TampilData()
        {
            

            dgvData.DataSource = ds.Tables["JoinShPM"];
            dgvData.Columns[0].HeaderText = "Sales ID";
            dgvData.Columns[1].HeaderText = "Sales Date";
            dgvData.Columns[2].HeaderText = "ID Pelanggan";
            dgvData.Columns[3].HeaderText = "Nama Pelanggan";
            dgvData.Columns[4].HeaderText = "Alamat";
            dgvData.Columns[5].HeaderText = "No HP";
            dgvData.Columns[6].HeaderText = "No Meja";
            dgvData.Columns[7].HeaderText = "Total";
            dgvData.AllowUserToAddRows = false;
            dgvData.ReadOnly = true;
        }

        private void Kosong()
        {
            txtSearch.Clear();
            dtpFrom.Value = DateTime.Today;
            dtpTo.Value = DateTime.Today;
        }

        private void frmCariTransaksi_Load(object sender, EventArgs e)
        {
            dtpFrom.CustomFormat = "dd MMMM yyyy";
            dtpFrom.Format = DateTimePickerFormat.Custom;

            dtpTo.CustomFormat = "dd MMMM yyyy";
            dtpTo.Format = DateTimePickerFormat.Custom;

            Koneksi();
            LoadData();
            TampilData();
        }

        private void dgvData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int baris = dgvData.CurrentCell.RowIndex;
            transaksiSales.txtSalesID.Text = dgvData[0, baris].Value.ToString();
            transaksiSales.dtpSalesDate.Value = DateTime.Parse(dgvData[1, baris].Value.ToString());
            transaksiSales.lblIDPelanggan.Text = dgvData[2, baris].Value.ToString();
            transaksiSales.lblPelangganDesc.Text = dgvData[3, baris].Value.ToString() + "\r\n" + dgvData[4, baris].Value.ToString() + "\r\n" + dgvData[5, baris].Value.ToString();
            transaksiSales.lblNoMeja.Text = dgvData[6, baris].Value.ToString();
            transaksiSales.lblTotal.Text = dgvData[7, baris].Value.ToString();
            this.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchData();
            TampilData();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            Kosong();
            LoadData();
            TampilData();
        }

    }
}
