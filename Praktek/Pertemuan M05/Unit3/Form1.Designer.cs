
namespace Unit3
{
    partial class frmLatihan2
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nudQty = new System.Windows.Forms.NumericUpDown();
            this.dudPilihProduk = new System.Windows.Forms.DomainUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblHarga = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtBayar = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblKembalian = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.picKeluar = new System.Windows.Forms.PictureBox();
            this.picBersih = new System.Windows.Forms.PictureBox();
            this.picBeli = new System.Windows.Forms.PictureBox();
            this.lblTampil = new System.Windows.Forms.Label();
            this.picProduk = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQty)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picKeluar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBersih)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBeli)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picProduk)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.Location = new System.Drawing.Point(97, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Frozen Food\'s";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nudQty);
            this.groupBox1.Controls.Add(this.dudPilihProduk);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.lblTotal);
            this.groupBox1.Controls.Add(this.lblHarga);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(13, 58);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(290, 160);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pemesanan";
            // 
            // nudQty
            // 
            this.nudQty.Location = new System.Drawing.Point(131, 58);
            this.nudQty.Name = "nudQty";
            this.nudQty.Size = new System.Drawing.Size(81, 20);
            this.nudQty.TabIndex = 2;
            this.nudQty.ValueChanged += new System.EventHandler(this.nudQty_ValueChanged);
            // 
            // dudPilihProduk
            // 
            this.dudPilihProduk.Location = new System.Drawing.Point(131, 27);
            this.dudPilihProduk.Name = "dudPilihProduk";
            this.dudPilihProduk.Size = new System.Drawing.Size(148, 20);
            this.dudPilihProduk.TabIndex = 1;
            this.dudPilihProduk.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.dudPilihProduk.SelectedItemChanged += new System.EventHandler(this.dudPilihProduk_SelectedItemChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Total";
            // 
            // lblTotal
            // 
            this.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTotal.Location = new System.Drawing.Point(131, 127);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(148, 23);
            this.lblTotal.TabIndex = 0;
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblHarga
            // 
            this.lblHarga.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblHarga.Location = new System.Drawing.Point(131, 92);
            this.lblHarga.Name = "lblHarga";
            this.lblHarga.Size = new System.Drawing.Size(148, 23);
            this.lblHarga.TabIndex = 0;
            this.lblHarga.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Harga";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(224, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(19, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "kg";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Qty";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Pilih Produk";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtBayar);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.lblKembalian);
            this.groupBox2.Location = new System.Drawing.Point(13, 225);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(290, 102);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pembayaran";
            // 
            // txtBayar
            // 
            this.txtBayar.Location = new System.Drawing.Point(131, 33);
            this.txtBayar.Name = "txtBayar";
            this.txtBayar.Size = new System.Drawing.Size(148, 20);
            this.txtBayar.TabIndex = 1;
            this.txtBayar.TextChanged += new System.EventHandler(this.txtBayar_TextChanged);
            this.txtBayar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBayar_KeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(106, 38);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(21, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "Rp";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(106, 73);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(21, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Rp";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 39);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Bayar";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 74);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Kembalian";
            // 
            // lblKembalian
            // 
            this.lblKembalian.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblKembalian.Location = new System.Drawing.Point(131, 66);
            this.lblKembalian.Name = "lblKembalian";
            this.lblKembalian.Size = new System.Drawing.Size(148, 23);
            this.lblKembalian.TabIndex = 0;
            this.lblKembalian.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.picKeluar);
            this.panel1.Controls.Add(this.picBersih);
            this.panel1.Controls.Add(this.picBeli);
            this.panel1.Location = new System.Drawing.Point(13, 334);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(290, 104);
            this.panel1.TabIndex = 3;
            // 
            // picKeluar
            // 
            this.picKeluar.Image = global::Unit3.Properties.Resources.keluar;
            this.picKeluar.Location = new System.Drawing.Point(201, 24);
            this.picKeluar.Name = "picKeluar";
            this.picKeluar.Size = new System.Drawing.Size(78, 59);
            this.picKeluar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picKeluar.TabIndex = 0;
            this.picKeluar.TabStop = false;
            this.picKeluar.Click += new System.EventHandler(this.picKeluar_Click);
            // 
            // picBersih
            // 
            this.picBersih.Image = global::Unit3.Properties.Resources.kosong;
            this.picBersih.Location = new System.Drawing.Point(107, 24);
            this.picBersih.Name = "picBersih";
            this.picBersih.Size = new System.Drawing.Size(78, 59);
            this.picBersih.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBersih.TabIndex = 0;
            this.picBersih.TabStop = false;
            this.picBersih.Click += new System.EventHandler(this.picBersih_Click);
            // 
            // picBeli
            // 
            this.picBeli.Image = global::Unit3.Properties.Resources.beli;
            this.picBeli.Location = new System.Drawing.Point(13, 24);
            this.picBeli.Name = "picBeli";
            this.picBeli.Size = new System.Drawing.Size(78, 59);
            this.picBeli.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBeli.TabIndex = 0;
            this.picBeli.TabStop = false;
            this.picBeli.Click += new System.EventHandler(this.picBeli_Click);
            // 
            // lblTampil
            // 
            this.lblTampil.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTampil.Location = new System.Drawing.Point(319, 258);
            this.lblTampil.Name = "lblTampil";
            this.lblTampil.Size = new System.Drawing.Size(189, 180);
            this.lblTampil.TabIndex = 5;
            this.lblTampil.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // picProduk
            // 
            this.picProduk.Location = new System.Drawing.Point(319, 58);
            this.picProduk.Name = "picProduk";
            this.picProduk.Size = new System.Drawing.Size(189, 184);
            this.picProduk.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picProduk.TabIndex = 4;
            this.picProduk.TabStop = false;
            // 
            // frmLatihan2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 450);
            this.Controls.Add(this.lblTampil);
            this.Controls.Add(this.picProduk);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "frmLatihan2";
            this.Text = "Frozen Food\'s";
            this.Load += new System.EventHandler(this.frmLatihan2_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQty)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picKeluar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBersih)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBeli)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picProduk)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown nudQty;
        private System.Windows.Forms.DomainUpDown dudPilihProduk;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblHarga;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtBayar;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblKembalian;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox picKeluar;
        private System.Windows.Forms.PictureBox picBersih;
        private System.Windows.Forms.PictureBox picBeli;
        private System.Windows.Forms.PictureBox picProduk;
        private System.Windows.Forms.Label lblTampil;
    }
}

