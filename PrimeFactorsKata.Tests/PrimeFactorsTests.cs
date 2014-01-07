using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeFactorsKata.Tests
{
    [TestFixture]
    public class PrimeFactorsTests
    {
        [Test]
        public void GeneratePrimesShouldReturnAList()
        {
            var generator = new PrimeFactorsCalculator();

            var actual = generator.GeneratePrimes();

            Assert.That(actual, Is.EqualTo(new List<Int32>()));
        }
    }
}
