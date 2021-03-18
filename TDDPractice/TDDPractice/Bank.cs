using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq.Expressions;
using System.Text;

namespace TDDPractice
{
    public class Bank
    {
        public Money Reduce(IExpression source, string to)
        {
            Sum sum = (Sum) source;
            return sum.Reduce(to);



        }
    }
}
