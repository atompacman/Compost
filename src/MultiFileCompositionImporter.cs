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
using System.Linq;
using System.Windows.Forms;

namespace FXGuild.Compost
{
    internal partial class MultiFileCompositionImporter : Form
    {
        #region Private fields

        private readonly ExtensionTable m_ExtensionTable;

        #endregion

        #region Constructors

        public MultiFileCompositionImporter(ExtensionTable a_ExtTable)
        {
            InitializeComponent();

            m_ExtensionTable = a_ExtTable;
        }

        #endregion

        #region Methods

        private void OnImportButtonClick(object a_Sender, EventArgs a_Args)
        {
            // Ask user to select files
            var dialog = new OpenFileDialog
            {
                Multiselect = true
            };
            dialog.ShowDialog();

            // For each selected file
            foreach (string file in dialog.FileNames)
            {
                // Don't add a file twice
                if (listView1.Items.ContainsKey(file))
                {
                    continue;
                }

                // Find file document type
                var docType = Composition.Document.Type.OTHER;
                int idx = file.LastIndexOf(".");
                if (idx != -1)
                {
                    // Look for document type in extension table
                    string ext = file.Substring(idx + 1, file.Length - idx - 1);
                    if (m_ExtensionTable.HasExtension(ext))
                    {
                        docType = m_ExtensionTable[ext].DocType;
                    }
                }

                // Find list view group containing documents of this type
                var group = listView1.Groups.Cast<ListViewGroup>()
                    .FirstOrDefault(a_Group => a_Group.Header == docType.ToString());

                // Create group if needed
                if (group == null)
                {
                    group = new ListViewGroup(docType.ToString());
                    listView1.Groups.Add(group);
                }

                // Add item to the list
                listView1.Items.Add(file).Group = group;
            }
        }

        #endregion
    }
}