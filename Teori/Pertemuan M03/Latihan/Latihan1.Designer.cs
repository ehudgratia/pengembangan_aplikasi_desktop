
namespace Latihan
{
    partial class Latihan1
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
            this.txtNama = new System.Windows.Forms.TextBox();
            this.lstDaftar = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblJumlah = new System.Windows.Forms.Label();
            this.btnEntry = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.ClearAll = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nama Mahasiswa";
            // 
            // txtNama
            // 
            this.txtNama.Location = new System.Drawing.Point(16, 30);
            this.txtNama.Name = "txtNama";
            this.txtNama.Size = new System.Drawing.Size(191, 20);
            this.txtNama.TabIndex = 1;
            // 
            // lstDaftar
            // 
            this.lstDaftar.FormattingEnabled = true;
            this.lstDaftar.Location = new System.Drawing.Point(16, 57);
            this.lstDaftar.Name = "lstDaftar";
            this.lstDaftar.Size = new System.Drawing.Size(191, 264);
            this.lstDaftar.TabIndex = 2;
            this.lstDaftar.SelectedIndexChanged += new System.EventHandler(this.lstDaftar_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 334);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Jumlah Mahasiswa";
            // 
            // lblJumlah
            // 
            this.lblJumlah.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblJumlah.Location = new System.Drawing.Point(115, 334);
            this.lblJumlah.Name = "lblJumlah";
            this.lblJumlah.Size = new System.Drawing.Size(92, 13);
            this.lblJumlah.TabIndex = 0;
            // 
            // btnEntry
            // 
            this.btnEntry.Location = new System.Drawing.Point(229, 28);
            this.btnEntry.Name = "btnEntry";
            this.btnEntry.Size = new System.Drawing.Size(75, 23);
            this.btnEntry.TabIndex = 3;
            this.btnEntry.Text = "Entry";
            this.btnEntry.UseVisualStyleBackColor = true;
            this.btnEntry.Click += new System.EventHandler(this.btnEntry_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(229, 57);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // ClearAll
            // 
            this.ClearAll.Location = new System.Drawing.Point(229, 86);
            this.ClearAll.Name = "ClearAll";
            this.ClearAll.Size = new System.Drawing.Size(75, 23);
            this.ClearAll.TabIndex = 3;
            this.ClearAll.Text = "Clear All";
            this.ClearAll.UseVisualStyleBackColor = true;
            this.ClearAll.Click += new System.EventHandler(this.ClearAll_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(229, 115);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Latihan1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.ClearAll);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnEntry);
            this.Controls.Add(this.lstDaftar);
            this.Controls.Add(this.txtNama);
            this.Controls.Add(this.lblJumlah);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Latihan1";
            this.Text = "Latihan1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNama;
        private System.Windows.Forms.ListBox lstDaftar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblJumlah;
        private System.Windows.Forms.Button btnEntry;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button ClearAll;
        private System.Windows.Forms.Button btnClose;
    }
}