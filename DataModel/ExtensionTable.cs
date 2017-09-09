// - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
// MIT License
// Copyright (c) 2017 Stained Glass Guild
// See file "LICENSE.txt" at project root for complete license
// ~   ~   ~   ~   ~   ~   ~   ~   ~   ~   ~   ~   ~   ~   ~   ~   ~   ~   ~   ~   ~   ~   ~   ~   ~
// Project: Compost
// File: ExtensionTable.cs
// Creation: 2017-09
// Author: Jérémie Coulombe
// - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -

using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace StainedGlassGuild.Compost.DataModel
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
         public Composition.Document.Type DocType { get; private set; }

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

      public bool HasExtension(string a_Ext)
      {
         return m_Extensions.ContainsKey(a_Ext);
      }

      private void AssertExtensionExists(string a_Ext)
      {
         if (!HasExtension(a_Ext))
         {
            throw new ArgumentException("No registered extension \"" + a_Ext + "\" found");
         }
      }

      private void AssertExtensionDoesNotExists(string a_Ext)
      {
         if (HasExtension(a_Ext))
         {
            throw new ArgumentException("Extension \"" + a_Ext + "\" is already registered");
         }
      }

      #endregion
   }
}
