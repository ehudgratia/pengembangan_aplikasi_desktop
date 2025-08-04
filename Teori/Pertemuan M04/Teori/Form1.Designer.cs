
namespace Teori
{
    partial class frm1
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
            this.nudAngka = new System.Windows.Forms.NumericUpDown();
            this.btnNaik = new System.Windows.Forms.Button();
            this.btnTurun = new System.Windows.Forms.Button();
            this.dudPAB = new System.Windows.Forms.DomainUpDown();
            this.hsbNilai = new System.Windows.Forms.HScrollBar();
            this.vsbNilai = new System.Windows.Forms.VScrollBar();
            this.lblNilai = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.trackBar2 = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.nudAngka)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            this.SuspendLayout();
            // 
            // nudAngka
            // 
            this.nudAngka.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.nudAngka.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudAngka.Location = new System.Drawing.Point(13, 13);
            this.nudAngka.Name = "nudAngka";
            this.nudAngka.Size = new System.Drawing.Size(130, 20);
            this.nudAngka.TabIndex = 0;
            this.nudAngka.ValueChanged += new System.EventHandler(this.nudAngka_ValueChanged);
            this.nudAngka.Enter += new System.EventHandler(this.nudAngka_Enter);
            this.nudAngka.Leave += new System.EventHandler(this.nudAngka_Leave);
            // 
            // btnNaik
            // 
            this.btnNaik.Location = new System.Drawing.Point(13, 40);
            this.btnNaik.Name = "btnNaik";
            this.btnNaik.Size = new System.Drawing.Size(52, 22);
            this.btnNaik.TabIndex = 1;
            this.btnNaik.Text = "Naik";
            this.btnNaik.UseVisualStyleBackColor = true;
            this.btnNaik.Click += new System.EventHandler(this.btnNaik_Click);
            // 
            // btnTurun
            // 
            this.btnTurun.Location = new System.Drawing.Point(82, 40);
            this.btnTurun.Name = "btnTurun";
            this.btnTurun.Size = new System.Drawing.Size(52, 22);
            this.btnTurun.TabIndex = 1;
            this.btnTurun.Text = "Turun";
            this.btnTurun.UseVisualStyleBackColor = true;
            this.btnTurun.Click += new System.EventHandler(this.btnTurun_Click);
            // 
            // dudPAB
            // 
            this.dudPAB.Items.Add("Hijau");
            this.dudPAB.Items.Add("Kuning");
            this.dudPAB.Items.Add("Merah");
            this.dudPAB.Location = new System.Drawing.Point(155, 13);
            this.dudPAB.Name = "dudPAB";
            this.dudPAB.Size = new System.Drawing.Size(168, 20);
            this.dudPAB.Sorted = true;
            this.dudPAB.TabIndex = 2;
            this.dudPAB.Text = "Pengembangan Aplikasi Bisnis";
            this.dudPAB.Wrap = true;
            this.dudPAB.SelectedItemChanged += new System.EventHandler(this.dudPAB_SelectedItemChanged);
            // 
            // hsbNilai
            // 
            this.hsbNilai.Location = new System.Drawing.Point(63, 128);
            this.hsbNilai.Name = "hsbNilai";
            this.hsbNilai.Size = new System.Drawing.Size(80, 17);
            this.hsbNilai.TabIndex = 3;
            this.hsbNilai.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hsbNilai_Scroll);
            // 
            // vsbNilai
            // 
            this.vsbNilai.Location = new System.Drawing.Point(13, 65);
            this.vsbNilai.Name = "vsbNilai";
            this.vsbNilai.Size = new System.Drawing.Size(17, 80);
            this.vsbNilai.TabIndex = 4;
            // 
            // lblNilai
            // 
            this.lblNilai.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNilai.Location = new System.Drawing.Point(43, 163);
            this.lblNilai.Name = "lblNilai";
            this.lblNilai.Size = new System.Drawing.Size(100, 23);
            this.lblNilai.TabIndex = 5;
            this.lblNilai.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 168);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nilai";
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(155, 159);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(120, 45);
            this.trackBar1.TabIndex = 7;
            // 
            // trackBar2
            // 
            this.trackBar2.Location = new System.Drawing.Point(155, 40);
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar2.Size = new System.Drawing.Size(45, 113);
            this.trackBar2.TabIndex = 7;
            // 
            // frm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 420);
            this.Controls.Add(this.trackBar2);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblNilai);
            this.Controls.Add(this.vsbNilai);
            this.Controls.Add(this.hsbNilai);
            this.Controls.Add(this.dudPAB);
            this.Controls.Add(this.btnTurun);
            this.Controls.Add(this.btnNaik);
            this.Controls.Add(this.nudAngka);
            this.Name = "frm1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frm1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudAngka)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nudAngka;
        private System.Windows.Forms.Button btnNaik;
        private System.Windows.Forms.Button btnTurun;
        private System.Windows.Forms.DomainUpDown dudPAB;
        private System.Windows.Forms.HScrollBar hsbNilai;
        private System.Windows.Forms.VScrollBar vsbNilai;
        private System.Windows.Forms.Label lblNilai;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.TrackBar trackBar2;
    }
}

