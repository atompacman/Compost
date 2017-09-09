using StainedGlassGuild.Compost.DataModel;
using static StainedGlassGuild.Compost.DataModel.Composition;
using static StainedGlassGuild.Compost.DataModel.Composition.Document;

namespace StainedGlassGuild.Compost.GUI
{
   partial class CompostBrowser
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
         this.components = new System.ComponentModel.Container();
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CompostBrowser));
         System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
         System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
         System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
         this.menuStrip1 = new System.Windows.Forms.MenuStrip();
         this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.openDatabaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
         this.closeDatabaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.panelsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.ToolStripItem_View_ShowHidePanels_Documents = new System.Windows.Forms.ToolStripMenuItem();
         this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
         this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.toolStrip1 = new System.Windows.Forms.ToolStrip();
         this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
         this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
         this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
         this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
         this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
         this.toolStripButton6 = new System.Windows.Forms.ToolStripButton();
         this.splitContainer1 = new System.Windows.Forms.SplitContainer();
         this.groupBox3 = new System.Windows.Forms.GroupBox();
         this.dataGridView1 = new System.Windows.Forms.DataGridView();
         this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.customPropertiesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.newCompositionBindingSource = new System.Windows.Forms.BindingSource(this.components);
         this.splitContainer2 = new System.Windows.Forms.SplitContainer();
         this.groupBox1 = new System.Windows.Forms.GroupBox();
         this.dataGridView2 = new System.Windows.Forms.DataGridView();
         this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.customPropertiesDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.newDocumentBindingSource = new System.Windows.Forms.BindingSource(this.components);
         this.groupBox2 = new System.Windows.Forms.GroupBox();
         this.dataGridView3 = new System.Windows.Forms.DataGridView();
         this.filePathDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.majorVersionNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.minorVersionNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.creationDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.lastModificationDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.customPropertiesDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.newVersionBindingSource = new System.Windows.Forms.BindingSource(this.components);
         this.menuStrip1.SuspendLayout();
         this.toolStrip1.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
         this.splitContainer1.Panel1.SuspendLayout();
         this.splitContainer1.Panel2.SuspendLayout();
         this.splitContainer1.SuspendLayout();
         this.groupBox3.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.newCompositionBindingSource)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
         this.splitContainer2.Panel1.SuspendLayout();
         this.splitContainer2.Panel2.SuspendLayout();
         this.splitContainer2.SuspendLayout();
         this.groupBox1.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.newDocumentBindingSource)).BeginInit();
         this.groupBox2.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.newVersionBindingSource)).BeginInit();
         this.SuspendLayout();
         // 
         // menuStrip1
         // 
         this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
         this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.addToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.helpToolStripMenuItem});
         this.menuStrip1.Location = new System.Drawing.Point(0, 0);
         this.menuStrip1.Name = "menuStrip1";
         this.menuStrip1.Size = new System.Drawing.Size(1578, 33);
         this.menuStrip1.TabIndex = 0;
         this.menuStrip1.Text = "menuStrip1";
         // 
         // fileToolStripMenuItem
         // 
         this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openDatabaseToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.toolStripSeparator1,
            this.closeDatabaseToolStripMenuItem,
            this.exitToolStripMenuItem});
         this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
         this.fileToolStripMenuItem.Size = new System.Drawing.Size(50, 29);
         this.fileToolStripMenuItem.Text = "File";
         // 
         // openDatabaseToolStripMenuItem
         // 
         this.openDatabaseToolStripMenuItem.Name = "openDatabaseToolStripMenuItem";
         this.openDatabaseToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
         this.openDatabaseToolStripMenuItem.Size = new System.Drawing.Size(271, 30);
         this.openDatabaseToolStripMenuItem.Text = "Open library...";
         this.openDatabaseToolStripMenuItem.Click += new System.EventHandler(this.OnClick_MenuStrip_File_OpenLibrary);
         // 
         // saveToolStripMenuItem
         // 
         this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
         this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
         this.saveToolStripMenuItem.Size = new System.Drawing.Size(271, 30);
         this.saveToolStripMenuItem.Text = "Save library";
         this.saveToolStripMenuItem.Click += new System.EventHandler(this.OnClick_MenuStrip_File_SaveLibrary);
         // 
         // toolStripSeparator1
         // 
         this.toolStripSeparator1.Name = "toolStripSeparator1";
         this.toolStripSeparator1.Size = new System.Drawing.Size(268, 6);
         // 
         // closeDatabaseToolStripMenuItem
         // 
         this.closeDatabaseToolStripMenuItem.Enabled = false;
         this.closeDatabaseToolStripMenuItem.Name = "closeDatabaseToolStripMenuItem";
         this.closeDatabaseToolStripMenuItem.Size = new System.Drawing.Size(271, 30);
         this.closeDatabaseToolStripMenuItem.Text = "Close library";
         this.closeDatabaseToolStripMenuItem.Click += new System.EventHandler(this.OnClick_MenuStrip_File_CloseLibrary);
         // 
         // exitToolStripMenuItem
         // 
         this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
         this.exitToolStripMenuItem.Size = new System.Drawing.Size(271, 30);
         this.exitToolStripMenuItem.Text = "Exit";
         this.exitToolStripMenuItem.Click += new System.EventHandler(this.OnClick_MenuStrip_File_Exit);
         // 
         // addToolStripMenuItem
         // 
         this.addToolStripMenuItem.Name = "addToolStripMenuItem";
         this.addToolStripMenuItem.Size = new System.Drawing.Size(58, 29);
         this.addToolStripMenuItem.Text = "Add";
         // 
         // viewToolStripMenuItem
         // 
         this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.panelsToolStripMenuItem});
         this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
         this.viewToolStripMenuItem.Size = new System.Drawing.Size(61, 29);
         this.viewToolStripMenuItem.Text = "View";
         // 
         // panelsToolStripMenuItem
         // 
         this.panelsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripItem_View_ShowHidePanels_Documents,
            this.toolStripMenuItem2});
         this.panelsToolStripMenuItem.Name = "panelsToolStripMenuItem";
         this.panelsToolStripMenuItem.Size = new System.Drawing.Size(230, 30);
         this.panelsToolStripMenuItem.Text = "Show/Hide Panel";
         // 
         // ToolStripItem_View_ShowHidePanels_Documents
         // 
         this.ToolStripItem_View_ShowHidePanels_Documents.Name = "ToolStripItem_View_ShowHidePanels_Documents";
         this.ToolStripItem_View_ShowHidePanels_Documents.Size = new System.Drawing.Size(187, 30);
         this.ToolStripItem_View_ShowHidePanels_Documents.Text = "Documents";
         this.ToolStripItem_View_ShowHidePanels_Documents.Click += new System.EventHandler(this.OnClick_MenuStrip_View_ShowHidePanels_Documents);
         // 
         // toolStripMenuItem2
         // 
         this.toolStripMenuItem2.Name = "toolStripMenuItem2";
         this.toolStripMenuItem2.Size = new System.Drawing.Size(187, 30);
         this.toolStripMenuItem2.Text = "Versions";
         this.toolStripMenuItem2.Click += new System.EventHandler(this.OnClick_MenuStrip_View_ShowHidePanels_Versions);
         // 
         // helpToolStripMenuItem
         // 
         this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
         this.helpToolStripMenuItem.Size = new System.Drawing.Size(61, 29);
         this.helpToolStripMenuItem.Text = "Help";
         // 
         // toolStrip1
         // 
         this.toolStrip1.BackColor = System.Drawing.SystemColors.AppWorkspace;
         this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
         this.toolStrip1.ImageScalingSize = new System.Drawing.Size(36, 36);
         this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripButton3,
            this.toolStripButton4,
            this.toolStripButton5,
            this.toolStripButton6});
         this.toolStrip1.Location = new System.Drawing.Point(9, 33);
         this.toolStrip1.Name = "toolStrip1";
         this.toolStrip1.Size = new System.Drawing.Size(252, 43);
         this.toolStrip1.TabIndex = 1;
         this.toolStrip1.Text = "toolStrip1";
         // 
         // toolStripButton1
         // 
         this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
         this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
         this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
         this.toolStripButton1.Name = "toolStripButton1";
         this.toolStripButton1.Size = new System.Drawing.Size(40, 40);
         this.toolStripButton1.Text = "toolStripButton1";
         // 
         // toolStripButton2
         // 
         this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
         this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
         this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
         this.toolStripButton2.Name = "toolStripButton2";
         this.toolStripButton2.Size = new System.Drawing.Size(40, 40);
         this.toolStripButton2.Text = "toolStripButton2";
         // 
         // toolStripButton3
         // 
         this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
         this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
         this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
         this.toolStripButton3.Name = "toolStripButton3";
         this.toolStripButton3.Size = new System.Drawing.Size(40, 40);
         this.toolStripButton3.Text = "toolStripButton3";
         // 
         // toolStripButton4
         // 
         this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
         this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
         this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
         this.toolStripButton4.Name = "toolStripButton4";
         this.toolStripButton4.Size = new System.Drawing.Size(40, 40);
         this.toolStripButton4.Text = "toolStripButton4";
         // 
         // toolStripButton5
         // 
         this.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
         this.toolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton5.Image")));
         this.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
         this.toolStripButton5.Name = "toolStripButton5";
         this.toolStripButton5.Size = new System.Drawing.Size(40, 40);
         this.toolStripButton5.Text = "toolStripButton5";
         // 
         // toolStripButton6
         // 
         this.toolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
         this.toolStripButton6.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton6.Image")));
         this.toolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta;
         this.toolStripButton6.Name = "toolStripButton6";
         this.toolStripButton6.Size = new System.Drawing.Size(40, 40);
         this.toolStripButton6.Text = "toolStripButton6";
         // 
         // splitContainer1
         // 
         this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.splitContainer1.BackColor = System.Drawing.SystemColors.Control;
         this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
         this.splitContainer1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
         this.splitContainer1.Location = new System.Drawing.Point(-1, 22);
         this.splitContainer1.Margin = new System.Windows.Forms.Padding(300);
         this.splitContainer1.Name = "splitContainer1";
         this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
         // 
         // splitContainer1.Panel1
         // 
         this.splitContainer1.Panel1.Controls.Add(this.groupBox3);
         this.splitContainer1.Panel1MinSize = 200;
         // 
         // splitContainer1.Panel2
         // 
         this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
         this.splitContainer1.Panel2MinSize = 200;
         this.splitContainer1.Size = new System.Drawing.Size(1584, 925);
         this.splitContainer1.SplitterDistance = 552;
         this.splitContainer1.TabIndex = 2;
         // 
         // groupBox3
         // 
         this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.groupBox3.Controls.Add(this.dataGridView1);
         this.groupBox3.Enabled = false;
         this.groupBox3.Location = new System.Drawing.Point(12, 56);
         this.groupBox3.Name = "groupBox3";
         this.groupBox3.Size = new System.Drawing.Size(1554, 482);
         this.groupBox3.TabIndex = 0;
         this.groupBox3.TabStop = false;
         this.groupBox3.Text = "Compositions";
         // 
         // dataGridView1
         // 
         this.dataGridView1.AllowUserToAddRows = false;
         this.dataGridView1.AllowUserToOrderColumns = true;
         this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.dataGridView1.AutoGenerateColumns = false;
         this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
         this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
         this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.titleDataGridViewTextBoxColumn,
            this.customPropertiesDataGridViewTextBoxColumn});
         this.dataGridView1.DataSource = this.newCompositionBindingSource;
         dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
         dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
         dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
         dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
         dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
         dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
         this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
         this.dataGridView1.Enabled = false;
         this.dataGridView1.Location = new System.Drawing.Point(15, 25);
         this.dataGridView1.Margin = new System.Windows.Forms.Padding(0);
         this.dataGridView1.MultiSelect = false;
         this.dataGridView1.Name = "dataGridView1";
         this.dataGridView1.RowTemplate.Height = 28;
         this.dataGridView1.Size = new System.Drawing.Size(1524, 441);
         this.dataGridView1.TabIndex = 0;
         this.dataGridView1.VirtualMode = true;
         this.dataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.OnCellValueChanged);
         this.dataGridView1.CellValueNeeded += new System.Windows.Forms.DataGridViewCellValueEventHandler(this.OnCellValueNeeded_Compositions);
         this.dataGridView1.CellValuePushed += new System.Windows.Forms.DataGridViewCellValueEventHandler(this.OnCellValuePushed_Compositions);
         this.dataGridView1.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.OnRowEnter_Compositions);
         // 
         // titleDataGridViewTextBoxColumn
         // 
         this.titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
         this.titleDataGridViewTextBoxColumn.HeaderText = "Title";
         this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
         // 
         // customPropertiesDataGridViewTextBoxColumn
         // 
         this.customPropertiesDataGridViewTextBoxColumn.DataPropertyName = "CustomProperties";
         this.customPropertiesDataGridViewTextBoxColumn.HeaderText = "CustomProperties";
         this.customPropertiesDataGridViewTextBoxColumn.Name = "customPropertiesDataGridViewTextBoxColumn";
         // 
         // newCompositionBindingSource
         // 
         this.newCompositionBindingSource.DataSource = typeof(Composition);
         // 
         // splitContainer2
         // 
         this.splitContainer2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
         this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
         this.splitContainer2.Location = new System.Drawing.Point(0, 0);
         this.splitContainer2.Name = "splitContainer2";
         // 
         // splitContainer2.Panel1
         // 
         this.splitContainer2.Panel1.Controls.Add(this.groupBox1);
         this.splitContainer2.Panel1MinSize = 400;
         // 
         // splitContainer2.Panel2
         // 
         this.splitContainer2.Panel2.Controls.Add(this.groupBox2);
         this.splitContainer2.Panel2MinSize = 400;
         this.splitContainer2.Size = new System.Drawing.Size(1584, 369);
         this.splitContainer2.SplitterDistance = 917;
         this.splitContainer2.TabIndex = 0;
         // 
         // groupBox1
         // 
         this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.groupBox1.Controls.Add(this.dataGridView2);
         this.groupBox1.Enabled = false;
         this.groupBox1.Location = new System.Drawing.Point(12, 3);
         this.groupBox1.Name = "groupBox1";
         this.groupBox1.Size = new System.Drawing.Size(891, 350);
         this.groupBox1.TabIndex = 0;
         this.groupBox1.TabStop = false;
         this.groupBox1.Text = "Documents";
         // 
         // dataGridView2
         // 
         this.dataGridView2.AllowUserToAddRows = false;
         this.dataGridView2.AllowUserToOrderColumns = true;
         this.dataGridView2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.dataGridView2.AutoGenerateColumns = false;
         this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
         this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
         this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.typeDataGridViewTextBoxColumn,
            this.customPropertiesDataGridViewTextBoxColumn2});
         this.dataGridView2.DataSource = this.newDocumentBindingSource;
         dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
         dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
         dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
         dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
         dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
         dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
         this.dataGridView2.DefaultCellStyle = dataGridViewCellStyle2;
         this.dataGridView2.Enabled = false;
         this.dataGridView2.Location = new System.Drawing.Point(15, 25);
         this.dataGridView2.MultiSelect = false;
         this.dataGridView2.Name = "dataGridView2";
         this.dataGridView2.RowTemplate.Height = 28;
         this.dataGridView2.Size = new System.Drawing.Size(862, 310);
         this.dataGridView2.TabIndex = 0;
         this.dataGridView2.VirtualMode = true;
         this.dataGridView2.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.OnCellValueChanged);
         this.dataGridView2.CellValueNeeded += new System.Windows.Forms.DataGridViewCellValueEventHandler(this.OnCellValueNeeded_Documents);
         this.dataGridView2.CellValuePushed += new System.Windows.Forms.DataGridViewCellValueEventHandler(this.OnCellValuePushed_Documents);
         this.dataGridView2.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.OnRowEnter_Documents);
         // 
         // typeDataGridViewTextBoxColumn
         // 
         this.typeDataGridViewTextBoxColumn.DataPropertyName = "Type";
         this.typeDataGridViewTextBoxColumn.HeaderText = "Type";
         this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
         // 
         // customPropertiesDataGridViewTextBoxColumn2
         // 
         this.customPropertiesDataGridViewTextBoxColumn2.DataPropertyName = "CustomProperties";
         this.customPropertiesDataGridViewTextBoxColumn2.HeaderText = "CustomProperties";
         this.customPropertiesDataGridViewTextBoxColumn2.Name = "customPropertiesDataGridViewTextBoxColumn2";
         // 
         // newDocumentBindingSource
         // 
         this.newDocumentBindingSource.DataSource = typeof(Document);
         // 
         // groupBox2
         // 
         this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.groupBox2.Controls.Add(this.dataGridView3);
         this.groupBox2.Enabled = false;
         this.groupBox2.Location = new System.Drawing.Point(13, 3);
         this.groupBox2.Name = "groupBox2";
         this.groupBox2.Size = new System.Drawing.Size(632, 350);
         this.groupBox2.TabIndex = 0;
         this.groupBox2.TabStop = false;
         this.groupBox2.Text = "Versions";
         // 
         // dataGridView3
         // 
         this.dataGridView3.AllowUserToAddRows = false;
         this.dataGridView3.AllowUserToOrderColumns = true;
         this.dataGridView3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.dataGridView3.AutoGenerateColumns = false;
         this.dataGridView3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
         this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
         this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.filePathDataGridViewTextBoxColumn,
            this.majorVersionNumberDataGridViewTextBoxColumn,
            this.minorVersionNumberDataGridViewTextBoxColumn,
            this.creationDateDataGridViewTextBoxColumn,
            this.lastModificationDateDataGridViewTextBoxColumn,
            this.customPropertiesDataGridViewTextBoxColumn1});
         this.dataGridView3.DataSource = this.newVersionBindingSource;
         dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
         dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
         dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ActiveCaption;
         dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
         dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
         dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
         this.dataGridView3.DefaultCellStyle = dataGridViewCellStyle3;
         this.dataGridView3.Enabled = false;
         this.dataGridView3.Location = new System.Drawing.Point(15, 25);
         this.dataGridView3.MultiSelect = false;
         this.dataGridView3.Name = "dataGridView3";
         this.dataGridView3.RowTemplate.Height = 28;
         this.dataGridView3.Size = new System.Drawing.Size(602, 310);
         this.dataGridView3.TabIndex = 0;
         this.dataGridView3.VirtualMode = true;
         this.dataGridView3.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.OnCellValueChanged);
         this.dataGridView3.CellValueNeeded += new System.Windows.Forms.DataGridViewCellValueEventHandler(this.OnCellValueNeeded_Versions);
         this.dataGridView3.CellValuePushed += new System.Windows.Forms.DataGridViewCellValueEventHandler(this.OnCellValuePushed_Versions);
         // 
         // filePathDataGridViewTextBoxColumn
         // 
         this.filePathDataGridViewTextBoxColumn.DataPropertyName = "FilePath";
         this.filePathDataGridViewTextBoxColumn.HeaderText = "FilePath";
         this.filePathDataGridViewTextBoxColumn.Name = "filePathDataGridViewTextBoxColumn";
         // 
         // majorVersionNumberDataGridViewTextBoxColumn
         // 
         this.majorVersionNumberDataGridViewTextBoxColumn.DataPropertyName = "MajorVersionNumber";
         this.majorVersionNumberDataGridViewTextBoxColumn.HeaderText = "MajorVersionNumber";
         this.majorVersionNumberDataGridViewTextBoxColumn.Name = "majorVersionNumberDataGridViewTextBoxColumn";
         // 
         // minorVersionNumberDataGridViewTextBoxColumn
         // 
         this.minorVersionNumberDataGridViewTextBoxColumn.DataPropertyName = "MinorVersionNumber";
         this.minorVersionNumberDataGridViewTextBoxColumn.HeaderText = "MinorVersionNumber";
         this.minorVersionNumberDataGridViewTextBoxColumn.Name = "minorVersionNumberDataGridViewTextBoxColumn";
         // 
         // creationDateDataGridViewTextBoxColumn
         // 
         this.creationDateDataGridViewTextBoxColumn.DataPropertyName = "CreationDate";
         this.creationDateDataGridViewTextBoxColumn.HeaderText = "CreationDate";
         this.creationDateDataGridViewTextBoxColumn.Name = "creationDateDataGridViewTextBoxColumn";
         // 
         // lastModificationDateDataGridViewTextBoxColumn
         // 
         this.lastModificationDateDataGridViewTextBoxColumn.DataPropertyName = "LastModificationDate";
         this.lastModificationDateDataGridViewTextBoxColumn.HeaderText = "LastModificationDate";
         this.lastModificationDateDataGridViewTextBoxColumn.Name = "lastModificationDateDataGridViewTextBoxColumn";
         // 
         // customPropertiesDataGridViewTextBoxColumn1
         // 
         this.customPropertiesDataGridViewTextBoxColumn1.DataPropertyName = "CustomProperties";
         this.customPropertiesDataGridViewTextBoxColumn1.HeaderText = "CustomProperties";
         this.customPropertiesDataGridViewTextBoxColumn1.Name = "customPropertiesDataGridViewTextBoxColumn1";
         // 
         // newVersionBindingSource
         // 
         this.newVersionBindingSource.DataSource = typeof(Version);
         // 
         // CompostBrowser
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
         this.ClientSize = new System.Drawing.Size(1578, 944);
         this.Controls.Add(this.toolStrip1);
         this.Controls.Add(this.menuStrip1);
         this.Controls.Add(this.splitContainer1);
         this.MainMenuStrip = this.menuStrip1;
         this.Name = "CompostBrowser";
         this.Text = "Compost";
         this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OnClosing);
         this.menuStrip1.ResumeLayout(false);
         this.menuStrip1.PerformLayout();
         this.toolStrip1.ResumeLayout(false);
         this.toolStrip1.PerformLayout();
         this.splitContainer1.Panel1.ResumeLayout(false);
         this.splitContainer1.Panel2.ResumeLayout(false);
         ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
         this.splitContainer1.ResumeLayout(false);
         this.groupBox3.ResumeLayout(false);
         ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.newCompositionBindingSource)).EndInit();
         this.splitContainer2.Panel1.ResumeLayout(false);
         this.splitContainer2.Panel2.ResumeLayout(false);
         ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
         this.splitContainer2.ResumeLayout(false);
         this.groupBox1.ResumeLayout(false);
         ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.newDocumentBindingSource)).EndInit();
         this.groupBox2.ResumeLayout(false);
         ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.newVersionBindingSource)).EndInit();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.MenuStrip menuStrip1;
      private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
      private System.Windows.Forms.ToolStrip toolStrip1;
      private System.Windows.Forms.ToolStripButton toolStripButton1;
      private System.Windows.Forms.SplitContainer splitContainer1;
      private System.Windows.Forms.SplitContainer splitContainer2;
      private System.Windows.Forms.GroupBox groupBox1;
      private System.Windows.Forms.GroupBox groupBox3;
      private System.Windows.Forms.GroupBox groupBox2;
      private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
      private System.Windows.Forms.ToolStripButton toolStripButton2;
      private System.Windows.Forms.ToolStripButton toolStripButton3;
      private System.Windows.Forms.ToolStripButton toolStripButton4;
      private System.Windows.Forms.ToolStripButton toolStripButton5;
      private System.Windows.Forms.ToolStripButton toolStripButton6;
      private System.Windows.Forms.DataGridView dataGridView1;
      private System.Windows.Forms.DataGridView dataGridView2;
      private System.Windows.Forms.DataGridView dataGridView3;
      private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem panelsToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem ToolStripItem_View_ShowHidePanels_Documents;
      private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
      private System.Windows.Forms.ToolStripMenuItem openDatabaseToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem closeDatabaseToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
      private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
      private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
      private System.Windows.Forms.BindingSource newCompositionBindingSource;
      private System.Windows.Forms.BindingSource newDocumentBindingSource;
      private System.Windows.Forms.BindingSource newVersionBindingSource;
      private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
      private System.Windows.Forms.DataGridViewTextBoxColumn customPropertiesDataGridViewTextBoxColumn;
      private System.Windows.Forms.DataGridViewTextBoxColumn customPropertyDataGridViewTextBoxColumn;
      private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
      private System.Windows.Forms.DataGridViewTextBoxColumn customPropertiesDataGridViewTextBoxColumn2;
      private System.Windows.Forms.DataGridViewTextBoxColumn filePathDataGridViewTextBoxColumn;
      private System.Windows.Forms.DataGridViewTextBoxColumn majorVersionNumberDataGridViewTextBoxColumn;
      private System.Windows.Forms.DataGridViewTextBoxColumn minorVersionNumberDataGridViewTextBoxColumn;
      private System.Windows.Forms.DataGridViewTextBoxColumn creationDateDataGridViewTextBoxColumn;
      private System.Windows.Forms.DataGridViewTextBoxColumn lastModificationDateDataGridViewTextBoxColumn;
      private System.Windows.Forms.DataGridViewTextBoxColumn customPropertiesDataGridViewTextBoxColumn1;
   }
}