using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAndPolymorphizm.Data
{
    public class Printer
    {
        public virtual void Print(string toPrint)
        {
            Console.WriteLine("Print method from base class printer.");
            Console.WriteLine("Message: " + toPrint);
        }
    }
}
