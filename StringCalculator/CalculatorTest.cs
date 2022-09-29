using NUnit.Framework;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace StringCalculator
{
    [TestFixture]
    class CalculatorTest
    {
        static Calculator c;
        [SetUp]
        public static void Initialize()
        {
            c = new Calculator();
        }
        [Test]
        public static void EmptyString()
        {
            NUnit.Framework.Assert.AreEqual(0, c.Add(""));
        }
        [Test]
        public static void OneParameter()
        {
            NUnit.Framework.Assert.AreEqual(5, c.Add("5"));
        }
        [Test]
        public static void TwoParameter()
        {
            NUnit.Framework.Assert.AreEqual(3, c.Add("//,\n1,2"));
        }
        [Test]
        public static void DifferentSeparators()
        {
            NUnit.Framework.Assert.AreEqual(6, c.Add("1\n2,3"));
        }
        [Test]
        [ExpectedException(typeof(InvalidOperationException), "Negatives not allowed: -1Negatives not allowed: -2")]
        public static void NegativeNumbers()
        {
            c.Add("//,\n-1,-2");
        }
    }
}
