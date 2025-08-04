using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UTS_211120645_Ehud_Gratia_Manullang
{
    public partial class uts : Form
    {
        public uts()
        {
            InitializeComponent();
        }

        private void uts_Load(object sender, EventArgs e)
        {
            //Menambahkan item Outlet
            cboOutlet.Items.Add("Thamrin Plaza");
            cboOutlet.Items.Add("Plaza Medan Fair");
            cboOutlet.Items.Add("Center Point");

            //Mengubah Sizemode dari picturebox menjadi stretch
            picGambar.SizeMode = PictureBoxSizeMode.StretchImage;

            //Mengubah DropDownStyle dari combobox menjadi dropdownlist
            cboOutlet.DropDownStyle = ComboBoxStyle.DropDownList;
            cboJenisMenu.DropDownStyle = ComboBoxStyle.DropDownList;
            cboMenu.DropDownStyle = ComboBoxStyle.DropDownList;

            //Pada saat form dijalankan maka tidak dapat di tekan
            grpPilihanMenu.Enabled = false;

            //Membuat faktur tidak bisa di edit
            rtbFaktur.ReadOnly = true;

            stbJam.Text = DateTime.Now.ToString();
            timJam.Interval = 1000;
            timJam.Enabled = true;

            //Link Bukti
            lklBuktiTransaksi.Text = "Bukti Transaksi.rtf";
            lklBuktiTransaksi.Hide();
        }


        //Mendeklarasikan variabel yang digunakan untuk menyimpan data
        string namaMenu, isianMenu;
        int harga, subtotal, qty, total, totalDiskon, pajak, bayar, kembalian, grandTotal;

        struct Pesanan
        {
            public string namaMenu, isianMenu, catatan;
            public int harga, qty, subtotal;
        }

        Pesanan[] pesanan = new Pesanan[0];

        private void hitungTotal()
        {
            qty = int.Parse(nudQty.Value.ToString());
            subtotal = qty * harga;
            lblTotal.Text = subtotal.ToString("Rp #,##0");
        }

        private void hitungDiskon()
        {
            if (rdoMember.Checked)
            {
                totalDiskon = total * 20 / 100;
            }
            else if (rdoNonMember.Checked)
            {
                totalDiskon = total * 10 / 100;
            }
        }

        private void hitungGrandTotal()
        {
            grandTotal = total - totalDiskon + pajak;
            lblGrandTotal.Text = grandTotal.ToString("Rp #,##0");
        }

        private void hitungKembalian()
        {
            if (txtBayar.Text == "") // jika bayar kosong
            {
                lblKembalian.Text = ""; // maka kosongkan kembalian
            }
            else
            {
                bayar = int.Parse(txtBayar.Text);
                kembalian = bayar - grandTotal;
                lblKembalian.Text = kembalian.ToString("Rp #,##0");
            }
        }

        private void TampilData()
        {
            lstKeranjang.Items.Clear();
            total = 0;
            
            for (int i = 0; i <= pesanan.GetUpperBound(0); i++)
            {
                lstKeranjang.Items.Add(pesanan[i].namaMenu.PadRight(15) + "\t" + pesanan[i].isianMenu.PadRight(15) + pesanan[i].qty.ToString().PadRight(7) + pesanan[i].harga.ToString("Rp #,##0").PadRight(13));
                total += pesanan[i].subtotal; //n = total + n
            }
            lblTotalBelanja.Text = total.ToString("Rp #,##0"); //Menampilkan total
        }

        private void cboOutlet_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            cboJenisMenu.Items.Clear();
            cboMenu.Items.Clear();
            cboMenu.Text = "";
            lblHarga.Text = "Rp.";
            nudQty.Value = 0;
            lblTotal.Text = "Rp.0";
            txtCatatan.Text = "";
            picGambar.Image = null;

            
            grpIsianMenu.Enabled = false;


            //Menambahkan Jenis Menu
            cboJenisMenu.Items.Add("Makanan");
            cboJenisMenu.Items.Add("Minuman");

            grpTipePemesanan.Enabled = true;
            grpPilihanMenu.Enabled = true;
        }

        private void cboJenisMenu_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboMenu.Items.Clear();
            lblHarga.Text = "Rp.";
            nudQty.Value = 0;
            lblTotal.Text = "Rp.0";
            txtCatatan.Text = "";
            picGambar.Image = null;

            lblIsianMenu.Text = "";
            grpIsianMenu.Enabled = true;

            if (cboJenisMenu.SelectedIndex == 0) //Memilih makanan
            {
                rdoBubble.Enabled = false;
                rdoOreo.Enabled = false;
                rdoJelly.Enabled = false;
                rdoChocochip.Enabled = false;
                hsbLevelKepedasan.Enabled = false;

                //Menambahkan item Menu Makanan
                cboMenu.Items.Add("Ayam Geprek");
                cboMenu.Items.Add("Nasi Goreng");
                cboMenu.Items.Add("Indomie Kuah");
                cboMenu.Items.Add("Burger");
                cboMenu.Items.Add("Jamur Crispy");
                cboMenu.Items.Add("Tela-tela");
            }
            else if (cboJenisMenu.SelectedIndex == 1) //Memilih minuman
            {
                rdoBubble.Enabled = false;
                rdoOreo.Enabled = false;
                rdoJelly.Enabled = false;
                rdoChocochip.Enabled = false;
                hsbLevelKepedasan.Enabled = false;

                
                //Menambah item Minuman
                cboMenu.Items.Add("Milo");
                cboMenu.Items.Add("Brown Sugar");
                cboMenu.Items.Add("Coffee");
                cboMenu.Items.Add("Milk Tea");
                cboMenu.Items.Add("Cappuccino");
                cboMenu.Items.Add("Bang - Bang");
            }
        }

        private void cboMenu_SelectedIndexChanged(object sender, EventArgs e)
        {
            nudQty.Value = 0;
            lblTotal.Text = "Rp.0";
            txtCatatan.Text = "";

            lblIsianMenu.Text = "";
            grpIsianMenu.Enabled = true;
            hsbLevelKepedasan.Enabled = false;
            rdoBubble.Enabled = false;
            rdoOreo.Enabled = false;
            rdoJelly.Enabled = false;
            rdoChocochip.Enabled = false;
            hsbLevelKepedasan.Enabled = false;

            if (cboJenisMenu.SelectedIndex == 0) //Memilih Makanan
            {
                hsbLevelKepedasan.Enabled = true; 

                if (cboMenu.SelectedIndex == 0) // Jika memilih Ayam Geprek
                {
                    namaMenu = "Ayam Geprek";
                    harga = 13000;

                    //Menambahkan foto
                    picGambar.Image = Properties.Resources.Ayam_Geprek;
                }
                else if (cboMenu.SelectedIndex == 1) // Jika memilih Nasi Goreng
                {
                    namaMenu = "Nasi Goreng";
                    harga = 15000;

                    //Menambahkan foto
                    picGambar.Image = Properties.Resources.Nasi_Goreng;
                }
                else if (cboMenu.SelectedIndex == 2) // Jika memilih Indomie kuah
                {
                    namaMenu = "Indomie Kuah";
                    harga = 10000;

                    //Menambahkan foto
                    picGambar.Image = Properties.Resources.Indomie_Kuah;
                }
                else if (cboMenu.SelectedIndex == 3) // Jika memilih burger
                {
                    namaMenu = "Burger";
                    harga = 15000;

                    //Menambahkan foto
                    picGambar.Image = Properties.Resources.Burger;
                }
                else if (cboMenu.SelectedIndex == 4) // Jika memilih Jamur Crizpy
                {
                    namaMenu = "Jamur Crizpy";
                    harga = 10000;

                    //Menambahkan foto
                    picGambar.Image = Properties.Resources.Jamur_Crispy;
                }
                else if (cboMenu.SelectedIndex == 5) // Jika memilih tela-tela
                {
                    namaMenu = "Tela-tela";
                    harga = 10000;

                    //Menambahkan foto
                    picGambar.Image = Properties.Resources.Tela_tela;
                }
            }
            else if (cboJenisMenu.SelectedIndex == 1) //Memilih minuman
            {
                hsbLevelKepedasan.Enabled = false;
                rdoBubble.Enabled = true;
                rdoOreo.Enabled = true;
                rdoJelly.Enabled = true;
                rdoChocochip.Enabled = true;

                if (cboMenu.SelectedIndex == 0) //Memilih Milo
                {
                    namaMenu = "Milo";
                    harga = 10000;

                    //Menambahkan foto
                    picGambar.Image = Properties.Resources.Milo;
                }
                else if (cboMenu.SelectedIndex == 1) //Memilih Brown Sugar
                {
                    namaMenu = "Brown Sugar";
                    harga = 20000;

                    picGambar.Image = Properties.Resources.Brown_Sugar;
                }
                else if (cboMenu.SelectedIndex == 2) //Memilih Coffee
                {
                    namaMenu = "Coffee";
                    harga = 18000;

                    picGambar.Image = Properties.Resources.Coffee;
                }
                else if (cboMenu.SelectedIndex == 3) //Memilih Milk Tea
                {
                    namaMenu = "Milk Tea";
                    harga = 15000;

                    picGambar.Image = Properties.Resources.Milk_TEa;
                }
                else if (cboMenu.SelectedIndex == 4) //Memilih Cappuccino
                {
                    namaMenu = "Cappuccino";
                    harga = 20000;

                    picGambar.Image = Properties.Resources.Cappuccino;
                }
                else if (cboMenu.SelectedIndex == 5) //Memilih CoffeeLatte
                {
                    namaMenu = "Bang - Bang";
                    harga = 25000;

                    picGambar.Image = Properties.Resources.BangBang;
                }
            }
            lblHarga.Text = harga.ToString("Rp #,##0");
            hitungTotal();
        }

        private void nudQty_ValueChanged(object sender, EventArgs e)
        {
            hitungTotal();
        }

        private void txtNoHp_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
        }

        private void txtBayar_TextChanged(object sender, EventArgs e)
        {
            hitungKembalian();
        }

        private void timWaktu_Tick(object sender, EventArgs e)
        {
            stbJam.Text = DateTime.Now.ToString();
        }

        private void lklBuktiTransaksi_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("Bukti Transaksi.rtf");
        }

        private void btnKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timJam_Tick(object sender, EventArgs e)
        {
            stbJam.Text = DateTime.Now.ToString();
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            if(nudQty.Value > 0)
            {
                Array.Resize(ref pesanan, pesanan.Count() + 1);

                pesanan[pesanan.GetUpperBound(0)].namaMenu = namaMenu;
                pesanan[pesanan.GetUpperBound(0)].harga = harga;
                pesanan[pesanan.GetUpperBound(0)].qty = qty;
                pesanan[pesanan.GetUpperBound(0)].isianMenu = isianMenu;
                pesanan[pesanan.GetUpperBound(0)].catatan = txtCatatan.Text;
                pesanan[pesanan.GetUpperBound(0)].subtotal = subtotal;
                

                TampilData();

                MessageBox.Show("Pesanan berhasil ditambahkan", "Tambah Produk", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Qty tidak boleh 0", "Tambah Produk", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            cboJenisMenu.SelectedIndex = -1;
            cboMenu.SelectedIndex = -1;
            lblHarga.Text = "Rp.0";
            nudQty.Value = 0;
            hsbLevelKepedasan.Enabled = false;
            lblTotal.Text = "Rp.0";
            txtCatatan.Text = "";
        }

        private void txtBayar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
        }

        private void rdoToppingMinuman_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoBubble.Checked)
            {
                isianMenu = "Bubble";
            }
            else if (rdoOreo.Checked)
            {
                isianMenu = "Oreo";
            }
            else if (rdoJelly.Checked)
            {
                isianMenu = "Jelly";
            }
            else if (rdoChocochip.Checked)
            {
                isianMenu = "Chocochip";
            }
        }

        private void hsbLevelKepedasan_Scroll_1(object sender, ScrollEventArgs e)
        {
            if (hsbLevelKepedasan.Value == 0)
            {
                isianMenu = "Tidak Pedas";
            }
            else if (hsbLevelKepedasan.Value == 1)
            {
                isianMenu = "Pedas";
            }
            else if (hsbLevelKepedasan.Value == 2)
            {
                isianMenu = "Sangat Pedas";
            }
            lblIsianMenu.Text = isianMenu;
        }

        private void btnBersih_Click(object sender, EventArgs e)
        {
            cboJenisMenu.SelectedIndex = -1;
            cboMenu.SelectedIndex = -1;
            lblHarga.Text = "Rp.0";
            nudQty.Value = 0;
            lblTotal.Text = "Rp.0";
            txtCatatan.Text = "";
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (lstKeranjang.SelectedIndex != -1) //Jika ada item yang dipilih pada lstBox Keranjang
            {
                if (MessageBox.Show("Apakah Anda ingin menghapus pesanan ini dari keranjang ?", "Hapus pesanan", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    for (int i = lstKeranjang.SelectedIndex + 1; i <= pesanan.GetUpperBound(0); i++)
                    {
                        pesanan[i - 1] = pesanan[i];
                    }
                    Array.Resize(ref pesanan, pesanan.Count() - 1);

                    TampilData();
                    MessageBox.Show("Pesanan Anda berhasil dihapus", "Hapus pesanan", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Pilih pesanan terlebih dahulu", "Hapus pesanan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnKonfirmasi_Click(object sender, EventArgs e)
        {
            pajak = 5000;
            lblPajak.Text = pajak.ToString("Rp #,##0");
            

            if (MessageBox.Show("Apakah Anda ingin melakukan konfirmasi pesanan ?", "Konfirmasi Pesanan", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                tabPesanan.SelectedIndex = 3;
                rtbFaktur.Text = new string(' ', 20) + "Ayam Geprek Santuy" + "\n";
                rtbFaktur.Text += new string('=', 50) + "\n";
                rtbFaktur.Text += "Cabang\t\t: " + cboOutlet.SelectedItem.ToString() + "\n";
                rtbFaktur.Text += "Hari, Tanggal\t: " + dateTimePicker1.Text + "\n";
                rtbFaktur.Text += "Nama Pelanggan\t: " + txtNamaPelanggan.Text + "\n";
                rtbFaktur.Text += "No Hp\t\t: " + txtNoHp.Text + "\n";
                rtbFaktur.Text += "Alamat Pelanggan\t: " + txtAlamat.Text + "\n";
                rtbFaktur.Text += "Tipe Pesanan\t: ";
                if (rdoBawaPulang.Checked)
                {
                    rtbFaktur.Text += rdoBawaPulang.Text + "\n";
                }
                else if (rdoMakanditempat.Checked)
                {
                    rtbFaktur.Text += rdoMakanditempat.Text + "\n";
                }
                rtbFaktur.Text += new string('=', 50) + "\n";
                rtbFaktur.Text += new string(' ', 25) + "PESANAN" + "\n";
                rtbFaktur.Text += "\n";
                rtbFaktur.Text += "Menu".PadRight(15) + "\t" + "Isian".PadRight(15) + "Qty".PadRight(7) + "Harga Menu".PadRight(13) + "\n";
                rtbFaktur.Text += new string('=', 50) + "\n";

                total = 0;

                for (int i = 0; i <= pesanan.GetUpperBound(0); i++)
                {
                    rtbFaktur.Text += pesanan[i].namaMenu.PadRight(15) + "\t" + pesanan[i].isianMenu.PadRight(15) + pesanan[i].qty.ToString().PadRight(7) + pesanan[i].harga.ToString("Rp #,##0").PadRight(13) + "\n";

                    total += pesanan[i].subtotal; //n = total + n
                }

                rtbFaktur.Text += new string('=', 50) + "\n";
                rtbFaktur.Text += "Total\t\t\t\t" + total.ToString("Rp #,##0") + "\n";
                rtbFaktur.Text += new string('=', 50) + "\n";
            }
        }

        //mengelompokkan setiap radiobutton menggunakan event CheckedChanged dengan nama rdoJenisPelanggan_CheckedChanged
        private void rdoJenisPelanggan_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoMember.Checked == true)
            {
                lblDiskon.Text = "20";
            }
            else if (rdoNonMember.Checked == true)
            {
                lblDiskon.Text = "10";
            }
            hitungDiskon();
            hitungGrandTotal();
        }

        private void btnBayar_Click(object sender, EventArgs e)
        {
            rtbFaktur.Text += "Catatan :\n" + txtCatatan.Text + "\n";
            rtbFaktur.Text += new string('=', 50) + "\n";
            rtbFaktur.Text += new string(' ', 23) + "PEMBAYARAN" + "\n";
            rtbFaktur.Text += "\n";
            rtbFaktur.Text += "Jenis Pelanggan\t: ";
            if (rdoMember.Checked)
            {
                rtbFaktur.Text += rdoMember.Text + "\n";
            }
            else if (rdoNonMember.Checked)
            {
                rtbFaktur.Text += rdoNonMember.Text + "\n";
            }
            rtbFaktur.Text += "Diskon " + lblDiskon.Text + "%\t: " + totalDiskon.ToString("Rp #,##0") + "\n";
            rtbFaktur.Text += "Pajak\t\t: " + pajak.ToString("Rp #,##0") + "\n";
            rtbFaktur.Text += "Grand Total\t: " + grandTotal.ToString("Rp #,##0") + "\n";
            rtbFaktur.Text += "Bayar\t\t: " + bayar.ToString("Rp #,##0") + "\n";
            rtbFaktur.Text += "Kembalian\t\t: " + kembalian.ToString("Rp #,##0") + "\n";
            rtbFaktur.Text += new string('=', 50) + "\n";
            rtbFaktur.Text += "Terima Kasih telah belanja dengan kami";

            rtbFaktur.SaveFile("Bukti Transaksi.rtf");
            lklBuktiTransaksi.Show();
        }
    }
}
