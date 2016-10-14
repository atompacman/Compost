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
using System.Windows.Forms;

namespace Compost.src
{
    internal partial class DatabaseSettingsEditor : Form
    {
        #region Private fields

        private readonly Action m_UnblockCallingWin;

        #endregion

        #region Constructors

        public DatabaseSettingsEditor(Action a_UnblockCallingWin)
        {
            InitializeComponent();

            m_UnblockCallingWin = a_UnblockCallingWin;
        }

        #endregion

        #region Methods

        private void OnAddExtensionButtonClick(object a_Sender, EventArgs a_Args)
        {
            // Open blocking extension adder dialog
            Enabled = false;
            var extAdder = new ExtensionAdder(() => Enabled = true);
            extAdder.Show();
        }

        private void OnFormClosed(object a_Sender, FormClosedEventArgs a_Args)
        {
            m_UnblockCallingWin();
        }

        #endregion
    }
}