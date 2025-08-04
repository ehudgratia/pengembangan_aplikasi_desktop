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
    public partial class Latihan1 : Form
    {
        public Latihan1()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEntry_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtNama.Text))
            {
                lstDaftar.Items.Add(txtNama.Text);
                lblJumlah.Text = lstDaftar.Items.Count.ToString();
                txtNama.Clear();
                txtNama.Focus();
            }
;
        }

        private void lstDaftar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstDaftar.SelectedIndex != null)
            {
                txtNama.Text = lstDaftar.SelectedItem.ToString();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            if (lstDaftar.SelectedIndex != null)
            {
                lstDaftar.Items.Remove(txtNama.Text);
                lblJumlah.Text = lstDaftar.Items.Count.ToString();
                txtNama.Clear();
                txtNama.Focus();
            }
        }

        private void ClearAll_Click(object sender, EventArgs e)
        {
            lstDaftar.Items.Clear();
            lblJumlah.Text = lstDaftar.Items.Count.ToString();
            txtNama.Clear();
            txtNama.Focus();
        }
    }
}
