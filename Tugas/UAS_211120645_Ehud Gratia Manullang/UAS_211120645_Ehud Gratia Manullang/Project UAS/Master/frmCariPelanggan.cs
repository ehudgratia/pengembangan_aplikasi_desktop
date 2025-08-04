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

namespace Project_UAS.Master
{
    public partial class frmCariPelanggan : Form
    {
        public frmCariPelanggan()
        {
            InitializeComponent();
        }

        Master.frmPelanggan masterPelanggan; //form yang memanggil
        public frmCariPelanggan(frmPelanggan masterPelanggan) //form yang dipanggil dihubungkan ke form yang memanggil
        {
            InitializeComponent();
            this.masterPelanggan = masterPelanggan; //terhubung
        }

        //<Multi Table Part I
        //Purchasing
        Transaksi.frmTransaksi transaksiSales;
        public frmCariPelanggan(Transaksi.frmTransaksi transaksiSales)
        {
            InitializeComponent();
            this.transaksiSales = transaksiSales; 
        }
        //Multi Table Part I>

        SqlConnection con;
        string constr;
        SqlDataAdapter da;
        SqlCommand cmd;
        string query;
        DataSet ds;
        DataRow dr;
        DataColumn[] dc = new DataColumn[1];

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
            query = "SELECT * FROM Pelanggan";
            cmd = new SqlCommand(query, con);
            da = new SqlDataAdapter(cmd);
            da.Fill(ds, "Pelanggan");
            dc[0] = ds.Tables["Pelanggan"].Columns[0];
            ds.Tables["Pelanggan"].PrimaryKey = dc;
        }

        private void TampilData()
        {
            dgvData.DataSource = ds.Tables["Pelanggan"]; //Sumber data
            //Judul kolom
            dgvData.Columns[0].HeaderText = "ID Pelanggan";
            dgvData.Columns[1].HeaderText = "Nama Pelanggan";
            dgvData.Columns[2].HeaderText = "Alamat";
            dgvData.Columns[3].HeaderText = "Phone";
            dgvData.Columns[4].HeaderText = "Jenis Pelanggan";
            dgvData.AllowUserToAddRows = false; //tidak ada baris kosong
            dgvData.ReadOnly = true; //data yang ditampilkan pada dgvData tidak dapat diketik/ubah
            lblCount.Text = dgvData.RowCount.ToString(); //menampilkan jumlah baris
        }

        private void frmCariPelanggan_Load(object sender, EventArgs e)
        {
            //Tampilkan data saat form dijalankan
            Koneksi();
            LoadData();
            TampilData();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            ds = new DataSet();
            if (rdoIDPelanggan.Checked)
            {
                query = "SELECT * FROM Pelanggan WHERE IDPelanggan LIKE '%" + txtSearch.Text + "%'"; 
            }
            else if (rdoNamaPelanggan.Checked) 
            {
                query = "SELECT * FROM Pelanggan WHERE NamaPelanggan LIKE '%" + txtSearch.Text + "%'"; 
            }
            cmd = new SqlCommand(query, con);
            da = new SqlDataAdapter(cmd);
            da.Fill(ds, "Pelanggan");
            dc[0] = ds.Tables["Pelanggan"].Columns[0];
            ds.Tables["Pelanggan"].PrimaryKey = dc;

            TampilData();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            //Tampilkan kembali data / refresh
            Koneksi();
            LoadData();
            TampilData();
            txtSearch.Clear();
            txtSearch.Focus();
        }


        private void dgvData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int baris = dgvData.CurrentCell.RowIndex; 
            if (this.Tag == masterPelanggan)
            {
                masterPelanggan.txtIDPelanggan.Text = dgvData[0, baris].Value.ToString();
                masterPelanggan.txtNamaPelanggan.Text = dgvData[1, baris].Value.ToString();
                masterPelanggan.txtAlamat.Text = dgvData[2, baris].Value.ToString();
                masterPelanggan.txtNoHP.Text = dgvData[3, baris].Value.ToString();
                if (dgvData[4, baris].Value.ToString() == "Member")
                {
                    masterPelanggan.rdoMember.Checked = true;
                }
                else
                {
                    masterPelanggan.rdoNonMember.Checked = true;
                }
            }
            else if (this.Tag == transaksiSales)
            {
                
                transaksiSales.lblIDPelanggan.Text = dgvData[0, baris].Value.ToString();
                transaksiSales.lblPelangganDesc.Text = dgvData[1, baris].Value.ToString() + "\r\n" + dgvData[2, baris].Value.ToString() + "\r\n" + dgvData[3, baris].Value.ToString() + "\r\n" + dgvData[4, baris].Value.ToString();
            }
            this.Close(); 
        }
    }
}
