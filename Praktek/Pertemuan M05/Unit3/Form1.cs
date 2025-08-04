using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Unit3
{
    public partial class frmLatihan2 : Form
    {
        public frmLatihan2()
        {
            InitializeComponent();
        }

        private void frmLatihan2_Load(object sender, EventArgs e)
        {
            dudPilihProduk.Text = "---Pilih Produk---";
            dudPilihProduk.Items.Add("Nugget");
            dudPilihProduk.Items.Add("Sosis");
            dudPilihProduk.Items.Add("Bakso");
            dudPilihProduk.Items.Add("Dinsum");
            dudPilihProduk.Items.Add("Risol");
            
            dudPilihProduk.ReadOnly = true;
            picProduk.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void txtBayar_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Jika karakter yang ditekan bukan termasuk kategori kontrol (backspace, space, tap) dan karakter yang ditekan bukan termasuk kategori digit (angka)
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
        }

        int harga = 0, qty, total = 0, bayar = 0, kembalian = 0;


        private void hitungTotal()
        {
            qty = int.Parse(nudQty.Value.ToString()); //Nilai qty diambil dari nudQty
            total = harga * qty; //mencari nilai total
            lblTotal.Text = total.ToString("Rp #,##0");
        }

        private void dudPilihProduk_SelectedItemChanged(object sender, EventArgs e)
        {
            if (dudPilihProduk.SelectedIndex == 0) //Nugget
            {
                picProduk.Image = Properties.Resources.Nugget;
                harga = 25000;
            }
            else if (dudPilihProduk.SelectedIndex == 1) //Sosis
            {
                picProduk.Image = Properties.Resources.Sosis;
                harga = 56000;
            }
            else if (dudPilihProduk.SelectedIndex == 2) //Bakso
            {
                picProduk.Image = Properties.Resources.Bakso;
                harga = 56000;
            }
            else if (dudPilihProduk.SelectedIndex == 3) //Dinsum
            {
                picProduk.Image = Properties.Resources.Dimsum;
                harga = 65000;
            }
            else if (dudPilihProduk.SelectedIndex == 4) //Risol
            {
                picProduk.Image = Properties.Resources.Risol;
                harga = 48000;
            }
            lblHarga.Text = harga.ToString("Rp #,##0"); //Menampilkan harga pada label harga
            hitungTotal();
        }

        private void nudQty_ValueChanged(object sender, EventArgs e)
        {
            hitungTotal();
        }

        private void hitungKembalian()
        {
            if (txtBayar.Text == "") //txtbayar Kosong
            {
                lblKembalian.Text = ""; //maka kosongkan lblKembalian
            }
            else
            {
                bayar = int.Parse(txtBayar.Text);
                kembalian = bayar - total;
                lblKembalian.Text = kembalian.ToString("Rp #,##0");
            }
        }

        private void txtBayar_TextChanged(object sender, EventArgs e)
        {
            hitungKembalian();
        }

        private void picBeli_Click(object sender, EventArgs e)
        {
            lblTampil.Text = new string(' ',17) + "Frozen Food's" + "\n";
            lblTampil.Text += new string('=', 30) + "\n";
            lblTampil.Text += "Nama Menu    : " + dudPilihProduk.SelectedItem + "\n";
            lblTampil.Text += "Qty              : " + nudQty.Value + "kg\n";
            lblTampil.Text += "Harga            : " + lblHarga.Text + "\n";
            lblTampil.Text += "Total            : " + lblTotal.Text + "\n";
            lblTampil.Text += new string('-', 60) + "\n";
            lblTampil.Text += "Bayar            : " + txtBayar.Text + "\n";
            lblTampil.Text += "Kembalian        : " + lblKembalian.Text + "\n";
            lblTampil.Text += new string('-', 60) + "\n";
            lblTampil.Text += DateTime.Now.ToString("dd MMMM yyyy, HH:mm:ss") + "\n";
            lblTampil.Text += new string('=', 30) + "\n";
        }

        private void picBersih_Click(object sender, EventArgs e)
        {
            dudPilihProduk.SelectedIndex = -1;
            dudPilihProduk.Text = "---Pilih Produk---";
            nudQty.Value = 0;
            harga = 0;
            lblHarga.Text = harga.ToString("Rp#");
            lblTampil.Text = "";
            bayar = 0;
            txtBayar.Text = bayar.ToString();
            kembalian = 0;
            lblKembalian.Text = kembalian.ToString();
            MessageBox.Show("Pilihan menu telah dikosongkan", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void picKeluar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Apakah anda yakin ingin keluar dari aplikasi ?", "Keluar", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
