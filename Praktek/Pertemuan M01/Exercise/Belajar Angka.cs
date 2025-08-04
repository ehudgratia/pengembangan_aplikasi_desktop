using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnNol_Click(object sender, EventArgs e)
        {
            lblAngka.Text = btnNol.Text;
            lblHuruf.Text = "Nol";
        }

        private void btnSatu_Click(object sender, EventArgs e)
        {
            lblAngka.Text = btnSatu.Text;
            lblHuruf.Text = "Satu";
        }

        private void btnDua_Click(object sender, EventArgs e)
        {
            lblAngka.Text = btnDua.Text;
            lblHuruf.Text = "Dua";
        }

        private void btnTiga_Click(object sender, EventArgs e)
        {
            lblAngka.Text = btnTiga.Text;
            lblHuruf.Text = "Tiga";
        }

        private void btnEmpat_Click(object sender, EventArgs e)
        {
            lblAngka.Text = btnEmpat.Text;
            lblHuruf.Text = "Empat";
        }

        private void btnLima_Click(object sender, EventArgs e)
        {
            lblAngka.Text = btnLima.Text;
            lblHuruf.Text = "Lima";
        }

        private void btnEnam_Click(object sender, EventArgs e)
        {
            lblAngka.Text = btnEnam.Text;
            lblHuruf.Text = "Enam";
        }

        private void btnTujuh_Click(object sender, EventArgs e)
        {
            lblAngka.Text = btnTujuh.Text;
            lblHuruf.Text = "Tujuh";
        }

        private void btnDelapan_Click(object sender, EventArgs e)
        {
            lblAngka.Text = btnDelapan.Text;
            lblHuruf.Text = "Delapan";
        }

        private void btnSembilan_Click(object sender, EventArgs e)
        {
            lblAngka.Text = btnNol.Text;
            lblHuruf.Text = "Sembilan";
        }
    }
}
