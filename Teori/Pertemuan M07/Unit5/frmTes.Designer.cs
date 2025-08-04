
namespace Unit5
{
    partial class frmTes
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileNew = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileSave = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFormat = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEditCut = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEditCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEditPaste = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFormatBold = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFormatIltalic = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFormatUnderline = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFormatSize = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile,
            this.mnuEdit,
            this.mnuFormat});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuFile
            // 
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFileNew,
            this.mnuFileOpen,
            this.mnuFileSave,
            this.mnuFileExit});
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(37, 20);
            this.mnuFile.Text = "&File";
            // 
            // mnuFileNew
            // 
            this.mnuFileNew.Name = "mnuFileNew";
            this.mnuFileNew.Size = new System.Drawing.Size(180, 22);
            this.mnuFileNew.Text = "&New";
            this.mnuFileNew.Click += new System.EventHandler(this.newToolStripMenuItem1_Click);
            // 
            // mnuFileOpen
            // 
            this.mnuFileOpen.Name = "mnuFileOpen";
            this.mnuFileOpen.Size = new System.Drawing.Size(180, 22);
            this.mnuFileOpen.Text = "&Open";
            // 
            // mnuFileSave
            // 
            this.mnuFileSave.Name = "mnuFileSave";
            this.mnuFileSave.Size = new System.Drawing.Size(180, 22);
            this.mnuFileSave.Text = "&Save";
            // 
            // mnuFileExit
            // 
            this.mnuFileExit.Name = "mnuFileExit";
            this.mnuFileExit.Size = new System.Drawing.Size(180, 22);
            this.mnuFileExit.Text = "&Exit";
            // 
            // mnuEdit
            // 
            this.mnuEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuEditCut,
            this.mnuEditCopy,
            this.mnuEditPaste});
            this.mnuEdit.Name = "mnuEdit";
            this.mnuEdit.Size = new System.Drawing.Size(39, 20);
            this.mnuEdit.Text = "&Edit";
            // 
            // mnuFormat
            // 
            this.mnuFormat.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFormatBold,
            this.mnuFormatIltalic,
            this.mnuFormatUnderline,
            this.mnuFormatSize});
            this.mnuFormat.Name = "mnuFormat";
            this.mnuFormat.Size = new System.Drawing.Size(57, 20);
            this.mnuFormat.Text = "F&ormat";
            this.mnuFormat.Click += new System.EventHandler(this.mnuFormat_Click);
            // 
            // mnuEditCut
            // 
            this.mnuEditCut.Name = "mnuEditCut";
            this.mnuEditCut.Size = new System.Drawing.Size(180, 22);
            this.mnuEditCut.Text = "Cu&t";
            // 
            // mnuEditCopy
            // 
            this.mnuEditCopy.Name = "mnuEditCopy";
            this.mnuEditCopy.Size = new System.Drawing.Size(180, 22);
            this.mnuEditCopy.Text = "&Copy";
            // 
            // mnuEditPaste
            // 
            this.mnuEditPaste.Name = "mnuEditPaste";
            this.mnuEditPaste.Size = new System.Drawing.Size(180, 22);
            this.mnuEditPaste.Text = "&Paste";
            this.mnuEditPaste.Click += new System.EventHandler(this.pasteToolStripMenuItem_Click);
            // 
            // mnuFormatBold
            // 
            this.mnuFormatBold.Name = "mnuFormatBold";
            this.mnuFormatBold.Size = new System.Drawing.Size(180, 22);
            this.mnuFormatBold.Text = "&Bold";
            // 
            // mnuFormatIltalic
            // 
            this.mnuFormatIltalic.Name = "mnuFormatIltalic";
            this.mnuFormatIltalic.Size = new System.Drawing.Size(180, 22);
            this.mnuFormatIltalic.Text = "&Italic";
            // 
            // mnuFormatUnderline
            // 
            this.mnuFormatUnderline.Name = "mnuFormatUnderline";
            this.mnuFormatUnderline.Size = new System.Drawing.Size(180, 22);
            this.mnuFormatUnderline.Text = "&Underline";
            // 
            // mnuFormatSize
            // 
            this.mnuFormatSize.Name = "mnuFormatSize";
            this.mnuFormatSize.Size = new System.Drawing.Size(180, 22);
            this.mnuFormatSize.Text = "&Size";
            // 
            // frmTes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmTes";
            this.Text = "Form2";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.ToolStripMenuItem mnuFileNew;
        private System.Windows.Forms.ToolStripMenuItem mnuFileOpen;
        private System.Windows.Forms.ToolStripMenuItem mnuFileSave;
        private System.Windows.Forms.ToolStripMenuItem mnuFileExit;
        private System.Windows.Forms.ToolStripMenuItem mnuEdit;
        private System.Windows.Forms.ToolStripMenuItem mnuEditCut;
        private System.Windows.Forms.ToolStripMenuItem mnuEditCopy;
        private System.Windows.Forms.ToolStripMenuItem mnuEditPaste;
        private System.Windows.Forms.ToolStripMenuItem mnuFormat;
        private System.Windows.Forms.ToolStripMenuItem mnuFormatBold;
        private System.Windows.Forms.ToolStripMenuItem mnuFormatIltalic;
        private System.Windows.Forms.ToolStripMenuItem mnuFormatUnderline;
        private System.Windows.Forms.ToolStripMenuItem mnuFormatSize;
    }
}