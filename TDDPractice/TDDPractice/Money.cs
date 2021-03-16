using System;
using System.Collections.Generic;
using System.Text;

namespace TDDPractice
{
    public abstract class Money
    {
        protected int amount;

        protected string currency;

        protected Money(int amount,string currency)
        {
            this.amount = amount;
            this.currency = currency;
        }

        public override bool Equals(object? obj)
        {
            Money money = (Money)obj;
            return amount == money.amount && this.GetType() == money.GetType();
        }

        public static Dollar Dollar(int amount)
        {
            return new Dollar(amount, "USD");
        }

        public static Franc Franc(int amount)
        {
            return new Franc(amount, "CHF");
        }

        public abstract Money Times(int multiplier);

        public string Currency()
        {
            return this.currency;
        }

    }
}
