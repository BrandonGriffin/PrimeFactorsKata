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
        private PrimeFactorsCalculator generator;

        [SetUp]
        public void SetUp()
        {
            generator = new PrimeFactorsCalculator();
        }

        [Test]
        public void GeneratePrimesShouldReturnAList()
        {
            var actual = generator.GeneratePrimes();

            Assert.That(actual, Is.EqualTo(new List<Int32>()));
        }
    }
}
