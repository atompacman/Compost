// - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
// MIT License
// Copyright (c) 2017 Stained Glass Guild
// See file "LICENSE.txt" at project root for complete license
// ~   ~   ~   ~   ~   ~   ~   ~   ~   ~   ~   ~   ~   ~   ~   ~   ~   ~   ~   ~   ~   ~   ~   ~   ~
// Project: Compost
// File: CreateExtensionMappingDialog.cs
// Creation: 2017-09
// Author: Jérémie Coulombe
// - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -

using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Forms;

using static StainedGlassGuild.Compost.DataModel.Composition;

namespace StainedGlassGuild.Compost.GUI
{
   internal partial class CreateExtensionMappingDialog : Form
   {
      #region Properties

      public KeyValuePair<string, Document.Type>? NewExtensionMapping { get; private set; }

      #endregion

      #region Constructors

      public CreateExtensionMappingDialog()
      {
         InitializeComponent();

         comboBox1.DataSource = Enum.GetNames(typeof(Document.Type));
         comboBox1.SelectedItem = Document.Type.SOFTWARE_PARTITION;

         NewExtensionMapping = null;
      }

      public CreateExtensionMappingDialog(string a_Ext) : this()
      {
         textBox1.Text = a_Ext;
         textBox1.ReadOnly = true;
         textBox1.Enabled = false;
      }

      #endregion

      #region Methods

      private void OnClick_Button_Cancel(object a_Sender, EventArgs a_E)
      {
         Close();
      }

      private void OnClick_Button_Ok(object a_Sender, EventArgs a_E)
      {
         string ext = textBox1.Text;

         if (ext.StartsWith("."))
         {
            ext = ext.Substring(1);
         }

         if (!Regex.IsMatch(ext, "^[a-zA-Z0-9_]*$"))
         {
            MessageBox.Show("File extension \"" + ext + "\" is not valid.",
               "Invalid file extension", MessageBoxButtons.OK);
            return;
         }
         
         if (!Enum.TryParse(comboBox1.SelectedItem.ToString(), out Document.Type docType))
         {
            return;
         }

         NewExtensionMapping = new KeyValuePair<string, Document.Type>(ext, docType);

         Close();
      }

      #endregion
   }
}
