using System;
using System.Collections.Generic;
using NUnit.Framework;

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
            Assert.That(actual, Is.EqualTo(new [] { 2 }));
        }

        [Test]
        public void ThreeShouldReturnThree()
        {
            var actual = generator.GeneratePrimes(3);
            Assert.That(actual, Is.EqualTo(new [] { 3 }));
        }

        [Test]
        public void FourShouldReturnTwoAndTwo()
        {
            var actual = generator.GeneratePrimes(4);
            Assert.That(actual, Is.EqualTo(new [] { 2, 2 }));
        }

        [Test]
        public void FiveShouldReturnFive()
        {
            var actual = generator.GeneratePrimes(5);
            Assert.That(actual, Is.EqualTo(new [] { 5 }));
        }

        [Test]
        public void SixShouldReturnThreeAndTwo()
        {
            var actual = generator.GeneratePrimes(6);
            Assert.That(actual, Is.EqualTo(new [] { 2, 3 }));
        }

        [Test]
        public void SevenShouldReturnSeven()
        {
            var actual = generator.GeneratePrimes(7);
            Assert.That(actual, Is.EqualTo(new [] { 7 }));
        }

        [Test]
        public void EightShouldReturnTwoTwoAndTwo()
        {
            var actual = generator.GeneratePrimes(8);
            Assert.That(actual, Is.EqualTo(new [] { 2, 2, 2 }));
        }

        [Test]
        public void NineShouldReturnThreeAndThree()
        {
            var actual = generator.GeneratePrimes(9);
            Assert.That(actual, Is.EqualTo(new [] { 3, 3 }));
        }

        [Test]
        public void SevenHundredSeventySevenShouldReturnThreeSevenAndThirtySeven()
        {
            var actual = generator.GeneratePrimes(777);
            Assert.That(actual, Is.EqualTo(new [] { 3, 7, 37 }));
        }
    }
}
