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
    public partial class frmLatihan1 : Form
    {
        public frmLatihan1()
        {
            InitializeComponent();
        }

        private void lklLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (rdoMika.Checked == true)
            {
                System.Diagnostics.Process.Start("Chrome", "https://mika.mikroskil.ac.id/");
            }
            else if (rdoELearning.Checked == true)
            {
                System.Diagnostics.Process.Start("Chrome", "https://www.microsoft.com/id-id/microsoft-teams/log-in");
            }
            else if (rdoWebmail.Checked == true)
            {
                System.Diagnostics.Process.Start("Chrome", "https://outlook.office.com/mail/inbox");
            }
            else if (rdoPerpustakaan.Checked == true)
            {
                System.Diagnostics.Process.Start("Chrome", "https://www.mikroskil.ac.id/perpustakaan/beranda");
            }
        }
    }
}
