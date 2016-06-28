using System;
using System.IO;
using ThreadZipper.Zipper;

namespace ThreadZipper
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello, this program will demonstrate process of zipping using Threads.");

            var threadZipper = new ThreadZip();

            Console.WriteLine("Please, enter full path to directory that will be zipped.");
            Console.Write("Path: ");
            threadZipper.ZipAllInDir(Console.ReadLine());

            Console.Clear();

            Console.WriteLine(@"All zips you can find by path: {0}\ResultZIpDir\", Directory.GetCurrentDirectory());

            Console.WriteLine("Thank you for your time, press any key to exit..");
            Console.ReadKey();
        }
    }
}
