using System;

namespace Librarium.Data.LibraryItems
{
    public class Journal : LibraryItem
    {
        public enum JournalType
        {
            Science = 1,
            VideoGames = 2,
            Travel = 3,
            Economy = 4,
            Fashion = 5
        }


        public JournalType JournalSubject { get; private set; }


        public Journal(string name, string[] authors, ItemType itemType, DateTime dateOfPublication, int amountOfPages, JournalType journalSubject)
            :base(name, authors, itemType, dateOfPublication, amountOfPages)
        {
            this.JournalSubject = journalSubject;
        }


        public Journal(string name, string author, ItemType itemType, DateTime dateOfPublication, int amountOfPages, JournalType journalSubject)
            : base(name, author, itemType, dateOfPublication, amountOfPages)
        {
            this.JournalSubject = journalSubject;
        }
    }
}
