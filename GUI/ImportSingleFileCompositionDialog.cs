// - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
// MIT License
// Copyright (c) 2017 Stained Glass Guild
// See file "LICENSE.txt" at project root for complete license
// ~   ~   ~   ~   ~   ~   ~   ~   ~   ~   ~   ~   ~   ~   ~   ~   ~   ~   ~   ~   ~   ~   ~   ~   ~
// Project: Compost
// File: ImportSingleFileCompositionDialog.cs
// Creation: 2017-09
// Author: Jérémie Coulombe
// - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -

using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

using StainedGlassGuild.Compost.DataModel;

namespace StainedGlassGuild.Compost.GUI
{
   public partial class ImportSingleFileCompositionDialog : Form
   {
      #region Private fields

      private KeyValuePair<string, Composition.Document.Type>? m_NewExtensionMapping;

      #endregion

      #region Constructors

      public ImportSingleFileCompositionDialog()
      {
         InitializeComponent();
         m_NewExtensionMapping = null;
      }

      #endregion

      #region Methods

      private void OnClick_Button_OpenFile(object a_Sender, EventArgs a_E)
      {
         var dialog = new OpenFileDialog();
         dialog.ShowDialog();

         if (dialog.FileName.Length != 0)
         {
            textBox1.Text = dialog.FileName;
         }
      }

      private void OnTextChanged_TextBox1(object a_Sender, EventArgs a_E)
      {
         string filePath = textBox1.Text;

         if (!File.Exists(filePath))
         {
            textBox1.ForeColor = Color.Red;
            return;
         }

         textBox1.ForeColor = Color.Black;

         string ext = Path.GetExtension(filePath)?.Substring(1);

         var extMap = CompostBrowser.Instance.CurrentLibrary.ExtensionMappings;

         if (ext != null && !extMap.ContainsKey(ext))
         {
            var result = MessageBox.Show("File extension \"" + ext + "\" was not found in the " +
                                         "library configuration. It must be mapped to a document " +
                                         " type to continue importation.",
               "Unknown file extension", MessageBoxButtons.OKCancel);

            if (result == DialogResult.OK)
            {
               var dialog = new CreateExtensionMappingDialog(ext);
               dialog.ShowDialog();
               if (dialog.NewExtensionMapping.HasValue)
               {
                  m_NewExtensionMapping = dialog.NewExtensionMapping;
               }
               else
               {
                  textBox1.Text = string.Empty;
               }
            }
            else
            {
               textBox1.Text = string.Empty;
            }
         }
      }

      private void OnClick_Button_Ok(object a_Sender, EventArgs a_E)
      {
         if (m_NewExtensionMapping.HasValue)
         {
            var extMap = CompostBrowser.Instance.CurrentLibrary.ExtensionMappings;
            extMap.Add(m_NewExtensionMapping.Value.Key, m_NewExtensionMapping.Value.Value);
            CompostBrowser.Instance.HasUnsavedChanges = true;
         }
      }

      private void OnClick_Button_Cancel(object a_Sender, EventArgs a_E)
      {
         Close();
      }

      #endregion
   }
}
