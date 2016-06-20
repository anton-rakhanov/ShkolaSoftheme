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


            Console.WriteLine("Hello, this program will demonstate a functionality of Library using LINQ and Attributes");
            Console.WriteLine("===================================================================================================================================");
            Console.WriteLine("Create new array of books with 2 invalid data input and 1 valid");


            var unvalidatedBooks = new Book[] { 
                                               new Book(null, "Zung Lung", (LibraryItem.ItemType) 5, new DateTime(1999, 01, 15), 0, Book.GenreEnum.Horror | Book.GenreEnum.Triller),
                                               new Book("Dead House", "Zung Lung", LibraryItem.ItemType.Book, new DateTime(1999, 01, 15), 574, Book.GenreEnum.Horror | Book.GenreEnum.Triller),
                                               new Book("", "Zung Lung", (LibraryItem.ItemType) 0, new DateTime(1999, 01, 15), -280, Book.GenreEnum.Horror | Book.GenreEnum.Triller)
                                              };


            Console.WriteLine("And try to add them into library");
            foreach(var book in unvalidatedBooks)
            {
                Console.WriteLine("===================================================================================================================================");
                localLibrary.DonateItemWithValidation(book);
            }


            Console.WriteLine("===================================================================================================================================");
            Console.WriteLine("Now we check our validation system, we will try register 3 users, but only 1 will have valid data");


            var userOne = new LibraryUser("", null, "boby", "234asd");
            localLibrary.Authorizator.Registration(userOne);


            Console.WriteLine("===================================================================================================================================");

            localLibrary.Authorizator.Registration(null, "Simon", "-2452", "___");


            Console.WriteLine("===================================================================================================================================");

            var userThree = new LibraryUser("Samuel", "Gordon", "Samuel1990", "12345678");
            localLibrary.Authorizator.Registration(userThree);


            if (localLibrary.Authorizator.IsAuthorized("Samuel1990", "12345678"))
            {
                Console.WriteLine("Authorization was successfully");
            }
            else
            {
                Console.WriteLine("There is no such user in Library");
            }


            Console.WriteLine("===================================================================================================================================");
            Console.WriteLine("Now will be demonstated custom attribute OnlyForView, it has been applied to Journal Type, so now, journals can't be given to users.");

            localLibrary.GiveItemToSubscriber("Legacy of Science");

            Console.WriteLine("===================================================================================================================================");
            Console.WriteLine("But information about journals in library can be provided");


            if (localLibrary.ContainsBy("Legacy of Science"))
            {
                Console.WriteLine("There is such item in library");
            }
            else
            {
                Console.WriteLine("There is no such item in library");
            }


            if (localLibrary.ContainsBy(authors: "GamersArmy Co."))
            {
                Console.WriteLine("There is such item in library");
            }
            else
            {
                Console.WriteLine("There is no such item in library");
            }


            if (localLibrary.ContainsBy("CyberWorld", "GamersArmy Co."))
            {
                Console.WriteLine("There is such item in library");
            }
            else
            {
                Console.WriteLine("There is no such item in library");
            }

            Console.WriteLine("===================================================================================================================================");
            Console.WriteLine("Thank you for your attention, please press any key to exit..");
            Console.ReadKey();

        }
    }
}
