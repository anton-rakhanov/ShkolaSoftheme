using ProtoBuf;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace Librarium.Data.LibraryItems
{
    [Serializable]
    [DataContract]
    [ProtoContract]
    [XmlInclude(typeof(Book))]
    [XmlInclude(typeof(TextBook))]
    [XmlInclude(typeof(Journal))]
    public abstract class LibraryItem
    {

        public enum ItemType
        {
            Book = 1,
            Journal = 2,
            TextBook = 3
        }

        [DataMember]
        [ProtoMember(1)]
        public int UniqueItemID { get; set; }

        [DataMember]
        [ProtoMember(2)]
        [Required]
        [StringLength(100, MinimumLength = 1, ErrorMessage = "Wrong name of the Library item")]
        public string Name { get; set; }

        [DataMember]
        [ProtoMember(3)]
        public List<string> Authors { get; set; }

        [DataMember]
        [ProtoMember(4)]
        [Required]
        [Range(1, 3, ErrorMessage = "Wrong value of enum of the Library item")]
        public ItemType TypeOfItem { get; set; }

        [DataMember]
        [ProtoMember(5)]
        [Required]
        public DateTime DateOfPublication { get; set; }

        [DataMember]
        [ProtoMember(6)]
        [Required]
        [Range(5, 9999, ErrorMessage = "Wrong amount of pages of the Library item")]
        public int AmountOfPages { get; set; }

        [DataMember]
        [ProtoMember(7)]
        [Range(1, int.MaxValue, ErrorMessage = "Wrong popularity index of the LibraryItem")]
        public int PopularityIndex { get; set; }


        [DataMember]
        [ProtoMember(8)]
        public LibraryUser LastSubscriber { get; set; }


        public LibraryItem()
        {

        }


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
