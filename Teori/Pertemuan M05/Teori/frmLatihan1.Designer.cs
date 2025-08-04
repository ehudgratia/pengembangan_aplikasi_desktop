
namespace Teori
{
    partial class frmLatihan1
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
            this.picZoom = new System.Windows.Forms.PictureBox();
            this.picStretchImage = new System.Windows.Forms.PictureBox();
            this.picNormal = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lblSize = new System.Windows.Forms.Label();
            this.btnPilihGambar = new System.Windows.Forms.Button();
            this.picCenterImage = new System.Windows.Forms.PictureBox();
            this.picAutoSize = new System.Windows.Forms.PictureBox();
            this.dlgOpen = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.picZoom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picStretchImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNormal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCenterImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAutoSize)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Normal";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(209, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "CenterImage";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(391, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "AutoSize";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "StretchImage";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(209, 216);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Zoom";
            // 
            // picZoom
            // 
            this.picZoom.BackColor = System.Drawing.SystemColors.Control;
            this.picZoom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picZoom.Location = new System.Drawing.Point(212, 232);
            this.picZoom.Name = "picZoom";
            this.picZoom.Size = new System.Drawing.Size(179, 155);
            this.picZoom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picZoom.TabIndex = 0;
            this.picZoom.TabStop = false;
            // 
            // picStretchImage
            // 
            this.picStretchImage.BackColor = System.Drawing.SystemColors.Control;
            this.picStretchImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picStretchImage.Location = new System.Drawing.Point(27, 232);
            this.picStretchImage.Name = "picStretchImage";
            this.picStretchImage.Size = new System.Drawing.Size(179, 155);
            this.picStretchImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picStretchImage.TabIndex = 0;
            this.picStretchImage.TabStop = false;
            // 
            // picNormal
            // 
            this.picNormal.BackColor = System.Drawing.SystemColors.Control;
            this.picNormal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picNormal.Location = new System.Drawing.Point(27, 44);
            this.picNormal.Name = "picNormal";
            this.picNormal.Size = new System.Drawing.Size(179, 155);
            this.picNormal.TabIndex = 0;
            this.picNormal.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(424, 231);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = " SIze Sebenarnya :";
            // 
            // lblSize
            // 
            this.lblSize.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSize.Location = new System.Drawing.Point(427, 252);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(128, 23);
            this.lblSize.TabIndex = 3;
            this.lblSize.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnPilihGambar
            // 
            this.btnPilihGambar.Location = new System.Drawing.Point(427, 278);
            this.btnPilihGambar.Name = "btnPilihGambar";
            this.btnPilihGambar.Size = new System.Drawing.Size(128, 23);
            this.btnPilihGambar.TabIndex = 4;
            this.btnPilihGambar.Text = "Pilih Gambar";
            this.btnPilihGambar.UseVisualStyleBackColor = true;
            this.btnPilihGambar.Click += new System.EventHandler(this.btnPilihGambar_Click);
            // 
            // picCenterImage
            // 
            this.picCenterImage.BackColor = System.Drawing.SystemColors.Control;
            this.picCenterImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picCenterImage.Location = new System.Drawing.Point(212, 44);
            this.picCenterImage.Name = "picCenterImage";
            this.picCenterImage.Size = new System.Drawing.Size(179, 155);
            this.picCenterImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picCenterImage.TabIndex = 0;
            this.picCenterImage.TabStop = false;
            // 
            // picAutoSize
            // 
            this.picAutoSize.BackColor = System.Drawing.SystemColors.Control;
            this.picAutoSize.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picAutoSize.Location = new System.Drawing.Point(397, 44);
            this.picAutoSize.Name = "picAutoSize";
            this.picAutoSize.Size = new System.Drawing.Size(179, 155);
            this.picAutoSize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picAutoSize.TabIndex = 0;
            this.picAutoSize.TabStop = false;
            // 
            // dlgOpen
            // 
            this.dlgOpen.FileName = "openFileDialog1";
            // 
            // frmLatihan1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnPilihGambar);
            this.Controls.Add(this.lblSize);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picZoom);
            this.Controls.Add(this.picAutoSize);
            this.Controls.Add(this.picCenterImage);
            this.Controls.Add(this.picStretchImage);
            this.Controls.Add(this.picNormal);
            this.Name = "frmLatihan1";
            this.Text = "frmLatihan1";
            this.Load += new System.EventHandler(this.frmLatihan1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picZoom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picStretchImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNormal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCenterImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAutoSize)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picNormal;
        private System.Windows.Forms.PictureBox picStretchImage;
        private System.Windows.Forms.PictureBox picZoom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.Button btnPilihGambar;
        private System.Windows.Forms.PictureBox picCenterImage;
        private System.Windows.Forms.PictureBox picAutoSize;
        private System.Windows.Forms.OpenFileDialog dlgOpen;
    }
}