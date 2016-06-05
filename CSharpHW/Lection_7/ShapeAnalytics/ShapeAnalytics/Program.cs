using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShapeAnalytics.Data;

namespace ShapeAnalytics
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("It's {0}", new ShapeDescriptor(new Point(1.0, 1.0), new Point(5.0, 1.0), new Point(1.0, 5.0)).ShapeType);

            Console.ReadKey();
        }
    }
}
