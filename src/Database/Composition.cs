using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Compost.Database
{
    [DataContract]
    internal sealed class Composition
    {
        #region NESTED TYPES

        [DataContract]
        public sealed class Document
        {

            #region NESTED TYPES

            [DataContract]
            public sealed class Version
            {
                #region PUBLIC PROPERTIES

                [DataMember(IsRequired = true)] public uint     MajorVersionNumber   { get; set; }
                [DataMember(IsRequired = true)] public uint     MinorVersionNumber   { get; set; }
                [DataMember(IsRequired = true)] public DateTime CreationDate         { get; set; }
                [DataMember(IsRequired = true)] public DateTime LastModificationDate { get; set; }
                [DataMember(IsRequired = true)] public string   Description          { get; set; }

                #endregion
            }

            public enum DocumentType
            {
                SoftwarePartition,
                SheetPartition,
                AudioFile,
                Artwork,
                Lyrics,
                Other
            }

            #endregion

            #region PUBLIC PROPERTIES

            [DataMember(IsRequired = true)] public List<Version> Versions    { get; set; }
            [DataMember(IsRequired = true)] public string        Name        { get; set; }
            [DataMember(IsRequired = true)] public DocumentType  DocType     { get; set; }
            [DataMember(IsRequired = true)] public string        Description { get; set; }

            #endregion
        }

        public enum AttributionType
        {
            Original,
            Arrangement,
            ByOthers,
            Collaboration,
        }

        public enum Tier
        {
            Stone,
            Bronze,
            Silver,
            Gold,
            Diamond
        }

        #endregion

        #region PUBLIC PROPERTIES

        [DataMember(IsRequired = true)]
        public List<Document> Resources { get; set; }

        [DataMember(IsRequired = true), CompostBrowser.ColumnInfo(RelativeColumnWidth = 0.1)]
        public AttributionType Attribution { get; set; }

        [DataMember(IsRequired = true), CompostBrowser.ColumnInfo(RelativeColumnWidth = 0.1)]
        public List<string> Authors { get; set; }

        [DataMember(IsRequired = true), CompostBrowser.ColumnInfo(RelativeColumnWidth = 0.1)]
        public string Era { get; set; }

        [DataMember(IsRequired = true), CompostBrowser.ColumnInfo(RelativeColumnWidth = 0.1)]
        public string Genre { get; set; }

        [DataMember(IsRequired = true), CompostBrowser.ColumnInfo(RelativeColumnWidth = 0.1)]
        public string Subgenre { get; set; }

        [DataMember(IsRequired = true), CompostBrowser.ColumnInfo(RelativeColumnWidth = 0.1)]
        public string Title { get; set; }

        [DataMember(IsRequired = true), CompostBrowser.ColumnInfo(RelativeColumnWidth = 0.1)]
        public string SetTitle { get; set; }

        [DataMember(IsRequired = true), CompostBrowser.ColumnInfo(RelativeColumnWidth = 0.1)]
        public Tier QualityTier { get; set; }

        [DataMember(IsRequired = true), CompostBrowser.ColumnInfo(RelativeColumnWidth = 0.1)]
        public List<string> Instruments { get; set; }

        [DataMember(IsRequired = true), CompostBrowser.ColumnInfo(RelativeColumnWidth = 0.1)]
        public string Description { get; set; }

        #endregion
    }
}
