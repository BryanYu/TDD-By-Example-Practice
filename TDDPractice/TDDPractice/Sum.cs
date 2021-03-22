using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualBasic;
using NUnit.Framework;

namespace TDDPractice
{
    class Sum :IExpression
    {
        
        public Sum(IExpression augend, IExpression addend)
        {
            this.Augend = augend;
            this.Addend = addend;
        }

        public IExpression Augend { get; set; }
        public IExpression Addend { get; set; }



        public Money Reduce(Bank bank, string to)
        {
            int amount = this.Augend.Reduce(bank, to).Amount + this.Addend.Reduce(bank, to).Amount;
            return new Money(amount, to);
        }

        public IExpression Plus(IExpression addend)
        {
            return new Sum(this, addend);
        }

        public IExpression Times(int multiplier)
        {
            return new Sum(this.Augend.Times(multiplier), Addend.Times(multiplier));
        }
    }
}
