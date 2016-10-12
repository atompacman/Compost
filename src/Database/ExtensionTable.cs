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
using System.Runtime.Serialization;

namespace FXGuild.Compost
{
    [DataContract]
    internal sealed class ExtensionTable
    {
        #region Nested types

        [DataContract]
        public sealed class ExtensionInfo
        {
            #region Properties

            [DataMember(IsRequired = true)]
            public Composition.Document.DocumentType DocType { get; private set; }

            [DataMember(IsRequired = true)]
            public string AppPath { get; private set; }

            #endregion
        }

        #endregion

        #region Private fields

        [DataMember(Name = "Extensions")]
        private Dictionary<string, ExtensionInfo> m_Extensions;

        #endregion

        #region Properties

        public ExtensionInfo this[string a_Ext]
        {
            get
            {
                AssertExtensionExists(a_Ext);
                return m_Extensions[a_Ext];
            }
        }

        #endregion

        #region Constructors

        public ExtensionTable()
        {
            m_Extensions = new Dictionary<string, ExtensionInfo>();
        }

        #endregion

        #region Methods

        public void AddExtension(string a_Ext, ExtensionInfo a_Info)
        {
            AssertExtensionDoesNotExists(a_Ext);
            m_Extensions[a_Ext] = a_Info;
        }

        public void RemoveExtension(string a_Ext)
        {
            AssertExtensionExists(a_Ext);
            m_Extensions.Remove(a_Ext);
        }

        private void AssertExtensionExists(string a_Ext)
        {
            if (!m_Extensions.ContainsKey(a_Ext))
            {
                throw new ArgumentException("No registered extension \"" + a_Ext + "\" found");
            }
        }

        private void AssertExtensionDoesNotExists(string a_Ext)
        {
            if (m_Extensions.ContainsKey(a_Ext))
            {
                throw new ArgumentException("Extension \"" + a_Ext + "\" is already registered");
            }
        }

        #endregion
    }
}
