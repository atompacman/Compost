using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Compost.Database
{
    [DataContract]
    internal sealed class Composition
    {
        //  ~  NESTED TYPES  ~  \\

        [DataContract]
        internal sealed class Resource
        {
            //  ~  NESTED TYPES  ~  \\

            [DataContract]
            internal sealed class Version
            {
                //  ~  ACCESSORS  ~  \\

                [DataMember(IsRequired = true)] internal uint     MajorVersionNumber   { get; set; }
                [DataMember(IsRequired = true)] internal uint     MinorVersionNumber   { get; set; }
                [DataMember(IsRequired = true)] internal DateTime CreationDate         { get; set; }
                [DataMember(IsRequired = true)] internal DateTime LastModificationDate { get; set; }
                [DataMember(IsRequired = true)] internal string   Description          { get; set; }
            }

            internal enum DocumentType
            {
                SOFTWARE_PARTITION,
                SHEET_PARTITION,
                AUDIO_FILE,
                ARTWORK,
                LYRICS,
                OTHER
            }


            //  ~  ACCESSORS  ~  \\

            [DataMember(IsRequired = true)] internal List<Version> Versions    { get; set; }
            [DataMember(IsRequired = true)] internal string        Name        { get; set; }
            [DataMember(IsRequired = true)] internal DocumentType  DocType     { get; set; }
            [DataMember(IsRequired = true)] internal string        Description { get; set; }
        }

        internal enum AttributionType
        {
            Original,
            Arrangement,
            By_Others,
            Collaboration,
        }

        internal enum Tier
        {
            Stone,
            Bronze,
            Silver,
            Gold,
            Diamond
        }


        //  ~  ACCESSORS  ~  \\

        [DataMember(IsRequired = true)] internal List<Resource>  Resources   { get; set; }
        [DataMember(IsRequired = true)] internal AttributionType Attribution { get; set; }
        [DataMember(IsRequired = true)] internal List<string>    Authors     { get; set; }
        [DataMember(IsRequired = true)] internal string          Era         { get; set; }
        [DataMember(IsRequired = true)] internal string          Genre       { get; set; }
        [DataMember(IsRequired = true)] internal string          Subgenre    { get; set; }
        [DataMember(IsRequired = true)] internal string          Title       { get; set; }
        [DataMember(IsRequired = true)] internal string          SetTitle    { get; set; }
        [DataMember(IsRequired = true)] internal Tier            QualityTier { get; set; }
        [DataMember(IsRequired = true)] internal List<string>    Instruments { get; set; }
        [DataMember(IsRequired = true)] internal string          Description { get; set; }
    }
}
