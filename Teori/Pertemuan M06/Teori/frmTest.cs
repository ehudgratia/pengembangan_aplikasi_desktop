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
    public partial class frmTest : Form
    {
        public frmTest()
        {
            InitializeComponent();
        }

        private void lklLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Website
            System.Diagnostics.Process.Start("Chrome", "https://mika.mikroskil.ac.id/");

            //File
            System.Diagnostics.Process.Start("C:\\Users\\Ehud Gratia\\OneDrive\\Dokumen\\Kuliah\\Semester 3\\Pengembangan Aplikasi Bisnis\\Teori\\PAB.txt");
        }

        private void btnTampil_Click(object sender, EventArgs e)
        {
            rtbText.LoadFile("Pengembangan Aplikasi Bisnis.rtf");
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            rtbText.SaveFile("wkwkwkwkwkwkwkwkwk.rtf");
        }
    }
}
