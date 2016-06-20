using System;
using System.Collections.Generic;
using System.IO.Compression;
using Librarium.Data;
using Librarium.Data.LibraryAuthorizationModule;
using Librarium.Data.LibraryItems;
using Librarium.ZIPCompressor;


namespace Librarium
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, this program will demonstate a deserialization of the Library state");


            Console.WriteLine("===================================================================================================================================");
            Console.WriteLine("Now we will deserialize our library with  XML deserialization alghoritm from XML file");


            var xmlSerialer = new XMLSerializator();
            Library localLibrary = xmlSerialer.DeserializeLibrary();


            Console.WriteLine("===================================================================================================================================");
            Console.WriteLine("Now we will zip library condition, unzip and then deserialize our library from unziped XML file");


            string pathFrom = @"LibraryConditionZip\LibState\";
            string pathToZip = @"LibraryConditionZip\zipped\LibState.zip";
            string pathToUnzip = @"LibraryConditionZip\extract\";


            ZipFile.CreateFromDirectory(pathFrom, pathToZip);


            ZipFile.ExtractToDirectory(pathToZip, pathToUnzip);


            localLibrary = xmlSerialer.DeserializeLibrary(@"LibraryConditionZip\extract\LibraryStateXML.xml");


            Console.WriteLine("===================================================================================================================================");
            Console.WriteLine("Thank you for your attention, please press any key to exit..");
            Console.ReadKey();

        }
    }
}
