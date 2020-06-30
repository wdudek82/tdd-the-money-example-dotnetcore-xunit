using System.Collections;
using Microsoft.VisualBasic.CompilerServices;

namespace TddMoneyExample.TDD.MoneyExample
{
    public class Bank
    {
        private Hashtable _rates = new Hashtable();

        public Money Reduce(IExpression source, string to)
        {
            return source.Reduce(this, to);
        }

        public void AddRate(string from, string to, int rate)
        {
            _rates.Add(new Pair(from, to), rate);
        }

        public int Rate(string from, string to)
        {
            if (from.Equals(to))
            {
                return 1;
            }

            var pair = new Pair(from, to);
            var rate = (int) _rates[pair];
            return rate;
        }
    }
}
