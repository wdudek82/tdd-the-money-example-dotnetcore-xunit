using System;

namespace TddMoneyExample.TDD.MoneyExample
{
    public abstract class Money
    {
        protected int Amount;

        public static Money dollar(int amount)
        {
            return new Dollar(amount);
        }

        public static Money franc(int amount)
        {
            return new Franc(amount);
        }

        public abstract Money Times(int amount);

        public override bool Equals(object? obj)
        {
            var money = (Money) obj;
            return Amount == money?.Amount
                && GetType() == obj.GetType();
        }
    }

}
