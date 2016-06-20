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

namespace Librarium.ZIPCompressor
{
    public class XMLSerializator
    {

        public void SerializeLibrary(Library lib)
        {
            var watch = Stopwatch.StartNew();


            var formatter = new XmlSerializer(typeof(Library));


            using (var fs = new FileStream("LibraryStateXML.xml", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, lib);
            }


            watch.Stop();

            var elapsedMs = watch.ElapsedMilliseconds;
            Console.WriteLine("XML serialization took {0} ms", elapsedMs);
        }


        public void SerializeLibrary(Library lib, string fullPath)
        {
            var watch = Stopwatch.StartNew();


            var formatter = new XmlSerializer(typeof(Library));


            using (var fs = new FileStream(fullPath, FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, lib);
            }


            watch.Stop();

            var elapsedMs = watch.ElapsedMilliseconds;
            Console.WriteLine("XML serialization took {0} ms", elapsedMs);
        }


        public Library DeserializeLibrary()
        {
            var watch = Stopwatch.StartNew();

            var formatter = new XmlSerializer(typeof(Library));
            Library lib = new Library();


            using (var fs = new FileStream("LibraryStateXML.xml", FileMode.OpenOrCreate))
            {
                lib = formatter.Deserialize(fs) as Library;
            }


            watch.Stop();

            var elapsedMs = watch.ElapsedMilliseconds;
            Console.WriteLine("XML deserialization took {0} ms", elapsedMs);


            return lib;
        }


        public Library DeserializeLibrary(string fullPath)
        {
            var watch = Stopwatch.StartNew();

            var formatter = new XmlSerializer(typeof(Library));
            Library lib = new Library();


            using (var fs = new FileStream(fullPath, FileMode.OpenOrCreate))
            {
                lib = formatter.Deserialize(fs) as Library;
            }


            watch.Stop();

            var elapsedMs = watch.ElapsedMilliseconds;
            Console.WriteLine("XML deserialization took {0} ms", elapsedMs);


            return lib;
        }
    }
}
