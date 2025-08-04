
namespace Exercise
{
    partial class Luas_dan_Volume_Balok
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
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPanjang = new System.Windows.Forms.TextBox();
            this.txtLebar = new System.Windows.Forms.TextBox();
            this.txtTinggi = new System.Windows.Forms.TextBox();
            this.lblLuas = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lblVolume = new System.Windows.Forms.Label();
            this.btnHitung = new System.Windows.Forms.Button();
            this.btnKosong = new System.Windows.Forms.Button();
            this.btnKeluar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Menghitung Luas dan Volume Balok";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Panjang";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Lebar";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Tinggi";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Luas";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 201);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Volume";
            // 
            // txtPanjang
            // 
            this.txtPanjang.Location = new System.Drawing.Point(143, 64);
            this.txtPanjang.Name = "txtPanjang";
            this.txtPanjang.Size = new System.Drawing.Size(100, 20);
            this.txtPanjang.TabIndex = 1;
            this.txtPanjang.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPanjang.Enter += new System.EventHandler(this.Luas_dan_Volume_Balok_Load);
            this.txtPanjang.Leave += new System.EventHandler(this.Luas_dan_Volume_Balok_Load);
            // 
            // txtLebar
            // 
            this.txtLebar.Location = new System.Drawing.Point(143, 100);
            this.txtLebar.Name = "txtLebar";
            this.txtLebar.Size = new System.Drawing.Size(100, 20);
            this.txtLebar.TabIndex = 1;
            this.txtLebar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtTinggi
            // 
            this.txtTinggi.Location = new System.Drawing.Point(143, 130);
            this.txtTinggi.Name = "txtTinggi";
            this.txtTinggi.Size = new System.Drawing.Size(100, 20);
            this.txtTinggi.TabIndex = 1;
            this.txtTinggi.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblLuas
            // 
            this.lblLuas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblLuas.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblLuas.Location = new System.Drawing.Point(143, 165);
            this.lblLuas.Name = "lblLuas";
            this.lblLuas.Size = new System.Drawing.Size(100, 19);
            this.lblLuas.TabIndex = 0;
            this.lblLuas.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(249, 67);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(21, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "cm";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(249, 103);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(21, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "cm";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(249, 133);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(21, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "cm";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label12.Location = new System.Drawing.Point(249, 168);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(27, 13);
            this.label12.TabIndex = 0;
            this.label12.Text = "cm2";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label13.Location = new System.Drawing.Point(249, 201);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(27, 13);
            this.label13.TabIndex = 0;
            this.label13.Text = "cm3";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblVolume
            // 
            this.lblVolume.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblVolume.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblVolume.Location = new System.Drawing.Point(143, 198);
            this.lblVolume.Name = "lblVolume";
            this.lblVolume.Size = new System.Drawing.Size(100, 19);
            this.lblVolume.TabIndex = 0;
            this.lblVolume.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnHitung
            // 
            this.btnHitung.Location = new System.Drawing.Point(26, 247);
            this.btnHitung.Name = "btnHitung";
            this.btnHitung.Size = new System.Drawing.Size(75, 23);
            this.btnHitung.TabIndex = 2;
            this.btnHitung.Text = "Hitung";
            this.btnHitung.UseVisualStyleBackColor = true;
            this.btnHitung.Click += new System.EventHandler(this.btnHitung_Click);
            // 
            // btnKosong
            // 
            this.btnKosong.Location = new System.Drawing.Point(107, 247);
            this.btnKosong.Name = "btnKosong";
            this.btnKosong.Size = new System.Drawing.Size(88, 23);
            this.btnKosong.TabIndex = 2;
            this.btnKosong.Text = "Kosong";
            this.btnKosong.UseVisualStyleBackColor = true;
            this.btnKosong.Click += new System.EventHandler(this.btnKosong_Click);
            // 
            // btnKeluar
            // 
            this.btnKeluar.Location = new System.Drawing.Point(201, 247);
            this.btnKeluar.Name = "btnKeluar";
            this.btnKeluar.Size = new System.Drawing.Size(75, 23);
            this.btnKeluar.TabIndex = 2;
            this.btnKeluar.Text = "Keluar";
            this.btnKeluar.UseVisualStyleBackColor = true;
            this.btnKeluar.Click += new System.EventHandler(this.button3_Click);
            // 
            // Luas_dan_Volume_Balok
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 301);
            this.Controls.Add(this.btnKeluar);
            this.Controls.Add(this.btnKosong);
            this.Controls.Add(this.btnHitung);
            this.Controls.Add(this.txtTinggi);
            this.Controls.Add(this.txtLebar);
            this.Controls.Add(this.txtPanjang);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblVolume);
            this.Controls.Add(this.lblLuas);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Luas_dan_Volume_Balok";
            this.Text = "Luas_dan_Volume_Balok";
            this.Load += new System.EventHandler(this.Luas_dan_Volume_Balok_Load);
            this.Enter += new System.EventHandler(this.Luas_dan_Volume_Balok_Load);
            this.Leave += new System.EventHandler(this.Luas_dan_Volume_Balok_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPanjang;
        private System.Windows.Forms.TextBox txtLebar;
        private System.Windows.Forms.TextBox txtTinggi;
        private System.Windows.Forms.Label lblLuas;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblVolume;
        private System.Windows.Forms.Button btnHitung;
        private System.Windows.Forms.Button btnKosong;
        private System.Windows.Forms.Button btnKeluar;
    }
}