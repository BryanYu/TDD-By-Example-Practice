using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualBasic;

namespace TDDPractice
{
    class Sum :IExpression
    {
        
        public Sum(Money augend, Money addend)
        {
            this.Augend = augend;
            this.Addend = addend;
        }

        public Money Augend { get; set; }
        public Money Addend { get; set; }

        public Money Reduce(string to)
        {
            int amount = this.Augend.Amount + this.Addend.Amount;
            return new Money(amount, to);
        }

        public Money Reduce(Bank bank, string to)
        {
            int amount = Augend.Amount + Addend.Amount;
            return new Money(amount, to);
        }
    }
}
