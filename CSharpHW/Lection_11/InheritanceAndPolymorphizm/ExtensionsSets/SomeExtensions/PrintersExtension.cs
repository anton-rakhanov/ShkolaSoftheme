using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InheritanceAndPolymorphizm.Data;
using InheritanceAndPolymorphizm.Data.SmallClassesAndEnums;

namespace ExtensionsSets.SomeExtensions
{
    public static class PrintersExtension
    {
        public static void TextExtension(this Printer printer, params string[] stringArr)
        {
            foreach(var str in stringArr)
            {
                Console.WriteLine(str);
            }
        }
        
        public static void TextAndColourExtension(this ColourPrinter colourPrinter, string[] stringArr, params Colours[] colours)
        {
            foreach (var str in stringArr)
            {
                Console.WriteLine(str);
            }

            foreach(var color in colours)
            {
                Console.WriteLine(color.ToString());
            }
        }

        public static void PhotoExtension(this PhotoPrinter photoPringer, params Photo[] photos)
        {
            foreach(var photo in photos)
            {
                Console.WriteLine(photo.PhotoName);
            }
        }
    }
}
