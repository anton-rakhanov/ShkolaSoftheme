using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateHandlerLibrary
{
    public class AgeFinder
    {
        public static int DetermineAge(DateTime birthDate)
        {
            int age = DateTime.Now.Year - birthDate.Year;

            if(DateTime.Now.Month < birthDate.Month ||
                (DateTime.Now.Month == birthDate.Month && DateTime.Now.Day < birthDate.Day))
            {
                age--;
            }
            return age;
        }
    }
}
