using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MemoryManagmentSystem.Data;

namespace MemoryManagmentSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program shows managment with memory through IDisposable interfaces and destructors.");
            Console.WriteLine("========================================================================================");

            Console.WriteLine("First example:");
            using(var resHolderBase = new ResourceHolderBase())
            {
                using(var resHolderDerived = new ResourceHolderDerived())
                {
                    resHolderBase.UselessAction();
                    resHolderDerived.UselessAction();
                }
            }

            Console.WriteLine("========================================================================================");
            Console.WriteLine("Second example:");

            var resHoldBaseTwo = new ResourceHolderBase();
            var resHoldDerivedTwo = new ResourceHolderDerived();

            resHoldBaseTwo.UselessAction();
            resHoldDerivedTwo.UselessAction();

            resHoldBaseTwo.Dispose();
            resHoldDerivedTwo.Dispose();

            resHoldBaseTwo.Dispose();
            resHoldDerivedTwo.Dispose();

            Console.WriteLine("========================================================================================");

            Console.WriteLine("Thank you for your time, good luck, press any key to exit");
            Console.ReadKey();
        }
    }
}
