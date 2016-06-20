using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using Librarium.Data;
using Librarium.Data.LibraryAuthorizationModule;
using Librarium.Data.LibraryItems;


namespace Librarium.Data
{
    [Serializable]
    public class Library
    {

        public List<LibraryItem> LibraryStorage { get; set; }


        public LibraryAuthorizator Authorizator { get; set; }


        public InnerLibraryValidator Validator { get; set; }


        public UniqueIDGenerator IDGenerator { get; set; }


        public Library()
        {
            LibraryStorage = new List<LibraryItem>();
            Authorizator = new LibraryAuthorizator();
            Validator = new InnerLibraryValidator();
        }


        public Library(List<LibraryItem> libraryStorage, LibraryAuthorizator authorizator, Dictionary<LibraryItem, LibraryUser> libraryLogBook)
        {
            this.LibraryStorage = libraryStorage;
            this.Authorizator = authorizator;
            Validator = new InnerLibraryValidator();
        }


        public int AmountOfBooksByGenre(Book.GenreEnum genre)
        {
            var bookItems = from item in LibraryStorage
                            where item is Book
                            select item as Book;


            var bookList = bookItems.ToList();


            var result = from book in bookList
                         where book.GenreOfBook.HasFlag(genre)
                         select book;

            result.ToList();

            return result.Count();
        }


        public int AmountOfTextBooksBySubject(TextBook.TextBookType subject)
        {
            var textBookItems = from item in LibraryStorage
                            where item is TextBook
                            select item as TextBook;


            var textBookList = textBookItems.ToList();


            var result = from textBook in textBookList
                         where textBook.TextBookSubject.Equals(subject)
                         select textBook;

            return result.Count();
        }


        public int AmountOfJournalsBySubject(Journal.JournalType subject)
        {
            var journalItems = from item in LibraryStorage
                                where item is Journal
                                select item as Journal;


            var journalList = journalItems.ToList();


            var result = from journal in journalList
                         where journal.JournalSubject.Equals(subject)
                         select journal;

            return result.Count();
        }


        public void MostNewItem(LibraryItem.ItemType typeOfSearchingItem)
        {
            var mostNewItem = LibraryStorage.Max(item => item.DateOfPublication);

            var result = from item in LibraryStorage
                         where item.DateOfPublication.Equals(mostNewItem)
                         select item;

            var foundItem = result.ToList()[0];

            Console.WriteLine("Most newest {0} is:", typeOfSearchingItem);
            Console.WriteLine("Name: " + foundItem.Name);

            foreach (var author in foundItem.Authors)
            {
                Console.WriteLine("Author: " + author);
            }

            Console.WriteLine("Pages: " + foundItem.AmountOfPages);
            Console.WriteLine("Date of publication: " + foundItem.DateOfPublication.ToShortDateString());
            Console.WriteLine("Popularity Index: " + foundItem.PopularityIndex);
        }


        public void MostOldItem(LibraryItem.ItemType typeOfSearchingItem)
        {
            var mostOldItem = LibraryStorage.Min(item => item.DateOfPublication);

            var result = from item in LibraryStorage
                         where item.DateOfPublication.Equals(mostOldItem)
                         select item;

            var foundItem = result.ToList()[0];

            Console.WriteLine("Most oldest {0} is:", typeOfSearchingItem);
            Console.WriteLine("Name: " + foundItem.Name);
            
            foreach(var author in foundItem.Authors)
            {
                Console.WriteLine("Author: " + author);
            }

            Console.WriteLine("Pages: " + foundItem.AmountOfPages);
            Console.WriteLine("Date of publication: " + foundItem.DateOfPublication.ToShortDateString());
            Console.WriteLine("Popularity Index: " + foundItem.PopularityIndex);
        }


        public void MostPopularItem(LibraryItem.ItemType typeOfSearchingItem)
        {
            var mostPopularItem = LibraryStorage.Max(item => item.PopularityIndex);

            var result = from item in LibraryStorage
                         where item.PopularityIndex.Equals(mostPopularItem)
                         select item;

            var foundItem = result.ToList()[0];

            Console.WriteLine("Most popular {0} is:", typeOfSearchingItem);
            Console.WriteLine("Name: " + foundItem.Name);

            foreach (var author in foundItem.Authors)
            {
                Console.WriteLine("Author: " + author);
            }

            Console.WriteLine("Pages: " + foundItem.AmountOfPages);
            Console.WriteLine("Date of publication: " + foundItem.DateOfPublication.ToShortDateString());
            Console.WriteLine("Popularity Index: " + foundItem.PopularityIndex);
        }


        public bool ContainsBy(string name)
        {
            return LibraryStorage.Any(item => item.Name.Equals(name));
        }


        public bool ContainsBy(params string[] authors)
        {
            bool result = false;


            foreach(var author in authors)
            {
                result = LibraryStorage.Any(item => item.Authors.Contains(author));
            }


            return result;
        }


        public bool ContainsBy(string name, params string[] authors)
        {
            bool result = false;


            foreach (var author in authors)
            {
                result = LibraryStorage.Any(item => item.Name.Equals(name) && item.Authors.Contains(author));
            }


            return result;
        }

        
        public LibraryItem GiveItemToSubscriber(string name)
        {
            foreach (var item in LibraryStorage)
            {
                if (item.Name.Equals(name))
                {
                    if (Validator.IsLibraryItemValid(item))
                    {
                        item.PopularityIndex++;
                        LibraryStorage.Remove(item);

                        return item;
                    }
                }
            }

            return null;
        }


        public LibraryItem GiveItemToSubscriber(string name, string[] authors)
        {
            foreach (var item in LibraryStorage)
            {
                if (item.Name.Equals(name) && item.Authors.Equals(authors))
                {
                    item.PopularityIndex++;
                    LibraryStorage.Remove(item);

                    if (Validator.IsLibraryItemValid(item))
                    {
                        return item;
                    }
                }
            }

            return null;
        }


        public void AcceptItemFromSubscriber(LibraryUser subscriber, LibraryItem item)
        {
            item.LastSubscriber = subscriber;
            LibraryStorage.Add(item);
        }


        public void DonateItemToLibrary(LibraryItem newItem)
        {
            LibraryStorage.Add(newItem);
        }


        public void DonateItemWithValidation(LibraryItem newItem)
        {
            if(Validator.IsLibraryItemValid(newItem))
            {
                LibraryStorage.Add(newItem);
                Console.WriteLine("Book {0} was succesfuly added to library", newItem.Name);
            }
        }
    }
}
