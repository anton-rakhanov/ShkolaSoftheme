using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConstructionOfCar.Data;
using ConstructionOfCar.Data.CarParts;
using ConstructionOfCar.Data.CarParts.Enums;


namespace ConstructionOfCar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, this programm demonstate a car construction and after that, reconstruction of the car! Enjoy!\n");

            var carFabric = new CarConstructor();

            Car newCar = carFabric.Construct(new Engine(300), new Color(Colors.GREEN), new Transmission(TransmissionTypes.MANUAL));

            Console.WriteLine("We construct a new car, the car has {0}-hp, {1} color and {2}-transmission!\n", 
                               newCar.EngineOfCar.HorsePower, newCar.ColorOfCar.ColorOfTheCar.ToString(), 
                               newCar.CarTransmission.TransmissionOfTheCar.ToString());

            Console.WriteLine("Now car constructor reconstruct the car with new engine!\n");

            carFabric.Reconstruct(newCar, new Engine(550));

            Console.WriteLine("Now the car has {0}-hp!\n", newCar.EngineOfCar.HorsePower);
            Console.WriteLine("Thank you for your attention, press any key to exit, goodbye!");
            Console.ReadKey();
        }
    }
}
