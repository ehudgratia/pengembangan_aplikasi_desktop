
namespace Latihan
{
    partial class frmLatihan5
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNoKendaraan = new System.Windows.Forms.TextBox();
            this.btnMasuk = new System.Windows.Forms.Button();
            this.cboKendaraan = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnKeluar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblNoKendaraan = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblMasuk = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblKeluar = new System.Windows.Forms.Label();
            this.lblSisa = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnMasuk);
            this.groupBox1.Controls.Add(this.txtNoKendaraan);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(253, 95);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kendaraan Masuk";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "No Kendaraan";
            // 
            // txtNoKendaraan
            // 
            this.txtNoKendaraan.Location = new System.Drawing.Point(119, 35);
            this.txtNoKendaraan.Name = "txtNoKendaraan";
            this.txtNoKendaraan.Size = new System.Drawing.Size(128, 20);
            this.txtNoKendaraan.TabIndex = 1;
            this.txtNoKendaraan.TextChanged += new System.EventHandler(this.txtNoKendaraan_TextChanged);
            // 
            // btnMasuk
            // 
            this.btnMasuk.Location = new System.Drawing.Point(119, 62);
            this.btnMasuk.Name = "btnMasuk";
            this.btnMasuk.Size = new System.Drawing.Size(128, 23);
            this.btnMasuk.TabIndex = 2;
            this.btnMasuk.Text = "Masuk";
            this.btnMasuk.UseVisualStyleBackColor = true;
            this.btnMasuk.Click += new System.EventHandler(this.btnMasuk_Click);
            // 
            // cboKendaraan
            // 
            this.cboKendaraan.FormattingEnabled = true;
            this.cboKendaraan.Location = new System.Drawing.Point(13, 115);
            this.cboKendaraan.Name = "cboKendaraan";
            this.cboKendaraan.Size = new System.Drawing.Size(253, 21);
            this.cboKendaraan.TabIndex = 1;
            this.cboKendaraan.SelectedIndexChanged += new System.EventHandler(this.cboKendaraan_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnKeluar);
            this.groupBox2.Controls.Add(this.lblNoKendaraan);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(13, 151);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(253, 100);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kendaraan Keluar";
            // 
            // btnKeluar
            // 
            this.btnKeluar.Location = new System.Drawing.Point(119, 62);
            this.btnKeluar.Name = "btnKeluar";
            this.btnKeluar.Size = new System.Drawing.Size(128, 23);
            this.btnKeluar.TabIndex = 2;
            this.btnKeluar.Text = "Keluar";
            this.btnKeluar.UseVisualStyleBackColor = true;
            this.btnKeluar.Click += new System.EventHandler(this.btnKeluar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "No Kendaraan";
            // 
            // lblNoKendaraan
            // 
            this.lblNoKendaraan.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNoKendaraan.Location = new System.Drawing.Point(119, 38);
            this.lblNoKendaraan.Name = "lblNoKendaraan";
            this.lblNoKendaraan.Size = new System.Drawing.Size(128, 21);
            this.lblNoKendaraan.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblSisa);
            this.groupBox3.Controls.Add(this.lblKeluar);
            this.groupBox3.Controls.Add(this.lblMasuk);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Location = new System.Drawing.Point(12, 257);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(253, 139);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Statistik";
            // 
            // lblMasuk
            // 
            this.lblMasuk.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMasuk.Location = new System.Drawing.Point(173, 38);
            this.lblMasuk.Name = "lblMasuk";
            this.lblMasuk.Size = new System.Drawing.Size(74, 21);
            this.lblMasuk.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Jumlah Kendaraan Masuk";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Jumlah Kendaraan Keluar";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 100);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Sisa Kendarran";
            // 
            // lblKeluar
            // 
            this.lblKeluar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblKeluar.Location = new System.Drawing.Point(173, 66);
            this.lblKeluar.Name = "lblKeluar";
            this.lblKeluar.Size = new System.Drawing.Size(74, 21);
            this.lblKeluar.TabIndex = 0;
            // 
            // lblSisa
            // 
            this.lblSisa.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSisa.Location = new System.Drawing.Point(173, 99);
            this.lblSisa.Name = "lblSisa";
            this.lblSisa.Size = new System.Drawing.Size(74, 21);
            this.lblSisa.TabIndex = 0;
            // 
            // frmLatihan5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(277, 409);
            this.Controls.Add(this.cboKendaraan);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmLatihan5";
            this.Text = "Kendaran Masuk/Keluar";
            this.Load += new System.EventHandler(this.frmLatihan5_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnMasuk;
        private System.Windows.Forms.TextBox txtNoKendaraan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboKendaraan;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnKeluar;
        private System.Windows.Forms.Label lblNoKendaraan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblSisa;
        private System.Windows.Forms.Label lblKeluar;
        private System.Windows.Forms.Label lblMasuk;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
    }
}