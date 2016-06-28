using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Linq;
using Librarium.ZIPCompressor;
using Librarium.Data;
using Librarium.Data.LibraryItems;

namespace Librarium.Data.LibraryExtensionMethods
{
    public static class LinqToXMLExtensions
    {

        public static void SearchBy(this Library lib, string name)
        {
            XDocument doc = XDocument.Load("LibraryStorageCondition.xml");
            var searchResult = doc.Descendants("LibraryItem")
                               .Where(li => li.Elements("Name")
                                   .Any(f => ((string)f == name)));

            var listResult = searchResult.ToList();

            foreach (var root in listResult)
            {

                var rootXElements = root.Elements();
                Console.WriteLine("===============================================");


                foreach (var XElem in rootXElements)
                {
                    Console.WriteLine("{0}: {1}", XElem.Name, XElem.Value);
                }
            }
        }


        public static void SearchBy(this Library lib, params string[] authors)
        {
            XDocument doc = XDocument.Load("LibraryStorageCondition.xml");


            foreach (var author in authors)
            {
                var searchResult = doc.Descendants("LibraryItem")
                                   .Where(li => li.Elements("Authors")
                                       .Elements("string")
                                           .Any(f => ((string)f == author)));

                var listResult = searchResult.ToList();

                foreach (var root in listResult)
                {

                    var rootXElements = root.Elements();
                    Console.WriteLine("===============================================");


                    foreach (var XElem in rootXElements)
                    {
                        Console.WriteLine("{0}: {1}", XElem.Name, XElem.Value);
                    }
                }
            }
        }


        public static void SearchBy(this Library lib, string name, params string[] authors)
        {
            XDocument doc = XDocument.Load("LibraryStorageCondition.xml");


            foreach (var author in authors)
            {
                var searchResult = doc.Descendants("LibraryItem")
                                   .Where(li => li.Elements("Name")
                                       .Any(f => (string)f == name)
                                            && li.Elements("Authors")
                                               .Elements("string")
                                                   .Any(f => ((string)f == author)));

                var listResult = searchResult.ToList();

                foreach (var root in listResult)
                {

                    var rootXElements = root.Elements();
                    Console.WriteLine("===============================================");


                    foreach (var XElem in rootXElements)
                    {
                        Console.WriteLine("{0}: {1}", XElem.Name, XElem.Value);
                    }
                }
            }
        }


        public static void AddLibraryItem(this Library lib, LibraryItem item)
        {

            XDocument doc = XDocument.Load("LibraryStorageCondition.xml");
            XNamespace ns = "http://www.w3.org/2001/XMLSchema-instance";


            var newItem = new XElement("LibraryItem",
                                            new XAttribute(ns + "type", item.TypeOfItem.ToString()),
                                       new XElement("UniqueItemID", lib.IDGenerator.GenerateUniqueID()),
                                       new XElement("Name", item.Name),
                                       new XElement("Authors"),
                                       new XElement("TypeOfItem", item.TypeOfItem.ToString()),
                                       new XElement("DateOfPublication", item.DateOfPublication.ToString()),
                                       new XElement("AmountOfPages", item.AmountOfPages),
                                       new XElement("PopularityIndex", item.PopularityIndex));


            foreach (var author in item.Authors)
            {
                newItem.Element("Authors").Add(new XElement("string", author));
            }

            switch (item.TypeOfItem)
            {
                case LibraryItem.ItemType.Book:
                    {
                        var book = item as Book;
                        newItem.Add(new XElement("GenreOfBook", book.GenreOfBook));
                        break;
                    }
                case LibraryItem.ItemType.Journal:
                    {
                        var journal = item as Journal;
                        newItem.Element("LibraryItem").Add(new XElement("JournalSubject", journal.JournalSubject));
                        break;
                    }
                case LibraryItem.ItemType.TextBook:
                    {
                        var textBook = item as TextBook;
                        newItem.Element("LibraryItem").Add(new XElement("GenreOfBook", textBook.TextBookSubject));
                        break;
                    }
            }

            doc.Element("ArrayOfLibraryItem").Add(newItem);
            doc.Save("LibraryStorageCondition.xml");
        }


        public static LibraryItem ExtractLibraryItemBy(this Library lib, string name)
        {
            XDocument doc = XDocument.Load("LibraryStorageCondition.xml");
            var searchResult = doc.Descendants("LibraryItem")
                               .Where(li => li.Elements("Name")
                                   .Any(f => ((string)f == name)));

            var listResult = searchResult.ToList();

            foreach (var root in listResult)
            {
                var xmlSerializator = new XMLSerializator();
                var findedItem = xmlSerializator.DeserializeLibraryItem(root);
                root.Remove();
                return findedItem;
            }


            return null;
        }


        public static LibraryItem ExtractLibraryItemBy(this Library lib, params string[] authors)
        {
            XDocument doc = XDocument.Load("LibraryStorageCondition.xml");


            foreach (var author in authors)
            {
                var searchResult = doc.Descendants("LibraryItem")
                                   .Where(li => li.Elements("Authors")
                                       .Elements("string")
                                           .Any(f => ((string)f == author)));

                var listResult = searchResult.ToList();

                foreach (var root in listResult)
                {
                    var xmlSerializator = new XMLSerializator();
                    var findedItem = xmlSerializator.DeserializeLibraryItem(root);
                    root.Remove();
                    return findedItem;
                }

            }

            return null;
        }


        public static LibraryItem ExtractLibraryItemBy(this Library lib, string name, params string[] authors)
        {
            XDocument doc = XDocument.Load("LibraryStorageCondition.xml");


            foreach (var author in authors)
            {
                var searchResult = doc.Descendants("LibraryItem")
                                   .Where(li => li.Elements("Name")
                                       .Any(f => (string)f == name)
                                            && li.Elements("Authors")
                                               .Elements("string")
                                                   .Any(f => ((string)f == author)));

                var listResult = searchResult.ToList();

                foreach (var root in listResult)
                {
                    var xmlSerializator = new XMLSerializator();
                    var findedItem = xmlSerializator.DeserializeLibraryItem(root);
                    root.Remove();
                    return findedItem;
                }

            }

            return null;
        }
    }
}
