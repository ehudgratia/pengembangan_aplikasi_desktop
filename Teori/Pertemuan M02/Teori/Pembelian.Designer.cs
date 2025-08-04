
namespace Teori
{
    partial class Latihan_6
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtHarga = new System.Windows.Forms.TextBox();
            this.lblKeterangan = new System.Windows.Forms.Label();
            this.txtJumlah = new System.Windows.Forms.TextBox();
            this.txtPotongan = new System.Windows.Forms.TextBox();
            this.lblPotongan = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Harga Beli / Unit (Rp)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 62);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Jumlah Unit";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 100);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Potongan (%)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 142);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Keterangan";
            // 
            // txtHarga
            // 
            this.txtHarga.Location = new System.Drawing.Point(182, 21);
            this.txtHarga.Name = "txtHarga";
            this.txtHarga.Size = new System.Drawing.Size(182, 23);
            this.txtHarga.TabIndex = 1;
            this.txtHarga.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblKeterangan
            // 
            this.lblKeterangan.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblKeterangan.Location = new System.Drawing.Point(16, 173);
            this.lblKeterangan.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblKeterangan.Name = "lblKeterangan";
            this.lblKeterangan.Size = new System.Drawing.Size(445, 35);
            this.lblKeterangan.TabIndex = 0;
            this.lblKeterangan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtJumlah
            // 
            this.txtJumlah.Location = new System.Drawing.Point(182, 62);
            this.txtJumlah.Name = "txtJumlah";
            this.txtJumlah.Size = new System.Drawing.Size(182, 23);
            this.txtJumlah.TabIndex = 1;
            this.txtJumlah.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtPotongan
            // 
            this.txtPotongan.Location = new System.Drawing.Point(182, 104);
            this.txtPotongan.Name = "txtPotongan";
            this.txtPotongan.Size = new System.Drawing.Size(100, 23);
            this.txtPotongan.TabIndex = 1;
            this.txtPotongan.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblPotongan
            // 
            this.lblPotongan.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPotongan.Location = new System.Drawing.Point(302, 104);
            this.lblPotongan.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPotongan.Name = "lblPotongan";
            this.lblPotongan.Size = new System.Drawing.Size(159, 24);
            this.lblPotongan.TabIndex = 0;
            this.lblPotongan.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(386, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 64);
            this.button1.TabIndex = 2;
            this.button1.Text = "&Hitung";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Latihan_6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 234);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtPotongan);
            this.Controls.Add(this.txtJumlah);
            this.Controls.Add(this.txtHarga);
            this.Controls.Add(this.lblPotongan);
            this.Controls.Add(this.lblKeterangan);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Latihan_6";
            this.Text = "Pembelian";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtHarga;
        private System.Windows.Forms.Label lblKeterangan;
        private System.Windows.Forms.TextBox txtJumlah;
        private System.Windows.Forms.TextBox txtPotongan;
        private System.Windows.Forms.Label lblPotongan;
        private System.Windows.Forms.Button button1;
    }
}