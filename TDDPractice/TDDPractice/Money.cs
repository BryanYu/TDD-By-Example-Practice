using System;
using System.Collections.Generic;
using System.Text;

namespace TDDPractice
{
    public class Money : IExpression
    {
        public int Amount;

        protected string currency;

        public Money(int amount,string currency)
        {
            this.Amount = amount;
            this.currency = currency;
        }

        public override bool Equals(object? obj)
        {
            Money money = (Money)obj;
            return Amount == money.Amount && this.Currency() == money.Currency();
        }

        public static Money Dollar(int amount)
        {
            return new Money(amount, "USD");
        }

        public static Money Franc(int amount)
        {
            return new Money(amount, "CHF");
        }


        public string Currency()
        {
            return this.currency;
        }

        public Money Times(int multiplier)
        {
            return new Money(Amount * multiplier, currency);
        }

        public override string ToString()
        {
            return Amount + " " + currency;
        }

        public IExpression Plus(Money addend)
        {
            return new Sum(this, addend);
        }

        public Money Reduce(Bank bank ,string to)
        {
            int rate = bank.Rate(currency, to);
            return new Money(Amount / rate, to);
        }
    }
}
