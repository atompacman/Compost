// - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
// MIT License
// Copyright (c) 2017 Stained Glass Guild
// See file "LICENSE.txt" at project root for complete license
// ~   ~   ~   ~   ~   ~   ~   ~   ~   ~   ~   ~   ~   ~   ~   ~   ~   ~   ~   ~   ~   ~   ~   ~   ~
// Project: Compost
// File: MultiFileCompositionImporter.cs
// Creation: 2017-09
// Author: Jérémie Coulombe
// - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -

using System;
using System.Linq;
using System.Windows.Forms;

using StainedGlassGuild.Compost.DataModel;

namespace StainedGlassGuild.Compost.GUI
{
   internal partial class MultiFileCompositionImporter : Form
   {
      #region Private fields

      private readonly ExtensionTable m_ExtensionTable;

      #endregion

      #region Constructors

      public MultiFileCompositionImporter(ExtensionTable a_ExtTable)
      {
         InitializeComponent();

         m_ExtensionTable = a_ExtTable;
      }

      #endregion

      #region Methods

      private void OnImportButtonClick(object a_Sender, EventArgs a_Args)
      {
         // Ask user to select files
         var dialog = new OpenFileDialog
         {
            Multiselect = true
         };
         dialog.ShowDialog();

         // For each selected file
         foreach (string file in dialog.FileNames)
         {
            // Don't add a file twice
            if (listView1.Items.ContainsKey(file))
            {
               continue;
            }

            // Find file document type
            var docType = Composition.Document.Type.OTHER;
            // ReSharper disable once StringLastIndexOfIsCultureSpecific.1
            int idx = file.LastIndexOf(".");
            if (idx != -1)
            {
               // Look for document type in extension table
               string ext = file.Substring(idx + 1, file.Length - idx - 1);
               if (m_ExtensionTable.HasExtension(ext))
               {
                  docType = m_ExtensionTable[ext].DocType;
               }
            }

            // Find list view group containing documents of this type
            var group = listView1.Groups.Cast<ListViewGroup>()
               .FirstOrDefault(a_Group => a_Group.Header == docType.ToString());

            // Create group if needed
            if (group == null)
            {
               group = new ListViewGroup(docType.ToString());
               listView1.Groups.Add(group);
            }

            // Add item to the list
            listView1.Items.Add(file).Group = group;
         }
      }

      #endregion
   }
}
