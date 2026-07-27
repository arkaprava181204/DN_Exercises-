using NUnit.Framework;
using CalcLibraryTests;

namespace CalcLibraryTests
{
    [TestFixture]
    public class CalculatorTests
    {
        private Calculator calc;

    
        [SetUp]
        public void Setup()
        {
            calc = new Calculator ();
        }

        
        [TearDown]
        public void Cleanup()
        {
            calc = null;
        }

       
        [Test]
        [TestCase(10, 20, 30)]
        [TestCase(5, 7, 12)]
        [TestCase(-5, 10, 5)]
        [TestCase(0, 0, 0)]
        [TestCase(-10, -20, -30)]
        public void Add_Test(int a, int b, int expected)
        {
            
            int actual = calc.Add(a, b);

           
            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}