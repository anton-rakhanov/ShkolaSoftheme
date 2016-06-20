using System;
using System.ComponentModel.DataAnnotations;

namespace Librarium.Data.LibraryItems
{
    public class Book : LibraryItem
    {
        [Flags]
        public enum GenreEnum
        {
            ScienceFiction = 1,
            Fantasy = 2,
            Drama = 4,
            Adventure = 8,
            Triller = 16,
            Horror = 32
        }


        [Required]
        public GenreEnum GenreOfBook { get; private set; }


        public Book(string name, string[] authors, ItemType itemType, DateTime dateOfPublication, int amountOfPages, GenreEnum genreOfBook)
            :base(name, authors, itemType, dateOfPublication, amountOfPages)
        {
            this.GenreOfBook = genreOfBook;
        }


        public Book(string name, string author, ItemType itemType, DateTime dateOfPublication, int amountOfPages, GenreEnum genreOfBook)
            : base(name, author, itemType, dateOfPublication, amountOfPages)
        {
            this.GenreOfBook = genreOfBook;
        }
    }
}
