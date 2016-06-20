using System;
using System.ComponentModel.DataAnnotations;
using Librarium.Data.CustomAttribute;
using System.Runtime.Serialization;
using ProtoBuf;

namespace Librarium.Data.LibraryItems
{
    [Serializable]
    [DataContract]
    [ProtoContract]
    [OnlyForViewing(ErrorMessage = "Journal Type can't be taken from library")]
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


        [DataMember]
        [ProtoMember(1)]
        [Required]
        public JournalType JournalSubject { get; set; }


        public Journal()
        {

        }


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
