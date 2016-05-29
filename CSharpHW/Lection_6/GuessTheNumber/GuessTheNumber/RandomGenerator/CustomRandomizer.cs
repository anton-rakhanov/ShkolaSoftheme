using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessTheNumber.RandomGenerator
{
    public class CustomRandomizer
    {
        public static int RandomValue()
        {
            int randomValue = new Random().Next(11);

            if(randomValue == 0)
            {
                randomValue = 1;
            }
            return randomValue;
        }
    }
}
