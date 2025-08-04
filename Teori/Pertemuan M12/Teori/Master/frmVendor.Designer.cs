
namespace Teori.Master
{
    partial class frmVendor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVendor));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdoNonActive = new System.Windows.Forms.RadioButton();
            this.rdoActive = new System.Windows.Forms.RadioButton();
            this.nudPurchasingPrice = new System.Windows.Forms.NumericUpDown();
            this.cboUnit = new System.Windows.Forms.ComboBox();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.txtProductID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDisplay = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPurchasingPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdoNonActive);
            this.groupBox1.Controls.Add(this.rdoActive);
            this.groupBox1.Controls.Add(this.nudPurchasingPrice);
            this.groupBox1.Controls.Add(this.cboUnit);
            this.groupBox1.Controls.Add(this.txtProductName);
            this.groupBox1.Controls.Add(this.txtProductID);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(298, 175);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Product";
            // 
            // rdoNonActive
            // 
            this.rdoNonActive.AutoSize = true;
            this.rdoNonActive.Location = new System.Drawing.Point(183, 139);
            this.rdoNonActive.Margin = new System.Windows.Forms.Padding(2);
            this.rdoNonActive.Name = "rdoNonActive";
            this.rdoNonActive.Size = new System.Drawing.Size(78, 17);
            this.rdoNonActive.TabIndex = 10;
            this.rdoNonActive.TabStop = true;
            this.rdoNonActive.Text = "Non-Active";
            this.rdoNonActive.UseVisualStyleBackColor = true;
            // 
            // rdoActive
            // 
            this.rdoActive.AutoSize = true;
            this.rdoActive.Location = new System.Drawing.Point(116, 139);
            this.rdoActive.Margin = new System.Windows.Forms.Padding(2);
            this.rdoActive.Name = "rdoActive";
            this.rdoActive.Size = new System.Drawing.Size(55, 17);
            this.rdoActive.TabIndex = 9;
            this.rdoActive.TabStop = true;
            this.rdoActive.Text = "Active";
            this.rdoActive.UseVisualStyleBackColor = true;
            // 
            // nudPurchasingPrice
            // 
            this.nudPurchasingPrice.Location = new System.Drawing.Point(116, 112);
            this.nudPurchasingPrice.Margin = new System.Windows.Forms.Padding(2);
            this.nudPurchasingPrice.Name = "nudPurchasingPrice";
            this.nudPurchasingPrice.Size = new System.Drawing.Size(118, 20);
            this.nudPurchasingPrice.TabIndex = 8;
            // 
            // cboUnit
            // 
            this.cboUnit.FormattingEnabled = true;
            this.cboUnit.Location = new System.Drawing.Point(116, 84);
            this.cboUnit.Margin = new System.Windows.Forms.Padding(2);
            this.cboUnit.Name = "cboUnit";
            this.cboUnit.Size = new System.Drawing.Size(118, 21);
            this.cboUnit.TabIndex = 7;
            // 
            // txtProductName
            // 
            this.txtProductName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtProductName.Location = new System.Drawing.Point(116, 58);
            this.txtProductName.Margin = new System.Windows.Forms.Padding(2);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(164, 20);
            this.txtProductName.TabIndex = 6;
            // 
            // txtProductID
            // 
            this.txtProductID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtProductID.Location = new System.Drawing.Point(116, 31);
            this.txtProductID.Margin = new System.Windows.Forms.Padding(2);
            this.txtProductID.Name = "txtProductID";
            this.txtProductID.Size = new System.Drawing.Size(118, 20);
            this.txtProductID.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 141);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Status";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 114);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Purch. Price";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 87);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Unit";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 61);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Product Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Product ID";
            // 
            // btnDisplay
            // 
            this.btnDisplay.BackgroundImage = global::Teori.Properties.Resources.display;
            this.btnDisplay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDisplay.Location = new System.Drawing.Point(270, 191);
            this.btnDisplay.Margin = new System.Windows.Forms.Padding(2);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(40, 40);
            this.btnDisplay.TabIndex = 14;
            this.btnDisplay.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.BackgroundImage = global::Teori.Properties.Resources.delete;
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDelete.Location = new System.Drawing.Point(226, 191);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(40, 40);
            this.btnDelete.TabIndex = 13;
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            this.btnEdit.BackgroundImage = global::Teori.Properties.Resources.edit;
            this.btnEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEdit.Location = new System.Drawing.Point(182, 191);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(2);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(40, 40);
            this.btnEdit.TabIndex = 12;
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.BackgroundImage = global::Teori.Properties.Resources.add;
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAdd.Location = new System.Drawing.Point(138, 191);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(40, 40);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // frmProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 243);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnDisplay);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmProduct";
            this.Text = "Vendor";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPurchasingPrice)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.RadioButton rdoNonActive;
        public System.Windows.Forms.RadioButton rdoActive;
        public System.Windows.Forms.NumericUpDown nudPurchasingPrice;
        public System.Windows.Forms.ComboBox cboUnit;
        public System.Windows.Forms.TextBox txtProductName;
        public System.Windows.Forms.TextBox txtProductID;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button btnDisplay;
        public System.Windows.Forms.Button btnDelete;
        public System.Windows.Forms.Button btnEdit;
        public System.Windows.Forms.Button btnAdd;
    }
}