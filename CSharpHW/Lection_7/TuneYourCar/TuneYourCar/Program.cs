using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TuneYourCar.Data;

namespace TuneYourCar
{
    class Program
    {
        static void Main(string[] args)
        {
            var newCar = new Car("Pickup", 1999, Colors.Yellow);

            Console.Write("Hello, this is color statement of a car before tune: ");
            Console.Write(newCar.Color.ToString());

            TuningAtelier.TuneCar(newCar);

            Console.Write("\nThis is color statement after Tuning Atelier: ");
            Console.Write(newCar.Color.ToString());

            Console.WriteLine("\nPlease, press any key to exit.");
            Console.ReadKey();
        }
    }
}
