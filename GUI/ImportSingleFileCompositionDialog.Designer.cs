namespace StainedGlassGuild.Compost.GUI
{
   partial class ImportSingleFileCompositionDialog
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
         this.button4 = new System.Windows.Forms.Button();
         this.textBox1 = new System.Windows.Forms.TextBox();
         this.panel1 = new System.Windows.Forms.Panel();
         this.groupBox2 = new System.Windows.Forms.GroupBox();
         this.button2 = new System.Windows.Forms.Button();
         this.button3 = new System.Windows.Forms.Button();
         this.groupBox1.SuspendLayout();
         this.groupBox2.SuspendLayout();
         this.SuspendLayout();
         // 
         // groupBox1
         // 
         this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.groupBox1.Controls.Add(this.button4);
         this.groupBox1.Controls.Add(this.textBox1);
         this.groupBox1.Location = new System.Drawing.Point(12, 12);
         this.groupBox1.Name = "groupBox1";
         this.groupBox1.Size = new System.Drawing.Size(1112, 80);
         this.groupBox1.TabIndex = 2;
         this.groupBox1.TabStop = false;
         this.groupBox1.Text = "Step 1: Select file";
         // 
         // button4
         // 
         this.button4.Location = new System.Drawing.Point(6, 25);
         this.button4.Name = "button4";
         this.button4.Size = new System.Drawing.Size(123, 42);
         this.button4.TabIndex = 7;
         this.button4.Text = "Select file...";
         this.button4.UseVisualStyleBackColor = true;
         this.button4.Click += new System.EventHandler(this.OnClick_Button_OpenFile);
         // 
         // textBox1
         // 
         this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.textBox1.Location = new System.Drawing.Point(135, 33);
         this.textBox1.Name = "textBox1";
         this.textBox1.Size = new System.Drawing.Size(971, 26);
         this.textBox1.TabIndex = 1;
         this.textBox1.TextChanged += new System.EventHandler(this.OnTextChanged_TextBox1);
         // 
         // panel1
         // 
         this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
         this.panel1.Location = new System.Drawing.Point(3, 22);
         this.panel1.Name = "panel1";
         this.panel1.Size = new System.Drawing.Size(1106, 456);
         this.panel1.TabIndex = 3;
         // 
         // groupBox2
         // 
         this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.groupBox2.Controls.Add(this.panel1);
         this.groupBox2.Location = new System.Drawing.Point(12, 98);
         this.groupBox2.Name = "groupBox2";
         this.groupBox2.Size = new System.Drawing.Size(1112, 481);
         this.groupBox2.TabIndex = 4;
         this.groupBox2.TabStop = false;
         this.groupBox2.Text = "Step 2: Enter information";
         // 
         // button2
         // 
         this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
         this.button2.Location = new System.Drawing.Point(1001, 585);
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
         this.button3.Enabled = false;
         this.button3.Location = new System.Drawing.Point(872, 585);
         this.button3.Name = "button3";
         this.button3.Size = new System.Drawing.Size(123, 42);
         this.button3.TabIndex = 6;
         this.button3.Text = "Ok";
         this.button3.UseVisualStyleBackColor = true;
         this.button3.Click += new System.EventHandler(this.OnClick_Button_Ok);
         // 
         // ImportSingleFileCompositionDialog
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(1136, 639);
         this.Controls.Add(this.button3);
         this.Controls.Add(this.button2);
         this.Controls.Add(this.groupBox2);
         this.Controls.Add(this.groupBox1);
         this.MinimumSize = new System.Drawing.Size(500, 400);
         this.Name = "ImportSingleFileCompositionDialog";
         this.Text = "Import Composition - Single File";
         this.groupBox1.ResumeLayout(false);
         this.groupBox1.PerformLayout();
         this.groupBox2.ResumeLayout(false);
         this.ResumeLayout(false);

      }

      #endregion

      private System.Windows.Forms.GroupBox groupBox1;
      private System.Windows.Forms.Button button4;
      private System.Windows.Forms.TextBox textBox1;
      private System.Windows.Forms.Panel panel1;
      private System.Windows.Forms.GroupBox groupBox2;
      private System.Windows.Forms.Button button2;
      private System.Windows.Forms.Button button3;
   }
}