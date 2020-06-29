namespace TddMoneyExample.TDD.MoneyExample
{
    public class Bank
    {
        public Money Reduce(Expression source, string to)
        {
            var sum = (Sum) source;
            return sum.Reduce(to);
        }
    }
}
