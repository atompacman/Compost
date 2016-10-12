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
using System.IO;
using System.Windows.Forms;

namespace FXGuild.Compost
{
    internal partial class CompostBrowser : Form
    {
        #region Private fields

        private Database m_Database;

        #endregion

        #region Constructors

        private CompostBrowser()
        {
            InitializeComponent();

            ClassBasedDataGridViewUpdater<Composition>.CreateColumns(dataGridView1);
            ClassBasedDataGridViewUpdater<Composition.Document>.CreateColumns(dataGridView2);
            ClassBasedDataGridViewUpdater<Composition.Document.Version>.CreateColumns(
                dataGridView3);
        }

        #endregion

        #region Static methods

        [STAThread]
        public static void Main()
        {
            var browser = new CompostBrowser();
            browser.LoadDatabase(@"B:\Documents\Dev\Atompacman\Compost\Database");
            Application.Run(browser);
        }

        #endregion

        #region Methods

        private void LoadDatabase(string a_Path)
        {
            m_Database = Database.Load(new DirectoryInfo(a_Path));
            ClassBasedDataGridViewUpdater<Composition>.Update(dataGridView1,
                m_Database.Compositions);
        }

        private void OpenDatabaseToolStripMenuItem_Click(object a_Sender, EventArgs a_E)
        {
            var dialog = new FolderBrowserDialog();
            dialog.ShowDialog();
            LoadDatabase(dialog.SelectedPath);
        }

        private void dataGridView1_RowEnter(object a_Sender, DataGridViewCellEventArgs a_E)
        {
            // Update document table
            var docs = m_Database.Compositions[a_E.RowIndex].Documents;
            ClassBasedDataGridViewUpdater<Composition.Document>.Update(dataGridView2, docs);

            // Update version table
            var vers = docs[0].Versions;
            ClassBasedDataGridViewUpdater<Composition.Document.Version>.Update(dataGridView3,
                vers);
        }

        private void dataGridView2_RowEnter(object a_Sender, DataGridViewCellEventArgs a_E)
        {
            if (dataGridView1.CurrentCell == null)
            {
                return;
            }

            // Update version table
            var compo = m_Database.Compositions[dataGridView1.CurrentCell.RowIndex];
            var vers = compo.Documents[a_E.RowIndex].Versions;
            ClassBasedDataGridViewUpdater<Composition.Document.Version>.Update(dataGridView3,
                vers);
        }

        #endregion
    }
}
