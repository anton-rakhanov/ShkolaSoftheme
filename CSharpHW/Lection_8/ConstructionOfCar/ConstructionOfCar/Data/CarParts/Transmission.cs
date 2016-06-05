using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConstructionOfCar.Data.CarParts.Enums;

namespace ConstructionOfCar.Data.CarParts
{
    public class Transmission
    {
        public TransmissionTypes TransmissionOfTheCar { get; private set; }

        public Transmission(TransmissionTypes transmissionType)
        {
            this.TransmissionOfTheCar = transmissionType;
        }
    }
}
