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
    public partial class Latihan_6 : Form
    {
        public Latihan_6()
        {
            InitializeComponent();
        }

        int harga, jumlah, potongan, jumPotongan, total;

        private void button1_Click(object sender, EventArgs e)
        {
            harga = int.Parse(txtHarga.Text);
            jumlah = int.Parse(txtJumlah.Text);
            potongan = int.Parse(txtPotongan.Text);

            jumPotongan = (harga * jumlah) * potongan / 100;
            lblPotongan.Text = jumPotongan.ToString("Rp #,##0.00");

            total = harga * jumlah - jumPotongan; 
            lblKeterangan.Text = "Besaran Total dari Pembelian Anda adalah " + total.ToString("Rp #,##0.00");
            
        }
    }
}
