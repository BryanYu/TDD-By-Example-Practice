using NUnit.Framework;

namespace TDDPractice
{
    public class TDDPracticeTests
    { 
        [Test]
        public void TestMultiplication()
        {
            Dollar five = new Dollar(5);
            Assert.AreEqual(new Dollar(10), five.Times(2));
            Assert.AreEqual(new Dollar(15), five.Times(3));
        }

        [Test]
        public void TestEqual()
        {
            Assert.AreEqual(new Dollar(5), new Dollar(5));
            Assert.AreNotEqual(new Dollar(5), new Dollar(6));
        }
    }
}