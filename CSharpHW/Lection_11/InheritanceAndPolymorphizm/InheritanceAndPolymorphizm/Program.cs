using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InheritanceAndPolymorphizm.Data;
using InheritanceAndPolymorphizm.Data.SmallClassesAndEnums;

namespace InheritanceAndPolymorphizm
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello this program demonstate inheritance and polymorphizm");

            var somePrinter = new Printer();

            Console.WriteLine("====================================================================");
            somePrinter.Print("Hello, this text was printed on simple printer");

            somePrinter = new ColourPrinter();
            Console.WriteLine("====================================================================");
            somePrinter.Print("Hi, this text was printed on colour printer");

            var colourPrinter = new ColourPrinter();
            Console.WriteLine("====================================================================");
            colourPrinter.Print("Text with some color", Colours.Green);

            somePrinter = new PhotoPrinter();
            Console.WriteLine("====================================================================");
            somePrinter.Print("Yo, this text was printed on photo printer");

            var photoPrinter = new PhotoPrinter();
            Console.WriteLine("====================================================================");
            photoPrinter.Print(new Photo("Vacation"));

            Console.WriteLine("====================================================================");
            Console.WriteLine("Thank you for your time, good luck, press any key to exit");
            Console.ReadKey();
        }
    }
}
