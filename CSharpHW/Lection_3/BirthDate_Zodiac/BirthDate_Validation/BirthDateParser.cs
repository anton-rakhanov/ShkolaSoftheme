using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DateHandlerLibrary.RunEnum;

namespace DateHandlerLibrary
{
    public class BirthDateParser
    {
        public static DateTime TryParseBirthDate(string stringBirthDate, ProgramEnums executionApp)
        {
            string[] birthDateArray;

            birthDateArray = stringBirthDate.Split('.', ',', '/');

            int day;
            int month;
            int year;

            DateTime birthDate;

            if (birthDateArray.Length == 3 &&
                int.TryParse(birthDateArray[0], out day) &&
                int.TryParse(birthDateArray[1], out month) &&
                int.TryParse(birthDateArray[2], out year) &&
                DateTime.TryParse(stringBirthDate, out birthDate) &&
                day > 0 && day < 32 &&
                month > 0 && month < 13 &&
                year > 1900 && year < DateTime.Now.Year)
            {
                birthDate = new DateTime(year, month, day);
                return birthDate;
            }
            else
            {
                if (executionApp.Equals(ProgramEnums.CONSOLE))
                {
                    Console.Clear();
                    Console.WriteLine("You entered invalid data");
                    Console.WriteLine("Please try again");
                    return TryParseBirthDate(Console.ReadLine(), ProgramEnums.CONSOLE);
                }
                else
                {
                    return DateTime.MinValue;
                }
            }
        }
    }
}
