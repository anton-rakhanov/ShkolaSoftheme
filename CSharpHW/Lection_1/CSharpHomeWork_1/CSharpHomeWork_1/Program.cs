using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpHomeWork_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Hello World, ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Anton\n");

            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("Please, press any key to exit.");
            Console.ReadKey();
        }
    }
}
