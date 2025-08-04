
namespace Teori
{
    partial class frmLatihan1a
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
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnValidasi = new System.Windows.Forms.Button();
            this.btnMasuk = new System.Windows.Forms.Button();
            this.btnKeluar = new System.Windows.Forms.Button();
            this.lblKeterangan = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 10F);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Masukan password Anda:";
            // 
            // txtPassword
            // 
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPassword.Location = new System.Drawing.Point(15, 29);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(300, 23);
            this.txtPassword.TabIndex = 1;
            // 
            // btnValidasi
            // 
            this.btnValidasi.Location = new System.Drawing.Point(15, 58);
            this.btnValidasi.Name = "btnValidasi";
            this.btnValidasi.Size = new System.Drawing.Size(86, 29);
            this.btnValidasi.TabIndex = 2;
            this.btnValidasi.Text = "&Validasi";
            this.btnValidasi.UseVisualStyleBackColor = true;
            this.btnValidasi.Click += new System.EventHandler(this.btnValidasi_Click);
            // 
            // btnMasuk
            // 
            this.btnMasuk.Location = new System.Drawing.Point(117, 58);
            this.btnMasuk.Name = "btnMasuk";
            this.btnMasuk.Size = new System.Drawing.Size(93, 29);
            this.btnMasuk.TabIndex = 2;
            this.btnMasuk.Text = "&Masuk";
            this.btnMasuk.UseVisualStyleBackColor = true;
            this.btnMasuk.Click += new System.EventHandler(this.btnMasuk_Click);
            // 
            // btnKeluar
            // 
            this.btnKeluar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnKeluar.Location = new System.Drawing.Point(226, 58);
            this.btnKeluar.Name = "btnKeluar";
            this.btnKeluar.Size = new System.Drawing.Size(89, 29);
            this.btnKeluar.TabIndex = 2;
            this.btnKeluar.Text = "&Keluar";
            this.btnKeluar.UseVisualStyleBackColor = true;
            this.btnKeluar.Click += new System.EventHandler(this.btnKeluar_Click);
            // 
            // lblKeterangan
            // 
            this.lblKeterangan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblKeterangan.Font = new System.Drawing.Font("Consolas", 10F);
            this.lblKeterangan.Location = new System.Drawing.Point(15, 98);
            this.lblKeterangan.Name = "lblKeterangan";
            this.lblKeterangan.Size = new System.Drawing.Size(300, 26);
            this.lblKeterangan.TabIndex = 0;
            this.lblKeterangan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmLatihan1a
            // 
            this.AcceptButton = this.btnValidasi;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.CancelButton = this.btnKeluar;
            this.ClientSize = new System.Drawing.Size(330, 133);
            this.Controls.Add(this.btnKeluar);
            this.Controls.Add(this.btnMasuk);
            this.Controls.Add(this.btnValidasi);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblKeterangan);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "frmLatihan1a";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Validasi Password";
            this.Load += new System.EventHandler(this.frmLatihan1a_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnValidasi;
        private System.Windows.Forms.Button btnMasuk;
        private System.Windows.Forms.Button btnKeluar;
        private System.Windows.Forms.Label lblKeterangan;
    }
}

