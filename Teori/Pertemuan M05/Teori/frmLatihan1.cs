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
        private void frmLatihan1_Load(object sender, EventArgs e)
        {
            picNormal.BorderStyle = BorderStyle.FixedSingle;
            picCenterImage.BorderStyle = BorderStyle.FixedSingle;
            picAutoSize.BorderStyle = BorderStyle.FixedSingle;
            picStretchImage.BorderStyle = BorderStyle.FixedSingle;
            picZoom.BorderStyle = BorderStyle.FixedSingle;

            picNormal.BackColor = Color.Red;
            picCenterImage.BackColor = Color.Yellow;
            picAutoSize.BackColor = Color.Green;
            picStretchImage.BackColor = Color.Blue;
            picZoom.BackColor = Color.Orange;

            picNormal.SizeMode = PictureBoxSizeMode.Normal;
            picCenterImage.SizeMode = PictureBoxSizeMode.CenterImage;
            picAutoSize.SizeMode = PictureBoxSizeMode.AutoSize;
            picStretchImage.SizeMode = PictureBoxSizeMode.StretchImage;
            picZoom.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void btnPilihGambar_Click(object sender, EventArgs e)
        {
            dlgOpen.Title = "Open";
            dlgOpen.FileName = "";
            dlgOpen.Filter = "Image Files(*.gif;*.jpg;*.jpeng;*.bmp;*.wmf;*.jpg)|*.gif;*.jpg;*.jpeng;*.bmp;*.wmf;*.jpg | All file(*.*|*.*";
            dlgOpen.InitialDirectory = @"D:\";
            dlgOpen.FilterIndex = 1;
            if (dlgOpen.ShowDialog() == DialogResult.OK)
            {
                picNormal.Image = Image.FromFile(dlgOpen.FileName);
                picCenterImage.Image = Image.FromFile(dlgOpen.FileName);
                picAutoSize.Image = Image.FromFile(dlgOpen.FileName);
                picStretchImage.Image = Image.FromFile(dlgOpen.FileName);
                picZoom.Image = Image.FromFile(dlgOpen.FileName);

                lblSize.Text = picAutoSize.Width.ToString() + " x " + picAutoSize.Height.ToString();
            }
        }
    }
}
