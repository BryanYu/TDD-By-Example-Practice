using NUnit.Framework;

namespace TDDPractice
{
    public class TDDPracticeTests
    { 
        [Test]
        public void TestMultiplication()
        {
            Dollar five = new Dollar(5);
            five.Times(2);
            Assert.AreEqual(10, five.Amount);
        }
    }
}