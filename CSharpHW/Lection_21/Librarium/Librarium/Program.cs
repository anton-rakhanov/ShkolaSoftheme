using System;
using System.Collections.Generic;
using Librarium.Data;
using Librarium.Data.LibraryAuthorizationModule;
using Librarium.Data.LibraryItems;
using Librarium.Serializators;


namespace Librarium
{
    public class Program
    {
        static void Main(string[] args)
        {

            List<LibraryItem> listOfLibraryItem = new List<LibraryItem>();


            var arrayOfNewBooks = new Book[] { 
                                               new Book("Dead House", "Zung Lung", LibraryItem.ItemType.Book, new DateTime(1999, 01, 15), 574, Book.GenreEnum.Horror | Book.GenreEnum.Triller),
                                               new Book("Dead House", "Zung Lung", LibraryItem.ItemType.Book, new DateTime(1999, 01, 15), 574, Book.GenreEnum.Horror | Book.GenreEnum.Triller),
                                               new Book("Solarium", new string[]{"Howard Dwon", "Shila DeTankewil"}, LibraryItem.ItemType.Book, new DateTime(1992, 07, 31), 876, Book.GenreEnum.ScienceFiction),
                                               new Book("Solarium", new string[]{"Howard Dwon", "Shila DeTankewil"}, LibraryItem.ItemType.Book, new DateTime(1992, 07, 31), 876, Book.GenreEnum.ScienceFiction),
                                               new Book("Dark Dawn", "Climent Cort", LibraryItem.ItemType.Book, new DateTime(1987, 05, 18), 657, Book.GenreEnum.Drama),
                                               new Book("Dark Dawn", "Climent Cort", LibraryItem.ItemType.Book, new DateTime(1987, 05, 18), 657, Book.GenreEnum.Drama),
                                               new Book("Irdwin", "Foggel Barks", LibraryItem.ItemType.Book, new DateTime(1907, 02, 23), 809, Book.GenreEnum.Fantasy),
                                               new Book("Irdwin", "Foggel Barks", LibraryItem.ItemType.Book, new DateTime(1907, 02, 23), 809, Book.GenreEnum.Fantasy),
                                               new Book("The Place for Innocent", "Juagar Brom", LibraryItem.ItemType.Book, new DateTime(1964, 03, 09), 423, Book.GenreEnum.Triller | Book.GenreEnum.Adventure),
                                               new Book("The Place for Innocent", "Juagar Brom", LibraryItem.ItemType.Book, new DateTime(1964, 03, 09), 423, Book.GenreEnum.Triller | Book.GenreEnum.Adventure),
                                               new Book("Endless road", new string[]{"Zirmala Shenada", "Anneta Whiteminer"}, LibraryItem.ItemType.Book, new DateTime(1974, 09, 20), 690, Book.GenreEnum.Adventure),
                                               new Book("Endless road", new string[]{"Zirmala Shenada", "Anneta Whiteminer"}, LibraryItem.ItemType.Book, new DateTime(1974, 09, 20), 690, Book.GenreEnum.Adventure)
                                             };


            var arrayOfNewJournals = new Journal[] { 
                                                     new Journal("CyberWorld", "GamersArmy Co.", LibraryItem.ItemType.Journal, new DateTime(2009, 11, 28), 140, Journal.JournalType.VideoGames),
                                                     new Journal("CyberWorld", "GamersArmy Co.", LibraryItem.ItemType.Journal, new DateTime(2009, 11, 28), 140, Journal.JournalType.VideoGames),
                                                     new Journal("Fat Sharks", "Economy Street Publish", LibraryItem.ItemType.Journal, new DateTime(2013, 10, 08), 103, Journal.JournalType.Economy),
                                                     new Journal("Fat Sharks", "Economy Street Publish", LibraryItem.ItemType.Journal, new DateTime(2013, 10, 08), 103, Journal.JournalType.Economy),
                                                     new Journal("Legacy of Science", "Old School Co.", LibraryItem.ItemType.Journal, new DateTime(2015, 09, 21), 185, Journal.JournalType.Science),
                                                     new Journal("Legacy of Science", "Old School Co.", LibraryItem.ItemType.Journal, new DateTime(2015, 09, 21), 185, Journal.JournalType.Science)
                                                    };


            var arrayOfNewTextBooks = new TextBook[] { 
                                                       new TextBook("Math for 5-th Grade", "Domen Wolf", LibraryItem.ItemType.TextBook, new DateTime(2009, 02, 15), 891, TextBook.TextBookType.Math),
                                                       new TextBook("Math for 5-th Grade", "Domen Wolf", LibraryItem.ItemType.TextBook, new DateTime(2009, 02, 15), 891, TextBook.TextBookType.Math),
                                                       new TextBook("Physics", "Clara Richards", LibraryItem.ItemType.TextBook, new DateTime(2012, 04, 08), 1280, TextBook.TextBookType.Physics),
                                                       new TextBook("Physics", "Clara Richards", LibraryItem.ItemType.TextBook, new DateTime(2012, 04, 08), 1280, TextBook.TextBookType.Physics),
                                                       new TextBook("Around The World", "Marcus Riddle", LibraryItem.ItemType.TextBook, new DateTime(2002, 11, 11), 453, TextBook.TextBookType.Geography),
                                                       new TextBook("Around The World", "Marcus Riddle", LibraryItem.ItemType.TextBook, new DateTime(2002, 11, 11), 453, TextBook.TextBookType.Geography)
                                                     };

            foreach(var book in arrayOfNewBooks)
            {
                listOfLibraryItem.Add(book as LibraryItem);
            }


            foreach (var journal in arrayOfNewJournals)
            {
                listOfLibraryItem.Add(journal as LibraryItem);
            }


            foreach (var textBook in arrayOfNewTextBooks)
            {
                listOfLibraryItem.Add(textBook as LibraryItem);
            }


            for (int i = 0; i < 200; i++ )
            {
                var libItem = new Book("TestingSerializationName"+i.ToString(), "TestingSerializationAuthor"+i.ToString(), LibraryItem.ItemType.Book, new DateTime(1800, 01, 01), 1000, Book.GenreEnum.Drama);
                listOfLibraryItem.Add(libItem as LibraryItem);
            }


            Console.WriteLine("Hello, this program will demonstate a library item list serialization");

            
            var binSerial = new BinarySerializator();
            var xmlSerial = new XMLSerializator();
            var jsonSerial = new JSONSerializator();
            var protobufSerial = new ProtoBufSerializator();


            Console.WriteLine("===================================================================================================================================");
            Console.WriteLine("Now we will serialize our library with Binary, XML, JSON and ProtoBuf serialization alghoritms");


            binSerial.SerializeLibrary(listOfLibraryItem);
            xmlSerial.SerializeLibrary(listOfLibraryItem);
            jsonSerial.SerializeLibrary(listOfLibraryItem);
            protobufSerial.SerializeLibrary(listOfLibraryItem);

            var itemList = xmlSerial.DeserializeLibrary();

            Console.WriteLine("===================================================================================================================================");
            Console.WriteLine("Thank you for your attention, please press any key to exit..");
            Console.ReadKey();

        }
    }
}
