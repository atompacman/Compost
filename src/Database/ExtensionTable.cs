using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;

namespace Compost.Database
{
    [DataContract]
    internal sealed class ExtensionTable
    {
        //  ~  NESTED TYPES  ~  \\

        [DataContract]
        internal sealed class ExtensionInfo
        {
            [DataMember(IsRequired = true)] 
            internal Composition.Resource.DocumentType DocType { get; private set; }
            [DataMember(IsRequired = true)]
            internal string                            AppPath { get; private set; }
        }


        //  ~  FIELDS  ~  \\

        [DataMember(Name = "Extensions")]
        private Dictionary<string, ExtensionInfo> m_Extensions;


        //  ~  SETTERS  ~  \\

        internal void AddExtension(string ext, ExtensionInfo info)
        {
            AssertExtensionDoesNotExists(ext);
            m_Extensions[ext] = info;
        }

        internal void RemoveExtension(string ext)
        {
            AssertExtensionExists(ext);
            m_Extensions.Remove(ext);
        }


        //  ~  GETTERS  ~  \\

        internal ExtensionInfo this[string ext]
        {
            get
            {
                AssertExtensionExists(ext);
                return m_Extensions[ext];
            }
        }


        //  ~  UTILS  ~  \\

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
    }
}
