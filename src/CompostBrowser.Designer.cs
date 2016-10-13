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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CompostBrowser));
            this.CompositionBrowser = new System.Windows.Forms.DataGridView();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openDatabaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveDatabaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeDatabaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.DocumentBrowser = new System.Windows.Forms.DataGridView();
            this.VersionBrowser = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.CompositionBrowser)).BeginInit();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DocumentBrowser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VersionBrowser)).BeginInit();
            this.SuspendLayout();
            // 
            // CompositionBrowser
            // 
            this.CompositionBrowser.AllowUserToAddRows = false;
            this.CompositionBrowser.AllowUserToDeleteRows = false;
            this.CompositionBrowser.AllowUserToOrderColumns = true;
            this.CompositionBrowser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CompositionBrowser.Location = new System.Drawing.Point(12, 57);
            this.CompositionBrowser.MultiSelect = false;
            this.CompositionBrowser.Name = "CompositionBrowser";
            this.CompositionBrowser.RowHeadersVisible = false;
            this.CompositionBrowser.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.CompositionBrowser.Size = new System.Drawing.Size(1560, 372);
            this.CompositionBrowser.TabIndex = 0;
            this.CompositionBrowser.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.OnCellEdited);
            this.CompositionBrowser.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.OnCompositionBrowserRowEnter);
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Controls.Add(this.menuStrip1);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.toolStrip1);
            this.toolStripContainer1.ContentPanel.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(1582, 24);
            this.toolStripContainer1.Location = new System.Drawing.Point(1, 2);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(1582, 49);
            this.toolStripContainer1.TabIndex = 1;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(-5, -1);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(176, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openDatabaseToolStripMenuItem,
            this.saveDatabaseToolStripMenuItem,
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
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(35, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // DocumentBrowser
            // 
            this.DocumentBrowser.AllowUserToAddRows = false;
            this.DocumentBrowser.AllowUserToDeleteRows = false;
            this.DocumentBrowser.AllowUserToOrderColumns = true;
            this.DocumentBrowser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DocumentBrowser.Location = new System.Drawing.Point(12, 437);
            this.DocumentBrowser.MultiSelect = false;
            this.DocumentBrowser.Name = "DocumentBrowser";
            this.DocumentBrowser.RowHeadersVisible = false;
            this.DocumentBrowser.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DocumentBrowser.Size = new System.Drawing.Size(794, 315);
            this.DocumentBrowser.TabIndex = 2;
            this.DocumentBrowser.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.OnCellEdited);
            this.DocumentBrowser.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.OnDocumentBrowserRowEnter);
            // 
            // VersionBrowser
            // 
            this.VersionBrowser.AllowUserToAddRows = false;
            this.VersionBrowser.AllowUserToDeleteRows = false;
            this.VersionBrowser.AllowUserToOrderColumns = true;
            this.VersionBrowser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.VersionBrowser.Location = new System.Drawing.Point(812, 437);
            this.VersionBrowser.MultiSelect = false;
            this.VersionBrowser.Name = "VersionBrowser";
            this.VersionBrowser.RowHeadersVisible = false;
            this.VersionBrowser.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.VersionBrowser.Size = new System.Drawing.Size(760, 315);
            this.VersionBrowser.TabIndex = 3;
            this.VersionBrowser.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.OnCellEdited);
            // 
            // CompostBrowser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1584, 762);
            this.Controls.Add(this.VersionBrowser);
            this.Controls.Add(this.DocumentBrowser);
            this.Controls.Add(this.CompositionBrowser);
            this.Controls.Add(this.toolStripContainer1);
            this.Name = "CompostBrowser";
            this.Text = "CompostBrowser";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OnExit);
            ((System.ComponentModel.ISupportInitialize)(this.CompositionBrowser)).EndInit();
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.ContentPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DocumentBrowser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VersionBrowser)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView CompositionBrowser;
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openDatabaseToolStripMenuItem;
        private System.Windows.Forms.DataGridView DocumentBrowser;
        private System.Windows.Forms.DataGridView VersionBrowser;
        private System.Windows.Forms.ToolStripMenuItem saveDatabaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeDatabaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}