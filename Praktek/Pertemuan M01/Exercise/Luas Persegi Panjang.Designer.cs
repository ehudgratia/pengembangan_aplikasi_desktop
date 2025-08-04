
namespace Exercise
{
    partial class Luas_Persegi_Panjang
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
            this.txtPanjang = new System.Windows.Forms.TextBox();
            this.txtLebar = new System.Windows.Forms.TextBox();
            this.lblLuas = new System.Windows.Forms.Label();
            this.btnHitung = new System.Windows.Forms.Button();
            this.btnKosong = new System.Windows.Forms.Button();
            this.btnKeluar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(23, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Panjang";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(23, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Lebar";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(23, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 0;
            this.label3.Text = "Luas";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtPanjang
            // 
            this.txtPanjang.Location = new System.Drawing.Point(184, 28);
            this.txtPanjang.Name = "txtPanjang";
            this.txtPanjang.Size = new System.Drawing.Size(105, 20);
            this.txtPanjang.TabIndex = 1;
            this.txtPanjang.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPanjang.Enter += new System.EventHandler(this.Luas_Persegi_Panjang_Load);
            this.txtPanjang.Leave += new System.EventHandler(this.Luas_Persegi_Panjang_Load);
            // 
            // txtLebar
            // 
            this.txtLebar.Location = new System.Drawing.Point(184, 77);
            this.txtLebar.Name = "txtLebar";
            this.txtLebar.Size = new System.Drawing.Size(105, 20);
            this.txtLebar.TabIndex = 1;
            this.txtLebar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtLebar.Leave += new System.EventHandler(this.Luas_Persegi_Panjang_Load);
            // 
            // lblLuas
            // 
            this.lblLuas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblLuas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblLuas.Location = new System.Drawing.Point(184, 120);
            this.lblLuas.Name = "lblLuas";
            this.lblLuas.Size = new System.Drawing.Size(105, 23);
            this.lblLuas.TabIndex = 0;
            this.lblLuas.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnHitung
            // 
            this.btnHitung.Location = new System.Drawing.Point(27, 185);
            this.btnHitung.Name = "btnHitung";
            this.btnHitung.Size = new System.Drawing.Size(75, 23);
            this.btnHitung.TabIndex = 2;
            this.btnHitung.Text = "Hitung";
            this.btnHitung.UseVisualStyleBackColor = true;
            this.btnHitung.Click += new System.EventHandler(this.btnHitung_Click);
            // 
            // btnKosong
            // 
            this.btnKosong.Location = new System.Drawing.Point(119, 185);
            this.btnKosong.Name = "btnKosong";
            this.btnKosong.Size = new System.Drawing.Size(75, 23);
            this.btnKosong.TabIndex = 2;
            this.btnKosong.Text = "Kosong";
            this.btnKosong.UseVisualStyleBackColor = true;
            this.btnKosong.Click += new System.EventHandler(this.btnKosong_Click);
            // 
            // btnKeluar
            // 
            this.btnKeluar.Location = new System.Drawing.Point(214, 185);
            this.btnKeluar.Name = "btnKeluar";
            this.btnKeluar.Size = new System.Drawing.Size(75, 23);
            this.btnKeluar.TabIndex = 2;
            this.btnKeluar.Text = "Keluar";
            this.btnKeluar.UseVisualStyleBackColor = true;
            this.btnKeluar.Click += new System.EventHandler(this.btnKeluar_Click);
            // 
            // Luas_Persegi_Panjang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 240);
            this.Controls.Add(this.btnKeluar);
            this.Controls.Add(this.btnKosong);
            this.Controls.Add(this.btnHitung);
            this.Controls.Add(this.txtLebar);
            this.Controls.Add(this.txtPanjang);
            this.Controls.Add(this.lblLuas);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Luas_Persegi_Panjang";
            this.Text = "Luas_Persegi_Panjang";
            this.Load += new System.EventHandler(this.Luas_Persegi_Panjang_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPanjang;
        private System.Windows.Forms.TextBox txtLebar;
        private System.Windows.Forms.Label lblLuas;
        private System.Windows.Forms.Button btnHitung;
        private System.Windows.Forms.Button btnKosong;
        private System.Windows.Forms.Button btnKeluar;
    }
}