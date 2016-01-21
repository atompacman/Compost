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
                //  ~  PROPERTIES  ~  \\

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


            //  ~  PROPERTIES  ~  \\

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

        [AttributeUsage(AttributeTargets.Property, AllowMultiple = false)]
        internal sealed class CompositionBrowserColumnInfoAttribute : Attribute
        {
            public uint ColumnWidth { get; set; }
        }


        //  ~  PROPERTIES  ~  \\

        [DataMember(IsRequired = true)]
        internal List<Resource> Resources { get; set; }

        [DataMember(IsRequired = true), CompositionBrowserColumnInfo(ColumnWidth = 100)]
        internal AttributionType Attribution { get; set; }

        [DataMember(IsRequired = true), CompositionBrowserColumnInfo(ColumnWidth = 477)]
        internal List<string> Authors { get; set; }

        [DataMember(IsRequired = true), CompositionBrowserColumnInfo(ColumnWidth = 100)]
        internal string Era { get; set; }

        [DataMember(IsRequired = true), CompositionBrowserColumnInfo(ColumnWidth = 60)]
        internal string Genre { get; set; }

        [DataMember(IsRequired = true), CompositionBrowserColumnInfo(ColumnWidth = 300)]
        internal string Subgenre { get; set; }

        [DataMember(IsRequired = true), CompositionBrowserColumnInfo(ColumnWidth = 100)]
        internal string Title { get; set; }

        [DataMember(IsRequired = true), CompositionBrowserColumnInfo(ColumnWidth = 100)]
        internal string SetTitle { get; set; }

        [DataMember(IsRequired = true), CompositionBrowserColumnInfo(ColumnWidth = 80)]
        internal Tier QualityTier { get; set; }

        [DataMember(IsRequired = true), CompositionBrowserColumnInfo(ColumnWidth = 100)]
        internal List<string> Instruments { get; set; }

        [DataMember(IsRequired = true), CompositionBrowserColumnInfo(ColumnWidth = 100)]
        internal string Description { get; set; }
    }
}
