using System;
using System.IO;
using ThreadUnzipper.Unzipper;


namespace ThreadUnzipper
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, this program will demonstrate process of unzipping using Threads.");

            var threadUnzipper = new ThreadUnzip();

            Console.WriteLine("Please, enter full path to directory that will be restored.");
            Console.Write("Path: ");
            threadUnzipper.UnZipAllFromDir(Console.ReadLine());

            Console.Clear();

            Console.WriteLine(@"All unzipped files you can find by path: {0}\\ResultOfUnzipDir\", Directory.GetCurrentDirectory());

            Console.WriteLine("Thank you for your time, press any key to exit..");
            Console.ReadKey();
        }
    }
}
