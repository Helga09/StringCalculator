using NUnit.Framework;

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
            Assert.AreEqual(0, c.Add(""));
        }
        [Test]
        public static void OneParameter()
        { 
            Assert.AreEqual(5, c.Add("5"));
        }
        [Test]
        public static void TwoParameter()
        {
            Assert.AreEqual(3, c.Add("1,2"));
        }
    }
}
