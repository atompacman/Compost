namespace StainedGlassGuild.Compost.GUI
{
    internal partial class EditLibraryConfigurationDialog
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
         this.textBox1 = new System.Windows.Forms.TextBox();
         this.listView1 = new System.Windows.Forms.ListView();
         this.button1 = new System.Windows.Forms.Button();
         this.groupBox1 = new System.Windows.Forms.GroupBox();
         this.groupBox2 = new System.Windows.Forms.GroupBox();
         this.button4 = new System.Windows.Forms.Button();
         this.button2 = new System.Windows.Forms.Button();
         this.button3 = new System.Windows.Forms.Button();
         this.groupBox1.SuspendLayout();
         this.groupBox2.SuspendLayout();
         this.SuspendLayout();
         // 
         // textBox1
         // 
         this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.textBox1.Location = new System.Drawing.Point(7, 27);
         this.textBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
         this.textBox1.Name = "textBox1";
         this.textBox1.Size = new System.Drawing.Size(981, 26);
         this.textBox1.TabIndex = 1;
         // 
         // listView1
         // 
         this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.listView1.Location = new System.Drawing.Point(7, 27);
         this.listView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
         this.listView1.Name = "listView1";
         this.listView1.Size = new System.Drawing.Size(981, 192);
         this.listView1.TabIndex = 3;
         this.listView1.TileSize = new System.Drawing.Size(75, 20);
         this.listView1.UseCompatibleStateImageBehavior = false;
         this.listView1.View = System.Windows.Forms.View.Tile;
         this.listView1.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.ItemSelectionChanged_ExtensionBox);
         // 
         // button1
         // 
         this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
         this.button1.Location = new System.Drawing.Point(7, 229);
         this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
         this.button1.Name = "button1";
         this.button1.Size = new System.Drawing.Size(123, 42);
         this.button1.TabIndex = 4;
         this.button1.Text = "Add";
         this.button1.UseVisualStyleBackColor = true;
         this.button1.Click += new System.EventHandler(this.OnClick_Button_AddExtension);
         // 
         // groupBox1
         // 
         this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.groupBox1.Controls.Add(this.textBox1);
         this.groupBox1.Location = new System.Drawing.Point(12, 12);
         this.groupBox1.MinimumSize = new System.Drawing.Size(0, 66);
         this.groupBox1.Name = "groupBox1";
         this.groupBox1.Size = new System.Drawing.Size(995, 66);
         this.groupBox1.TabIndex = 5;
         this.groupBox1.TabStop = false;
         this.groupBox1.Text = "Library name";
         // 
         // groupBox2
         // 
         this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.groupBox2.Controls.Add(this.button4);
         this.groupBox2.Controls.Add(this.listView1);
         this.groupBox2.Controls.Add(this.button1);
         this.groupBox2.Location = new System.Drawing.Point(12, 84);
         this.groupBox2.MinimumSize = new System.Drawing.Size(0, 212);
         this.groupBox2.Name = "groupBox2";
         this.groupBox2.Size = new System.Drawing.Size(995, 279);
         this.groupBox2.TabIndex = 6;
         this.groupBox2.TabStop = false;
         this.groupBox2.Text = "Document types";
         // 
         // button4
         // 
         this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
         this.button4.Enabled = false;
         this.button4.Location = new System.Drawing.Point(138, 229);
         this.button4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
         this.button4.Name = "button4";
         this.button4.Size = new System.Drawing.Size(123, 42);
         this.button4.TabIndex = 5;
         this.button4.Text = "Remove";
         this.button4.UseVisualStyleBackColor = true;
         this.button4.Click += new System.EventHandler(this.OnClick_Button_Remove);
         // 
         // button2
         // 
         this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
         this.button2.Location = new System.Drawing.Point(884, 640);
         this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
         this.button2.Name = "button2";
         this.button2.Size = new System.Drawing.Size(123, 42);
         this.button2.TabIndex = 5;
         this.button2.Text = "Cancel";
         this.button2.UseVisualStyleBackColor = true;
         this.button2.Click += new System.EventHandler(this.OnClick_Button_Cancel);
         // 
         // button3
         // 
         this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
         this.button3.Location = new System.Drawing.Point(753, 640);
         this.button3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
         this.button3.Name = "button3";
         this.button3.Size = new System.Drawing.Size(123, 42);
         this.button3.TabIndex = 7;
         this.button3.Text = "Ok";
         this.button3.UseVisualStyleBackColor = true;
         this.button3.Click += new System.EventHandler(this.OnClick_Button_Ok);
         // 
         // EditLibraryConfigurationDialog
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(1019, 696);
         this.Controls.Add(this.button3);
         this.Controls.Add(this.button2);
         this.Controls.Add(this.groupBox2);
         this.Controls.Add(this.groupBox1);
         this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
         this.MinimumSize = new System.Drawing.Size(300, 418);
         this.Name = "EditLibraryConfigurationDialog";
         this.Text = "Library Configuration";
         this.groupBox1.ResumeLayout(false);
         this.groupBox1.PerformLayout();
         this.groupBox2.ResumeLayout(false);
         this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button button1;
      private System.Windows.Forms.GroupBox groupBox1;
      private System.Windows.Forms.GroupBox groupBox2;
      private System.Windows.Forms.Button button2;
      private System.Windows.Forms.Button button3;
      private System.Windows.Forms.Button button4;
   }
}