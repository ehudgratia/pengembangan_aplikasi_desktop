
namespace Unit5
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabProduk = new System.Windows.Forms.TabPage();
            this.tabKeranjangBelanja = new System.Windows.Forms.TabPage();
            this.tabPengirimanPembayaran = new System.Windows.Forms.TabPage();
            this.tabKonfirmasi = new System.Windows.Forms.TabPage();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPengirimanPembayaran.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabProduk);
            this.tabControl1.Controls.Add(this.tabKeranjangBelanja);
            this.tabControl1.Controls.Add(this.tabPengirimanPembayaran);
            this.tabControl1.Controls.Add(this.tabKonfirmasi);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.ItemSize = new System.Drawing.Size(100, 50);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(656, 450);
            this.tabControl1.TabIndex = 0;
            // 
            // tabProduk
            // 
            this.tabProduk.Location = new System.Drawing.Point(4, 54);
            this.tabProduk.Name = "tabProduk";
            this.tabProduk.Padding = new System.Windows.Forms.Padding(3);
            this.tabProduk.Size = new System.Drawing.Size(648, 392);
            this.tabProduk.TabIndex = 0;
            this.tabProduk.Text = "Produk";
            this.tabProduk.UseVisualStyleBackColor = true;
            // 
            // tabKeranjangBelanja
            // 
            this.tabKeranjangBelanja.Location = new System.Drawing.Point(4, 54);
            this.tabKeranjangBelanja.Name = "tabKeranjangBelanja";
            this.tabKeranjangBelanja.Padding = new System.Windows.Forms.Padding(3);
            this.tabKeranjangBelanja.Size = new System.Drawing.Size(648, 392);
            this.tabKeranjangBelanja.TabIndex = 1;
            this.tabKeranjangBelanja.Text = "Keranjang Belanja";
            this.tabKeranjangBelanja.UseVisualStyleBackColor = true;
            // 
            // tabPengirimanPembayaran
            // 
            this.tabPengirimanPembayaran.Controls.Add(this.button1);
            this.tabPengirimanPembayaran.Location = new System.Drawing.Point(4, 54);
            this.tabPengirimanPembayaran.Name = "tabPengirimanPembayaran";
            this.tabPengirimanPembayaran.Size = new System.Drawing.Size(648, 392);
            this.tabPengirimanPembayaran.TabIndex = 2;
            this.tabPengirimanPembayaran.Text = "Pengiriman & Pembayaran";
            this.tabPengirimanPembayaran.UseVisualStyleBackColor = true;
            // 
            // tabKonfirmasi
            // 
            this.tabKonfirmasi.Location = new System.Drawing.Point(4, 54);
            this.tabKonfirmasi.Name = "tabKonfirmasi";
            this.tabKonfirmasi.Size = new System.Drawing.Size(648, 392);
            this.tabKonfirmasi.TabIndex = 3;
            this.tabKonfirmasi.Text = "Konfirmasi";
            this.tabKonfirmasi.UseVisualStyleBackColor = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cutToolStripMenuItem,
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(103, 70);
            // 
            // cutToolStripMenuItem
            // 
            this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            this.cutToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.cutToolStripMenuItem.Text = "Cut";
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.copyToolStripMenuItem.Text = "Copy";
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.pasteToolStripMenuItem.Text = "Paste";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(31, 78);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Belanja";
            this.tabControl1.ResumeLayout(false);
            this.tabPengirimanPembayaran.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabProduk;
        private System.Windows.Forms.TabPage tabKeranjangBelanja;
        private System.Windows.Forms.TabPage tabPengirimanPembayaran;
        private System.Windows.Forms.TabPage tabKonfirmasi;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
    }
}

