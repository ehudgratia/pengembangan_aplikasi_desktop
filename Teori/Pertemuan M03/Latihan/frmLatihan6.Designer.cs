
namespace Latihan
{
    partial class frmLatihan6
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
            this.rdoEkonomi = new System.Windows.Forms.RadioButton();
            this.rdoBisnis = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtNoKtp = new System.Windows.Forms.TextBox();
            this.txtNama = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnPesan = new System.Windows.Forms.Button();
            this.btnKosong = new System.Windows.Forms.Button();
            this.btnKeluar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cboMaskapai = new System.Windows.Forms.ComboBox();
            this.lblHargaMenu = new System.Windows.Forms.Label();
            this.lstMenu = new System.Windows.Forms.ListBox();
            this.lblHargaTiket = new System.Windows.Forms.Label();
            this.lblTampil = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Consolas", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(441, 47);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tiket Medan - Jakarta";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdoEkonomi);
            this.groupBox1.Controls.Add(this.rdoBisnis);
            this.groupBox1.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(21, 89);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(190, 60);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kelas";
            // 
            // rdoEkonomi
            // 
            this.rdoEkonomi.AutoSize = true;
            this.rdoEkonomi.Location = new System.Drawing.Point(92, 28);
            this.rdoEkonomi.Name = "rdoEkonomi";
            this.rdoEkonomi.Size = new System.Drawing.Size(67, 17);
            this.rdoEkonomi.TabIndex = 0;
            this.rdoEkonomi.TabStop = true;
            this.rdoEkonomi.Text = "Ekonomi";
            this.rdoEkonomi.UseVisualStyleBackColor = true;
            this.rdoEkonomi.CheckedChanged += new System.EventHandler(this.rdoEkonomi_CheckedChanged_1);
            // 
            // rdoBisnis
            // 
            this.rdoBisnis.AutoSize = true;
            this.rdoBisnis.Location = new System.Drawing.Point(19, 28);
            this.rdoBisnis.Name = "rdoBisnis";
            this.rdoBisnis.Size = new System.Drawing.Size(61, 17);
            this.rdoBisnis.TabIndex = 0;
            this.rdoBisnis.TabStop = true;
            this.rdoBisnis.Text = "Bisnis";
            this.rdoBisnis.UseVisualStyleBackColor = true;
            this.rdoBisnis.CheckedChanged += new System.EventHandler(this.rdoBisnis_CheckedChanged_1);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtNoKtp);
            this.groupBox2.Controls.Add(this.txtNama);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(21, 155);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(190, 112);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Penumpang";
            // 
            // txtNoKtp
            // 
            this.txtNoKtp.Location = new System.Drawing.Point(83, 74);
            this.txtNoKtp.Name = "txtNoKtp";
            this.txtNoKtp.Size = new System.Drawing.Size(100, 20);
            this.txtNoKtp.TabIndex = 1;
            // 
            // txtNama
            // 
            this.txtNama.Location = new System.Drawing.Point(83, 41);
            this.txtNama.Name = "txtNama";
            this.txtNama.Size = new System.Drawing.Size(100, 20);
            this.txtNama.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "No KTP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nama";
            // 
            // btnPesan
            // 
            this.btnPesan.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesan.Location = new System.Drawing.Point(21, 287);
            this.btnPesan.Name = "btnPesan";
            this.btnPesan.Size = new System.Drawing.Size(150, 23);
            this.btnPesan.TabIndex = 2;
            this.btnPesan.Text = "&Pesan";
            this.btnPesan.UseVisualStyleBackColor = true;
            // 
            // btnKosong
            // 
            this.btnKosong.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKosong.Location = new System.Drawing.Point(21, 359);
            this.btnKosong.Name = "btnKosong";
            this.btnKosong.Size = new System.Drawing.Size(150, 23);
            this.btnKosong.TabIndex = 2;
            this.btnKosong.Text = "&Kosong";
            this.btnKosong.UseVisualStyleBackColor = true;
            // 
            // btnKeluar
            // 
            this.btnKeluar.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKeluar.Location = new System.Drawing.Point(21, 388);
            this.btnKeluar.Name = "btnKeluar";
            this.btnKeluar.Size = new System.Drawing.Size(150, 23);
            this.btnKeluar.TabIndex = 2;
            this.btnKeluar.Text = "K&eluar";
            this.btnKeluar.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(248, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Maskapai";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(248, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Harga Tiket";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(248, 155);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Menu";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(248, 249);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Harga Menu";
            // 
            // cboMaskapai
            // 
            this.cboMaskapai.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMaskapai.FormattingEnabled = true;
            this.cboMaskapai.Location = new System.Drawing.Point(333, 91);
            this.cboMaskapai.Name = "cboMaskapai";
            this.cboMaskapai.Size = new System.Drawing.Size(121, 21);
            this.cboMaskapai.TabIndex = 3;
            this.cboMaskapai.SelectedIndexChanged += new System.EventHandler(this.cboMaskapai_SelectedIndexChanged);
            // 
            // lblHargaMenu
            // 
            this.lblHargaMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblHargaMenu.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHargaMenu.Location = new System.Drawing.Point(333, 244);
            this.lblHargaMenu.Name = "lblHargaMenu";
            this.lblHargaMenu.Size = new System.Drawing.Size(121, 23);
            this.lblHargaMenu.TabIndex = 0;
            this.lblHargaMenu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lstMenu
            // 
            this.lstMenu.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstMenu.FormattingEnabled = true;
            this.lstMenu.Location = new System.Drawing.Point(333, 147);
            this.lstMenu.Name = "lstMenu";
            this.lstMenu.Size = new System.Drawing.Size(121, 82);
            this.lstMenu.TabIndex = 4;
            // 
            // lblHargaTiket
            // 
            this.lblHargaTiket.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblHargaTiket.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHargaTiket.Location = new System.Drawing.Point(333, 117);
            this.lblHargaTiket.Name = "lblHargaTiket";
            this.lblHargaTiket.Size = new System.Drawing.Size(121, 23);
            this.lblHargaTiket.TabIndex = 0;
            this.lblHargaTiket.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTampil
            // 
            this.lblTampil.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTampil.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTampil.Location = new System.Drawing.Point(180, 287);
            this.lblTampil.Name = "lblTampil";
            this.lblTampil.Size = new System.Drawing.Size(274, 124);
            this.lblTampil.TabIndex = 0;
            this.lblTampil.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmLatihan6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 425);
            this.Controls.Add(this.lstMenu);
            this.Controls.Add(this.cboMaskapai);
            this.Controls.Add(this.btnKeluar);
            this.Controls.Add(this.btnKosong);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblHargaTiket);
            this.Controls.Add(this.lblTampil);
            this.Controls.Add(this.lblHargaMenu);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnPesan);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "frmLatihan6";
            this.Text = "Penerbangan";
            this.Load += new System.EventHandler(this.frmLatihan6_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdoEkonomi;
        private System.Windows.Forms.RadioButton rdoBisnis;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtNoKtp;
        private System.Windows.Forms.TextBox txtNama;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnPesan;
        private System.Windows.Forms.Button btnKosong;
        private System.Windows.Forms.Button btnKeluar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cboMaskapai;
        private System.Windows.Forms.Label lblHargaMenu;
        private System.Windows.Forms.ListBox lstMenu;
        private System.Windows.Forms.Label lblHargaTiket;
        private System.Windows.Forms.Label lblTampil;
    }
}