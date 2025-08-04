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
    public partial class Pizza_House : Form
    {
        public Pizza_House()
        {
            InitializeComponent();
        }

        private void btnPesan_Click(object sender, EventArgs e)
        {
            CheckBox[] toping = new CheckBox[6];
            lblKeterangan.Text = "Pizza Order (";
            
            if (rboEatIn.Checked)
            {
                lblKeterangan.Text += rboEatIn.Text + ")\n";
            }
            else if (rboTakeOut.Checked)
            {
                lblKeterangan.Text += rboTakeOut.Text + ")\n";
            }

            lblKeterangan.Text += new string('-', 50) + "\n";
            lblKeterangan.Text += "Ukuran : ";
            if (rboSmall.Checked)
            {
                lblKeterangan.Text += rboSmall.Text + " Pizza\n";
            }
            else if (rboMedium.Checked)
            {
                lblKeterangan.Text += rboMedium.Text + " Pizza\n";
            }
            else
            {
                lblKeterangan.Text += rboLarge.Text + " Pizza\n";
            }

            lblKeterangan.Text += "Pinggiran : ";
            if (rboKeju.Checked)
            {
                lblKeterangan.Text += rboKeju.Text + "\n";
            }
            else if (rboSosis.Checked)
            {
                lblKeterangan.Text += rboSosis.Text + "\n";
            }
            else
            {
                lblKeterangan.Text += rboNugget.Text + "\n";
            }

            lblKeterangan.Text += new string('-', 50) + "\n";
            lblKeterangan.Text += "TOPPING\n";
            lblKeterangan.Text += new string('-', 50) + "\n";

            toping[0] = chkExtraCheese;
            toping[1] = chkMushrooms;
            toping[2] = chkBlackOlives;
            toping[3] = chkUnions;
            toping[4] = chkGreenPappers;
            toping[5] = chkTomatoes;

            for (int i = 0; i < 6; i++)
            {
                if (toping[i].Checked)
                {
                    lblKeterangan.Text += toping[i].Text + "\n";
                }
            }
            lblKeterangan.Text += new string('=', 25) + "\n";
        }

        private void btnKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
