using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Teori
{
    public partial class frmLatihan1a : Form
    {
        public frmLatihan1a()
        {
            InitializeComponent();
        }


        private void btnKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmLatihan1a_Load(object sender, EventArgs e)
        {
            btnMasuk.Enabled = false;
        }

        private void btnValidasi_Click(object sender, EventArgs e)
        {

            if (txtPassword.Text == "ehudgratia") //Jika Password Benar
            {
                btnValidasi.Enabled = false;
                btnMasuk.Enabled = true;

                lblKeterangan.Text = "Password Benar1!";
                lblKeterangan.ForeColor = Color.Green;
            }
            else if (txtPassword.Text != "ehudgratia") //Jika password Salah
            {
                btnValidasi.Enabled = true;
                btnMasuk.Enabled = false;

                lblKeterangan.Text = "Password Salah! Input Ulang";
                lblKeterangan.ForeColor = Color.Red;
            }
;
        }

        private void btnMasuk_Click(object sender, EventArgs e)
        {
            frmLatihan1b form2 = new frmLatihan1b();
            form2.Show();
        }
    }
}
