using NUnit.Framework;
using TestRce;

namespace TestProjectTesting
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }
        [Test]
        public void Test1()
        {
            double p = 0.0;
            p = RceCalculator.CalculatorPlus(1,5,1);
            Assert.AreEqual(-2, p, 1.0e-6);
        }
        [Test]
        public void Test2()
        {
            double m = 0.0;
            m = RceCalculator.CalculatorMinus(1, 5, 1);
            Assert.AreEqual(-3, m, 1.0e-6);
        }
    }
}