
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdoMika = new System.Windows.Forms.RadioButton();
            this.rdoELearning = new System.Windows.Forms.RadioButton();
            this.rdoWebmail = new System.Windows.Forms.RadioButton();
            this.rdoPerpustakaan = new System.Windows.Forms.RadioButton();
            this.lklLink = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdoPerpustakaan);
            this.groupBox1.Controls.Add(this.rdoELearning);
            this.groupBox1.Controls.Add(this.rdoWebmail);
            this.groupBox1.Controls.Add(this.rdoMika);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(221, 104);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Link";
            // 
            // rdoMika
            // 
            this.rdoMika.AutoSize = true;
            this.rdoMika.Location = new System.Drawing.Point(7, 40);
            this.rdoMika.Name = "rdoMika";
            this.rdoMika.Size = new System.Drawing.Size(51, 17);
            this.rdoMika.TabIndex = 0;
            this.rdoMika.TabStop = true;
            this.rdoMika.Text = "MIKA";
            this.rdoMika.UseVisualStyleBackColor = true;
            // 
            // rdoELearning
            // 
            this.rdoELearning.AutoSize = true;
            this.rdoELearning.Location = new System.Drawing.Point(7, 63);
            this.rdoELearning.Name = "rdoELearning";
            this.rdoELearning.Size = new System.Drawing.Size(76, 17);
            this.rdoELearning.TabIndex = 0;
            this.rdoELearning.TabStop = true;
            this.rdoELearning.Text = "E-Learning";
            this.rdoELearning.UseVisualStyleBackColor = true;
            // 
            // rdoWebmail
            // 
            this.rdoWebmail.AutoSize = true;
            this.rdoWebmail.Location = new System.Drawing.Point(113, 40);
            this.rdoWebmail.Name = "rdoWebmail";
            this.rdoWebmail.Size = new System.Drawing.Size(66, 17);
            this.rdoWebmail.TabIndex = 0;
            this.rdoWebmail.TabStop = true;
            this.rdoWebmail.Text = "Webmail";
            this.rdoWebmail.UseVisualStyleBackColor = true;
            // 
            // rdoPerpustakaan
            // 
            this.rdoPerpustakaan.AutoSize = true;
            this.rdoPerpustakaan.Location = new System.Drawing.Point(113, 63);
            this.rdoPerpustakaan.Name = "rdoPerpustakaan";
            this.rdoPerpustakaan.Size = new System.Drawing.Size(91, 17);
            this.rdoPerpustakaan.TabIndex = 0;
            this.rdoPerpustakaan.TabStop = true;
            this.rdoPerpustakaan.Text = "Perpustakaan";
            this.rdoPerpustakaan.UseVisualStyleBackColor = true;
            // 
            // lklLink
            // 
            this.lklLink.AutoSize = true;
            this.lklLink.Location = new System.Drawing.Point(105, 124);
            this.lklLink.Name = "lklLink";
            this.lklLink.Size = new System.Drawing.Size(28, 13);
            this.lklLink.TabIndex = 1;
            this.lklLink.TabStop = true;
            this.lklLink.Text = "here";
            this.lklLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lklLink_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Click";
            // 
            // frmLatihan1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lklLink);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmLatihan1";
            this.Text = "frmLatihan1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdoPerpustakaan;
        private System.Windows.Forms.RadioButton rdoELearning;
        private System.Windows.Forms.RadioButton rdoWebmail;
        private System.Windows.Forms.RadioButton rdoMika;
        private System.Windows.Forms.LinkLabel lklLink;
        private System.Windows.Forms.Label label1;
    }
}