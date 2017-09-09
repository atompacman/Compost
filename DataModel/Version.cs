// - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
// MIT License
// Copyright (c) 2017 Stained Glass Guild
// See file "LICENSE.txt" at project root for complete license
// ~   ~   ~   ~   ~   ~   ~   ~   ~   ~   ~   ~   ~   ~   ~   ~   ~   ~   ~   ~   ~   ~   ~   ~   ~
// Project: Compost
// File: Version.cs
// Creation: 2017-09
// Author: Jérémie Coulombe
// - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -

using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace StainedGlassGuild.Compost.DataModel
{
   internal sealed partial class Composition
   {
      #region Nested types

      public sealed partial class Document
      {
         #region Nested types

         [DataContract]
         public sealed class Version
         {
            #region Properties

            [DataMember(IsRequired = true)]
            public string FilePath { get; set; }

            [DataMember(IsRequired = true)]
            public string VersionNumber { get; set; }

            [DataMember(IsRequired = true)]
            public DateTime CreationDate { get; set; }

            [DataMember(IsRequired = true)]
            public DateTime LastModificationDate { get; set; }

            [DataMember]
            public Dictionary<string, string> CustomProperties { get; set; }

            #endregion
         }

         #endregion
      }

      #endregion
   }
}
