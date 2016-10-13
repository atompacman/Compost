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
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

// ReSharper disable StaticMemberInGenericType

namespace FXGuild.Compost
{
    /// <summary>
    /// Helper class that initializes and update DataGridViews to contain elements of type T with
    /// its columns being properties of T marked by the ColumnInfo attribute.
    /// </summary>
    /// <typeparam name="T">Type of objects in the grid</typeparam>
    internal static class ClassBasedDataGridViewUpdater<T>
    {
        #region Runtime constants

        private static readonly List<Tuple<PropertyInfo, ColumnInfoAttribute>> COLUMNS_INFO;
        private static readonly double RELATIVE_COLUMN_WIDTHS_SUM;

        #endregion

        #region Constructors

        static ClassBasedDataGridViewUpdater()
        {
            // Save class T properties that have a ColumnInfo attribute
            COLUMNS_INFO = new List<Tuple<PropertyInfo, ColumnInfoAttribute>>();
            RELATIVE_COLUMN_WIDTHS_SUM = 0;
            foreach (var property in typeof(T).GetRuntimeProperties())
            {
                var attr = property.GetCustomAttribute<ColumnInfoAttribute>();
                if (attr == null)
                {
                    continue;
                }
                COLUMNS_INFO.Add(new Tuple<PropertyInfo, ColumnInfoAttribute>(property, attr));
                RELATIVE_COLUMN_WIDTHS_SUM += attr.RelativeColumnWidth;
            }
        }

        #endregion

        #region Static methods

        public static void CreateColumns(DataGridView a_DataGridView)
        {
            // Clear existing columns
            a_DataGridView.Columns.Clear();

            // Create columns
            foreach (var property in COLUMNS_INFO)
            {
                DataGridViewColumn column;

                // Enum properties
                if (property.Item1.PropertyType.IsEnum)
                {
                    var dgvcbc = new DataGridViewComboBoxColumn
                    {
                        DataSource = Enum.GetValues(property.Item1.PropertyType),
                        ValueType = property.Item1.PropertyType
                    };
                    column = dgvcbc;
                }
                // Other properties
                else
                {
                    column = new DataGridViewTextBoxColumn();
                }

                column.Name = property.Item1.Name;
                column.Width = (int) (a_DataGridView.Width *
                                      (property.Item2.RelativeColumnWidth /
                                       RELATIVE_COLUMN_WIDTHS_SUM));
                a_DataGridView.Columns.Add(column);
            }

            // Last column fills the rest of the table
            var last = a_DataGridView.Columns[a_DataGridView.Columns.Count - 1];
            last.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        public static void UpdateView(DataGridView a_DataGridView, List<T> a_Elements)
        {
            // Clear previous rows
            a_DataGridView.Rows.Clear();

            // For each element
            for (int i = 0; i < a_Elements.Count; ++i)
            {
                // Add row for this element
                a_DataGridView.Rows.Add();

                // For each element property
                int j = 0;
                foreach (var property in COLUMNS_INFO)
                {
                    var a = a_DataGridView.Rows[i];

                    // Call the getter to get the value
                    var b = property.Item1.GetGetMethod(true);
                    var obj = b.Invoke(a_Elements[i], new object[0]);

                    // Non enum values need toString conversion
                    if (!property.Item1.PropertyType.IsEnum)
                    {
                        string objStr = obj.ToString();

                        // Concatenate list of strings into a single string
                        if (obj is List<string>)
                        {
                            objStr = (obj as List<string>).Aggregate("",
                                (a_Current, a_Item) => a_Current + a_Item + ", ");
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

        public static PropertyInfo GetColumnProperty(int a_ColumnIdx)
        {
            return COLUMNS_INFO[a_ColumnIdx].Item1;
        }

        #endregion
    }

    [AttributeUsage(AttributeTargets.Property)]
    internal sealed class ColumnInfoAttribute : Attribute
    {
        #region Properties

        public double RelativeColumnWidth { get; set; }

        #endregion
    }
}