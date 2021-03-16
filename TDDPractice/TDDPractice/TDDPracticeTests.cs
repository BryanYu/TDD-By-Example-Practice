using NUnit.Framework;

namespace TDDPractice
{
    public class TDDPracticeTests
    { 
        [Test]
        public void TestMultiplication()
        {
            Money five = Money.Dollar(5);
            Assert.AreEqual(Money.Dollar(10), five.Times(2));
            Assert.AreEqual(Money.Dollar(15), five.Times(3));
        }

        [Test]
        public void TestFrancMultiplication()
        {
            Franc five = Money.Franc(5);
            Assert.AreEqual(Money.Franc(10), five.Times(2));
            Assert.AreEqual(Money.Franc(15), five.Times(3));
        }

        [Test]
        public void TestEqual()
        {
            Assert.AreEqual(Money.Dollar(5), Money.Dollar(5));
            Assert.AreNotEqual(Money.Dollar(5), Money.Dollar(6));
            Assert.AreEqual(Money.Franc(5), Money.Franc(5));
            Assert.AreNotEqual(Money.Franc(5), Money.Franc(6));
            Assert.AreNotEqual(Money.Franc(5), Money.Dollar(5));
        }
    }
}