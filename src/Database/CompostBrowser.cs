using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace Compost.Database
{
    public partial class CompostBrowser : Form
    {
        #region PRIVATE FIELDS  

        private Database m_Database;

        #endregion

        #region MAIN

        [STAThread]
        public static void Main()
        {
            var browser = new MultiFileCompositionImporter();// CompostBrowser();
            //browser.LoadDatabase(@"C:\Users\Utilisateur\Dev\MSVC\C#\Compost\Database");
            Application.Run(browser);
        }

        #endregion

        #region INIT

        private CompostBrowser()
        {
            InitializeComponent();

            ClassBasedDataGridViewUpdater<Composition>.CreateColumns(dataGridView1);
            ClassBasedDataGridViewUpdater<Composition.Document>.CreateColumns(dataGridView2);
            ClassBasedDataGridViewUpdater<Composition.Document.Version>.CreateColumns(dataGridView3);
        }

        private void LoadDatabase(string path)
        {
            m_Database = Database.Load(new DirectoryInfo(path));
            ClassBasedDataGridViewUpdater<Composition>.Update(dataGridView1, m_Database.Compositions);
        }

        #endregion

        #region ON CLICK

        private void OpenDatabaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var dialog = new FolderBrowserDialog();
            dialog.ShowDialog();
            LoadDatabase(dialog.SelectedPath);
        }

        #endregion

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            // Update document table
            var docs = m_Database.Compositions[e.RowIndex].Documents;
            ClassBasedDataGridViewUpdater<Composition.Document>.Update(dataGridView2, docs);

            // Update version table
            var vers = docs[0].Versions;
            ClassBasedDataGridViewUpdater<Composition.Document.Version>.Update(dataGridView3, vers);
        }

        private void dataGridView2_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentCell == null)
            {
                return;
            }

            // Update version table
            var compo = m_Database.Compositions[dataGridView1.CurrentCell.RowIndex];
            var vers = compo.Documents[e.RowIndex].Versions;
            ClassBasedDataGridViewUpdater<Composition.Document.Version>.Update(dataGridView3, vers);
        }
    }
}
