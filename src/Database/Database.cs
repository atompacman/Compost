using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Text;

namespace Compost.Database
{
    [DataContract]
    internal sealed class Database
    {
        #region COMPILE-TIME CONSTANTS

        private const string DB_FILE_NAME     = "Database.json";
        private const string ARCHIVE_DIR_NAME = "Archive";

        #endregion

        #region RUNTIME CONSTANTS

        private static readonly DataContractJsonSerializer DCJS;

        #endregion

        #region PUBLIC PROPERTIES

        [DataMember(IsRequired = true)] public List<Composition> Compositions   { get; set; }
        [DataMember(IsRequired = true)] public string            Name           { get; set; }
        [DataMember(IsRequired = true)] public string            FileHierarchy  { get; set; }
        [DataMember(IsRequired = true)] public ExtensionTable    ExtensionTable { get; set; }

        public DirectoryInfo Root { get; set; }

        #endregion

        #region INIT

        static Database()
        {
            var settings = new DataContractJsonSerializerSettings
            {
                UseSimpleDictionaryFormat = true
            };
            DCJS = new DataContractJsonSerializer(typeof(Database), settings);
        }

        public static Database Load(DirectoryInfo dir)
        {
            var stream = File.OpenRead(Path.Combine(dir.FullName, DB_FILE_NAME));
            var db = DCJS.ReadObject(stream) as Database;
            stream.Close();
            db.Root = dir;
            return db;
        }

        #endregion

        #region SAVE

        public void Save()
        {
            if (!Directory.Exists(Root.ToString()))
            {
                throw new IOException("Project directory (" + Root + " does not exist!");
            }
            Save(Path.Combine(Root.ToString(), DB_FILE_NAME));

            var archiveDir = new DirectoryInfo(Path.Combine(Root.ToString(), ARCHIVE_DIR_NAME));
            archiveDir.Create();
            Save(Path.Combine(archiveDir.ToString(), DateTime.Now.ToString("MM-dd-yyyy HH-mm-ss")));
        }

        public void Save(string path)
        {
            var stream = File.OpenWrite(path);
            var writer = JsonReaderWriterFactory.CreateJsonWriter(stream, Encoding.UTF8, true,true);
            DCJS.WriteObject(writer, this);
            writer.Close();
        }

        #endregion
    }
}
