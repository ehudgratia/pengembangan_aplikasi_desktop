
namespace Teori
{
    partial class frmTest
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
            this.dtpTanggal = new System.Windows.Forms.DateTimePicker();
            this.lklLink = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.rtbText = new System.Windows.Forms.RichTextBox();
            this.btnTampil = new System.Windows.Forms.Button();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dtpTanggal
            // 
            this.dtpTanggal.CalendarMonthBackground = System.Drawing.Color.Yellow;
            this.dtpTanggal.CalendarTitleBackColor = System.Drawing.Color.Aqua;
            this.dtpTanggal.CalendarTitleForeColor = System.Drawing.Color.Blue;
            this.dtpTanggal.CalendarTrailingForeColor = System.Drawing.Color.Purple;
            this.dtpTanggal.CustomFormat = "";
            this.dtpTanggal.Location = new System.Drawing.Point(12, 12);
            this.dtpTanggal.Name = "dtpTanggal";
            this.dtpTanggal.Size = new System.Drawing.Size(303, 20);
            this.dtpTanggal.TabIndex = 0;
            // 
            // lklLink
            // 
            this.lklLink.AutoSize = true;
            this.lklLink.LinkArea = new System.Windows.Forms.LinkArea(13, 8);
            this.lklLink.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lklLink.LinkColor = System.Drawing.Color.Red;
            this.lklLink.LinkVisited = true;
            this.lklLink.Location = new System.Drawing.Point(48, 69);
            this.lklLink.Name = "lklLink";
            this.lklLink.Size = new System.Drawing.Size(160, 17);
            this.lklLink.TabIndex = 1;
            this.lklLink.TabStop = true;
            this.lklLink.Text = "Pengembangan Aplikasi Bisnis";
            this.lklLink.UseCompatibleTextRendering = true;
            this.lklLink.VisitedLinkColor = System.Drawing.Color.Blue;
            this.lklLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lklLink_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Click";
            // 
            // rtbText
            // 
            this.rtbText.Location = new System.Drawing.Point(12, 89);
            this.rtbText.Name = "rtbText";
            this.rtbText.Size = new System.Drawing.Size(303, 96);
            this.rtbText.TabIndex = 3;
            this.rtbText.Text = "";
            // 
            // btnTampil
            // 
            this.btnTampil.Location = new System.Drawing.Point(15, 186);
            this.btnTampil.Name = "btnTampil";
            this.btnTampil.Size = new System.Drawing.Size(75, 23);
            this.btnTampil.TabIndex = 4;
            this.btnTampil.Text = "Tampil";
            this.btnTampil.Click += new System.EventHandler(this.btnTampil_Click);
            // 
            // btnSimpan
            // 
            this.btnSimpan.Location = new System.Drawing.Point(96, 186);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(75, 23);
            this.btnSimpan.TabIndex = 4;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // frmTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 221);
            this.Controls.Add(this.btnSimpan);
            this.Controls.Add(this.btnTampil);
            this.Controls.Add(this.rtbText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lklLink);
            this.Controls.Add(this.dtpTanggal);
            this.Name = "frmTest";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpTanggal;
        private System.Windows.Forms.LinkLabel lklLink;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox rtbText;
        private System.Windows.Forms.Button btnTampil;
        private System.Windows.Forms.Button btnSimpan;
    }
}

