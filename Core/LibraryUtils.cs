// - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
// MIT License
// Copyright (c) 2017 Stained Glass Guild
// See file "LICENSE.txt" at project root for complete license
// ~   ~   ~   ~   ~   ~   ~   ~   ~   ~   ~   ~   ~   ~   ~   ~   ~   ~   ~   ~   ~   ~   ~   ~   ~
// Project: Compost
// File: LibraryUtils.cs
// Creation: 2017-09
// Author: Jérémie Coulombe
// - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -

using System;
using System.IO;
using System.Runtime.Serialization.Json;
using System.Text;

using StainedGlassGuild.Compost.DataModel;

namespace StainedGlassGuild.Compost.Core
{
   internal static class LibraryUtils
   {
      #region Compile-time constants

      private const string BACKUP_DIR_PREFIX = "Backup";
      private const string BACKUP_FILE_TIMESTAMP_PATTERN = "MM-dd-yyyy HH-mm-ss";

      #endregion

      #region Runtime constants

      private static readonly DataContractJsonSerializer DCJS;

      #endregion

      #region Constructors

      static LibraryUtils()
      {
         // Create json database object parser
         var settings = new DataContractJsonSerializerSettings
         {
            UseSimpleDictionaryFormat = true
         };
         DCJS = new DataContractJsonSerializer(typeof(Library), settings);
      }

      #endregion

      #region Static methods

      public static Library Open(string a_Path)
      {
         using (var stream = File.OpenRead(a_Path))
         {
            return (Library) DCJS.ReadObject(stream);
         }
      }

      public static void Save(Library a_Lib, string a_DestPath)
      {
         void WriteLib(string a_Path)
         {
            using (var stream = File.Create(a_Path))
            {
               using (var writer =
                  JsonReaderWriterFactory.CreateJsonWriter(stream, Encoding.UTF8, true, true))
               {
                  DCJS.WriteObject(writer, a_Lib);
               }
            }
         }

         // Create archive directory if needed
         string archiveDirName = BACKUP_DIR_PREFIX + '_' + a_Lib.Name;
         string archiveDirPath = Path.Combine(Directory.GetCurrentDirectory(), archiveDirName);
         if (!Directory.Exists(archiveDirPath))
         {
            Directory.CreateDirectory(archiveDirPath);
         }

         // Save a copy of the database in the archive directory
         string timestamp = DateTime.Now.ToString(BACKUP_FILE_TIMESTAMP_PATTERN);
         WriteLib(Path.Combine(archiveDirPath, timestamp));

         // Overwrite current copy of the database
         WriteLib(a_DestPath);
      }

      #endregion
   }
}
