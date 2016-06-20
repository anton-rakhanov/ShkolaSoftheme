using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Diagnostics;
using Librarium.Data;
using Librarium.Data.LibraryAuthorizationModule;
using Librarium.Data.CustomAttribute;
using Librarium.Data.LibraryItems;

namespace Librarium.ZIPCompressor
{
    public class BinarySerializator
    {
        public void SerializeLibrary(List<LibraryItem> lib)
        {
            var watch = Stopwatch.StartNew();

            var formatter = new BinaryFormatter();


            using(var fs = new FileStream("BinaryLibrary.dat", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, lib);
            }


            watch.Stop();

            var elapsedMs = watch.ElapsedMilliseconds;
            Console.WriteLine("Binary serialization took {0} ms", elapsedMs);
        }
    }
}
