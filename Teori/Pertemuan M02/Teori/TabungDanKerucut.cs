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
    public partial class Latihan_5 : Form
    {
        public Latihan_5()
        {
            InitializeComponent();
        }

        int jari, tinggi, volTabung, volKerucut, n = 22/7;

        private void btnHitung_Click(object sender, EventArgs e)
        {
            jari = int.Parse(txtJarijari.Text);
            tinggi = int.Parse(txtTinggi.Text);


            volTabung = (n * jari * jari) * tinggi;
            lblTabung.Text = "Volume Tabung = " + volTabung + " cm kubik";

            volKerucut = 1/3 * n * jari * jari * tinggi;
            lblKerucut.Text = "Volume Kerucut = " + volKerucut + " cm kubik";

        }
    }
}
