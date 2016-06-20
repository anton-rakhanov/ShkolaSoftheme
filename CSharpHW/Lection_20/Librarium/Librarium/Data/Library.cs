using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using Librarium.Data;
using Librarium.Data.LibraryAuthorizationModule;
using Librarium.Data.LibraryItems;

namespace Librarium.Data
{
    public class Library
    {

        private List<LibraryItem> _libraryStorage;


        public LibraryAuthorizator Authorizator { get; private set; }


        private InnerLibraryValidator _validator;


        private Dictionary<LibraryItem, LibraryUser> _libraryLogBook;


        public Library()
        {
            _libraryStorage = new List<LibraryItem>();
            Authorizator = new LibraryAuthorizator();
            _validator = new InnerLibraryValidator();
            _libraryLogBook = new Dictionary<LibraryItem, LibraryUser>();
        }


        public Library(List<LibraryItem> libraryStorage, LibraryAuthorizator authorizator, Dictionary<LibraryItem, LibraryUser> libraryLogBook)
        {
            this._libraryStorage = libraryStorage;
            this.Authorizator = authorizator;
            _validator = new InnerLibraryValidator();
            this._libraryLogBook = libraryLogBook;
        }


        public int AmountOfBooksByGenre(Book.GenreEnum genre)
        {
            var bookItems = from item in _libraryStorage
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
            var textBookItems = from item in _libraryStorage
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
            var journalItems = from item in _libraryStorage
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
            var mostNewItem = _libraryStorage.Max(item => item.DateOfPublication);

            var result = from item in _libraryStorage
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
            var mostOldItem = _libraryStorage.Min(item => item.DateOfPublication);

            var result = from item in _libraryStorage
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
            var mostPopularItem = _libraryStorage.Max(item => item.PopularityIndex);

            var result = from item in _libraryStorage
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
            return _libraryStorage.Any(item => item.Name.Equals(name));
        }


        public bool ContainsBy(params string[] authors)
        {
            bool result = false;


            foreach(var author in authors)
            {
                result = _libraryStorage.Any(item => item.Authors.Contains(author));
            }


            return result;
        }


        public bool ContainsBy(string name, params string[] authors)
        {
            bool result = false;


            foreach (var author in authors)
            {
                result = _libraryStorage.Any(item => item.Name.Equals(name) && item.Authors.Contains(author));
            }


            return result;
        }

        
        public LibraryItem GiveItemToSubscriber(string name)
        {
            foreach (var item in _libraryStorage)
            {
                if (item.Name.Equals(name))
                {
                    if (_validator.IsLibraryItemValid(item))
                    {
                        item.PopularityIndex++;
                        _libraryStorage.Remove(item);

                        return item;
                    }
                }
            }

            return null;
        }


        public LibraryItem GiveItemToSubscriber(string name, string[] authors)
        {
            foreach (var item in _libraryStorage)
            {
                if (item.Name.Equals(name) && item.Authors.Equals(authors))
                {
                    item.PopularityIndex++;
                    _libraryStorage.Remove(item);

                    if (_validator.IsLibraryItemValid(item))
                    {
                        return item;
                    }
                }
            }

            return null;
        }


        public void AcceptItemFromSubscriber(LibraryUser subscriber, LibraryItem item)
        {
            _libraryStorage.Add(item);
            
            if(_libraryLogBook.ContainsKey(item))
            {
                _libraryLogBook[item] = subscriber;
            }
            else
            {
                _libraryLogBook.Add(item, subscriber);
            }

        }


        public void DonateItemToLibrary(LibraryItem newItem)
        {
            _libraryStorage.Add(newItem);
        }


        public void DonateItemWithValidation(LibraryItem newItem)
        {
            if(_validator.IsLibraryItemValid(newItem))
            {
                _libraryStorage.Add(newItem);
                Console.WriteLine("Book {0} was succesfuly added to library", newItem.Name);
            }
        }
    }
}
