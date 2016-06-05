using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExtensionsSets.SomeExtensions;
using InheritanceAndPolymorphizm.Data;
using InheritanceAndPolymorphizm.Data.SmallClassesAndEnums;

namespace ExtensionsSets
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, this program will demonstrate some extensions for printers");

            var simplePrinter = new Printer();
            var colourPrinter = new ColourPrinter();
            var photoPrinter = new PhotoPrinter();

            Console.WriteLine("======================================");
            simplePrinter.TextExtension("Zero", "One", "Two", "Three", "Four", "Five");

            Console.WriteLine("======================================");
            colourPrinter.TextAndColourExtension(new string[] { "First", "Second", "Third" }, new Colours[] { Colours.Green, Colours.Blue, Colours.Red });

            Console.WriteLine("======================================");
            photoPrinter.PhotoExtension(new Photo("Vacation"), new Photo("Holidays"), new Photo("Weekend"));

            Console.WriteLine("Thank you for your time, good luck, press any key to exit");
            Console.ReadKey();
        }
    }
}
