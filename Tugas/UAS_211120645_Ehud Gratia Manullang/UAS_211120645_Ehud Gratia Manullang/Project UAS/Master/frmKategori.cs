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
    public partial class frmKategori : Form
    {
        public frmKategori()
        {
            InitializeComponent();
        }

        
        frmMenu masterMenu; 
        public frmKategori(frmMenu masterMenu) 
        {
            InitializeComponent();
            this.masterMenu = masterMenu; 
        }

        Transaksi.frmTransaksi transaksiSales;
        public frmKategori(Transaksi.frmTransaksi transaksiSales) 
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
            if (this.Tag == masterMenu)
            {
                query = "SELECT * FROM Menu"; 
            }
            else if (this.Tag == transaksiSales)
            {
                
                query = "SELECT * FROM Menu"; 
            }
            //Multi Table Part I>
            cmd = new SqlCommand(query, con);
            da = new SqlDataAdapter(cmd);
            da.Fill(ds, "Menu");
            dc[0] = ds.Tables["Menu"].Columns[0];
            ds.Tables["Menu"].PrimaryKey = dc;
        }

        private void TampilData()
        {
            dgvData.DataSource = ds.Tables["Menu"]; 
            dgvData.Columns[0].HeaderText = "ID Menu";
            dgvData.Columns[1].HeaderText = "Nama Menu";
            dgvData.Columns[2].HeaderText = "Harga";
            dgvData.Columns[3].HeaderText = "Jenis Menu";
            dgvData.AllowUserToAddRows = false; 
            dgvData.ReadOnly = true;
            lblCount.Text = dgvData.RowCount.ToString(); 
        }

        private void frmKategori_Load(object sender, EventArgs e)
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
            if (this.Tag == masterMenu) //Untuk tag masterMenu
            {
                if (rdoIDMenu.Checked) 
                {
                    query = "SELECT * FROM Menu WHERE IDMenu LIKE '%" + txtSearch.Text + "%'";
                }
                else if (rdoNamaProduk.Checked) 
                {
                    query = "SELECT * FROM Menu WHERE NamaMenu LIKE '%" + txtSearch.Text + "%'"; 
                }
            }
            cmd = new SqlCommand(query, con);
            da = new SqlDataAdapter(cmd);
            da.Fill(ds, "Menu");
            dc[0] = ds.Tables["Menu"].Columns[0];
            ds.Tables["Menu"].PrimaryKey = dc;

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
            if (this.Tag == masterMenu)
            {
                masterMenu.txtIDMenu.Text = dgvData[0, baris].Value.ToString(); 
                masterMenu.txtNamaMenu.Text = dgvData[1, baris].Value.ToString();
                masterMenu.nudPurchasingPrice.Value = int.Parse(dgvData[2, baris].Value.ToString());
                if (dgvData[3, baris].Value.ToString() == "Makanan")
                {
                    masterMenu.rdoMakanan.Checked = true;
                }
                else
                {
                    masterMenu.rdoMinuman.Checked = true;
                }
            }
            else if (this.Tag == transaksiSales)
            {
                transaksiSales.lblIDMenu.Text = dgvData[0, baris].Value.ToString();
                transaksiSales.lblNamaMenu.Text = dgvData[1, baris].Value.ToString();
                transaksiSales.lblHarga.Text = dgvData[2, baris].Value.ToString();
               
            }
            this.Close();
        }
    }
}
