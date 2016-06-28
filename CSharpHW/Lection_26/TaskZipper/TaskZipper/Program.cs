using System;
using System.IO;
using TaskZipper.Zipper;

namespace TaskZipper
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, this program will demonstrate process of zipping using Tasks.");

            var taskZipper = new TaskZip();

            Console.WriteLine("Please, enter full path to directory that will be zipped.");
            Console.Write("Path: ");
            taskZipper.ZipAllInDir(Console.ReadLine());

            Console.Clear();

            Console.WriteLine(@"All zips you can find by path: {0}\ResultZIpDir\", Directory.GetCurrentDirectory());

            Console.WriteLine("Thank you for your time, press any key to exit..");
            Console.ReadKey();
        }
    }
}
