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
        #region NESTED TYPES

        [AttributeUsage(AttributeTargets.Property)]
        public sealed class ColumnInfoAttribute : Attribute
        {
            public double RelativeColumnWidth { get; set; }
        }

        #endregion

        #region RUNTIME CONSTANTS

        private static readonly Dictionary<PropertyInfo, ColumnInfoAttribute> COLUMNS_INFO;

        #endregion

        #region PRIVATE FIELDS  

        private Database m_Database;

        #endregion

        #region MAIN

        [STAThread]
        public static void Main()
        {
            var browser = new CompostBrowser();
            browser.LoadDatabase(@"B:\Documents\Dev\Atompacman\Compost\Database");
            Application.Run(browser);
        }

        #endregion

        #region INIT

        static CompostBrowser()
        {
            // Get columns info from annotations on Composition properties
            COLUMNS_INFO = new Dictionary<PropertyInfo, ColumnInfoAttribute>();
            foreach (var property in typeof(Composition).GetRuntimeProperties())
            {
                var attr = property.GetCustomAttribute<ColumnInfoAttribute>();
                if (attr != null)
                {
                    COLUMNS_INFO.Add(property, attr);
                }
            }
        }

        private CompostBrowser()
        {
            InitializeComponent();

            // Create composition browser's columns
            foreach (var property in COLUMNS_INFO)
            {
                DataGridViewColumn column;
                if (property.Key.PropertyType.IsEnum)
                {
                    var dgvcbc = new DataGridViewComboBoxColumn
                    {
                        DataSource = Enum.GetValues(property.Key.PropertyType),
                        ValueType = property.Key.PropertyType
                    };
                    column = dgvcbc;
                }
                else
                {
                    column = new DataGridViewTextBoxColumn();
                }

                column.Name  = property.Key.Name;
                column.Width = (int) (property.Value.RelativeColumnWidth * dataGridView1.Width);
                dataGridView1.Columns.Add(column);
            }

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void LoadDatabase(string path)
        {
            m_Database = Database.Load(new DirectoryInfo(path));
            UpdateCompositionBrowser();
        }

        #endregion

        #region UPDATE

        private void UpdateCompositionBrowser()
        {
            for (var i = 0; i < m_Database.Compositions.Count; ++i)
            {
                var composition = m_Database.Compositions[i];
                dataGridView1.Rows.Add();

                var j = 0;
                foreach (var property in COLUMNS_INFO)
                {
                    var a = dataGridView1.Rows[i];
                    var b = property.Key.GetGetMethod(true);
                    var obj = b.Invoke(composition, new object[0]);

                    if (!property.Key.PropertyType.IsEnum)
                    {
                        var objStr = obj.ToString();

                        if (obj is List<string>)
                        {
                            objStr = (obj as List<string>).Aggregate("", 
                                (current, item) => current + item + ", ");
                            if ((obj as List<string>).Count != 0)
                            {
                                objStr = objStr.Substring(0, objStr.Length - 2);
                            }
                        }
                        obj = objStr;
                    }

                    a.Cells[j++].Value = obj;
                }
            }
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
    }
}
