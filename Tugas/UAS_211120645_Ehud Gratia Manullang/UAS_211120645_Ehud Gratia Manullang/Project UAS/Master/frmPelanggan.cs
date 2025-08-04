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
    public partial class frmPelanggan : Form
    {
        public frmPelanggan()
        {
            InitializeComponent();
        }


        //Part1
        SqlConnection con;
        string constr;
        SqlDataAdapter da;
        SqlCommand cmd;
        string query;
        DataSet ds;
        DataRow dr;
        DataColumn[] dc = new DataColumn[1];
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

        private void frmPelanggan_Load(object sender, EventArgs e)
        {
            Koneksi();
            txtIDPelanggan.MaxLength = 5; 
            txtNamaPelanggan.MaxLength = 50;
            txtAlamat.MaxLength = 200;
            txtNoHP.MaxLength = 13;
            
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            Master.frmCariPelanggan masterCariPelanggan = new Master.frmCariPelanggan(this); 
            masterCariPelanggan.Tag = this;
            masterCariPelanggan.ShowDialog(); 
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

        private void UpdateData()
        {
            cb = new SqlCommandBuilder(da);
            da = cb.DataAdapter;
            da.Update(ds.Tables["Pelanggan"]);
        }

        private void Kosong()
        {
            txtIDPelanggan.Clear();
            txtNamaPelanggan.Clear();
            txtAlamat.Clear();
            txtNoHP.Clear();
            rdoMember.Checked = false;
            rdoNonMember.Checked = false;
            txtIDPelanggan.Focus();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            LoadData();

            dr = ds.Tables["Pelanggan"].Rows.Find(txtIDPelanggan.Text); 
            if (dr != null) 
            {
                dr.Delete(); 
                UpdateData();
                MessageBox.Show("ID Pelanggan " + txtIDPelanggan.Text + " has been deleted.", "Delete Pelanggan", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Kosong();
            }
            else 
            {
                MessageBox.Show("Product ID " + txtIDPelanggan.Text + " does not exists in database.", "Delete Pelanggan", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            LoadData();

            dr = ds.Tables["Pelanggan"].Rows.Find(txtIDPelanggan.Text); 
            if (dr == null) 
            {
                dr = ds.Tables["Pelanggan"].NewRow(); 
                dr[0] = txtIDPelanggan.Text;
                dr[1] = txtNamaPelanggan.Text;
                dr[2] = txtAlamat.Text;
                dr[3] = txtNoHP.Text;
                if (rdoMember.Checked) 
                {
                    dr[4] = rdoMember.Text; 
                }
                else if (rdoNonMember.Checked) 
                {
                    dr[4] = rdoNonMember.Text; 
                }
                ds.Tables["Pelanggan"].Rows.Add(dr); 
                UpdateData();
                MessageBox.Show("ID Pelanggan " + txtIDPelanggan.Text + " has been added.", "Tambahkan Pelanggan", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Kosong(); 
            }
            else 
            {=
                MessageBox.Show("ID Pelanggan " + txtIDPelanggan.Text + " exists in database.", "Tambahkan pelanggan", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEdit_Click_1(object sender, EventArgs e)
        {
            LoadData();

            dr = ds.Tables["Pelanggan"].Rows.Find(txtIDPelanggan.Text); 
            if (dr != null)
            {
                
                dr[1] = txtNamaPelanggan.Text;
                dr[2] = txtAlamat.Text;
                dr[3] = txtNoHP.Text;
                if (rdoMember.Checked) 
                {
                    dr[3] = rdoMember.Text; ; 
                }
                else if (rdoNonMember.Checked)
                {
                    dr[3] = rdoNonMember.Text; ; 
                }
                UpdateData();
                MessageBox.Show("ID Pelanggan " + txtIDPelanggan.Text + " has been edited.", "Edit Pelanggan", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Kosong();
            }
            else //Jika data baris berdasarkan txtVendorID tidak ada
            {
                MessageBox.Show("ID Pelanggan " + txtIDPelanggan.Text + " does not exists in database.", "Edit Pelanggan", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
