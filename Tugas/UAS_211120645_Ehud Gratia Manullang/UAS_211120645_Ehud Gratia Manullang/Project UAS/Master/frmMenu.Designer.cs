
namespace Project_UAS.Master
{
    partial class frmMenu
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
            this.txtIDMenu = new System.Windows.Forms.TextBox();
            this.txtNamaMenu = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdoMinuman = new System.Windows.Forms.RadioButton();
            this.rdoMakanan = new System.Windows.Forms.RadioButton();
            this.btnDisplay = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.nudPurchasingPrice = new System.Windows.Forms.NumericUpDown();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPurchasingPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID Menu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nama Menu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Harga";
            // 
            // txtIDMenu
            // 
            this.txtIDMenu.Location = new System.Drawing.Point(123, 6);
            this.txtIDMenu.Name = "txtIDMenu";
            this.txtIDMenu.Size = new System.Drawing.Size(155, 20);
            this.txtIDMenu.TabIndex = 1;
            // 
            // txtNamaMenu
            // 
            this.txtNamaMenu.Location = new System.Drawing.Point(123, 30);
            this.txtNamaMenu.Name = "txtNamaMenu";
            this.txtNamaMenu.Size = new System.Drawing.Size(155, 20);
            this.txtNamaMenu.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdoMinuman);
            this.groupBox1.Controls.Add(this.rdoMakanan);
            this.groupBox1.Location = new System.Drawing.Point(11, 82);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(266, 67);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Jenis Menu";
            // 
            // rdoMinuman
            // 
            this.rdoMinuman.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoMinuman.Location = new System.Drawing.Point(142, 23);
            this.rdoMinuman.Name = "rdoMinuman";
            this.rdoMinuman.Size = new System.Drawing.Size(105, 32);
            this.rdoMinuman.TabIndex = 0;
            this.rdoMinuman.TabStop = true;
            this.rdoMinuman.Text = "Minuman";
            this.rdoMinuman.UseVisualStyleBackColor = true;
            // 
            // rdoMakanan
            // 
            this.rdoMakanan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoMakanan.Location = new System.Drawing.Point(16, 23);
            this.rdoMakanan.Name = "rdoMakanan";
            this.rdoMakanan.Size = new System.Drawing.Size(107, 32);
            this.rdoMakanan.TabIndex = 0;
            this.rdoMakanan.TabStop = true;
            this.rdoMakanan.Text = "Makanan";
            this.rdoMakanan.UseVisualStyleBackColor = true;
            // 
            // btnDisplay
            // 
            this.btnDisplay.BackgroundImage = global::Project_UAS.Properties.Resources.display;
            this.btnDisplay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDisplay.Location = new System.Drawing.Point(238, 176);
            this.btnDisplay.Margin = new System.Windows.Forms.Padding(2);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(40, 40);
            this.btnDisplay.TabIndex = 36;
            this.btnDisplay.UseVisualStyleBackColor = true;
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackgroundImage = global::Project_UAS.Properties.Resources.delete;
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDelete.Location = new System.Drawing.Point(194, 176);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(40, 40);
            this.btnDelete.TabIndex = 35;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackgroundImage = global::Project_UAS.Properties.Resources.edit;
            this.btnEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEdit.Location = new System.Drawing.Point(150, 176);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(2);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(40, 40);
            this.btnEdit.TabIndex = 34;
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackgroundImage = global::Project_UAS.Properties.Resources.add;
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAdd.Location = new System.Drawing.Point(106, 176);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(40, 40);
            this.btnAdd.TabIndex = 33;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // nudPurchasingPrice
            // 
            this.nudPurchasingPrice.Location = new System.Drawing.Point(123, 57);
            this.nudPurchasingPrice.Margin = new System.Windows.Forms.Padding(2);
            this.nudPurchasingPrice.Name = "nudPurchasingPrice";
            this.nudPurchasingPrice.Size = new System.Drawing.Size(155, 20);
            this.nudPurchasingPrice.TabIndex = 8;
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 228);
            this.Controls.Add(this.nudPurchasingPrice);
            this.Controls.Add(this.btnDisplay);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtNamaMenu);
            this.Controls.Add(this.txtIDMenu);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.frmMenu_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudPurchasingPrice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Button btnDisplay;
        public System.Windows.Forms.Button btnDelete;
        public System.Windows.Forms.Button btnEdit;
        public System.Windows.Forms.Button btnAdd;
        public System.Windows.Forms.NumericUpDown nudPurchasingPrice;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txtIDMenu;
        public System.Windows.Forms.TextBox txtNamaMenu;
        public System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.RadioButton rdoMinuman;
        public System.Windows.Forms.RadioButton rdoMakanan;
    }
}