using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

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


        [Required]
        [StringLength(100, MinimumLength = 1, ErrorMessage = "Wrong name of the Library item")]
        public string Name { get; private set; }


        public List<string> Authors { get; set; }


        [Required]
        [Range(1, 3, ErrorMessage = "Wrong value of enum of the Library item")]
        public ItemType TypeOfItem { get; private set; }


        [Required]
        public DateTime DateOfPublication { get; set; }


        [Required]
        [Range(5, 9999, ErrorMessage = "Wrong amount of pages of the Library item")]
        public int AmountOfPages { get; private set; }


        [Range(1, int.MaxValue, ErrorMessage = "Wrong popularity index of the LibraryItem")]
        public int PopularityIndex { get; set; }


        public LibraryItem(string name, string[] authors, ItemType itemType, DateTime dateOfPublication, int amountOfPages)
        {
            Authors = new List<string>();


            this.UniqueItemID = UniqueIDGenerator.GetInstance().GenerateUniqueID();
            this.Name = name;

            foreach (var author in authors)
            {
                this.Authors.Add(author);
            }

            this.TypeOfItem = itemType;
            this.DateOfPublication = dateOfPublication;
            this.AmountOfPages = amountOfPages;
            this.PopularityIndex = 1;
        }


        public LibraryItem(string name, string author, ItemType itemType, DateTime dateOfPublication, int amountOfPages)
        {
            Authors = new List<string>();


            this.UniqueItemID = UniqueIDGenerator.GetInstance().GenerateUniqueID();
            this.Name = name;
            this.Authors.Add(author);
            this.TypeOfItem = itemType;
            this.DateOfPublication = dateOfPublication;
            this.AmountOfPages = amountOfPages;
            this.PopularityIndex = 1;
        }
    }
}
