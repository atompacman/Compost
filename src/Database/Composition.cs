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

                [DataMember(IsRequired = true), ColumnInfo(RelativeColumnWidth = 0.2)]
                public uint MajorVersionNumber { get; set; }

                [DataMember(IsRequired = true), ColumnInfo(RelativeColumnWidth = 0.2)]
                public uint MinorVersionNumber { get; set; }

                [DataMember(IsRequired = true), ColumnInfo(RelativeColumnWidth = 0.8)]
                public DateTime CreationDate { get; set; }

                [DataMember(IsRequired = true), ColumnInfo(RelativeColumnWidth = 0.8)]
                public DateTime LastModificationDate { get; set; }

                [DataMember(IsRequired = true), ColumnInfo(RelativeColumnWidth = 2.0)]
                public string Description { get; set; }

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

            [DataMember(IsRequired = true)]
            public List<Version> Versions { get; set; }

            [DataMember(IsRequired = true), ColumnInfo(RelativeColumnWidth = 1.0)]
            public string Name { get; set; }

            [DataMember(IsRequired = true), ColumnInfo(RelativeColumnWidth = 0.3)]
            public DocumentType DocType { get; set; }

            [DataMember(IsRequired = true), ColumnInfo(RelativeColumnWidth = 2.0)]
            public string Description { get; set; }

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
        public List<Document> Documents { get; set; }

        [DataMember(IsRequired = true), ColumnInfo(RelativeColumnWidth = 0.6)]
        public AttributionType Attribution { get; set; }

        [DataMember(IsRequired = true), ColumnInfo(RelativeColumnWidth = 1.0)]
        public List<string> Authors { get; set; }

        [DataMember(IsRequired = true), ColumnInfo(RelativeColumnWidth = 0.8)]
        public string Era { get; set; }

        [DataMember(IsRequired = true), ColumnInfo(RelativeColumnWidth = 0.6)]
        public string Genre { get; set; }

        [DataMember(IsRequired = true), ColumnInfo(RelativeColumnWidth = 0.8)]
        public string Subgenre { get; set; }

        [DataMember(IsRequired = true), ColumnInfo(RelativeColumnWidth = 1.1)]
        public string Title { get; set; }

        [DataMember(IsRequired = true), ColumnInfo(RelativeColumnWidth = 1.2)]
        public string SetTitle { get; set; }

        [DataMember(IsRequired = true), ColumnInfo(RelativeColumnWidth = 0.5)]
        public Tier QualityTier { get; set; }

        [DataMember(IsRequired = true), ColumnInfo(RelativeColumnWidth = 1.3)]
        public List<string> Instruments { get; set; }

        [DataMember(IsRequired = true), ColumnInfo(RelativeColumnWidth = 3.0)]
        public string Description { get; set; }

        #endregion
    }
}
