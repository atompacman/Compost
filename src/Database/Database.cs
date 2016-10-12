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
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Text;

namespace FXGuild.Compost
{
    [DataContract]
    internal sealed class Database
    {
        #region Compile-time constants

        private const string DB_FILE_NAME = "Database.json";
        private const string ARCHIVE_DIR_NAME = "Archive";
        private const string ARCHIVE_FILE_TIMESTAMP_PATTERN = "MM-dd-yyyy HH-mm-ss";

        #endregion

        #region Runtime constants

        private static readonly DataContractJsonSerializer DCJS;

        #endregion

        #region Properties

        [DataMember(IsRequired = true)]
        public List<Composition> Compositions { get; set; }

        [DataMember(IsRequired = true)]
        public string Name { get; set; }

        [DataMember(IsRequired = true)]
        public string FileHierarchy { get; set; }

        [DataMember(IsRequired = true)]
        public ExtensionTable ExtensionTable { get; set; }

        public DirectoryInfo Root { get; set; }

        #endregion

        #region Constructors

        static Database()
        {
            var settings = new DataContractJsonSerializerSettings
            {
                UseSimpleDictionaryFormat = true
            };
            DCJS = new DataContractJsonSerializer(typeof(Database), settings);
        }

        #endregion

        #region Static methods

        public static Database Load(DirectoryInfo a_Dir)
        {
            var stream = File.OpenRead(Path.Combine(a_Dir.FullName, DB_FILE_NAME));
            var db = (Database) DCJS.ReadObject(stream);
            stream.Close();
            db.Root = a_Dir;
            return db;
        }

        #endregion

        #region Methods

        public void Save()
        {
            if (!Directory.Exists(Root.ToString()))
            {
                throw new IOException("Project directory (" + Root + " does not exist!");
            }
            Save(Path.Combine(Root.ToString(), DB_FILE_NAME));

            var archiveDir = new DirectoryInfo(Path.Combine(Root.ToString(), ARCHIVE_DIR_NAME));
            archiveDir.Create();
            Save(Path.Combine(archiveDir.ToString(),
                DateTime.Now.ToString(ARCHIVE_FILE_TIMESTAMP_PATTERN)));
        }

        public void Save(string a_Path)
        {
            var stream = File.OpenWrite(a_Path);
            var writer = JsonReaderWriterFactory.CreateJsonWriter(stream, Encoding.UTF8, true,
                true);
            DCJS.WriteObject(writer, this);
            writer.Close();
        }

        #endregion
    }
}