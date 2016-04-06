using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Compost.Database
{
    [DataContract]
    internal sealed class ExtensionTable
    {
        #region NESTED TYPES

        [DataContract]
        public sealed class ExtensionInfo
        {
            [DataMember(IsRequired = true)] 
            public Composition.Document.DocumentType DocType { get; private set; }
            [DataMember(IsRequired = true)]
            public string                            AppPath { get; private set; }
        }

        #endregion

        #region PRIVATE FIELDS  

        [DataMember(Name = "Extensions")]
        private Dictionary<string, ExtensionInfo> m_Extensions;

        #endregion

        #region SETTERS

        public void AddExtension(string ext, ExtensionInfo info)
        {
            AssertExtensionDoesNotExists(ext);
            m_Extensions[ext] = info;
        }

        public void RemoveExtension(string ext)
        {
            AssertExtensionExists(ext);
            m_Extensions.Remove(ext);
        }

        #endregion

        #region GETTERS

        public ExtensionInfo this[string ext]
        {
            get
            {
                AssertExtensionExists(ext);
                return m_Extensions[ext];
            }
        }
        #endregion

        #region UTILS

        private void AssertExtensionExists(string ext)
        {
            if (!m_Extensions.ContainsKey(ext))
            {
                throw new ArgumentException("No registered extension \"" + ext + "\" found");
            }
        }

        private void AssertExtensionDoesNotExists(string ext)
        {
            if (m_Extensions.ContainsKey(ext))
            {
                throw new ArgumentException("Extension \"" + ext + "\" is already registered");
            }
        }

        #endregion
    }
}
