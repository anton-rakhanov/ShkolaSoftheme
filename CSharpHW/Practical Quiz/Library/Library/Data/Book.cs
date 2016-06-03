using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Data
{
    public class Book
    {
        private int _bookID;

        public int BookID
        {
            get { return _bookID; }
        }

        private int _uniqueIDCounter = 1;

        public string Name { get; set; }

        public string Author { get; set; }

        public GenreEnum Genre { get; set; }

        private DateTime _dateOfPublication;

        public DateTime DateOfPublication
        {
            get { return _dateOfPublication; }
            set { _dateOfPublication = value; }
        }

        public int AmountOfPages { get; set; }

        public int PopularityIndex { get; set; }

        public Book(string name, string author, GenreEnum genre, DateTime dateOfPublication, int amountOfPages)
        {
            _bookID = _uniqueIDCounter++;
            Name = name;
            Author = author;
            Genre = genre;
            DateOfPublication = dateOfPublication;
            AmountOfPages = amountOfPages;
            PopularityIndex = 0;
        }


    }
}
