
namespace Project_UAS.Laporan
{
    partial class frmLaporanPenjualan
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnTampil = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnTampil
            // 
            this.btnTampil.Location = new System.Drawing.Point(13, 13);
            this.btnTampil.Name = "btnTampil";
            this.btnTampil.Size = new System.Drawing.Size(210, 58);
            this.btnTampil.TabIndex = 0;
            this.btnTampil.Text = "Tampilkan Laporan Penjualan";
            this.btnTampil.UseVisualStyleBackColor = true;
            this.btnTampil.Click += new System.EventHandler(this.btnTampil_Click);
            // 
            // frmLaporanPenjualan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 263);
            this.Controls.Add(this.btnTampil);
            this.Name = "frmLaporanPenjualan";
            this.Text = "Laporan Penjualan";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTampil;
    }
}