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
                
            if(numberToFactor < 4 && numberToFactor > 1)
                return new List<Int32>{ numberToFactor };

            if (numberToFactor % 2 == 0)
            {
                numberToFactor /= 2;
                factors.Add(2);
                factors.Add(numberToFactor);
            }
            
            return factors;
        }
    }
}
