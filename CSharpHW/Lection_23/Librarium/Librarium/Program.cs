using System;
using System.Collections.Generic;
using System.IO.Compression;
using Librarium.Data;
using Librarium.Data.LibraryAuthorizationModule;
using Librarium.Data.LibraryItems;
using Librarium.ZIPCompressor;
using Librarium.Data.LibraryExtensionMethods;
using System.Xml.Linq;

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
            Console.WriteLine("Now we will serialize our library storage condition");


            //xmlSerialer.SerializeLibraryStorage(localLibrary.LibraryStorage);


            Console.WriteLine("===================================================================================================================================");
            Console.WriteLine("Now we will use extension methods for searching in XML file using LINQ To XML in our library storage");
            

            localLibrary.SearchBy(name: "Dead House");


            localLibrary.SearchBy(authors: "Howard Dwon");


            localLibrary.SearchBy(name: "Irdwin", authors:"Foggel Barks");


            localLibrary.AddLibraryItem(new Book("Blood For The King", "Damil Akra", LibraryItem.ItemType.Book, new DateTime(1965, 12, 01), 903, Book.GenreEnum.Drama));


            var result = localLibrary.ExtractLibraryItemBy(name: "Blood For The King");


            Console.WriteLine("===================================================================================================================================");
            Console.WriteLine("Thank you for your attention, please press any key to exit..");
            Console.ReadKey();

        }
    }
}
