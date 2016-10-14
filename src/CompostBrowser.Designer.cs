namespace FXGuild.Compost
{
    internal partial class CompostBrowser
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
            this.CompositionBrowser = new System.Windows.Forms.DataGridView();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openDatabaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveDatabaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.multifileCompositionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.closeDatabaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DocumentBrowser = new System.Windows.Forms.DataGridView();
            this.VersionBrowser = new System.Windows.Forms.DataGridView();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            ((System.ComponentModel.ISupportInitialize)(this.CompositionBrowser)).BeginInit();
            this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DocumentBrowser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VersionBrowser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // CompositionBrowser
            // 
            this.CompositionBrowser.AllowUserToAddRows = false;
            this.CompositionBrowser.AllowUserToDeleteRows = false;
            this.CompositionBrowser.AllowUserToOrderColumns = true;
            this.CompositionBrowser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CompositionBrowser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CompositionBrowser.Location = new System.Drawing.Point(12, 9);
            this.CompositionBrowser.MultiSelect = false;
            this.CompositionBrowser.Name = "CompositionBrowser";
            this.CompositionBrowser.RowHeadersVisible = false;
            this.CompositionBrowser.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.CompositionBrowser.Size = new System.Drawing.Size(1563, 361);
            this.CompositionBrowser.TabIndex = 0;
            this.CompositionBrowser.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.OnCellEdited);
            this.CompositionBrowser.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.OnCompositionBrowserRowEnter);
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(1582, 25);
            this.toolStripContainer1.Location = new System.Drawing.Point(1, 2);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(1582, 49);
            this.toolStripContainer1.TabIndex = 1;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.menuStrip1);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1582, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openDatabaseToolStripMenuItem,
            this.saveDatabaseToolStripMenuItem,
            this.importToolStripMenuItem,
            this.toolStripSeparator1,
            this.closeDatabaseToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openDatabaseToolStripMenuItem
            // 
            this.openDatabaseToolStripMenuItem.Name = "openDatabaseToolStripMenuItem";
            this.openDatabaseToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.openDatabaseToolStripMenuItem.Text = "Open database...";
            this.openDatabaseToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.openDatabaseToolStripMenuItem.Click += new System.EventHandler(this.OnFileToolbarOpenDatabase);
            // 
            // saveDatabaseToolStripMenuItem
            // 
            this.saveDatabaseToolStripMenuItem.Name = "saveDatabaseToolStripMenuItem";
            this.saveDatabaseToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.saveDatabaseToolStripMenuItem.Text = "Save database";
            this.saveDatabaseToolStripMenuItem.Click += new System.EventHandler(this.OnFileToolbarSaveDatabase);
            // 
            // importToolStripMenuItem
            // 
            this.importToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.multifileCompositionToolStripMenuItem});
            this.importToolStripMenuItem.Name = "importToolStripMenuItem";
            this.importToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.importToolStripMenuItem.Text = "Import";
            // 
            // multifileCompositionToolStripMenuItem
            // 
            this.multifileCompositionToolStripMenuItem.Name = "multifileCompositionToolStripMenuItem";
            this.multifileCompositionToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.multifileCompositionToolStripMenuItem.Text = "Multifile composition...";
            this.multifileCompositionToolStripMenuItem.Click += new System.EventHandler(this.OnFileToolBarImportMultiFileComposition);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(159, 6);
            // 
            // closeDatabaseToolStripMenuItem
            // 
            this.closeDatabaseToolStripMenuItem.Name = "closeDatabaseToolStripMenuItem";
            this.closeDatabaseToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.closeDatabaseToolStripMenuItem.Text = "Close database";
            this.closeDatabaseToolStripMenuItem.Click += new System.EventHandler(this.OnFileToolbarCloseDatabase);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.OnFileToolbarExit);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // DocumentBrowser
            // 
            this.DocumentBrowser.AllowUserToAddRows = false;
            this.DocumentBrowser.AllowUserToDeleteRows = false;
            this.DocumentBrowser.AllowUserToOrderColumns = true;
            this.DocumentBrowser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DocumentBrowser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DocumentBrowser.Location = new System.Drawing.Point(12, 3);
            this.DocumentBrowser.MultiSelect = false;
            this.DocumentBrowser.Name = "DocumentBrowser";
            this.DocumentBrowser.RowHeadersVisible = false;
            this.DocumentBrowser.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DocumentBrowser.Size = new System.Drawing.Size(776, 347);
            this.DocumentBrowser.TabIndex = 2;
            this.DocumentBrowser.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.OnCellEdited);
            this.DocumentBrowser.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.OnDocumentBrowserRowEnter);
            // 
            // VersionBrowser
            // 
            this.VersionBrowser.AllowUserToAddRows = false;
            this.VersionBrowser.AllowUserToDeleteRows = false;
            this.VersionBrowser.AllowUserToOrderColumns = true;
            this.VersionBrowser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.VersionBrowser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.VersionBrowser.Location = new System.Drawing.Point(3, 3);
            this.VersionBrowser.MultiSelect = false;
            this.VersionBrowser.Name = "VersionBrowser";
            this.VersionBrowser.RowHeadersVisible = false;
            this.VersionBrowser.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.VersionBrowser.Size = new System.Drawing.Size(777, 347);
            this.VersionBrowser.TabIndex = 3;
            this.VersionBrowser.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.OnCellEdited);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(-4, 26);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.CompositionBrowser);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1587, 739);
            this.splitContainer1.SplitterDistance = 373;
            this.splitContainer1.TabIndex = 4;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.DocumentBrowser);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.VersionBrowser);
            this.splitContainer2.Size = new System.Drawing.Size(1587, 362);
            this.splitContainer2.SplitterDistance = 791;
            this.splitContainer2.TabIndex = 0;
            // 
            // CompostBrowser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1584, 762);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.toolStripContainer1);
            this.Name = "CompostBrowser";
            this.Text = "CompostBrowser";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OnExit);
            ((System.ComponentModel.ISupportInitialize)(this.CompositionBrowser)).EndInit();
            this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DocumentBrowser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VersionBrowser)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView CompositionBrowser;
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openDatabaseToolStripMenuItem;
        private System.Windows.Forms.DataGridView DocumentBrowser;
        private System.Windows.Forms.DataGridView VersionBrowser;
        private System.Windows.Forms.ToolStripMenuItem saveDatabaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeDatabaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.ToolStripMenuItem importToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem multifileCompositionToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    }
}