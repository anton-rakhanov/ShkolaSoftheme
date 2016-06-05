using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FIFOWithTwoStacks.Data;

namespace FIFOWithTwoStacks
{
    class Program
    {
        static void Main(string[] args)
        {
            var queue = new Queue(new Stack(), new Stack());

            for(int i = 0; i < queue.QueueSize; i++)
            {
                queue.Add(i+20);
            }

            for (int i = 0; i < queue.QueueSize; i++)
            {
                Console.WriteLine("Value of element {0}, is {1}", i, queue.Take());
            }

            Console.ReadKey();
        }
    }
}
