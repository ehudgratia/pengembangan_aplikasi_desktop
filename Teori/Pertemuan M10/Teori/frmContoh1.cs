using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient

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
        private void btnKoneksi_Click(object sender, EventArgs e)
        {
            try
            {
                constr = "Data Source = localhost; Initial Catalog = Teori; Integrated Security = true"; //Alamat
                con = new SqlConnection(constr);
                con.Open();

                MessageBox.Show("Koneksi Database Berhasil", "Koneksi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Koneksi database gagal", "Koneksi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }



    }
}
