
namespace Teori
{
    partial class frmContoh2
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
            this.btnKoneksi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnKoneksi
            // 
            this.btnKoneksi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKoneksi.Location = new System.Drawing.Point(62, 28);
            this.btnKoneksi.Name = "btnKoneksi";
            this.btnKoneksi.Size = new System.Drawing.Size(138, 32);
            this.btnKoneksi.TabIndex = 1;
            this.btnKoneksi.Text = "Koneksi";
            this.btnKoneksi.UseVisualStyleBackColor = true;
            this.btnKoneksi.Click += new System.EventHandler(this.btnKoneksi_Click);
            // 
            // frmContoh2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(262, 89);
            this.Controls.Add(this.btnKoneksi);
            this.Name = "frmContoh2";
            this.Text = "Object Connection";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnKoneksi;
    }
}