using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CopyDemonstration.Data;

namespace CopyDemonstration
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello, this program demonstrates a copying of a value type and a copying of reference type");

            var firstUser = new User("Bob", "Rhamones");
            User secondUser;

            Console.WriteLine("Users state before copying:");

            Console.WriteLine("\nFirst user data: " +
                              "\nFirst name: {0}" +
                              "\nLast name: {1}",
                              firstUser.FirstName,
                              firstUser.LastName);

            Console.WriteLine("\nSecond user data: " +
                              "\nFirst name: none" +
                              "\nLast name: none");

            secondUser = firstUser;

            Console.WriteLine("===================================================================================================");

            Console.WriteLine("Users state after copying:");

            Console.WriteLine("\nFirst user data: " +
                              "\nFirst name: {0}" +
                              "\nLast name: {1}",
                              firstUser.FirstName,
                              firstUser.LastName);

            Console.WriteLine("\nSecond user data: " +
                              "\nFirst name: {0}" +
                              "\nLast name: {1}",
                              secondUser.FirstName,
                              secondUser.LastName);

            Console.WriteLine("===================================================================================================");

            Console.WriteLine("Now we change second user data, new first name will be Bart and new last name wiil be Dwonson");

            secondUser.FirstName = "Bart";
            secondUser.LastName = "Dwonson";

            Console.WriteLine("===================================================================================================");

            Console.WriteLine("Users state after changing second user data:");

            Console.WriteLine("\nFirst user data: " +
                              "\nFirst name: {0}" +
                              "\nLast name: {1}",
                              firstUser.FirstName,
                              firstUser.LastName);

            Console.WriteLine("\nSecond user data: " +
                              "\nFirst name: {0}" +
                              "\nLast name: {1}",
                              secondUser.FirstName,
                              secondUser.LastName);

            Console.WriteLine("===================================================================================================");

            Console.WriteLine("As you can see, changes affected both users, this happens because User is reference type, and when we copy reference type, we actualy copy link to it, not value by itself");

            Console.WriteLine("===================================================================================================");

            Console.WriteLine("Now we do the same with ValueType variables");

            int firstValueType = 10;
            int secondValueType = 0;

            Console.WriteLine("\nVariables state before copying:");

            Console.WriteLine("\nFirst variable: {0}", firstValueType);

            Console.WriteLine("\nSecond variable: {0}", secondValueType);

            Console.WriteLine("===================================================================================================");

            secondValueType = firstValueType;

            Console.WriteLine("Variables state after copying:");

            Console.WriteLine("\nFirst variable: {0}", firstValueType);

            Console.WriteLine("\nSecond variable: {0}", secondValueType);

            Console.WriteLine("===================================================================================================");

            Console.WriteLine("Now we change first variable value on 9856");

            firstValueType = 9856;

            Console.WriteLine("===================================================================================================");

            Console.WriteLine("Variables state after we changed first variable:");

            Console.WriteLine("\nFirst variable: {0}", firstValueType);

            Console.WriteLine("\nSecond variable: {0}", secondValueType);

            Console.WriteLine("===================================================================================================");

            Console.WriteLine("And here, changes of the first variable hasn't affected to the second variable, because this variables are ValueType, and when we copy them we copy only their value, not links to their places in stack");

            Console.WriteLine("\nThank you for your time, good luck, press any key to exit.");
            Console.ReadKey();
        }
    }
}
