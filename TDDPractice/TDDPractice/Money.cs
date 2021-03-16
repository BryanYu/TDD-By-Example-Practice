using System;
using System.Collections.Generic;
using System.Text;

namespace TDDPractice
{
    public abstract class Money
    {
        protected int amount;

        public override bool Equals(object? obj)
        {
            Money money = (Money)obj;
            return amount == money.amount && this.GetType() == money.GetType();
        }

        public static Dollar Dollar(int amount)
        {
            return new Dollar(amount);
        }

        public static Franc Franc(int amount)
        {
            return new Franc(amount);
        }

        public abstract Money Times(int multiplier);

    }
}
