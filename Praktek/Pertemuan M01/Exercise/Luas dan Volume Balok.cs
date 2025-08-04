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
    public partial class Luas_dan_Volume_Balok : Form
    {
        public Luas_dan_Volume_Balok()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnKosong_Click(object sender, EventArgs e)
        {
            txtPanjang.Clear();
            txtLebar.Clear();
            txtTinggi.Clear();
            txtPanjang.Focus();
        }

        int p, l, t, luas, volume;

        

        //Load adalah event dari form pada saat form dijalankan
        private void Luas_dan_Volume_Balok_Load(object sender, EventArgs e)
        {
            txtPanjang.ForeColor = Color.Red;
            txtLebar.ForeColor = Color.Red;
            txtTinggi.ForeColor = Color.Red;
        }

        private void btnHitung_Click(object sender, EventArgs e)
        {
            p = int.Parse(txtPanjang.Text);
            l = int.Parse(txtLebar.Text);
            t = int.Parse(txtTinggi.Text);

            luas = p * l;
            volume = p * l * t;

            lblLuas.Text = luas.ToString();
            lblVolume.Text = volume.ToString();
        }
    }
}
