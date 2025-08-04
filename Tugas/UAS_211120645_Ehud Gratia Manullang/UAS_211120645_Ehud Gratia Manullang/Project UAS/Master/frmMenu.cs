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
    public partial class frmMenu : Form
    {
        public frmMenu()
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

        private void frmMenu_Load(object sender, EventArgs e)
        {
            Koneksi();
            txtIDMenu.MaxLength = 5;
            txtNamaMenu.MaxLength = 50;
            nudPurchasingPrice.Maximum = 100000; 
            nudPurchasingPrice.Increment = 1000; 
            nudPurchasingPrice.ThousandsSeparator = true;
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            Master.frmKategori masterKategori = new Master.frmKategori(this); 
            masterKategori.Tag = this;
            masterKategori.ShowDialog(); 
        }

        //Part II
        private void LoadData()
        {
            ds = new DataSet();
            query = "SELECT * FROM Menu";
            cmd = new SqlCommand(query, con);
            da = new SqlDataAdapter(cmd);
            da.Fill(ds, "Menu");
            dc[0] = ds.Tables["Menu"].Columns[0];
            ds.Tables["Menu"].PrimaryKey = dc;
        }

        private void UpdateData()
        {
            cb = new SqlCommandBuilder(da);
            da = cb.DataAdapter;
            da.Update(ds.Tables["Menu"]);
        }

        private void Kosong()
        {
            txtIDMenu.Clear();
            txtNamaMenu.Clear();
            nudPurchasingPrice.Value = 0;
            rdoMakanan.Checked = false;
            rdoMinuman.Checked = false;
            txtIDMenu.Focus();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            LoadData();

            dr = ds.Tables["Menu"].Rows.Find(txtIDMenu.Text);
            if (dr == null)
            {
                dr = ds.Tables["Menu"].NewRow();
                dr[0] = txtIDMenu.Text;
                dr[1] = txtNamaMenu.Text;
                dr[2] = nudPurchasingPrice.Value.ToString();
                if (rdoMakanan.Checked)
                {
                    dr[3] = rdoMakanan.Text;
                }
                else if (rdoMinuman.Checked)
                {
                    dr[3] = rdoMinuman.Text;
                }
                ds.Tables["Menu"].Rows.Add(dr);
                UpdateData();
                MessageBox.Show("ID Menu " + txtIDMenu.Text + " has been added.", "Tambah Menu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Kosong();
            }
            else 
            {
                MessageBox.Show("ID Menu " + txtIDMenu.Text + " exists in database.", "Tambah Menu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            LoadData();

            dr = ds.Tables["Menu"].Rows.Find(txtIDMenu.Text); 
            if (dr != null) 
            {
                
                dr[1] = txtNamaMenu.Text;
                dr[2] = nudPurchasingPrice.Value.ToString();
                if (rdoMakanan.Checked) 
                {
                    dr[3] = rdoMakanan.Text; 
                }
                else if (rdoMinuman.Checked) 
                {
                    dr[3] = rdoMinuman.Text; 
                }
                UpdateData();
                MessageBox.Show("ID Menu " + txtIDMenu.Text + " has been edited.", "Edit Menu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Kosong();
            }
            else 
            {
                MessageBox.Show("ID Menu " + txtIDMenu.Text + " does not exists in database.", "Edit Menu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            LoadData();

            dr = ds.Tables["Menu"].Rows.Find(txtIDMenu.Text);
            if (dr != null)
            {
                dr.Delete(); 
                UpdateData();
                MessageBox.Show("ID Menu " + txtIDMenu.Text + " has been deleted.", "Delete Menu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Kosong();
            }
            else 
            {
                MessageBox.Show("ID Menu " + txtIDMenu.Text + " does not exists in database.", "Delete Menu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
