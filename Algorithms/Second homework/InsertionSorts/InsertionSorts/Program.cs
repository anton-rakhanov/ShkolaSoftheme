using System;
using InsertionSorts.Alghorithm;


namespace InsertionSorts
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello, this program will demonstrate amount of operation to sort array by insertion sort\n");

            Random rand = new Random();

            int[] unsortedArrayOne = new int[1000];

            for (int i = 0; i < unsortedArrayOne.Length; i++)
            {
                unsortedArrayOne[i] = rand.Next(0, 100000);
            }

            Console.WriteLine("Unsorted array size: " + unsortedArrayOne.Length);

            var ImprovedSorter = new InsertionSort();

            ImprovedSorter.Sort(unsortedArrayOne);

            Console.WriteLine("Amount of operation by improved insertion sort: " + ImprovedSorter.OperationCounter);

            Console.WriteLine("\nThanks for your time, press any key to exit");
            Console.ReadKey();

        }
    }
}
