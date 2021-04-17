using System;
using CalculatorVS;
using NUnit.Framework;

namespace NUnit.Test
{
    [TestFixture]
    public class CalculatorTest
    {
        private Calculator _cal;

        [SetUp]
        public void Setup()
        {
            _cal = new Calculator();
        }

        [Test]
        public void OnePlusOneEqualTwo()
        {
            Assert.AreEqual(2, _cal.Add(1, 1));
        }

        [Test]
        public void TwoPlusTwoEqualFour()
        {
            Assert.AreEqual(4, _cal.Add(2, 2));
        }

        [Test]
        public void FourPlusOneEqualFive()
        {
            Assert.AreEqual(5, _cal.Add(4, 1));
        }
        
        [Test]
        public void FourPlusTwoEqualSix()
        {
            Assert.AreEqual(6, _cal.Add(4, 2));
        }
        
        [Test]
        public void FourPlusThreeEqualSeven()
        {
            Assert.AreEqual(7, _cal.Add(4, 3));
        }
        
        [Test]
        public void FourPlusFourEqualEight()
        {
            Assert.AreEqual(8, _cal.Add(4, 4));
        }
    }
}
