// - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
// MIT License
// Copyright (c) 2017 Stained Glass Guild
// See file "LICENSE.txt" at project root for complete license
// ~   ~   ~   ~   ~   ~   ~   ~   ~   ~   ~   ~   ~   ~   ~   ~   ~   ~   ~   ~   ~   ~   ~   ~   ~
// Project: Compost
// File: CompostBrowser.cs
// Creation: 2017-09
// Author: Jérémie Coulombe
// - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -

using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Windows.Forms;

using StainedGlassGuild.Compost.DataModel;

namespace StainedGlassGuild.Compost.GUI
{
   internal partial class CompostBrowser : Form
   {
      #region Nested types

      private enum CellAction
      {
         GET_VALUE,
         SET_VALUE
      }

      #endregion

      #region Compile-time constants

      private const string BACKUP_DIR_PREFIX = "Backup";
      private const string BACKUP_FILE_TIMESTAMP_PATTERN = "MM-dd-yyyy HH-mm-ss";

      #endregion

      #region Runtime constants

      private static readonly DataContractJsonSerializer DCJS;

      #endregion

      #region Private fields

      private bool m_HasUnsavedChanges;
      private Library m_CurrDB;
      private string m_CurrDbFilePath;

      #endregion

      #region Properties

      private bool IsDatabaseOpened => m_CurrDB != null;

      private bool HasUnsavedChanges
      {
         get => m_HasUnsavedChanges;
         set
         {
            m_HasUnsavedChanges = value;
            UpdateTitle();
         }
      }

      private IEnumerable<DataGridView> DataGridViews => new[]
         {dataGridView1, dataGridView2, dataGridView3};

      private IEnumerable<GroupBox> GroupBoxes => new[]
         {groupBox1, groupBox2, groupBox3};

      #endregion

      #region Constructors

      static CompostBrowser()
      {
         // Create json database object parser
         var settings = new DataContractJsonSerializerSettings
         {
            UseSimpleDictionaryFormat = true
         };
         DCJS = new DataContractJsonSerializer(typeof(Library), settings);
      }

      public CompostBrowser()
      {
         InitializeComponent();
         CloseDatabase();
      }

      #endregion

      #region Static methods

      [STAThread]
      public static void Main(string[] a_Args)
      {
         // Needed to display ListView groups
         Application.EnableVisualStyles();
         SetProcessDPIAware();

         // Create main window
         var browser = new CompostBrowser();

         // Load database if a path is provided
         if (a_Args.Length > 0)
         {
            browser.LoadDatabase(a_Args[0]);
         }

         // Run app on main thread
         Application.Run(browser);
      }

      [DllImport("user32.dll")]
      private static extern bool SetProcessDPIAware();

      private static void PopulateGrid(DataGridView a_DGV, IEnumerable<object> a_Data)
      {
         var bindingSrc = (BindingSource) a_DGV.DataSource;
         bindingSrc.Clear();
         foreach (var data in a_Data)
         {
            bindingSrc.Add(data);
         }
      }

      private static void CellValueProcess(DataGridView a_Dvg,
                                           IDictionary<string, string> a_CustomProperties,
                                           DataGridViewCellValueEventArgs a_E,
                                           CellAction a_Action)
      {
         if (a_E.ColumnIndex < 0 || a_E.ColumnIndex >= a_Dvg.Columns.Count)
         {
            return;
         }

         string columnName = a_Dvg.Columns[a_E.ColumnIndex].Name;

         if (a_CustomProperties.TryGetValue(columnName, out string value))
         {
            if (a_Action == CellAction.GET_VALUE)
            {
               a_E.Value = value;
            }
            else
            {
               a_CustomProperties[columnName] = a_E.Value?.ToString() ?? "";
            }
         }
         else
         {
            if (a_Action == CellAction.GET_VALUE)
            {
               a_E.Value = string.Empty;
            }
            else
            {
               a_CustomProperties.Add(columnName, a_E.Value?.ToString() ?? "");
            }
         }
      }

      #endregion

      #region Methods

      private void LoadDatabase(string a_Path)
      {
         // Nothing to do if asked to open the same database
         if (m_CurrDbFilePath == a_Path)
         {
            return;
         }

         // Close current database
         if (IsDatabaseOpened)
         {
            CloseDatabase();
         }

         // Parse json database file
         m_CurrDbFilePath = a_Path;
         using (var stream = File.OpenRead(a_Path))
         {
            m_CurrDB = (Library) DCJS.ReadObject(stream);
         }

         ///////
         dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
         {
            Name = "Title",
            DataPropertyName = "Title"
         });

         foreach (string custPropName in m_CurrDB.CompositionCustomPropertyNames)
         {
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
               Name = custPropName
            });
         }

         dataGridView2.Columns.Add(new DataGridViewTextBoxColumn
         {
            Name = "Name",
            DataPropertyName = "Name"
         });
         dataGridView2.Columns.Add(new DataGridViewComboBoxColumn
         {
            AutoComplete = true,
            Name = "Type",
            DataPropertyName = "DocType",
            DataSource = Enum.GetValues(typeof(Composition.Document.Type))
         });

         foreach (string custPropName in m_CurrDB.DocumentCustomPropertyNames)
         {
            dataGridView2.Columns.Add(new DataGridViewTextBoxColumn
            {
               Name = custPropName
            });
         }

         dataGridView3.Columns.Add(new DataGridViewTextBoxColumn
         {
            Name = "Version Number",
            DataPropertyName = "VersionNumber"
         });

         dataGridView3.Columns.Add(new DataGridViewTextBoxColumn
         {
            Name = "File Path",
            DataPropertyName = "FilePath"
         });

         foreach (string custPropName in m_CurrDB.VersionCustomPropertyNames)
         {
            dataGridView3.Columns.Add(new DataGridViewTextBoxColumn
            {
               Name = custPropName
            });
         }

         ///////

         // Populate composition browser
         PopulateGrid(dataGridView1, m_CurrDB.Compositions);

         SetControlsEnabled(true);

         UpdateTitle();

         closeDatabaseToolStripMenuItem.Enabled = true;
      }

      private void WriteDatabase(string a_Path)
      {
         using (var stream = File.Create(a_Path))
         {
            using (var writer = JsonReaderWriterFactory.CreateJsonWriter(
               stream, Encoding.UTF8, true, true))
            {
               DCJS.WriteObject(writer, m_CurrDB);
            }
         }
      }

      private void SaveDatabase()
      {
         if (!m_HasUnsavedChanges)
         {
            // Nothing to save
            return;
         }

         // Create archive directory if needed
         string archiveDirName = BACKUP_DIR_PREFIX + '_' + m_CurrDB.Name;
         string archiveDirPath = Path.Combine(Directory.GetCurrentDirectory(), archiveDirName);
         if (!Directory.Exists(archiveDirPath))
         {
            Directory.CreateDirectory(archiveDirPath);
         }

         // Save a copy of the database in the archive directory
         string timestamp = DateTime.Now.ToString(BACKUP_FILE_TIMESTAMP_PATTERN);
         WriteDatabase(Path.Combine(archiveDirPath, timestamp));

         // Overwrite current copy of the database
         WriteDatabase(m_CurrDbFilePath);

         // Change window title
         HasUnsavedChanges = false;
      }

      /// <returns>False if the save was canceled, true otherwise</returns>
      private bool AskToSaveChanges()
      {
         if (!HasUnsavedChanges)
         {
            // Nothing to save
            return true;
         }

         switch (MessageBox.Show("Save database ?", "Save", MessageBoxButtons.YesNoCancel))
         {
         case DialogResult.Yes:
            SaveDatabase();
            return true;

         case DialogResult.No:
            return true;

         default:
            return false;
         }
      }

      private void SetControlsEnabled(bool a_Enabled)
      {
         foreach (var dgv in DataGridViews)
         {
            dgv.Enabled = a_Enabled;
         }
         foreach (var gb in GroupBoxes)
         {
            gb.Enabled = a_Enabled;
         }
      }

      private void CloseDatabase()
      {
         foreach (var dgv in DataGridViews)
         {
            ((BindingSource) dgv.DataSource).Clear();
            dgv.Columns.Clear();
         }

         SetControlsEnabled(false);

         m_CurrDB = null;
         m_CurrDbFilePath = string.Empty;
         HasUnsavedChanges = false;

         closeDatabaseToolStripMenuItem.Enabled = false;
      }

      private void UpdateTitle()
      {
         Text = "Compost";
         if (!IsDatabaseOpened)
         {
            return;
         }

         Text += " - " + m_CurrDB.Name;
         if (m_HasUnsavedChanges)
         {
            Text += "*";
         }
      }

      private void OnClick_MenuStrip_File_OpenLibrary(object a_Sender, EventArgs a_E)
      {
         if (!AskToSaveChanges())
         {
            return;
         }

         var dialog = new OpenFileDialog();
         dialog.ShowDialog();

         if (dialog.FileName.Length != 0)
         {
            LoadDatabase(dialog.FileName);
         }
      }

      private void OnClick_MenuStrip_File_SaveLibrary(object a_Sender, EventArgs a_E)
      {
         SaveDatabase();
      }

      private void OnClick_MenuStrip_File_CloseLibrary(object a_Sender, EventArgs a_E)
      {
         if (!AskToSaveChanges())
         {
            return;
         }

         CloseDatabase();
      }

      private void OnClick_MenuStrip_File_Exit(object a_Sender, EventArgs a_E)
      {
         Close();
      }

      private void OnClick_MenuStrip_View_ShowHidePanels_Documents(object a_Sender, EventArgs a_E)
      {
         if (splitContainer1.Panel2Collapsed)
         {
            splitContainer1.Panel2Collapsed = false;
            splitContainer2.Panel1Collapsed = false;
            splitContainer2.Panel2Collapsed = true;
         }
         else if (splitContainer2.Panel2Collapsed)
         {
            splitContainer1.Panel2Collapsed = true;
         }
         else
         {
            splitContainer2.Panel1Collapsed = !splitContainer2.Panel1Collapsed;
         }
      }

      private void OnClick_MenuStrip_View_ShowHidePanels_Versions(object a_Sender, EventArgs a_E)
      {
         if (splitContainer1.Panel2Collapsed)
         {
            splitContainer1.Panel2Collapsed = false;
            splitContainer2.Panel1Collapsed = true;
            splitContainer2.Panel2Collapsed = false;
         }
         else if (splitContainer2.Panel1Collapsed)
         {
            splitContainer1.Panel2Collapsed = true;
         }
         else
         {
            splitContainer2.Panel2Collapsed = !splitContainer2.Panel2Collapsed;
         }
      }

      private Composition GetComposition(int a_CompoIdx)
      {
         return m_CurrDB.Compositions[a_CompoIdx];
      }

      private Composition GetCurrentComposition()
      {
         return dataGridView1.CurrentRow == null
            ? null
            : GetComposition(dataGridView1.CurrentRow.Index);
      }

      private Composition.Document GetDocument(int a_DocIdx)
      {
         return GetCurrentComposition()?.Documents[a_DocIdx];
      }

      private Composition.Document GetCurrentDocument()
      {
         return dataGridView2.CurrentRow == null
            ? null
            : GetDocument(dataGridView2.CurrentRow.Index);
      }

      private Composition.Document.Version GetVersion(int a_VersIdx)
      {
         return GetCurrentDocument()?.Versions[a_VersIdx];
      }

      private void UpdateGroupBoxText(Composition a_Compo, Composition.Document a_Doc)
      {
         groupBox1.Text = "Documents of \"" + a_Compo?.Title + "\"";
         groupBox2.Text = "Versions of \"" + a_Doc?.Name + "\"";
      }

      private void OnCellValueChanged(object a_Sender, DataGridViewCellEventArgs a_E)
      {
         HasUnsavedChanges = true;
         UpdateGroupBoxText(GetCurrentComposition(), GetCurrentDocument());
      }

      private void OnRowEnter_Compositions(object a_Sender, DataGridViewCellEventArgs a_E)
      {
         if (dataGridView1.CurrentRow != null && dataGridView1.CurrentRow.Index == a_E.RowIndex)
         {
            return;
         }

         // Populate document browser
         var currCompo = GetComposition(a_E.RowIndex);
         var docs = currCompo.Documents;
         PopulateGrid(dataGridView2, docs);

         // Populate version browser
         if (docs.Count > 0)
         {
            PopulateGrid(dataGridView3, docs[0].Versions);
         }

         UpdateGroupBoxText(currCompo, docs[0]);
      }

      private void OnRowEnter_Documents(object a_Sender, DataGridViewCellEventArgs a_E)
      {
         if (dataGridView2.CurrentRow != null && dataGridView2.CurrentRow.Index == a_E.RowIndex)
         {
            return;
         }

         // Populate version browser
         var currDoc = GetDocument(a_E.RowIndex);
         if (currDoc == null)
         {
            return;
         }
         var vers = currDoc.Versions;
         if (vers.Count > 0)
         {
            PopulateGrid(dataGridView3, vers);
         }

         UpdateGroupBoxText(GetCurrentComposition(), currDoc);
      }

      private void OnClosing(object a_Sender, FormClosingEventArgs a_E)
      {
         a_E.Cancel = !AskToSaveChanges();
      }

      private void CellValueProcess_Compositions(object a_Sender,
                                                 DataGridViewCellValueEventArgs a_E,
                                                 CellAction a_Action)
      {
         CellValueProcess(
            a_Sender as DataGridView,
            GetComposition(a_E.RowIndex).CustomProperties,
            a_E,
            a_Action);
      }

      private void CellValueProcess_Documents(object a_Sender,
                                              DataGridViewCellValueEventArgs a_E,
                                              CellAction a_Action)
      {
         CellValueProcess(
            a_Sender as DataGridView,
            GetDocument(a_E.RowIndex).CustomProperties,
            a_E,
            a_Action);
      }

      private void CellValueProcess_Versions(object a_Sender,
                                             DataGridViewCellValueEventArgs a_E,
                                             CellAction a_Action)
      {
         CellValueProcess(
            a_Sender as DataGridView,
            GetVersion(a_E.RowIndex).CustomProperties,
            a_E,
            a_Action);
      }

      private void OnCellValueNeeded_Compositions(object a_Sender,
                                                  DataGridViewCellValueEventArgs a_E)
      {
         CellValueProcess_Compositions(a_Sender, a_E, CellAction.GET_VALUE);
      }

      private void OnCellValuePushed_Compositions(object a_Sender,
                                                  DataGridViewCellValueEventArgs a_E)
      {
         CellValueProcess_Compositions(a_Sender, a_E, CellAction.SET_VALUE);
      }

      private void OnCellValueNeeded_Documents(object a_Sender,
                                               DataGridViewCellValueEventArgs a_E)
      {
         CellValueProcess_Documents(a_Sender, a_E, CellAction.GET_VALUE);
      }

      private void OnCellValuePushed_Documents(object a_Sender,
                                               DataGridViewCellValueEventArgs a_E)
      {
         CellValueProcess_Documents(a_Sender, a_E, CellAction.SET_VALUE);
      }

      private void OnCellValueNeeded_Versions(object a_Sender,
                                              DataGridViewCellValueEventArgs a_E)
      {
         CellValueProcess_Versions(a_Sender, a_E, CellAction.GET_VALUE);
      }

      private void OnCellValuePushed_Versions(object a_Sender,
                                              DataGridViewCellValueEventArgs a_E)
      {
         CellValueProcess_Versions(a_Sender, a_E, CellAction.SET_VALUE);
      }

      #endregion
   }
}
