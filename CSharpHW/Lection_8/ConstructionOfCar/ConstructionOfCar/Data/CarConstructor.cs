using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConstructionOfCar.Data.CarParts;

namespace ConstructionOfCar.Data
{
    public class CarConstructor
    {
        private Car _carUnderConstruction;

        public Car Construct(Engine engine, Color color, Transmission transmission)
        {
            _carUnderConstruction = new Car(engine, color, transmission);
            return _carUnderConstruction;
        }

        public void Reconstruct(Car carOnReconstruction, Engine newEngine)
        {
            carOnReconstruction.EngineOfCar = newEngine;
        }
    }
}
