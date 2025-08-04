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
    public partial class frmTransaksi : Form
    {
        public frmTransaksi()
        {
            InitializeComponent();
        }

        //<Multi Table Part III
        SqlConnection con;
        string constr;
        SqlDataAdapter da;
        SqlCommand cmd;
        string query;
        DataSet ds;
        DataRow dr;
        DataColumn[] dc = new DataColumn[1];
        DataColumn[] dc1 = new DataColumn[1];
        DataColumn[] dc2 = new DataColumn[2];
        SqlCommandBuilder cb;

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

        //1PK
        private void LoadDataHeader()
        {
            ds = new DataSet();
            query = "SELECT * FROM SalesHeader";
            cmd = new SqlCommand(query, con);
            da = new SqlDataAdapter(cmd);
            da.Fill(ds, "SalesHeader");
            dc1[0] = ds.Tables["SalesHeader"].Columns[0];
            ds.Tables["SalesHeader"].PrimaryKey = dc1;
        }

        //2PK
        private void LoadDataDetail()
        {
            ds = new DataSet();
            query = "SELECT * FROM SalesDetail";
            cmd = new SqlCommand(query, con);
            da = new SqlDataAdapter(cmd);
            da.Fill(ds, "SalesDetail");
            dc2[0] = ds.Tables["SalesDetail"].Columns[0];
            dc2[1] = ds.Tables["SalesDetail"].Columns[1];
            ds.Tables["SalesDetail"].PrimaryKey = dc2;
        }

        private void UpdateDataHeader()
        {
            cb = new SqlCommandBuilder(da);
            da = cb.DataAdapter;
            da.Update(ds, "SalesHeader");
        }

        private void UpdateDataDetail()
        {
            cb = new SqlCommandBuilder(da);
            da = cb.DataAdapter;
            da.Update(ds, "SalesDetail");
        }

        private void KosongHeader()
        {
            txtSalesID.Clear();
            dtpSalesDate.Value = DateTime.Today;
            lblIDPelanggan.Text = "";
            lblPelangganDesc.Text = "";
            lblNoMeja.Text = "";
            dgvData.Rows.Clear();
            lblTotal.Text = "";

            txtSalesID.Focus();
        }

        private void HitungSubtotal()
        {
            decimal harga, subtotal;
            if (!string.IsNullOrWhiteSpace(lblHarga.Text)) 
            {
                harga = decimal.Parse(lblHarga.Text); 
            }
            else 
            {
                harga = 0; 
            }
            subtotal = harga * nudQty.Value; 
            lblSubtotal.Text = subtotal.ToString(); 
        }

        private void HitungTotal()
        {
            int total = 0; 
            for (int i = 0; i <= dgvData.Rows.Count - 1; i++) 
            {
                total += int.Parse(dgvData.Rows[i].Cells[4].Value.ToString()); //total = total + subtotal tiap baris 
            }
            lblTotal.Text = total.ToString(); //tampilkan total
        }

        private void KosongDetail()
        {
            
            lblIDMenu.Text = "";
            lblNamaMenu.Text = "";
            nudQty.Value = 0;
            lblHarga.Text = "";
            lblSubtotal.Text = "";
        }


        private void frmTransaksi_Load(object sender, EventArgs e)
        {
            Koneksi();
            txtSalesID.MaxLength = 10;
            dtpSalesDate.CustomFormat = "dd MMMM yyyy";
            dtpSalesDate.Format = DateTimePickerFormat.Custom;

            

            dgvData.ColumnCount = 6;
            dgvData.Columns[0].HeaderText = "ID Menu";
            dgvData.Columns[1].HeaderText = "Nama Menu";
            dgvData.Columns[2].HeaderText = "Qty";
            dgvData.Columns[3].HeaderText = "Harga";
            dgvData.Columns[4].HeaderText = "Subtotal";
            dgvData.AllowUserToAddRows = false; //tidak sediakan baris baru
            dgvData.ReadOnly = true; //hanya bisa baca

            
        }

        private void btnCariSalesID_Click(object sender, EventArgs e)
        {
            Transaksi.frmCariTransaksi transactionCariTransaksi = new Transaksi.frmCariTransaksi(this);
            transactionCariTransaksi.ShowDialog();
            HitungSubtotal();
        }

        private void btnCariPelanggan_Click(object sender, EventArgs e)
        {
            Master.frmCariPelanggan masterCariPelanggan = new Master.frmCariPelanggan(this);
            masterCariPelanggan.Tag = this;
            masterCariPelanggan.ShowDialog();
        }

        private void btnBrowseProduct_Click(object sender, EventArgs e)
        {
            Master.frmKategori masterKategori = new Master.frmKategori(this);
            masterKategori.Tag = this;
            masterKategori.ShowDialog();

            HitungSubtotal();
        }

        private void txtSalesID_TextChanged(object sender, EventArgs e)
        {
            //1. Munculkan Data Header
            LoadDataHeader();
            dr = ds.Tables["SalesHeader"].Rows.Find(txtSalesID.Text);
            if (dr != null) //Jika dr ada
            {
                ds = new DataSet();
                query = "SELECT sh.SalesID, sh.SalesDate, p.IDPelanggan, p.NamaPelanggan, p.Alamat, p.NoHP, sh.Total FROM SalesHeader sh INNER JOIN Pelanggan p ON sh.IDPelanggan = p.IDPelanggan WHERE sh.SalesID = '" + txtSalesID.Text + "'";
                cmd = new SqlCommand(query, con);
                da = new SqlDataAdapter(cmd);
                da.Fill(ds, "JoinShPM");
                dc1[0] = ds.Tables["JoinShPM"].Columns[0];
                ds.Tables["JoinShPM"].PrimaryKey = dc1;

                dr = ds.Tables["JoinShPM"].Rows.Find(txtSalesID.Text);
                dtpSalesDate.Value = DateTime.Parse(dr[1].ToString());
                lblIDPelanggan.Text = dr[2].ToString();
                lblPelangganDesc.Text = dr[3].ToString() + "\r\n" + dr[4].ToString() + "\r\n" + dr[5].ToString();
                lblTotal.Text = dr[5].ToString();

                //2. Munculkan Data Detail ke dgvData
                ds = new DataSet();
                query = "SELECT sd.IDMenu, m.NamaMenu, sd.Qty, m.Harga, m.Harga * sd.Qty AS Subtotal FROM SalesDetail sd INNER JOIN Menu m ON sd.IDMenu = m.IDMenu WHERE sd.SalesID = '" + txtSalesID.Text + "'";
                cmd = new SqlCommand(query, con);
                da = new SqlDataAdapter(cmd);
                da.Fill(ds, "JoinSdM");

                dgvData.Rows.Clear();
                foreach (DataRow dr in ds.Tables["JoinSdM"].Rows)
                {
                    dgvData.Rows.Add(dr[0], dr[1], dr[2], dr[3], dr[4]); //Data baris yang dimunculkan untuk masing-masing kolom
                }
            }
            else //Jika dr tidak ada, maka bersihkan semua field
            {
                dtpSalesDate.Value = DateTime.Today;
                lblIDPelanggan.Text = "";
                lblPelangganDesc.Text = "";
                lblNoMeja.Text = "";
                dgvData.Rows.Clear();
                lblTotal.Text = "";

                KosongDetail();
            }
        }

        private void nudQty_ValueChanged(object sender, EventArgs e)
        {
            HitungSubtotal();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            bool cari = false;
            for (int i = 0; i <= dgvData.Rows.Count - 1; i++)
            {
                if (lblIDMenu.Text == dgvData.Rows[i].Cells[0].Value.ToString())
                {
                    cari = true;
                }
            }

            if (cari == false)
            {
                dgvData.Rows.Add(lblIDMenu.Text, lblNamaMenu.Text, nudQty.Value, lblHarga.Text, lblSubtotal.Text);

                HitungTotal();
            }
            else
            {
                MessageBox.Show("ID Menu " + lblIDMenu.Text + " exists.", "Add Sales Detail.", MessageBoxButtons.OK, MessageBoxIcon.Error); //Munculkan pesan sudah ada
            }
            KosongDetail();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            bool cari = false;
            for (int i = 0; i <= dgvData.Rows.Count - 1; i++)
            {
                if (lblIDMenu.Text == dgvData.Rows[i].Cells[0].Value.ToString())
                {
                    cari = true;

                    dgvData.Rows[i].Cells[1].Value = lblNamaMenu.Text;
                    dgvData.Rows[i].Cells[2].Value = nudQty.Value;
                    dgvData.Rows[i].Cells[3].Value = lblHarga.Text;
                    dgvData.Rows[i].Cells[4].Value = lblSubtotal.Text;
                }
            }

            if (cari == true)
            {
                HitungTotal();
            }
            else //jika cari = false / tidak ada
            {
                MessageBox.Show("ID Menu " + lblIDMenu.Text + " does not exists.", "Edit Sales Detail.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            KosongDetail();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            bool cari = false;
            for (int i = 0; i <= dgvData.Rows.Count - 1; i++)
            {
                if (lblIDMenu.Text == dgvData.Rows[i].Cells[0].Value.ToString())
                {
                    cari = true;
                    dgvData.Rows.Remove(dgvData.Rows[i]);
                }
            }
            if (cari == true)
            {
                HitungTotal();
            }
            else
            {
                MessageBox.Show("ID Menu " + lblIDMenu.Text + " does not exists.", "Delete Sales Detail.", MessageBoxButtons.OK, MessageBoxIcon.Error); //Munculkan pesan tidak ada
            }
            KosongDetail();
        }

        private void btnSearchNoMeja_Click(object sender, EventArgs e)
        {
            Master.frmCariMeja masterCariMeja = new Master.frmCariMeja(this);
            masterCariMeja.Tag = this;
            masterCariMeja.ShowDialog();
        }

        private void btnSaveHeader_Click(object sender, EventArgs e)
        {
            //1. Simpan ke Header
            LoadDataHeader();
            dr = ds.Tables["SalesHeader"].Rows.Find(txtSalesID.Text);
            if (dr == null) //Jika data baris kosong
            {
                dr = ds.Tables["SalesHeader"].NewRow();
                dr[0] = txtSalesID.Text;
                dr[1] = dtpSalesDate.Value.ToString();
                dr[2] = lblIDPelanggan.Text;
                dr[3] = lblNoMeja.Text;
                dr[4] = lblTotal.Text;
                ds.Tables["SalesHeader"].Rows.Add(dr);
                UpdateDataHeader();

                //2. Simpan ke Detail
                for (int i = 0; i <= dgvData.Rows.Count - 1; i++)
                {
                    LoadDataDetail();
                    dr = ds.Tables["SalesDetail"].NewRow();
                    dr[0] = txtSalesID.Text;
                    dr[1] = dgvData.Rows[i].Cells[0].Value;
                    dr[2] = dgvData.Rows[i].Cells[2].Value;
                    dr[3] = dgvData.Rows[i].Cells[3].Value;
                    ds.Tables["SalesDetail"].Rows.Add(dr);
                    UpdateDataDetail();
                }
                MessageBox.Show("Sales ID " + txtSalesID.Text + " has been saved", "Save Purchase Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                KosongHeader();
            }
            //<Multi Table Part IV
            else //Jika data baris tidak kosong / ada
            {
                //UpdateHeader
                dr[1] = dtpSalesDate.Value;
                dr[2] = lblIDPelanggan.Text;
                dr[3] = lblNoMeja.Text;
                dr[4] = lblTotal.Text;
                UpdateDataHeader();

                //Hapus nilai lama, simpan nilai baru
                //Hapus nilai lama
                ds = new DataSet();
                query = "SELECT * FROM SalesDetail WHERE SalesID = '" + txtSalesID.Text + "'";
                cmd = new SqlCommand(query, con);
                da = new SqlDataAdapter(cmd);
                da.Fill(ds, "SalesDetail");

                foreach (DataRow baris in ds.Tables["SalesDetail"].Rows)
                {
                    string kode = baris[1].ToString();
                    int lama = int.Parse(baris[2].ToString());
                }

                ds = new DataSet();
                query = "SELECT * FROM SalesDetail WHERE SalesID = '" + txtSalesID.Text + "'";
                cmd = new SqlCommand(query, con);
                da = new SqlDataAdapter(cmd);
                da.Fill(ds, "SalesDetail");

                foreach (DataRow baris in ds.Tables["SalesDetail"].Rows)
                {
                    baris.Delete(); //Hapus nilai
                }
                UpdateDataDetail();

                //Simpan nilai baru ke Detail
                for (int i = 0; i <= dgvData.Rows.Count - 1; i++)
                {
                    LoadDataDetail();
                    dr = ds.Tables["SalesDetail"].NewRow();
                    dr[0] = txtSalesID.Text;
                    //diambil dari dgvData
                    dr[1] = dgvData.Rows[i].Cells[0].Value; //kolom 1 (ProductID)
                    dr[2] = dgvData.Rows[i].Cells[2].Value; //kolom 3 (Qty)
                    ds.Tables["SalesDetail"].Rows.Add(dr);
                    UpdateDataDetail();
                }
                MessageBox.Show("Sales ID " + txtSalesID.Text + " has been edited", "Edit Sales Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                KosongHeader();
            }
        }

        private void btnDeleteHeader_Click(object sender, EventArgs e)
        {
            LoadDataHeader();
            dr = ds.Tables["SalesHeader"].Rows.Find(txtSalesID.Text);
            if (dr != null) //Jika dr tidak kosong
            {
                dr.Delete();
                UpdateDataHeader();

                //Hapus nilai lama
                ds = new DataSet();
                query = "SELECT * FROM SalesDetail WHERE SalesID = '" + txtSalesID.Text + "'";
                cmd = new SqlCommand(query, con);
                da = new SqlDataAdapter(cmd);
                da.Fill(ds, "SalesDetail");


                ds = new DataSet();
                query = "SELECT * FROM SalesDetail WHERE SalesID = '" + txtSalesID.Text + "'";
                cmd = new SqlCommand(query, con);
                da = new SqlDataAdapter(cmd);
                da.Fill(ds, "SalesDetail");

                foreach (DataRow baris in ds.Tables["SalesDetail"].Rows)
                {
                    baris.Delete(); //Hapus nilai
                }
                UpdateDataDetail();

                MessageBox.Show("Sales ID " + txtSalesID.Text + " has been deleted", "Delete Sales Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                KosongHeader();
            }
            else //Jika dr tidak ada
            {
                MessageBox.Show("Sales ID " + txtSalesID.Text + " does not exists", "Delete Sales Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                KosongHeader();
            }
        }

        private void dgvData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int baris = dgvData.CurrentCell.RowIndex;
            //Pindahkan data pada dgvData ke inputan Purchasing Detail
            lblIDMenu.Text = dgvData.Rows[baris].Cells[0].Value.ToString();
            lblNamaMenu.Text = dgvData.Rows[baris].Cells[1].Value.ToString();
            nudQty.Value = int.Parse(dgvData.Rows[baris].Cells[2].Value.ToString());
            lblHarga.Text = dgvData.Rows[baris].Cells[3].Value.ToString();
            lblSubtotal.Text = dgvData.Rows[baris].Cells[4].Value.ToString();
        }

        private void btnSeacrhSalesID_Click(object sender, EventArgs e)
        {
            Transaksi.frmCariTransaksi transactionCariTransaksi = new Transaksi.frmCariTransaksi(this);
            transactionCariTransaksi.ShowDialog();
            HitungSubtotal();
        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }
    }
}
