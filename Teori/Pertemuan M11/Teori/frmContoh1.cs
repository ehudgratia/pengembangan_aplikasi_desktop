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

namespace Teori
{
    public partial class frmContoh1 : Form
    {
        public frmContoh1()
        {
            InitializeComponent();
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
                constr = "Data Source = localhost; Initial Catalog = Teori; Integrated Security =  true";
                con = new SqlConnection(constr);
                con.Open();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LoadData()
        {
            ds = new DataSet();
            query = "SELECT * FROM Customer";
            cmd = new SqlCommand(query, con);
            da = new SqlDataAdapter(cmd);
            da.Fill(ds, "Customer");
            dc[0] = ds.Tables["Customer"].Columns[0];
            ds.Tables["Customer"].PrimaryKey = dc;
        }

        private void TampilData()
        {
            dgvData.DataSource = ds.Tables["Customer"];
            dgvData.Columns[0].HeaderText = "Customer ID";
            dgvData.Columns[0].HeaderText = "Company Name";
            dgvData.AllowUserToAddRows = false;
            dgvData.ReadOnly = true;

        }
    }
}
