using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Latihan
{
    public partial class frmLatihan5 : Form
    {
        public frmLatihan5()
        {
            InitializeComponent();
        }

        private void frmLatihan5_Load(object sender, EventArgs e)
        {
            btnMasuk.Enabled = false;
            btnKeluar.Enabled = false;
        }

        int keluar, masuk;

        private void txtNoKendaraan_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtNoKendaraan.Text))
            {
                btnMasuk.Enabled = true;
            }
            else
            {
                btnMasuk.Enabled = false;
            }
        }

        private void cboKendaraan_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboKendaraan.SelectedItem != null)
            {
                lblNoKendaraan.Text = cboKendaraan.SelectedItem.ToString();
                btnKeluar.Enabled = true;
            }
            else
            {
                btnKeluar.Enabled = false;
            }
        }

        private void btnKeluar_Click(object sender, EventArgs e)
        {
            if (cboKendaraan.SelectedItem != null)
            {
                cboKendaraan.Items.Remove(cboKendaraan.SelectedItem);
                lblNoKendaraan.Text = "";
                txtNoKendaraan.Focus();
                keluar += 1;
                lblKeluar.Text = keluar.ToString();
                lblSisa.Text = cboKendaraan.Items.Count.ToString();
            }
        }

        private void btnMasuk_Click(object sender, EventArgs e)
        {
            cboKendaraan.Items.Add(txtNoKendaraan.Text);
            txtNoKendaraan.Clear();
            txtNoKendaraan.Focus();
            masuk += 1;
            lblMasuk.Text = masuk.ToString();
            lblSisa.Text = cboKendaraan.Items.Count.ToString();
        }
    }
}
