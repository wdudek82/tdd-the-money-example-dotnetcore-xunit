using System.Linq.Expressions;

namespace TddMoneyExample.TDD.MoneyExample
{
    public class Sum : IExpression
    {
        public Sum(IExpression augend, IExpression addend)
        {
            Augend = augend;
            Addend = addend;
        }

        public IExpression Augend { get; }
        public IExpression Addend { get; }

        public Money Reduce(Bank bank, string to)
        {
            var reducedAugend = Augend.Reduce(bank, to);
            var reducedAddend = Addend.Reduce(bank, to);
            var amount = reducedAugend.Amount + reducedAddend.Amount;
            return new Money(amount, to);
        }

        public IExpression Plus(IExpression addend)
        {
            return new Sum(this, addend);
        }

        public IExpression Times(int multiplier)
        {
            return new Sum(Augend.Times(multiplier), Addend.Times(multiplier));
        }
    }
}
