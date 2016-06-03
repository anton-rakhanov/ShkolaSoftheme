using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Data
{
    public class LibraryBase
    {
        private List<Book> _booksStorage = new List<Book>();

        public List<Book> BooksStorage
        {
            get { return _booksStorage; }
            set { _booksStorage = value; }
        }

        private Dictionary<Book, User> _logBook = new Dictionary<Book, User>();

        private List<User> _usersDataBase = new List<User>();

        /*private Book[] _booksStorage;

        public Book[] BooksStorage
        {
            get { return _booksStorage; }
            set { _booksStorage = value; }
        }*/

        public LibraryBase()
        {
            _booksStorage.Add(new Book("Star", "Mark Jonson", GenreEnum.ScienceFiction, new DateTime(1992, 10, 5), 323));
            _booksStorage.Add(new Book("Star", "Mark Jonson", GenreEnum.ScienceFiction, new DateTime(1992, 10, 5), 323));
            _booksStorage.Add(new Book("Dead House", "Zung Lung", GenreEnum.Horror | GenreEnum.Triller, new DateTime(1999, 1, 15), 689));
            _booksStorage.Add(new Book("Long Summer", "Daniel Kraug", GenreEnum.Drama, new DateTime(2000, 11, 1), 384));

            _usersDataBase.Add(new User("Bob", "Frader", "Boby1", "123456"));
        }

        public bool IsVerifiedUser(string login, string password)
        {
            foreach(var user in _usersDataBase)
            {
                if(user.Login == login && user.Password == password)
                {
                    return true;
                }
            }
            return false;
        }

        public int FindAmountOfBooksByGenre(GenreEnum genre)
        {
            int amountCounter = 0;

            foreach (var book in _booksStorage)
            {
                if (book.Genre == genre)
                {
                    amountCounter++;
                }
            }
            return amountCounter;
        }

        public void FindMostNewPublicatedBook()
        {
            var mostNewBook = _booksStorage[0];

            foreach (var book in _booksStorage)
            {
                if (book.DateOfPublication > mostNewBook.DateOfPublication)
                {
                    mostNewBook = book;
                }
            }

            Console.WriteLine("Name of book: {0} \nName of author: {1} \nGenre: {2} \nPublication date: {3} \nNumber of pages: {4} \nIndex of popularity: {5}",
                            mostNewBook.Name,
                            mostNewBook.Author,
                            mostNewBook.Genre.ToString(),
                            mostNewBook.DateOfPublication.ToShortDateString(),
                            mostNewBook.AmountOfPages,
                            mostNewBook.PopularityIndex);
        }

        public void FindMostOldPublicatedBook()
        {
            var mostOldBook = _booksStorage[0];

            foreach (var book in _booksStorage)
            {
                if (book.DateOfPublication < mostOldBook.DateOfPublication)
                {
                    mostOldBook = book;
                }
            }

            Console.WriteLine("Name of book: {0} \nName of author: {1} \nGenre: {2} \nPublication date: {3} \nNumber of pages: {4} \nIndex of popularity: {5}",
                            mostOldBook.Name,
                            mostOldBook.Author,
                            mostOldBook.Genre.ToString(),
                            mostOldBook.DateOfPublication.ToShortDateString(),
                            mostOldBook.AmountOfPages,
                            mostOldBook.PopularityIndex);
        }

        public void FindMostPopularBook()
        {
            var mostPopularBook = _booksStorage[0];

            foreach (var book in _booksStorage)
            {
                if (book.PopularityIndex > mostPopularBook.PopularityIndex)
                {
                    mostPopularBook = book;
                }
            }

            Console.WriteLine("Name of book: {0} \nName of author: {1} \nGenre: {2} \nPublication date: {3} \nNumber of pages: {4} \nIndex of popularity: {5}",
                            mostPopularBook.Name,
                            mostPopularBook.Author,
                            mostPopularBook.Genre.ToString(),
                            mostPopularBook.DateOfPublication.ToShortDateString(),
                            mostPopularBook.AmountOfPages,
                            mostPopularBook.PopularityIndex);
        }

        public bool IsAvailableByName(string name)
        {
            foreach (var book in _booksStorage)
            {
                if (book.Name == name)
                {
                    return true;
                }
            }
            return false;
        }

        public bool IsAvailableByAuthor(string author)
        {
            foreach (var book in _booksStorage)
            {
                if (book.Author == author)
                {
                    return true;
                }
            }
            return false;
        }

        public bool IsAvailableByNameAndAuthor(string name, string author)
        {
            foreach (var book in _booksStorage)
            {
                if (book.Name == name & book.Author == author)
                {
                    return true;
                }
            }
            return false;
        }

        public Book GiveBookToUser(string name)
        {
            foreach(var book in _booksStorage)
            {
                if(book.Name == name)
                {
                    book.PopularityIndex++;
                    return book;
                }
            }
            return null;
        }

        public Book GiveBookToUser(string name, string author)
        {
            foreach (var book in _booksStorage)
            {
                if (book.Name == name & book.Author == author)
                {
                    book.PopularityIndex++;
                    return book;
                }
            }

            return null;
        }

        public void AcceptBookFromUser(User user, Book book)
        {
            _booksStorage.Add(book);
            _logBook.Add(book, user);
        }

        public void DonateBookToLibrary(Book book)
        {
            _booksStorage.Add(book);
        }
    }
}
