using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InheritanceAndPolymorphizm.Data.SmallClassesAndEnums;

namespace InheritanceAndPolymorphizm.Data
{
    public class ColourPrinter : Printer
    {
        public override void Print(string toPrint)
        {
            Console.WriteLine("Print method from derived ColourPrinter class.");
            Console.WriteLine("Message: " + toPrint);
        }

        public void Print(string toPrint, Colours colour)
        {
            Console.WriteLine("Print method, that takes text and color, from derived ColourPrinter class.");
            Console.WriteLine("Message: {0} and colour is: {1} ", toPrint, colour.ToString());
        }
    }
}
