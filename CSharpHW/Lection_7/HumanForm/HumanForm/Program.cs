using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HumanForm.Data;

namespace HumanForm
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program compares humans..");

            var firstHuman = new Human(new DateTime(1995,9,21), "Fred", "Taurbarhus", 21);
            var firstHumanClone = new Human(new DateTime(1995, 9, 21), "Fred", "Taurbarhus", 21);

            Console.WriteLine("\nFor example, here we have {0} {1} he is {2} old, and his date of birth is {3}",
                firstHuman.FirstName, firstHuman.LastName, firstHuman.Age, firstHuman.BirthDate.ToString().Substring(0,10));

            Console.WriteLine("And his clone, with the same physic data..");

            if(firstHuman.Equals(firstHumanClone))
            {
                Console.WriteLine("\nFirst human and his clone are equals! What a surprise!");
            }

            var secondHuman = new Human(new DateTime(1990, 9, 21), "Migel", "Santiago", 26);

            Console.WriteLine("\nAnd here we have {0} {1} he is {2} old, and his date of birth is {3}",
                secondHuman.FirstName, secondHuman.LastName, secondHuman.Age, secondHuman.BirthDate.ToString().Substring(0,10));

            Console.WriteLine("Now we compare {0} {1}, and {2} {3}",
                firstHuman.FirstName, firstHuman.LastName, secondHuman.FirstName, secondHuman.LastName);
            
            if(!firstHuman.Equals(secondHuman))
            {
                Console.WriteLine("\nThey aren't equals!");
            }

            Console.WriteLine("\nThank you for your time, press any key to quit. Good luck!");
            Console.ReadKey();
        }
    }
}
