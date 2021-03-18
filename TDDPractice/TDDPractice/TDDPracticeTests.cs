using System.Runtime.InteropServices;
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
        public void TestEqual()
        {
            Assert.AreEqual(Money.Dollar(5), Money.Dollar(5));
            Assert.AreNotEqual(Money.Dollar(5), Money.Dollar(6));
            Assert.AreEqual(Money.Franc(5), Money.Franc(5));
        }

        [Test]
        public void TestCurrency()
        {
            Assert.AreSame("USD", Money.Dollar(1).Currency());
            Assert.AreSame("CHF", Money.Franc(1).Currency());
        }

        [Test]
        public void TestSimpleAddition()
        {
            Money five = Money.Dollar(5);
            IExpression sum = five.Plus(five);
            Bank bank = new Bank();
            Money reduced = bank.Reduce(sum, "USD");
            Assert.AreEqual(Money.Dollar(10), reduced);
            ;
        }
    }
}