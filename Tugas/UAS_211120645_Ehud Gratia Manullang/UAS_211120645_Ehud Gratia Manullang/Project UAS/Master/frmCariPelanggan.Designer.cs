
namespace Project_UAS.Master
{
    partial class frmCariPelanggan
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
            this.rdoNamaPelanggan = new System.Windows.Forms.RadioButton();
            this.rdoIDPelanggan = new System.Windows.Forms.RadioButton();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblCount = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdoNamaPelanggan);
            this.groupBox1.Controls.Add(this.rdoIDPelanggan);
            this.groupBox1.Controls.Add(this.btnRefresh);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.txtSearch);
            this.groupBox1.Location = new System.Drawing.Point(11, 11);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(408, 118);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search";
            // 
            // rdoNamaPelanggan
            // 
            this.rdoNamaPelanggan.AutoSize = true;
            this.rdoNamaPelanggan.Location = new System.Drawing.Point(134, 31);
            this.rdoNamaPelanggan.Margin = new System.Windows.Forms.Padding(2);
            this.rdoNamaPelanggan.Name = "rdoNamaPelanggan";
            this.rdoNamaPelanggan.Size = new System.Drawing.Size(107, 17);
            this.rdoNamaPelanggan.TabIndex = 6;
            this.rdoNamaPelanggan.TabStop = true;
            this.rdoNamaPelanggan.Text = "Nama Pelanggan";
            this.rdoNamaPelanggan.UseVisualStyleBackColor = true;
            // 
            // rdoIDPelanggan
            // 
            this.rdoIDPelanggan.AutoSize = true;
            this.rdoIDPelanggan.Location = new System.Drawing.Point(16, 31);
            this.rdoIDPelanggan.Margin = new System.Windows.Forms.Padding(2);
            this.rdoIDPelanggan.Name = "rdoIDPelanggan";
            this.rdoIDPelanggan.Size = new System.Drawing.Size(90, 17);
            this.rdoIDPelanggan.TabIndex = 5;
            this.rdoIDPelanggan.TabStop = true;
            this.rdoIDPelanggan.Text = "ID Pelanggan";
            this.rdoIDPelanggan.UseVisualStyleBackColor = true;
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackgroundImage = global::Project_UAS.Properties.Resources.refresh;
            this.btnRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRefresh.Location = new System.Drawing.Point(337, 49);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(2);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(40, 40);
            this.btnRefresh.TabIndex = 4;
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackgroundImage = global::Project_UAS.Properties.Resources.search;
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearch.Location = new System.Drawing.Point(293, 49);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(40, 40);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearch.Location = new System.Drawing.Point(16, 58);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(2);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(273, 20);
            this.txtSearch.TabIndex = 1;
            // 
            // lblCount
            // 
            this.lblCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCount.Location = new System.Drawing.Point(379, 334);
            this.lblCount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(39, 27);
            this.lblCount.TabIndex = 20;
            this.lblCount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(333, 339);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Count";
            // 
            // dgvData
            // 
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Location = new System.Drawing.Point(11, 133);
            this.dgvData.Margin = new System.Windows.Forms.Padding(2);
            this.dgvData.Name = "dgvData";
            this.dgvData.RowHeadersWidth = 51;
            this.dgvData.RowTemplate.Height = 24;
            this.dgvData.Size = new System.Drawing.Size(408, 194);
            this.dgvData.TabIndex = 18;
            this.dgvData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvData_CellClick);
            // 
            // frmCariPelanggan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 366);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvData);
            this.Name = "frmCariPelanggan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cari Pelanggan";
            this.Load += new System.EventHandler(this.frmCariPelanggan_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdoNamaPelanggan;
        private System.Windows.Forms.RadioButton rdoIDPelanggan;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvData;
    }
}