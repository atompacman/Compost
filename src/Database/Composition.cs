// MIT License
// 
// Copyright (c) 2016 FXGuild
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy of this software and
// associated documentation files (the "Software"), to deal in the Software without restriction,
// including without limitation the rights to use, copy, modify, merge, publish, distribute,
// sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in all copies or
// substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT
// NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM,
// DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.

using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace FXGuild.Compost
{
    [DataContract]
    internal sealed class Composition
    {
        #region Nested types

        [DataContract]
        public sealed class Document
        {
            #region Nested types

            public enum DocumentType
            {
                SOFTWARE_PARTITION,
                SHEET_PARTITION,
                AUDIO_FILE,
                ARTWORK,
                LYRICS,
                OTHER
            }

            #endregion

            #region Nested types

            [DataContract]
            public sealed class Version
            {
                #region Properties

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

            #endregion

            #region Properties

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

        #endregion

        #region Nested types

        public enum Tier
        {
            STONE,
            BRONZE,
            SILVER,
            GOLD,
            DIAMOND
        }

        #endregion

        #region Properties

        [DataMember(IsRequired = true)]
        public List<Document> Documents { get; set; }

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
