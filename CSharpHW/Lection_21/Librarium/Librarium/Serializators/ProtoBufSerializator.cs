using System;
using System.Collections.Generic;
using ProtoBuf;
using ProtoBuf.Serializers;
using System.IO;
using System.Diagnostics;
using Librarium.Data;
using Librarium.Data.LibraryAuthorizationModule;
using Librarium.Data.CustomAttribute;
using Librarium.Data.LibraryItems;

namespace Librarium.Serializators
{
    public class ProtoBufSerializator
    {
        public void SerializeLibrary(List<LibraryItem> lib)
        {
            var watch = Stopwatch.StartNew();


            using (var fs = new FileStream("ProtoBufLibrary.bin", FileMode.OpenOrCreate))
            {
                Serializer.Serialize(fs, lib);
            }


            watch.Stop();

            var elapsedMs = watch.ElapsedMilliseconds;
            Console.WriteLine("Protobuf serialization took {0} ms", elapsedMs);
        }
    }
}
