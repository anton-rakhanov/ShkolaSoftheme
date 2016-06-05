using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InheritanceAndPolymorphizm.Data.SmallClassesAndEnums;

namespace InheritanceAndPolymorphizm.Data
{
    public class PhotoPrinter : Printer
    {
        public override void Print(string toPrint)
        {
            Console.WriteLine("Print method from derived PhotoPrinter class.");
            Console.WriteLine("Message: " + toPrint);
        }

        public void Print(Photo photo)
        {
            Console.WriteLine("Print method, that takes photo, from derived PhotoPrinter class.");
            Console.WriteLine("Photo: Name of photo is " + photo.PhotoName);
        }
    }
}
