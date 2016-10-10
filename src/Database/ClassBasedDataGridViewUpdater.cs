using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace Compost.Database
{
    [AttributeUsage(AttributeTargets.Property)]
    internal sealed class ColumnInfoAttribute : Attribute
    {
        public double RelativeColumnWidth { get; set; }
    }

    internal static class ClassBasedDataGridViewUpdater<T>
    {
        private static readonly Dictionary<PropertyInfo, ColumnInfoAttribute> COLUMNS_INFO;
        private static readonly double RELATIVE_COLUMN_WIDTHS_SUM;

        static ClassBasedDataGridViewUpdater()
        {
            // Save class T properties that have a ColumnInfoAttribute
            COLUMNS_INFO = new Dictionary<PropertyInfo, ColumnInfoAttribute>();
            RELATIVE_COLUMN_WIDTHS_SUM = 0;
            foreach (var property in typeof(T).GetRuntimeProperties())
            {
                var attr = property.GetCustomAttribute<ColumnInfoAttribute>();
                if (attr != null)
                {
                    COLUMNS_INFO.Add(property, attr);
                    RELATIVE_COLUMN_WIDTHS_SUM += attr.RelativeColumnWidth;
                }
            }
        }
        
        public static void CreateColumns(DataGridView a_DataGridView)
        {
            // Clear existing columns
            a_DataGridView.Columns.Clear();

            // Create columns
            foreach (var property in COLUMNS_INFO)
            {
                DataGridViewColumn column;

                // Enum properties
                if (property.Key.PropertyType.IsEnum)
                {
                    var dgvcbc = new DataGridViewComboBoxColumn
                    {
                        DataSource = Enum.GetValues(property.Key.PropertyType),
                        ValueType = property.Key.PropertyType
                    };
                    column = dgvcbc;
                }
                // Other properties
                else
                {
                    column = new DataGridViewTextBoxColumn();
                }

                column.Name  = property.Key.Name;
                column.Width = (int)(a_DataGridView.Width * 
                    (property.Value.RelativeColumnWidth / RELATIVE_COLUMN_WIDTHS_SUM));
                a_DataGridView.Columns.Add(column);
            }

           // a_DataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        public static void Update(DataGridView a_DataGridView, List<T> a_Elements)
        {
            // Clear previous rows
            a_DataGridView.Rows.Clear();

            for (int i = 0; i < a_Elements.Count; ++i)
            {
                a_DataGridView.Rows.Add();

                var j = 0;
                foreach (var property in COLUMNS_INFO)
                {
                    var a = a_DataGridView.Rows[i];
                    var b = property.Key.GetGetMethod(true);
                    var obj = b.Invoke(a_Elements[i], new object[0]);

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
    }
}
