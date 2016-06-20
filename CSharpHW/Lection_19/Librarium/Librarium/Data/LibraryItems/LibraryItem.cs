using System;
using System.Collections.Generic;

namespace Librarium.Data.LibraryItems
{
    public abstract class LibraryItem
    {
        public enum ItemType
        {
            Book = 1,
            Journal = 2,
            TextBook = 3
        }


        public int UniqueItemID { get; private set; }


        public string Name { get; private set; }


        public List<string> Authors { get; set; }


        public ItemType TypeOfItem { get; private set; }


        public DateTime DateOfPublication { get; set; }


        public int AmountOfPages { get; private set; }


        public int PopularityIndex { get; set; }


        public LibraryItem(string name, string[] authors, ItemType itemType, DateTime dateOfPublication, int amountOfPages)
        {
            Authors = new List<string>();


            this.UniqueItemID = UniqueIDGenerator.GetInstance().GenerateUniqueID();

            if (name.Equals("") && name == null)
            {
                throw new ArgumentException("Name of book is null or a blank string");
            }
            else
            {
                this.Name = name;
            }


            foreach (var author in authors)
            {
                if (author.Equals("") && author == null)
                {
                    throw new ArgumentException("Author or authors are null or blank string");
                }
                else
                {
                    this.Authors.Add(author);
                }
            }

            this.TypeOfItem = itemType;
            this.DateOfPublication = dateOfPublication;

            if (amountOfPages <= 0)
            {
                throw new ArgumentException("Pages in book are equals 0 or less!");
            }
            else
            {
                this.AmountOfPages = amountOfPages;
            }

            this.PopularityIndex = 1;
        }


        public LibraryItem(string name, string author, ItemType itemType, DateTime dateOfPublication, int amountOfPages)
        {
            Authors = new List<string>();


            this.UniqueItemID = UniqueIDGenerator.GetInstance().GenerateUniqueID();

            if (name.Equals("") && name == null)
            {
                throw new ArgumentException("Name of book is null or a blank string");
            }
            else
            {
                this.Name = name;
            }


            if (author.Equals("") && author == null)
            {
                throw new ArgumentException("Author or authors are null or blank string");
            }
            else
            {
                this.Authors.Add(author);
            }


            this.TypeOfItem = itemType;
            this.DateOfPublication = dateOfPublication;

            if (amountOfPages <= 0)
            {
                throw new ArgumentException("Pages in book are equals 0 or less!");
            }
            else
            {
                this.AmountOfPages = amountOfPages;
            }

            this.PopularityIndex = 1;
        }
    }
}
