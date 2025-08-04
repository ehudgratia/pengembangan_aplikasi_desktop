
namespace Teori.Transaction
{
    partial class frmInventory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInventory));
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lblUnit = new System.Windows.Forms.Label();
            this.lblProductName = new System.Windows.Forms.Label();
            this.lblProductID = new System.Windows.Forms.Label();
            this.nudQty = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDisplay = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQty)).BeginInit();
            this.SuspendLayout();
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.lblUnit);
            this.groupBox1.Controls.Add(this.lblProductName);
            this.groupBox1.Controls.Add(this.lblProductID);
            this.groupBox1.Controls.Add(this.nudQty);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(10, 10);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(298, 156);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Product";
            // 
            // button1
            // 
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(238, 31);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(21, 21);
            this.button1.TabIndex = 15;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // lblUnit
            // 
            this.lblUnit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblUnit.Location = new System.Drawing.Point(116, 112);
            this.lblUnit.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUnit.Name = "lblUnit";
            this.lblUnit.Size = new System.Drawing.Size(118, 21);
            this.lblUnit.TabIndex = 13;
            this.lblUnit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblProductName
            // 
            this.lblProductName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblProductName.Location = new System.Drawing.Point(116, 59);
            this.lblProductName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(164, 21);
            this.lblProductName.TabIndex = 12;
            this.lblProductName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblProductID
            // 
            this.lblProductID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblProductID.Location = new System.Drawing.Point(116, 31);
            this.lblProductID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProductID.Name = "lblProductID";
            this.lblProductID.Size = new System.Drawing.Size(118, 21);
            this.lblProductID.TabIndex = 11;
            this.lblProductID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // nudQty
            // 
            this.nudQty.Location = new System.Drawing.Point(116, 85);
            this.nudQty.Margin = new System.Windows.Forms.Padding(2);
            this.nudQty.Name = "nudQty";
            this.nudQty.Size = new System.Drawing.Size(118, 20);
            this.nudQty.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 114);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Unit";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 87);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Qty";
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
            this.btnDisplay.Location = new System.Drawing.Point(268, 170);
            this.btnDisplay.Margin = new System.Windows.Forms.Padding(2);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(40, 40);
            this.btnDisplay.TabIndex = 19;
            this.btnDisplay.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.BackgroundImage = global::Teori.Properties.Resources.delete;
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDelete.Location = new System.Drawing.Point(224, 170);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(40, 40);
            this.btnDelete.TabIndex = 18;
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            this.btnEdit.BackgroundImage = global::Teori.Properties.Resources.edit;
            this.btnEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEdit.Location = new System.Drawing.Point(180, 170);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(2);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(40, 40);
            this.btnEdit.TabIndex = 17;
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.BackgroundImage = global::Teori.Properties.Resources.add;
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAdd.Location = new System.Drawing.Point(136, 170);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(40, 40);
            this.btnAdd.TabIndex = 16;
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // frmInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 220);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnDisplay);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmInventory";
            this.Text = "Inventory";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQty)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.Button button1;
        public System.Windows.Forms.Label lblUnit;
        public System.Windows.Forms.Label lblProductName;
        public System.Windows.Forms.Label lblProductID;
        public System.Windows.Forms.NumericUpDown nudQty;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button btnDisplay;
        public System.Windows.Forms.Button btnDelete;
        public System.Windows.Forms.Button btnEdit;
        public System.Windows.Forms.Button btnAdd;
    }
}