using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConstructionOfCar.Data.CarParts;

namespace ConstructionOfCar.Data
{
    public class Car
    {
        public Engine EngineOfCar { get; set; }

        public Color ColorOfCar { get; set; }

        public Transmission CarTransmission { get;  set; }

        public Car(Engine carEngine, Color carColor, Transmission carTransmission)
        {
            this.EngineOfCar = carEngine;
            this.ColorOfCar = carColor;
            this.CarTransmission = carTransmission;
        }
    }
}
