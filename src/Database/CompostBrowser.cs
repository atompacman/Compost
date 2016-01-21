using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Reflection;
using System.Runtime.Serialization;
using System.Windows.Forms;

namespace Compost.Database
{
    public partial class CompostBrowser : Form
    {
        //  ~  STATIC FIELDS  ~  \\

        // Browsers column info
        private static readonly Dictionary<PropertyInfo, 
            Composition.CompositionBrowserColumnInfoAttribute> s_CompoBrowserColumnsInfo;


        //  ~  FIELDS  ~  \\

        // Current loaded database
        private Database m_Database;


        //  ~  MAIN  ~  \\

        [STAThread]
        public static void Main()
        {
            //var dir = new DirectoryInfo(@"B:\Documents\Dev\Atompacman\Compost\Database");
            //var db = Database.Load(dir);
            Application.Run(new CompostBrowser());
            //db.Save();
        }


        //  ~  INIT  ~  \\

        static CompostBrowser()
        {
            // Get columns info from annotations on Composition properties
            s_CompoBrowserColumnsInfo = new Dictionary<PropertyInfo,
                Composition.CompositionBrowserColumnInfoAttribute>();
            foreach (var property in typeof(Composition).GetRuntimeProperties())
            {
                var info = property.GetCustomAttribute<
                    Composition.CompositionBrowserColumnInfoAttribute>();
                if (info != null)
                {
                    s_CompoBrowserColumnsInfo.Add(property, info);
                }
            }
        }

        internal CompostBrowser()
        {
            InitializeComponent();

            // Create composition browser's columns
            foreach (var property in s_CompoBrowserColumnsInfo)
            {
                DataGridViewColumn column;

                if (property.Key.PropertyType.IsEnum)
                {
                    var dgvcbc = new DataGridViewComboBoxColumn();
                    dgvcbc.DataSource = Enum.GetValues(property.Key.PropertyType);
                    dgvcbc.ValueType = property.Key.PropertyType;
                    column = dgvcbc;
                }
                else
                {
                    column = new DataGridViewTextBoxColumn();
                }

                column.Name = property.Key.Name;
                column.Width = (int)property.Value.ColumnWidth;
                dataGridView1.Columns.Add(column);
            }
        }

        private void LoadDatabase(string path)
        {
            m_Database = Database.Load(new DirectoryInfo(path));
            UpdateCompositionBrowser();
        }


        //  ~  UPDATE  ~  \\

        private void UpdateCompositionBrowser()
        {


            for (int i = 0; i < m_Database.Compositions.Count; ++i)
            {
                var composition = m_Database.Compositions[i];
                dataGridView1.Rows.Add();

                int j = 0;
                foreach (var property in s_CompoBrowserColumnsInfo)
                {
                    var a = dataGridView1.Rows[i];
                    var b = property.Key.GetGetMethod(true);
                    var obj = b.Invoke(composition, new object[0]);

                    if (!property.Key.PropertyType.IsEnum)
                    {
                        var objStr = obj.ToString();

                        if (obj is List<string>)
                        {
                            objStr = "";
                            foreach (var item in obj as List<string>)
                            {
                                objStr = objStr + item.ToString() + ", ";
                            }
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


        //  ~  CLICK EVENTS  ~  \\

        private void OpenDatabaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.ShowDialog();
            LoadDatabase(dialog.SelectedPath);
        }
    }
}
