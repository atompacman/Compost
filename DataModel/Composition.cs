// - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
// MIT License
// Copyright (c) 2017 Stained Glass Guild
// See file "LICENSE.txt" at project root for complete license
// ~   ~   ~   ~   ~   ~   ~   ~   ~   ~   ~   ~   ~   ~   ~   ~   ~   ~   ~   ~   ~   ~   ~   ~   ~
// Project: Compost
// File: Composition.cs
// Creation: 2017-09
// Author: Jérémie Coulombe
// - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -

using System.Collections.Generic;
using System.Runtime.Serialization;

namespace StainedGlassGuild.Compost.DataModel
{
   [DataContract]
   internal sealed partial class Composition
   {
      #region Properties

      [DataMember(IsRequired = true)]
      public string Title { get; set; }

      [DataMember]
      public Dictionary<string, string> CustomProperties { get; set; }

      [DataMember(IsRequired = true)]
      public List<Document> Documents { get; set; }

      #endregion
   }
}
