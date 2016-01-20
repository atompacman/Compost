using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace Compost.Database
{
    public partial class CompostBrowser : Form
    {
        //  ~  FIELDS  ~  \\

        private Database m_Database;


        //  ~  MAIN  ~  \\

        [STAThread]
        static void Main()
        {
            var dir = new DirectoryInfo(@"B:\Documents\Dev\Atompacman\Compost\Database");
            var db = Database.Load(dir);
            Application.Run(new CompostBrowser(db));
            db.Save();
        }

        public List<string> s;

        internal CompostBrowser(Database m_Database)
        {
            InitializeComponent();

            var compositionProperties = typeof(Composition).GetRuntimeProperties();

            foreach (var property in compositionProperties)
            {
                DataGridViewColumn column;

                if (property.PropertyType.IsEnum)
                {
                    var dgvcbc = new DataGridViewComboBoxColumn();
                    dgvcbc.Name = "lol";
                    dgvcbc.DataSource = Enum.GetValues(property.PropertyType);
                    dgvcbc.ValueType = property.PropertyType;
                    column = dgvcbc;
                }
                else
                {
                    column = new DataGridViewTextBoxColumn();
                }

                column.Name = property.Name;
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dataGridView1.Columns.Add(column);
            }

            for (int i = 0; i < m_Database.Compositions.Count; ++i)
            {
                var composition = m_Database.Compositions[i];
                dataGridView1.Rows.Add();

                int j = 0;
                foreach (var property in compositionProperties)
                {
                    var a = dataGridView1.Rows[i];
                    var b = property.GetGetMethod(true);
                    a.Cells[j++].Value = b.Invoke(composition, new object[0]);
                }
            }
        }
    }
}
