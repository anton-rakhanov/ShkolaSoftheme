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
using System.Xml;
using System.Xml.Linq;
using System.Text;

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


        public void SerializeLibraryStorage(List<LibraryItem> libItems)
        {
            var watch = Stopwatch.StartNew();


            var formatter = new XmlSerializer(typeof(List<LibraryItem>));


            using (var fs = new FileStream("LibraryStorageCondition.xml", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, libItems);
            }


            watch.Stop();

            var elapsedMs = watch.ElapsedMilliseconds;
            Console.WriteLine("XML serialization took {0} ms", elapsedMs);
        }


        public XElement SerializeLibraryItemInMemory(LibraryItem item)
        {
            using (var mS = new MemoryStream())
            {
                using (TextWriter sW = new StreamWriter(mS))
                {
                    var xmlSerializer = new XmlSerializer(typeof(XElement));
                    xmlSerializer.Serialize(sW, item);
                    return XElement.Parse(Encoding.UTF8.GetString(mS.ToArray()));
                }
            }
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


        public List<LibraryItem> DeserializeLibraryStorage()
        {
            var watch = Stopwatch.StartNew();

            var formatter = new XmlSerializer(typeof(Library));
            var libItemsStorage = new List<LibraryItem>();


            using (var fs = new FileStream("LibraryStorageCondition.xml", FileMode.OpenOrCreate))
            {
                libItemsStorage = formatter.Deserialize(fs) as List<LibraryItem>;
            }


            watch.Stop();

            var elapsedMs = watch.ElapsedMilliseconds;
            Console.WriteLine("XML deserialization took {0} ms", elapsedMs);


            return libItemsStorage;
        }


        public LibraryItem DeserializeLibraryItem(XElement xElem)
        {
            var serializer = new XmlSerializer(typeof(LibraryItem));
            var item = serializer.Deserialize(xElem.CreateReader()) as LibraryItem;

            return item;
        }
    }
}
