namespace StainedGlassGuild.Compost.GUI
{
    internal partial class CreateExtensionMappingDialog
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
         this.textBox1 = new System.Windows.Forms.TextBox();
         this.label1 = new System.Windows.Forms.Label();
         this.label2 = new System.Windows.Forms.Label();
         this.comboBox1 = new System.Windows.Forms.ComboBox();
         this.typeBindingSource = new System.Windows.Forms.BindingSource(this.components);
         this.button2 = new System.Windows.Forms.Button();
         this.button1 = new System.Windows.Forms.Button();
         ((System.ComponentModel.ISupportInitialize)(this.typeBindingSource)).BeginInit();
         this.SuspendLayout();
         // 
         // textBox1
         // 
         this.textBox1.Location = new System.Drawing.Point(12, 34);
         this.textBox1.Name = "textBox1";
         this.textBox1.Size = new System.Drawing.Size(80, 26);
         this.textBox1.TabIndex = 0;
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Location = new System.Drawing.Point(12, 9);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(79, 20);
         this.label1.TabIndex = 1;
         this.label1.Text = "Extension";
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Location = new System.Drawing.Point(110, 9);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(117, 20);
         this.label2.TabIndex = 2;
         this.label2.Text = "Document type";
         // 
         // comboBox1
         // 
         this.comboBox1.FormattingEnabled = true;
         this.comboBox1.Location = new System.Drawing.Point(114, 34);
         this.comboBox1.Name = "comboBox1";
         this.comboBox1.Size = new System.Drawing.Size(300, 28);
         this.comboBox1.TabIndex = 3;
         // 
         // typeBindingSource
         // 
         this.typeBindingSource.DataSource = typeof(StainedGlassGuild.Compost.DataModel.Composition.Document.Type);
         // 
         // button2
         // 
         this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
         this.button2.Location = new System.Drawing.Point(291, 71);
         this.button2.Name = "button2";
         this.button2.Size = new System.Drawing.Size(123, 42);
         this.button2.TabIndex = 7;
         this.button2.Text = "Cancel";
         this.button2.UseVisualStyleBackColor = true;
         this.button2.Click += new System.EventHandler(this.OnClick_Button_Cancel);
         // 
         // button1
         // 
         this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
         this.button1.Location = new System.Drawing.Point(162, 71);
         this.button1.Name = "button1";
         this.button1.Size = new System.Drawing.Size(123, 42);
         this.button1.TabIndex = 8;
         this.button1.Text = "Ok";
         this.button1.UseVisualStyleBackColor = true;
         this.button1.Click += new System.EventHandler(this.OnClick_Button_Ok);
         // 
         // MapExtensionToDocTypeDialog
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(426, 125);
         this.Controls.Add(this.button1);
         this.Controls.Add(this.button2);
         this.Controls.Add(this.comboBox1);
         this.Controls.Add(this.label2);
         this.Controls.Add(this.label1);
         this.Controls.Add(this.textBox1);
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
         this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
         this.Name = "MapExtensionToDocTypeDialog";
         this.Text = "Map file extension";
         ((System.ComponentModel.ISupportInitialize)(this.typeBindingSource)).EndInit();
         this.ResumeLayout(false);
         this.PerformLayout();

        }

      #endregion

      private System.Windows.Forms.TextBox textBox1;
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.ComboBox comboBox1;
      private System.Windows.Forms.Button button2;
      private System.Windows.Forms.Button button1;
      private System.Windows.Forms.BindingSource typeBindingSource;
   }
}