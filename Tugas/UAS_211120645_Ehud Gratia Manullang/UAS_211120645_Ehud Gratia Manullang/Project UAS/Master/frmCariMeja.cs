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
    public partial class frmCariMeja : Form
    {
        public frmCariMeja()
        {
            InitializeComponent();
        }

        frmMeja masterMeja; //form yang memanggil
        public frmCariMeja(frmMeja masterMeja) //form yang dipanggil dihubungkan ke form yang memanggil
        {
            InitializeComponent();
            this.masterMeja = masterMeja; //terhubung
        }

        Transaksi.frmTransaksi transaksiSales;
        public frmCariMeja(Transaksi.frmTransaksi transaksiSales)
        {
            InitializeComponent();
            this.transaksiSales = transaksiSales; //frmBrowseVendor dan frmPurchasing sudah terhubung
        }

        //<Single Table Part I
        SqlConnection con;
        string constr;
        SqlDataAdapter da;
        SqlCommand cmd;
        string query;
        DataSet ds;
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
            //<Multi Table Part I
            if (this.Tag == masterMeja)
            {
                query = "SELECT * FROM Meja"; 
            }
            else if (this.Tag == transaksiSales)
            {
                query = "SELECT * FROM Meja"; 
            }
            //Multi Table Part I>
            cmd = new SqlCommand(query, con);
            da = new SqlDataAdapter(cmd);
            da.Fill(ds, "Meja");
            dc[0] = ds.Tables["Meja"].Columns[0];
            ds.Tables["Meja"].PrimaryKey = dc;
        }

        private void TampilData()
        {
            dgvData.DataSource = ds.Tables["Meja"]; //Sumber data
            //Judul kolom
            dgvData.Columns[0].HeaderText = "No Meja";
            dgvData.Columns[1].HeaderText = "Jenis Meja";
            dgvData.AllowUserToAddRows = false; //tidak ada baris kosong
            dgvData.ReadOnly = true; //data yang ditampilkan pada dgvData tidak dapat diketik/ubah
            lblCount.Text = dgvData.RowCount.ToString(); //menampilkan jumlah baris
        }

        private void frmCariMeja_Load(object sender, EventArgs e)
        {
            //Tampilkan data saat form dijalankan
            Koneksi();
            LoadData();
            TampilData();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            ds = new DataSet();
            //<Multi Table Part I
            if (this.Tag == masterMeja) 
            {
                query = "SELECT * FROM Meja WHERE NoMeja LIKE '%" + txtSearch.Text + "%'";
            }

            cmd = new SqlCommand(query, con);
            da = new SqlDataAdapter(cmd);
            da.Fill(ds, "Meja");
            dc[0] = ds.Tables["Meja"].Columns[0];
            ds.Tables["Meja"].PrimaryKey = dc;

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
            if (this.Tag == masterMeja)
            {
                masterMeja.txtNoMeja.Text = dgvData[0, baris].Value.ToString();
                masterMeja.cboJenisMeja.SelectedItem = dgvData[1, baris].Value.ToString();
            }
            else if (this.Tag ==  transaksiSales)
            {
                transaksiSales.lblNoMeja.Text = dgvData[0, baris].Value.ToString();
            }
            this.Close();
        }
    }
}
