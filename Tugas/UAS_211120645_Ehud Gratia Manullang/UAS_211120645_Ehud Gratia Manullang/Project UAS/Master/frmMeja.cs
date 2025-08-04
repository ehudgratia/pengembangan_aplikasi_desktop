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
    public partial class frmMeja : Form
    {
        public frmMeja()
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

        private void frmMeja_Load(object sender, EventArgs e)
        {
            Koneksi();
            txtNoMeja.MaxLength = 3;
            cboJenisMeja.Items.Add("Biasa");
            cboJenisMeja.Items.Add("VIP");
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            Master.frmCariMeja masterCariMeja = new Master.frmCariMeja(this); 
            masterCariMeja.Tag = this;
            masterCariMeja.ShowDialog(); 
        }

        //Part II
        private void LoadData()
        {
            ds = new DataSet();
            query = "SELECT * FROM Meja";
            cmd = new SqlCommand(query, con);
            da = new SqlDataAdapter(cmd);
            da.Fill(ds, "Meja");
            dc[0] = ds.Tables["Meja"].Columns[0];
            ds.Tables["Meja"].PrimaryKey = dc;
        }

        private void UpdateData()
        {
            cb = new SqlCommandBuilder(da);
            da = cb.DataAdapter;
            da.Update(ds.Tables["Meja"]);
        }

        private void Kosong()
        {
            txtNoMeja.Clear();
            cboJenisMeja.SelectedIndex = -1;
            txtNoMeja.Focus();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            LoadData();

            dr = ds.Tables["Meja"].Rows.Find(txtNoMeja.Text);
            if (dr == null)
            {
                dr = ds.Tables["Meja"].NewRow();
                dr[0] = txtNoMeja.Text;
                dr[1] = cboJenisMeja.SelectedItem.ToString();
                ds.Tables["Meja"].Rows.Add(dr);
                UpdateData();
                MessageBox.Show("No Meja " + txtNoMeja.Text + " has been added.", "Tambah Meja", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Kosong();
            }
            else 
            {
                MessageBox.Show("No Meja " + txtNoMeja.Text + " exists in database.", "Tambah Meja", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            LoadData();

            dr = ds.Tables["Meja"].Rows.Find(txtNoMeja.Text); 
            if (dr != null) 
            {
                
                dr[0] = txtNoMeja.Text;
                dr[1] = cboJenisMeja.SelectedItem.ToString();
                UpdateData();
                MessageBox.Show("No Meja " + txtNoMeja.Text + " has been edited.", "Edit Meja", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Kosong();
            }
            else 
            {
                MessageBox.Show("ID Menu " + txtNoMeja.Text + " does not exists in database.", "Edit Menu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            LoadData();

            dr = ds.Tables["Meja"].Rows.Find(txtNoMeja.Text); 
            if (dr != null) 
            {
                dr.Delete(); 
                UpdateData();
                MessageBox.Show("No Meja " + txtNoMeja.Text + " has been deleted.", "Delete Meja", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Kosong();
            }
            else 
            {
                MessageBox.Show("No Meja " + txtNoMeja.Text + " does not exists in database.", "Delete Meja", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
