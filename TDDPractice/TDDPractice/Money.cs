using System;
using System.Collections.Generic;
using System.Text;

namespace TDDPractice
{
    public class Money
    {
        protected int amount;

        protected string currency;

        public Money(int amount,string currency)
        {
            this.amount = amount;
            this.currency = currency;
        }

        public override bool Equals(object? obj)
        {
            Money money = (Money)obj;
            return amount == money.amount && this.Currency() == money.Currency();
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
            return new Money(amount * multiplier, currency);
        }

        public override string ToString()
        {
            return amount + " " + currency;
        }
    }
}
