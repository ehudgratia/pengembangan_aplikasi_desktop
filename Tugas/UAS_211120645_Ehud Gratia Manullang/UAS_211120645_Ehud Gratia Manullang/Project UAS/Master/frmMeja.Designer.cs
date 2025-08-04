
namespace Project_UAS.Master
{
    partial class frmMeja
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
            this.cboJenisMeja = new System.Windows.Forms.ComboBox();
            this.txtNoMeja = new System.Windows.Forms.TextBox();
            this.btnDisplay = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "No Meja";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Jenis Meja";
            // 
            // cboJenisMeja
            // 
            this.cboJenisMeja.FormattingEnabled = true;
            this.cboJenisMeja.Location = new System.Drawing.Point(99, 36);
            this.cboJenisMeja.Name = "cboJenisMeja";
            this.cboJenisMeja.Size = new System.Drawing.Size(149, 21);
            this.cboJenisMeja.TabIndex = 1;
            // 
            // txtNoMeja
            // 
            this.txtNoMeja.Location = new System.Drawing.Point(99, 8);
            this.txtNoMeja.Name = "txtNoMeja";
            this.txtNoMeja.Size = new System.Drawing.Size(149, 20);
            this.txtNoMeja.TabIndex = 2;
            // 
            // btnDisplay
            // 
            this.btnDisplay.BackgroundImage = global::Project_UAS.Properties.Resources.display;
            this.btnDisplay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDisplay.Location = new System.Drawing.Point(208, 75);
            this.btnDisplay.Margin = new System.Windows.Forms.Padding(2);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(40, 40);
            this.btnDisplay.TabIndex = 40;
            this.btnDisplay.UseVisualStyleBackColor = true;
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackgroundImage = global::Project_UAS.Properties.Resources.delete;
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDelete.Location = new System.Drawing.Point(164, 75);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(40, 40);
            this.btnDelete.TabIndex = 39;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackgroundImage = global::Project_UAS.Properties.Resources.edit;
            this.btnEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEdit.Location = new System.Drawing.Point(120, 75);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(2);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(40, 40);
            this.btnEdit.TabIndex = 38;
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackgroundImage = global::Project_UAS.Properties.Resources.add;
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAdd.Location = new System.Drawing.Point(76, 75);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(40, 40);
            this.btnAdd.TabIndex = 37;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // frmMeja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(262, 121);
            this.Controls.Add(this.btnDisplay);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtNoMeja);
            this.Controls.Add(this.cboJenisMeja);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmMeja";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Meja";
            this.Load += new System.EventHandler(this.frmMeja_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Button btnDisplay;
        public System.Windows.Forms.Button btnDelete;
        public System.Windows.Forms.Button btnEdit;
        public System.Windows.Forms.Button btnAdd;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.ComboBox cboJenisMeja;
        public System.Windows.Forms.TextBox txtNoMeja;
    }
}