using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuickSortImplementation.QuickSort;


namespace QuickSortImplementation
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] _unsortedArray = new int[25];
            var randomizer = new Random();

            for(int i = 0; i < _unsortedArray.Length; i++)
            {
                _unsortedArray[i] = randomizer.Next(1, 100000);
            }

            var sorter = new QuickSorter(_unsortedArray);
            sorter.Sort(0, _unsortedArray.Length - 1);

            foreach (int element in _unsortedArray)
            {
                Console.WriteLine(element);
            }

            Console.ReadKey();

        }
    }
}
