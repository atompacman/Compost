using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Xml;

namespace Compost.Database
{
    [DataContract]
    internal sealed class Database
    {
        //  ~  CONSTANTS  ~  \\

        private const string DB_FILE_NAME     = "Database.json";
        private const string ARCHIVE_DIR_NAME = "Archive";


        //  ~  STATIC FIELDS  ~  \\

        private static DataContractJsonSerializer s_DCJS;


        //  ~  ACCESSORS  ~  \\

        [DataMember(IsRequired = true)] internal List<Composition> Compositions   { get; set; }
        [DataMember(IsRequired = true)] internal string            Name           { get; set; }
        [DataMember(IsRequired = true)] internal string            FileHierarchy  { get; set; }
        [DataMember(IsRequired = true)] internal ExtensionTable    ExtensionTable { get; set; }

        internal DirectoryInfo Root { get; set; }


        //  ~  INIT  ~  \\

        static Database()
        {
            var settings = new DataContractJsonSerializerSettings();
            settings.UseSimpleDictionaryFormat = true;
            s_DCJS = new DataContractJsonSerializer(typeof(Database), settings);
        }

        internal static Database Load(DirectoryInfo dir)
        {
            var stream = File.OpenRead(Path.Combine(dir.FullName, DB_FILE_NAME));
            var db = s_DCJS.ReadObject(stream) as Database;
            stream.Close();
            db.Root = dir;
            return db;
        }


        // ~ SAVE ~ \\

        internal void Save()
        {
            if (!Directory.Exists(Root.ToString()))
            {
                throw new IOException("Project directory (" + Root.ToString() + " does not exist!");
            }
            Save(Path.Combine(Root.ToString(), DB_FILE_NAME));

            var archiveDir = new DirectoryInfo(Path.Combine(Root.ToString(), ARCHIVE_DIR_NAME));
            archiveDir.Create();
            Save(Path.Combine(archiveDir.ToString(), DateTime.Now.ToString("MM-dd-yyyy HH-mm-ss")));
        }

        private void Save(string path)
        {
            var stream = File.OpenWrite(path);
            var writer = JsonReaderWriterFactory.CreateJsonWriter(stream, Encoding.UTF8, true,true);
            s_DCJS.WriteObject(writer, this);
            writer.Close();
        }
    }
}
