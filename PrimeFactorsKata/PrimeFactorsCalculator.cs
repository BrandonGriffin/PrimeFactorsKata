using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeFactorsKata
{
    public class PrimeFactorsCalculator
    {
        public List<Int32> GeneratePrimes(Int32 numberToFactor)
        {
            if(numberToFactor == 1)
                return new List<Int32>();

            return new List<Int32>{ numberToFactor };
        }
    }
}
