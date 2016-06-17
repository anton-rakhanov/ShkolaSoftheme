using System;
using QuickSortWithTailRecursion.Alghoritm;

namespace QuickSortWithTailRecursion
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello, this program demonstrate work of quick sort with tail recursion");

            int[] _unsortedArray = new int[1000];

            var randomizer = new Random();

            for (int i = 0; i < _unsortedArray.Length; i++)
            {
                _unsortedArray[i] = randomizer.Next(1, 10000);
            }

            var tailQuickSorter = new TailRecursionQuickSort(_unsortedArray);

            tailQuickSorter.Sort(0, _unsortedArray.Length - 1);

            Console.WriteLine("\nResult of sort:");

            foreach (int element in _unsortedArray)
            {
                Console.WriteLine(element);
            }

            Console.WriteLine("\nThank you for your time, press any key to exit..");

            Console.ReadKey();

        }
    }
}
