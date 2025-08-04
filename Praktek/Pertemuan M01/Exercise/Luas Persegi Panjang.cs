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
    public partial class Luas_Persegi_Panjang : Form
    {
        public Luas_Persegi_Panjang()
        {
            InitializeComponent();
        }

        private void btnKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnKosong_Click(object sender, EventArgs e)
        {
            txtPanjang.Clear();
            txtLebar.Clear();
            lblLuas.Text = "";
            txtPanjang.Focus();
        }

        int p, l, luas;




        //Load adalah event dari form pada saat form dijalankan
        private void Luas_Persegi_Panjang_Load(object sender, EventArgs e)
        {
            txtPanjang.ForeColor = Color.Red;
            txtLebar.ForeColor = Color.Blue;
        }

        private void btnHitung_Click(object sender, EventArgs e)
        {
            p = int.Parse(txtPanjang.Text);
            l = int.Parse(txtLebar.Text);

            luas = p * l;
            lblLuas.Text = luas.ToString();
        }

        private void txtPanjang_KeyPress(object sender, KeyPressEventArgs e)
        {
            //jika karakter yang ditekan bukan termasuk kategori kontrol (backspace, space, tab) dan jika karakter yang ditekan bukan termasuk kategori digit (angka)
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                //maka tidak menerima input
                e.Handled = true;
            }
            //jika karakter yang ditekan termasuk kategori kontrol (backspace, space, tab) dan jika karakter yang ditekan termasuk kategori digit (angka)
            else
            {
                //mana menerima input (kontrol (backspace, space, tab) dan digit (angka))
                e.Handled = false;
            }
        }
    }
}
