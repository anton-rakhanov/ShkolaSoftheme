using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DateHandlerLibrary;
using DateHandlerLibrary.RunEnum;

namespace Console_BirthDate_Zodiac
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime birthDate;

            Console.WriteLine("Hello, please enter your birth day date in format: DD/MM/YYYY and the program will display your age and zodiac sign!");

            birthDate =  BirthDateParser.TryParseBirthDate(Console.ReadLine(), ProgramEnums.CONSOLE);

            Console.WriteLine("Your age is {0} and your zodiac sigh is {1}", AgeFinder.DetermineAge(birthDate), ZodiacExplorer.DetermineZodiacSign(birthDate));

            Console.WriteLine("Press any key to exit!");

            Console.ReadKey();
        }
    }
}
