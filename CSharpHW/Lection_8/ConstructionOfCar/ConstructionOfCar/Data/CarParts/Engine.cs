using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructionOfCar.Data.CarParts
{
    public class Engine
    {
        public int HorsePower { get; private set; }

        public Engine(int horsePower)
        {
            this.HorsePower = horsePower;
        }
    }
}
