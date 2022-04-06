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
        public void TestFivePlusFive()
        {
            CalculatorUIMock userinterface = new CalculatorUIMock(new Controller(), new List<double>() { 3, 4 });
            userinterface.Run();
            Assert.Pass();
        }
    }
}