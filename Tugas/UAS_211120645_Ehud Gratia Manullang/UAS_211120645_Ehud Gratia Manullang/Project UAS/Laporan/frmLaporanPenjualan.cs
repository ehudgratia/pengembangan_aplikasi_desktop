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

namespace Project_UAS.Laporan
{
    public partial class frmLaporanPenjualan : Form
    {
        public frmLaporanPenjualan()
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
                constr = "Data source = DESKTOP-P93837C; Initial Catalog = UAS; Integrated Security = true";
                con = new SqlConnection(constr);
                con.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LoadData() //tarik data dari DB ke DS
        {
            {
                ds = new DataSet();
                query = "SELECT sh.SalesID, sh.SalesDate, sh.IDPelanggan, p.NamaPelanggan, p.Alamat, p.NoHP, sd.IDMenu, m.NamaMenu, sd.Qty, sd.Tambahan, m.Harga FROM SalesHeader sh INNER JOIN SalesDetail sd ON sh.SalesID = sd.SalesID INNER JOIN Pelanggan p ON sh.IDPelanggan = p.IDPelanggan INNER JOIN Menu m ON sd.IDMenu = m.IDMenu";
                cmd = new SqlCommand(query, con);
                da = new SqlDataAdapter(cmd);
                da.Fill(ds, "Sales");
            }
        }

        private void btnTampil_Click(object sender, EventArgs e)
        {
                
        }
    }
}
