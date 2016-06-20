using System;
using Librarium.Data;
using Librarium.Data.LibraryItems;
using Librarium.Data.LibraryAuthorizationModule;

namespace Librarium
{
    public class Program
    {
        static void Main(string[] args)
        {

            Library localLibrary = new Library();


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
                localLibrary.DonateItemToLibrary(book as LibraryItem);
            }


            foreach (var journal in arrayOfNewJournals)
            {
                localLibrary.DonateItemToLibrary(journal as LibraryItem);
            }


            foreach (var textBook in arrayOfNewTextBooks)
            {
                localLibrary.DonateItemToLibrary(textBook as LibraryItem);
            }


            Console.WriteLine("Hello, this program will demonstate a functionality of Library using LINQ");


            Console.WriteLine("===================================================================================================================================");
            if (localLibrary.ContainsBy(name: "Dawn Of World"))
            {
                Console.WriteLine("There is such item in library");
            }
            else
            {
                Console.WriteLine("There is no such item in library");
            }


            Console.WriteLine("===================================================================================================================================");
            if (localLibrary.ContainsBy(authors: "Clara Richards"))
            {
                Console.WriteLine("There is such item in library");
            }
            else
            {
                Console.WriteLine("There is no such item in library");
            }


            Console.WriteLine("===================================================================================================================================");
            if (localLibrary.ContainsBy("Endless road", new string[] { "Zirmala Shenada", "Anneta Whiteminer" }))
            {
                Console.WriteLine("There is such item in library");
            }
            else
            {
                Console.WriteLine("There is no such item in library");
            }


            Console.WriteLine("===================================================================================================================================");
            Console.WriteLine("Amount of books with genre Horror is: " + localLibrary.AmountOfBooksByGenre(Book.GenreEnum.Horror));


            Console.WriteLine("===================================================================================================================================");
            localLibrary.MostOldItem(LibraryItem.ItemType.Book);


            Console.WriteLine("===================================================================================================================================");
            localLibrary.MostNewItem(LibraryItem.ItemType.Journal);

            Console.WriteLine("===================================================================================================================================");

            var user = new LibraryUser("Bob", "Clauden", "BobyBoy", "11111");
            localLibrary.Authorizator.Registration(user);

            var takenItem = localLibrary.GiveItemToSubscriber("Solarium");
            localLibrary.AcceptItemFromSubscriber(user, takenItem);

            localLibrary.MostPopularItem(LibraryItem.ItemType.Book);

            Console.WriteLine("===================================================================================================================================");

            Console.WriteLine("Thank you for your attention, please press any key to exit..");
            Console.ReadKey();

        }
    }
}
