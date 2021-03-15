using NUnit.Framework;

namespace TDDPractice
{
    public class TDDPracticeTests
    { 
        [Test]
        public void TestMultiplication()
        {
            Dollar five = new Dollar(5);
            Dollar product = five.Times(2);
            Assert.AreEqual(10, product.Amount);
            product = five.Times(3);
            Assert.AreEqual(15, product.Amount);
        }

        [Test]
        public void TestEqual()
        {
            Assert.AreEqual(new Dollar(5), new Dollar(5));
            Assert.AreNotEqual(new Dollar(5), new Dollar(6));
        }
    }
}