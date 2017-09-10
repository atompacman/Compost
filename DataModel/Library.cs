// - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
// MIT License
// Copyright (c) 2017 Stained Glass Guild
// See file "LICENSE.txt" at project root for complete license
// ~   ~   ~   ~   ~   ~   ~   ~   ~   ~   ~   ~   ~   ~   ~   ~   ~   ~   ~   ~   ~   ~   ~   ~   ~
// Project: Compost
// File: Library.cs
// Creation: 2017-09
// Author: Jérémie Coulombe
// - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -

using System.Collections.Generic;
using System.Runtime.Serialization;

namespace StainedGlassGuild.Compost.DataModel
{
   [DataContract]
   internal sealed class Library
   {
      #region Properties

      [DataMember(IsRequired = true)]
      public List<Composition> Compositions { get; set; }

      [DataMember(IsRequired = true)]
      public string Name { get; set; }

      [DataMember(IsRequired = true)]
      public string FileHierarchy { get; set; }

      [DataMember(IsRequired = true)]
      public Dictionary<string, Composition.Document.Type> ExtensionMappings { get; set; }

      [DataMember(IsRequired = true)]
      public List<string> CompositionCustomPropertyNames { get; set; }

      [DataMember(IsRequired = true)]
      public List<string> DocumentCustomPropertyNames { get; set; }

      [DataMember(IsRequired = true)]
      public List<string> VersionCustomPropertyNames { get; set; }

      #endregion
   }
}
