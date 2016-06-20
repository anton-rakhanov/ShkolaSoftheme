using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.IO;
using System.Diagnostics;
using Librarium.Data;
using Librarium.Data.LibraryAuthorizationModule;
using Librarium.Data.CustomAttribute;
using Librarium.Data.LibraryItems;

namespace Librarium.ZIPCompressor
{
    public class JSONSerializator
    {
        public void SerializeLibrary(List<LibraryItem> lib)
        {
            var watch = Stopwatch.StartNew();


            var settings = new DataContractJsonSerializerSettings()
            {
                KnownTypes = new List<Type> { typeof(List<Book>), typeof(List<Journal>), typeof(List<TextBook>) }
            };


            var formatter = new DataContractJsonSerializer(typeof(List<LibraryItem>), settings);


            using (var fs = new FileStream("JSONLibrary.json", FileMode.OpenOrCreate))
            {
                formatter.WriteObject(fs, lib);
            }


            watch.Stop();

            var elapsedMs = watch.ElapsedMilliseconds;
            Console.WriteLine("JSON serialization took {0} ms", elapsedMs);
        }
    }
}
