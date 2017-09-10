// - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
// MIT License
// Copyright (c) 2017 Stained Glass Guild
// See file "LICENSE.txt" at project root for complete license
// ~   ~   ~   ~   ~   ~   ~   ~   ~   ~   ~   ~   ~   ~   ~   ~   ~   ~   ~   ~   ~   ~   ~   ~   ~
// Project: Compost
// File: EditLibraryConfigurationDialog.cs
// Creation: 2017-09
// Author: Jérémie Coulombe
// - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -

using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

using StainedGlassGuild.Compost.DataModel;

namespace StainedGlassGuild.Compost.GUI
{
   internal partial class EditLibraryConfigurationDialog : Form
   {
      #region Private fields

      private readonly Dictionary<Composition.Document.Type, ListViewGroup> m_Groups;

      #endregion

      #region Constructors

      public EditLibraryConfigurationDialog()
      {
         InitializeComponent();

         m_Groups = new Dictionary<Composition.Document.Type, ListViewGroup>();

         foreach (Composition.Document.Type docType in Enum.GetValues(
            typeof(Composition.Document.Type)))
         {
            var group = new ListViewGroup {Header = docType.ToString()};
            listView1.Groups.Add(group);
            m_Groups.Add(docType, group);
         }

         var lib = CompostBrowser.Instance.CurrentLibrary;

         foreach (var entry in lib.ExtensionMappings)
         {
            listView1.Items.Add(new ListViewItem
            {
               Text = entry.Key,
               Group = m_Groups[entry.Value]
            });
         }

         textBox1.Text = lib.Name;
      }

      #endregion

      #region Methods

      private void OnClick_Button_AddExtension(object a_Sender, EventArgs a_Args)
      {
         var dialog = new CreateExtensionMappingDialog();
         dialog.ShowDialog();

         if (!dialog.NewExtensionMapping.HasValue)
         {
            return;
         }

         var newMapping = dialog.NewExtensionMapping.Value;

         string newExt = newMapping.Key;

         var existing = listView1.Items.Cast<ListViewItem>().FirstOrDefault(a_Item => a_Item.Text == newExt);

         if (existing != null)
         {
            MessageBox.Show("File extension \"" + newExt + "\" has already been mapped " +
                            "to document type \"" + existing.Group.Header + "\".",
               "Extension already exists", MessageBoxButtons.OK);
            return;
         }

         listView1.Items.Add(new ListViewItem
         {
            Text = newExt,
            Group = m_Groups[newMapping.Value]
         });
      }

      private void OnClick_Button_Remove(object a_Sender, EventArgs a_E)
      {
         foreach (ListViewItem extToRemove in listView1.SelectedItems)
         {
            listView1.Items.Remove(extToRemove);
         }
      }

      private void OnClick_Button_Ok(object a_Sender, EventArgs a_E)
      {
         var lib = CompostBrowser.Instance.CurrentLibrary;

         // Update library name
         if (textBox1.Text == string.Empty)
         {
            textBox1.Text = "Untitled";
         }
         if (lib.Name != textBox1.Text)
         {
            lib.Name = textBox1.Text;
            CompostBrowser.Instance.HasUnsavedChanges = true;
         }

         // Update extension mappings
         var newMappings = listView1.Items.Cast<ListViewItem>()
            .ToDictionary(a_Item => a_Item.Text, a_Item => (Composition.Document.Type)
               Enum.Parse(typeof(Composition.Document.Type), a_Item.Group.Header));

         if (lib.ExtensionMappings.Count != newMappings.Count || !lib.ExtensionMappings.All(
                a_Item => newMappings.TryGetValue(a_Item.Key, out Composition.Document.Type type) &&
                          type == a_Item.Value))
         {
            lib.ExtensionMappings = newMappings;
            CompostBrowser.Instance.HasUnsavedChanges = true;
         }

         Close();
      }

      private void OnClick_Button_Cancel(object a_Sender, EventArgs a_E)
      {
         Close();
      }

      private void ItemSelectionChanged_ExtensionBox(object a_Sender,
                                                     ListViewItemSelectionChangedEventArgs a_E)
      {
         button4.Enabled = listView1.SelectedItems.Count > 0;
      }

      #endregion
   }
}
