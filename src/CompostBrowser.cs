// MIT License
//
// Copyright (c) 2016 FXGuild
//
// Permission is hereby granted, free of charge, to any person obtaining a copy of this software and
// associated documentation files (the "Software"), to deal in the Software without restriction,
// including without limitation the rights to use, copy, modify, merge, publish, distribute,
// sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in all copies or
// substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT
// NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM,
// DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Windows.Forms;
using Compost.src;

namespace FXGuild.Compost
{
    internal partial class CompostBrowser : Form
    {
        #region Compile-time constants

        private const string ARCHIVE_DIR_PREFIX = "Archive";
        private const string ARCHIVE_FILE_TIMESTAMP_PATTERN = "MM-dd-yyyy HH-mm-ss";

        #endregion

        #region Runtime constants

        private static readonly DataContractJsonSerializer DCJS;

        #endregion

        #region Private fields

        private bool m_HasUnsavedChanges;
        private string m_DbFilePath;
        private Database m_Database;

        #endregion

        #region Constructors

        static CompostBrowser()
        {
            // Create json database parser
            var settings = new DataContractJsonSerializerSettings
            {
                UseSimpleDictionaryFormat = true
            };
            DCJS = new DataContractJsonSerializer(typeof(Database), settings);
        }

        private CompostBrowser()
        {
            // Build win form
            InitializeComponent();

            // Initialize browsers
            ClassBasedDataGridViewUpdater<Composition>.CreateColumns(
                CompositionBrowser);
            ClassBasedDataGridViewUpdater<Composition.Document>.CreateColumns(
                DocumentBrowser);
            ClassBasedDataGridViewUpdater<Composition.Document.Version>.CreateColumns(
                VersionBrowser);

            m_HasUnsavedChanges = false;
        }

        #endregion

        #region Static methods

        [STAThread]
        public static void Main(string[] a_Args)
        {
            // Needed to display ListView groups
            Application.EnableVisualStyles();

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

        #endregion

        #region Methods

        private void LoadDatabase(string a_Path)
        {
            m_HasUnsavedChanges = false;

            // Parse json database file
            m_DbFilePath = a_Path;
            using (var stream = File.OpenRead(a_Path))
            {
                m_Database = (Database) DCJS.ReadObject(stream);
            }

            // Update composition browser
            ClassBasedDataGridViewUpdater<Composition>.UpdateView(
                CompositionBrowser, m_Database.Compositions);
        }

        /// <returns>False if the save was canceled, true otherwise</returns>
        private bool AskToSaveChanges()
        {
            if (!m_HasUnsavedChanges)
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

        private void MarkChanges()
        {
            if (m_HasUnsavedChanges)
            {
                return;
            }

            Text = Text + '*';
            m_HasUnsavedChanges = true;
        }

        private void SaveDatabase()
        {
            if (!m_HasUnsavedChanges)
            {
                // Nothing to save
                return;
            }

            // Create archive directory if needed
            string archiveDirName = ARCHIVE_DIR_PREFIX + '_' + m_Database.Name;
            string archiveDirPath = Path.Combine(Directory.GetCurrentDirectory(), archiveDirName);
            if (!Directory.Exists(archiveDirPath))
            {
                Directory.CreateDirectory(archiveDirPath);
            }

            // Save a copy of the database in the archive directory
            string timestamp = DateTime.Now.ToString(ARCHIVE_FILE_TIMESTAMP_PATTERN);
            SaveCopy(Path.Combine(archiveDirPath, timestamp));

            // Overwrite current copy of the database
            SaveCopy(m_DbFilePath);

            m_HasUnsavedChanges = false;
            Text = Text.Replace("*", "");
        }

        private void SaveCopy(string a_Path)
        {
            using (var stream = File.Create(a_Path))
            {
                using (var writer = JsonReaderWriterFactory.CreateJsonWriter(
                    stream, Encoding.UTF8, true, true))
                {
                    DCJS.WriteObject(writer, m_Database);
                }
            }
        }

        private void EditCell<T>(DataGridView a_Dgv,
                                 int a_RowIdx,
                                 int a_ColumnIdx,
                                 IReadOnlyList<T> a_Elements)
        {
            // Get the reflected property that was edited
            var property = ClassBasedDataGridViewUpdater<T>.GetColumnProperty(a_ColumnIdx);

            // Get the cell that was modified
            var cell = a_Dgv.Rows[a_RowIdx].Cells[a_ColumnIdx];

            // Convert cell content to appropriate value
            var value = cell.Value;

            // The only property type that must be reconstructed is the string list
            if (property.PropertyType == typeof(List<string>))
            {
                value =
                    ((string) cell.Value).Split(',').Select(a_Name => a_Name.Trim()).ToList();
            }

            // Get modified elements
            var elem = a_Elements[a_RowIdx];

            // Get property getter and setter method
            var getter = property.GetGetMethod();
            var setter = property.GetSetMethod();

            // Get previous value
            var prev = getter.Invoke(elem, new object[] {});

            // Return if value stays the same
            if (value == prev)
            {
                return;
            }

            // Set value
            setter.Invoke(elem, new[] {value});
            MarkChanges();
        }

        private Composition GetSelectedComposition()
        {
            if (CompositionBrowser.CurrentCell == null)
            {
                return null;
            }
            int idx = CompositionBrowser.CurrentCell.RowIndex;
            return idx < m_Database.Compositions.Count ? m_Database.Compositions[idx] : null;
        }

        private Composition.Document GetSelectedDocument()
        {
            var compo = GetSelectedComposition();
            if (compo == null)
            {
                return null;
            }
            int idx = DocumentBrowser.CurrentCell.RowIndex;
            return idx < compo.Documents.Count ? compo.Documents[idx] : null;
        }

        private void OnCellEdited(object a_Sender, DataGridViewCellEventArgs a_Args)
        {
            // Call the cell editing function according to the type inside the data grid view
            var dgv = (DataGridView) a_Sender;
            switch (dgv.Name)
            {
            case "CompositionBrowser":
                EditCell(dgv, a_Args.RowIndex, a_Args.ColumnIndex, m_Database.Compositions);
                return;

            case "DocumentBrowser":
                EditCell(dgv, a_Args.RowIndex, a_Args.ColumnIndex,
                    GetSelectedComposition().Documents);
                return;

            default:
                EditCell(dgv, a_Args.RowIndex, a_Args.ColumnIndex,
                    GetSelectedDocument().Versions);
                return;
            }
        }

        private void OnExit(object a_Sender, FormClosingEventArgs a_Args)
        {
            AskToSaveChanges();
        }
        
        private void OnFileToolbarNewDatabase(object a_Sender, EventArgs a_Args)
        {
            if (!AskToSaveChanges())
            {
                return;
            }

            // Open blocking window
            Enabled = false;
            var browser = new DatabaseSettingsEditor(() => Enabled = true);
            browser.Show();
        }

        private void OnFileToolbarOpenDatabase(object a_Sender, EventArgs a_Args)
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

        private void OnFileToolbarSaveDatabase(object a_Sender, EventArgs a_Args)
        {
            SaveDatabase();
        }

        private void OnFileToolBarImportMultiFileComposition(object a_Sender, EventArgs a_Args)
        {
            var browser = new MultiFileCompositionImporter(m_Database.ExtensionTable);
            browser.Show();
        }

        private void OnFileToolbarCloseDatabase(object a_Sender, EventArgs a_Args)
        {
            if (!AskToSaveChanges())
            {
                return;
            }

            ClassBasedDataGridViewUpdater<Composition>.UpdateView(CompositionBrowser,
                new List<Composition>());
            ClassBasedDataGridViewUpdater<Composition.Document>.UpdateView(DocumentBrowser,
                new List<Composition.Document>());
            ClassBasedDataGridViewUpdater<Composition.Document.Version>.UpdateView(
                VersionBrowser,
                new List<Composition.Document.Version>());
        }

        private void OnFileToolbarExit(object a_Sender, EventArgs a_Args)
        {
            Close();
        }

        private void OnCompositionBrowserRowEnter(object a_Sender, DataGridViewCellEventArgs a_E)
        {
            // UpdateView document table
            var docs = m_Database.Compositions[a_E.RowIndex].Documents;
            ClassBasedDataGridViewUpdater<Composition.Document>.UpdateView(DocumentBrowser, docs);

            // UpdateView version table
            ClassBasedDataGridViewUpdater<Composition.Document.Version>.UpdateView(
                VersionBrowser,
                docs[0].Versions);
        }

        private void OnDocumentBrowserRowEnter(object a_Sender, DataGridViewCellEventArgs a_E)
        {
            var compo = GetSelectedComposition();
            if (compo == null)
            {
                return;
            }

            // UpdateView version table
            var vers = GetSelectedComposition().Documents[a_E.RowIndex].Versions;
            ClassBasedDataGridViewUpdater<Composition.Document.Version>.UpdateView(
                VersionBrowser,
                vers);
        }

        #endregion
    }
}