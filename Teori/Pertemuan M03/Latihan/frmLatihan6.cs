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
    public partial class frmLatihan6 : Form
    {
        public frmLatihan6()
        {
            InitializeComponent();
        }

        private void frmLatihan6_Load(object sender, EventArgs e)
        {
            cboMaskapai.Items.Add("Batik Air");
            cboMaskapai.Items.Add("Garuda Indonesia");

            rdoBisnis.Checked = true;
            rdoEkonomi.Checked = false;
        }

        int tiket = 0, menu = 0, total = 0;

        private void rdoBisnis_CheckedChanged_1(object sender, EventArgs e)
        {
            cboMaskapai.SelectedIndex = -1;
            lstMenu.Items.Clear();
            tiket -= tiket;
            menu -= menu;
            lblHargaTiket.Text = tiket.ToString("Rp#,##0");
            lblHargaMenu.Text = menu.ToString("Rp#,##0");
        }

        private void rdoEkonomi_CheckedChanged_1(object sender, EventArgs e)
        {
            cboMaskapai.SelectedIndex = -1;
            lstMenu.Items.Clear();
            tiket -= tiket;
            menu -= menu;
            lblHargaTiket.Text = tiket.ToString("Rp#,##0");
            lblHargaMenu.Text = menu.ToString("Rp#,##0");
        }

        private void cboMaskapai_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (rdoBisnis.Checked) //Memilih kelas bisnis
            {
                if (cboMaskapai.SelectedIndex == 0)
                {
                    menu -= menu;
                    tiket = 1500000;
                    lstMenu.Items.Clear();
                    lstMenu.Items.Add("Opor Ayam");
                    lstMenu.Items.Add("Ikan Asam Manis");
                }
                else if (cboMaskapai.SelectedIndex == 1)
                {
                    menu -= menu;
                    tiket = 2000000;
                    lstMenu.Items.Clear();
                    lstMenu.Items.Add("Steak Udang");
                    lstMenu.Items.Add("Sphagetti");
                }
            }
            else //memilih kelas ekonomi
            {
                if (cboMaskapai.SelectedIndex == 0)
                {
                    menu -= menu;
                    tiket = 1375000;
                    lstMenu.Items.Clear();
                    lstMenu.Items.Add("Bihun Goreng");
                    lstMenu.Items.Add("Kwetiau Goreng");
                }
                else if (cboMaskapai.SelectedIndex == 1)
                {
                    menu -= menu;
                    tiket = 1750000;
                    lstMenu.Items.Clear();
                    lstMenu.Items.Add("Nasi Goreng");
                    lstMenu.Items.Add("Mie Goreng");
                }
            }
            lblHargaTiket.Text = tiket.ToString("Rp#,##0");
            lblHargaMenu.Text = menu.ToString("Rp#,##0");
        }
    }
}
