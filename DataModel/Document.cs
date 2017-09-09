// - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
// MIT License
// Copyright (c) 2017 Stained Glass Guild
// See file "LICENSE.txt" at project root for complete license
// ~   ~   ~   ~   ~   ~   ~   ~   ~   ~   ~   ~   ~   ~   ~   ~   ~   ~   ~   ~   ~   ~   ~   ~   ~
// Project: Compost
// File: Document.cs
// Creation: 2017-09
// Author: Jérémie Coulombe
// - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -

using System.Collections.Generic;
using System.Runtime.Serialization;

namespace StainedGlassGuild.Compost.DataModel
{
   internal sealed partial class Composition
   {
      #region Nested types

      [DataContract]
      public sealed partial class Document
      {
         #region Nested types

         public enum Type
         {
            SOFTWARE_PARTITION,
            SHEET_PARTITION,
            AUDIO_FILE,
            ARTWORK,
            LYRICS,
            OTHER
         }

         #endregion

         #region Properties

         [DataMember(IsRequired = true)]
         public string Name { get; set; }

         [DataMember(IsRequired = true)]
         public Type DocType { get; set; }

         [DataMember]
         public Dictionary<string, string> CustomProperties { get; set; }

         [DataMember(IsRequired = true)]
         public List<Version> Versions { get; set; }

         #endregion
      }

      #endregion
   }
}
