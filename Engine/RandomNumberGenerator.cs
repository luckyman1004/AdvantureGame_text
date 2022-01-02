using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class RandomNumberGenerator
    {
        private static Random _generator = new Random();

        public static int NumberBetween(int minimumValue, int maximumValue)
        {
            return _generator.Next(minimumValue, maximumValue + 1);

            // create a Random object (_generator)
            // and use its Next() method to get a random value
            // between the minimum and maximum values passed in as parameter

        }
    }
}
