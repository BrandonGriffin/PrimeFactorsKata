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
        public void OneShouldReturnAnEmptyList()
        {
            var actual = generator.GeneratePrimes(1);

            Assert.That(actual, Is.EqualTo(new List<Int32>()));
        }

        [Test]
        public void TwoShouldReturnTwo()
        {
            var actual = generator.GeneratePrimes(2);

            Assert.That(actual, Is.EqualTo(new List<Int32>{ 2 }));
        }
    }
}
