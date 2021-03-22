using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq.Expressions;
using System.Text;

namespace TDDPractice
{
    public class Bank
    {

        private Hashtable rates = new Hashtable();
        public Money Reduce(IExpression source, string to)
        {
            return source.Reduce(this, to);
        }
        
        public void AddRate(string from, string to, int rate)
        {
            this.rates.Add(new Pair(from, to), rate);
        }

        public int Rate(string from, string to)
        {
            if (from.Equals(to))
            {
                return 1;
            }
            var rate = rates[new Pair(from, to)];
            return (int)rate;
        }
    }
}
