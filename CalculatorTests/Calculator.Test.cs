using NUnit.Framework;
using Calculator;
using System.Collections.Generic;

namespace CalculatorTests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestThreePlusFour()
        {
            CalculatorUIMock userinterface = new CalculatorUIMock(new Controller(), new List<double?>() { 3, 4 }, 7);
            userinterface.Run();
            Assert.Pass();
        }
    }
}