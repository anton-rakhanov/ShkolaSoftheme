using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Xml.Serialization;
using System.IO;
using System.Diagnostics;
using Librarium.Data;
using Librarium.Data.LibraryAuthorizationModule;
using Librarium.Data.CustomAttribute;
using Librarium.Data.LibraryItems;

namespace Librarium.Serializators
{
    public class XMLSerializator
    {
        public void SerializeLibrary(List<LibraryItem> lib)
        {
            var watch = Stopwatch.StartNew();

            var formatter = new XmlSerializer(typeof(List<LibraryItem>));


            using (var fs = new FileStream("XMLLibrary.xml", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, lib);
            }


            watch.Stop();

            var elapsedMs = watch.ElapsedMilliseconds;
            Console.WriteLine("XML serialization took {0} ms", elapsedMs);
        }


        public List<LibraryItem> DeserializeLibrary()
        {
            var watch = Stopwatch.StartNew();

            var formatter = new XmlSerializer(typeof(List<LibraryItem>));
            List<LibraryItem> lib = new List<LibraryItem>();


            using (var fs = new FileStream("XMLLibrary.xml", FileMode.OpenOrCreate))
            {
                lib = formatter.Deserialize(fs) as List<LibraryItem>;
            }


            watch.Stop();

            var elapsedMs = watch.ElapsedMilliseconds;
            Console.WriteLine("XML deserialization took {0} ms", elapsedMs);


            return lib;
        }
    }
}
