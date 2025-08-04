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
    public partial class frm1 : Form
    {
        public frm1()
        {
            InitializeComponent();
        }

        private void btnNaik_Click(object sender, EventArgs e)
        {
            nudAngka.UpButton();
        }

        private void btnTurun_Click(object sender, EventArgs e)
        {
            nudAngka.DownButton();
        }

        private void nudAngka_Leave(object sender, EventArgs e)
        {
            nudAngka.ForeColor = Color.Yellow;
        }

        private void nudAngka_Enter(object sender, EventArgs e)
        {
            nudAngka.ForeColor = Color.White;
        }

        private void frm1_Load(object sender, EventArgs e)
        {
            nudAngka.ForeColor = Color.White;
            if (nudAngka.Value == 0)
            {
                this.BackColor = Color.White;
            }
            else if (nudAngka.Value == 1)
            {
                this.BackColor = Color.Black;
            }
            else
            {
                this.BackColor = Color.Brown;
            }

            dudPAB.SelectedIndex = 0;

            lblNilai.Text = hsbNilai.Value.ToString();

            hsbNilai.Minimum = 0;
            vsbNilai.Maximum = 0;
            hsbNilai.Maximum = 109;
            vsbNilai.Maximum = 109;
        }

        private void nudAngka_ValueChanged(object sender, EventArgs e)
        {
            if (nudAngka.Value == 0)
            {
                this.BackColor = Color.White;
            }
            else if (nudAngka.Value == 1)
            {
                this.BackColor = Color.Black;
            }
            else
            {
                this.BackColor = Color.Brown;
            }
        }

        private void dudPAB_SelectedItemChanged(object sender, EventArgs e)
        {
            if (dudPAB.SelectedItem.ToString() == "Merah")
            {
                this.BackColor = Color.Red;
            }
            else if (dudPAB.SelectedItem.ToString() == "Kuning")
            {
                this.BackColor = Color.Yellow;
            }
            else if(dudPAB.SelectedItem.ToString() == "Hijau")
            {
                this.BackColor = Color.White;
            }
        }

        private void hsbNilai_Scroll(object sender, ScrollEventArgs e)
        {
            lblNilai.Text = hsbNilai.Value.ToString();

        }
    }
}
