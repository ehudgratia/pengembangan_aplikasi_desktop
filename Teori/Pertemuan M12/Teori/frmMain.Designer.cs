
namespace Teori
{
    partial class frmMain
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
            this.mnuMain = new System.Windows.Forms.MenuStrip();
            this.mnuMaster = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTransaction = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuReport = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMasterProduct = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMasterVendor = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTransactionPurchasing = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTransactionSales = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTransactionInventory = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuReportProductList = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuReportVendorList = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuReportPurchaseReport = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuReportSalesReport = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuReportInventoryReport = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuMain
            // 
            this.mnuMain.AutoSize = false;
            this.mnuMain.ImageScalingSize = new System.Drawing.Size(50, 50);
            this.mnuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuMaster,
            this.mnuTransaction,
            this.mnuReport});
            this.mnuMain.Location = new System.Drawing.Point(0, 0);
            this.mnuMain.Name = "mnuMain";
            this.mnuMain.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.mnuMain.Size = new System.Drawing.Size(614, 60);
            this.mnuMain.TabIndex = 0;
            this.mnuMain.Text = "menuStrip1";
            // 
            // mnuMaster
            // 
            this.mnuMaster.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuMasterProduct,
            this.mnuMasterVendor});
            this.mnuMaster.Image = global::Teori.Properties.Resources.master;
            this.mnuMaster.Name = "mnuMaster";
            this.mnuMaster.Size = new System.Drawing.Size(62, 56);
            // 
            // mnuTransaction
            // 
            this.mnuTransaction.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuTransactionPurchasing,
            this.mnuTransactionSales,
            this.mnuTransactionInventory});
            this.mnuTransaction.Image = global::Teori.Properties.Resources.transaction;
            this.mnuTransaction.Name = "mnuTransaction";
            this.mnuTransaction.Size = new System.Drawing.Size(62, 56);
            // 
            // mnuReport
            // 
            this.mnuReport.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuReportProductList,
            this.mnuReportVendorList,
            this.mnuReportPurchaseReport,
            this.mnuReportSalesReport,
            this.mnuReportInventoryReport});
            this.mnuReport.Image = global::Teori.Properties.Resources.report;
            this.mnuReport.Name = "mnuReport";
            this.mnuReport.Size = new System.Drawing.Size(62, 56);
            // 
            // mnuMasterProduct
            // 
            this.mnuMasterProduct.Image = global::Teori.Properties.Resources.product;
            this.mnuMasterProduct.Name = "mnuMasterProduct";
            this.mnuMasterProduct.Size = new System.Drawing.Size(214, 56);
            this.mnuMasterProduct.Text = "Product";
            // 
            // mnuMasterVendor
            // 
            this.mnuMasterVendor.Image = global::Teori.Properties.Resources.supplier;
            this.mnuMasterVendor.Name = "mnuMasterVendor";
            this.mnuMasterVendor.Size = new System.Drawing.Size(214, 56);
            this.mnuMasterVendor.Text = "Vendor";
            // 
            // mnuTransactionPurchasing
            // 
            this.mnuTransactionPurchasing.Image = global::Teori.Properties.Resources.purchase;
            this.mnuTransactionPurchasing.Name = "mnuTransactionPurchasing";
            this.mnuTransactionPurchasing.Size = new System.Drawing.Size(167, 56);
            this.mnuTransactionPurchasing.Text = "Purchasing";
            // 
            // mnuTransactionSales
            // 
            this.mnuTransactionSales.Image = global::Teori.Properties.Resources.sales;
            this.mnuTransactionSales.Name = "mnuTransactionSales";
            this.mnuTransactionSales.Size = new System.Drawing.Size(167, 56);
            this.mnuTransactionSales.Text = "Sales";
            // 
            // mnuTransactionInventory
            // 
            this.mnuTransactionInventory.Image = global::Teori.Properties.Resources.inventory;
            this.mnuTransactionInventory.Name = "mnuTransactionInventory";
            this.mnuTransactionInventory.Size = new System.Drawing.Size(167, 56);
            this.mnuTransactionInventory.Text = "Inventory";
            // 
            // mnuReportProductList
            // 
            this.mnuReportProductList.Image = global::Teori.Properties.Resources.product_list;
            this.mnuReportProductList.Name = "mnuReportProductList";
            this.mnuReportProductList.Size = new System.Drawing.Size(196, 56);
            this.mnuReportProductList.Text = "Product List";
            // 
            // mnuReportVendorList
            // 
            this.mnuReportVendorList.Image = global::Teori.Properties.Resources.vendor_list;
            this.mnuReportVendorList.Name = "mnuReportVendorList";
            this.mnuReportVendorList.Size = new System.Drawing.Size(196, 56);
            this.mnuReportVendorList.Text = "Vendor List";
            // 
            // mnuReportPurchaseReport
            // 
            this.mnuReportPurchaseReport.Image = global::Teori.Properties.Resources.purchase_report;
            this.mnuReportPurchaseReport.Name = "mnuReportPurchaseReport";
            this.mnuReportPurchaseReport.Size = new System.Drawing.Size(196, 56);
            this.mnuReportPurchaseReport.Text = "Purchase Report";
            // 
            // mnuReportSalesReport
            // 
            this.mnuReportSalesReport.Image = global::Teori.Properties.Resources.sales_report;
            this.mnuReportSalesReport.Name = "mnuReportSalesReport";
            this.mnuReportSalesReport.Size = new System.Drawing.Size(196, 56);
            this.mnuReportSalesReport.Text = "Sales Report";
            // 
            // mnuReportInventoryReport
            // 
            this.mnuReportInventoryReport.Image = global::Teori.Properties.Resources.inventory_report;
            this.mnuReportInventoryReport.Name = "mnuReportInventoryReport";
            this.mnuReportInventoryReport.Size = new System.Drawing.Size(196, 56);
            this.mnuReportInventoryReport.Text = "Inventory Report";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 450);
            this.Controls.Add(this.mnuMain);
            this.Name = "frmMain";
            this.Text = "Logistic";
            this.mnuMain.ResumeLayout(false);
            this.mnuMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuMain;
        private System.Windows.Forms.ToolStripMenuItem mnuMaster;
        private System.Windows.Forms.ToolStripMenuItem mnuTransaction;
        private System.Windows.Forms.ToolStripMenuItem mnuReport;
        private System.Windows.Forms.ToolStripMenuItem mnuMasterProduct;
        private System.Windows.Forms.ToolStripMenuItem mnuMasterVendor;
        private System.Windows.Forms.ToolStripMenuItem mnuTransactionPurchasing;
        private System.Windows.Forms.ToolStripMenuItem mnuTransactionSales;
        private System.Windows.Forms.ToolStripMenuItem mnuTransactionInventory;
        private System.Windows.Forms.ToolStripMenuItem mnuReportProductList;
        private System.Windows.Forms.ToolStripMenuItem mnuReportVendorList;
        private System.Windows.Forms.ToolStripMenuItem mnuReportPurchaseReport;
        private System.Windows.Forms.ToolStripMenuItem mnuReportSalesReport;
        private System.Windows.Forms.ToolStripMenuItem mnuReportInventoryReport;
    }
}

