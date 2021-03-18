using System;
using System.Collections.Generic;
using System.Text;

namespace TDDPractice
{
    public class Bank
    {
        public Money Reduce(IExpression sum, string to)
        {
            return Money.Dollar(10);
        }
    }
}
