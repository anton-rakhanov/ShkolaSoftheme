using ProtoBuf;
using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Librarium.Data.LibraryItems
{
    [Serializable]
    [DataContract]
    [ProtoContract]
    public class TextBook : LibraryItem
    {

        public enum TextBookType
        {
            Math = 1,
            Physics = 2,
            Language = 3,
            Chimestry = 4,
            Biology = 5,
            Geography = 6
        }


        [DataMember]
        [ProtoMember(1)]
        [Required]
        public TextBookType TextBookSubject { get; set; }


        public TextBook()
        {

        }


        public TextBook(string name, string[] authors, ItemType itemType, DateTime dateOfPublication, int amountOfPages, TextBookType textBookSubject)
            :base(name, authors, itemType, dateOfPublication, amountOfPages)
        {
            this.TextBookSubject = textBookSubject;
        }


        public TextBook(string name, string author, ItemType itemType, DateTime dateOfPublication, int amountOfPages, TextBookType textBookSubject)
            : base(name, author, itemType, dateOfPublication, amountOfPages)
        {
            this.TextBookSubject = textBookSubject;
        }
    }
}
