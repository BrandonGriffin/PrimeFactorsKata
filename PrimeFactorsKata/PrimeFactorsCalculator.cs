using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeFactorsKata
{
    public class PrimeFactorsCalculator
    {
        private List<Int32> factors;

        public List<Int32> GeneratePrimes(Int32 numberToFactor)
        {
            factors = new List<Int32>();
            var possibleFactor = 2;

            while (numberToFactor > 1)
            {
                if (numberToFactor % possibleFactor == 0)
                {
                    numberToFactor /= possibleFactor;
                    factors.Add(possibleFactor);
                }
                else
                {
                    possibleFactor++;
                }
            }

            if (numberToFactor > 1)
            {
                factors.Add(numberToFactor);
                numberToFactor /= numberToFactor;
            }

            return factors;
        }
    }
}
