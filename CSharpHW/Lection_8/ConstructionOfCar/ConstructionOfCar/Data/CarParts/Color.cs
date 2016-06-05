using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConstructionOfCar.Data.CarParts.Enums;

namespace ConstructionOfCar.Data.CarParts
{
    public class Color
    {
        public Colors ColorOfTheCar { get; set; }

        public Color(Colors color)
        {
            ColorOfTheCar = color;
        }
    }
}
