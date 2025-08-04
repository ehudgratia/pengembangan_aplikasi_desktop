
namespace Project_UAS.Master
{
    partial class frmPelanggan
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
            this.btnDisplay = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.rdoNonMember = new System.Windows.Forms.RadioButton();
            this.rdoMember = new System.Windows.Forms.RadioButton();
            this.txtNoHP = new System.Windows.Forms.TextBox();
            this.txtAlamat = new System.Windows.Forms.TextBox();
            this.txtNamaPelanggan = new System.Windows.Forms.TextBox();
            this.txtIDPelanggan = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnDisplay
            // 
            this.btnDisplay.BackgroundImage = global::Project_UAS.Properties.Resources.display;
            this.btnDisplay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDisplay.Location = new System.Drawing.Point(334, 185);
            this.btnDisplay.Margin = new System.Windows.Forms.Padding(2);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(40, 40);
            this.btnDisplay.TabIndex = 32;
            this.btnDisplay.UseVisualStyleBackColor = true;
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackgroundImage = global::Project_UAS.Properties.Resources.delete;
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDelete.Location = new System.Drawing.Point(290, 185);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(40, 40);
            this.btnDelete.TabIndex = 31;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackgroundImage = global::Project_UAS.Properties.Resources.edit;
            this.btnEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEdit.Location = new System.Drawing.Point(246, 185);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(2);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(40, 40);
            this.btnEdit.TabIndex = 30;
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click_1);
            // 
            // btnAdd
            // 
            this.btnAdd.BackgroundImage = global::Project_UAS.Properties.Resources.add;
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAdd.Location = new System.Drawing.Point(202, 185);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(40, 40);
            this.btnAdd.TabIndex = 29;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // rdoNonMember
            // 
            this.rdoNonMember.AutoSize = true;
            this.rdoNonMember.Location = new System.Drawing.Point(204, 142);
            this.rdoNonMember.Name = "rdoNonMember";
            this.rdoNonMember.Size = new System.Drawing.Size(86, 17);
            this.rdoNonMember.TabIndex = 27;
            this.rdoNonMember.TabStop = true;
            this.rdoNonMember.Text = "Non Member";
            this.rdoNonMember.UseVisualStyleBackColor = true;
            // 
            // rdoMember
            // 
            this.rdoMember.AutoSize = true;
            this.rdoMember.Location = new System.Drawing.Point(131, 142);
            this.rdoMember.Name = "rdoMember";
            this.rdoMember.Size = new System.Drawing.Size(63, 17);
            this.rdoMember.TabIndex = 28;
            this.rdoMember.TabStop = true;
            this.rdoMember.Text = "Member";
            this.rdoMember.UseVisualStyleBackColor = true;
            // 
            // txtNoHP
            // 
            this.txtNoHP.Location = new System.Drawing.Point(131, 109);
            this.txtNoHP.MaxLength = 13;
            this.txtNoHP.Name = "txtNoHP";
            this.txtNoHP.Size = new System.Drawing.Size(136, 20);
            this.txtNoHP.TabIndex = 23;
            // 
            // txtAlamat
            // 
            this.txtAlamat.AcceptsReturn = true;
            this.txtAlamat.Location = new System.Drawing.Point(131, 53);
            this.txtAlamat.MaxLength = 200;
            this.txtAlamat.Multiline = true;
            this.txtAlamat.Name = "txtAlamat";
            this.txtAlamat.Size = new System.Drawing.Size(240, 50);
            this.txtAlamat.TabIndex = 24;
            // 
            // txtNamaPelanggan
            // 
            this.txtNamaPelanggan.Location = new System.Drawing.Point(131, 29);
            this.txtNamaPelanggan.MaxLength = 50;
            this.txtNamaPelanggan.Name = "txtNamaPelanggan";
            this.txtNamaPelanggan.Size = new System.Drawing.Size(136, 20);
            this.txtNamaPelanggan.TabIndex = 25;
            // 
            // txtIDPelanggan
            // 
            this.txtIDPelanggan.Location = new System.Drawing.Point(131, 5);
            this.txtIDPelanggan.MaxLength = 5;
            this.txtIDPelanggan.Name = "txtIDPelanggan";
            this.txtIDPelanggan.Size = new System.Drawing.Size(136, 20);
            this.txtIDPelanggan.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "No HP";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Kategori Pelanggan";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Nama Pelanggan";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Alamat";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "ID Pelanggan";
            // 
            // frmPelanggan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 231);
            this.Controls.Add(this.btnDisplay);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.rdoNonMember);
            this.Controls.Add(this.rdoMember);
            this.Controls.Add(this.txtNoHP);
            this.Controls.Add(this.txtAlamat);
            this.Controls.Add(this.txtNamaPelanggan);
            this.Controls.Add(this.txtIDPelanggan);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "frmPelanggan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Daftar Pelanggan";
            this.Load += new System.EventHandler(this.frmPelanggan_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button btnDisplay;
        public System.Windows.Forms.Button btnDelete;
        public System.Windows.Forms.Button btnEdit;
        public System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.RadioButton rdoNonMember;
        public System.Windows.Forms.RadioButton rdoMember;
        public System.Windows.Forms.TextBox txtNoHP;
        public System.Windows.Forms.TextBox txtAlamat;
        public System.Windows.Forms.TextBox txtNamaPelanggan;
        public System.Windows.Forms.TextBox txtIDPelanggan;
    }
}