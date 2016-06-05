using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ArrayWrapper.Wrapper;

namespace ArrayWrapper
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, this program represents theoretically infinite array.");

            var infiniteArray = new TheoreticallyInfiniteArray(15, 15);

            var randomizer = new Random();

            // Variable for test GetByIndex Method
            int indexToFindByIndex = 65;

            // Variable for test Contains Method
            int valueToFind = 200;

            for (int i = 0; i < 100; i++)
            {
                if (i == 53)
                {
                    infiniteArray.Add(valueToFind);
                }
                if (i == indexToFindByIndex)
                {
                    infiniteArray.Add(100);
                }
                infiniteArray.Add(randomizer.Next(1000, 100000));
            }

            Console.WriteLine("Element by index - {0} is {1} ", indexToFindByIndex, infiniteArray.GetByIndex(indexToFindByIndex + 1));

            Console.WriteLine("Infinity array contains value 200? : ", infiniteArray.Contains(200).ToString());

            Console.WriteLine("Press any key to exit, good luck");

            Console.ReadKey();

        }
    }
}
