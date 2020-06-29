namespace TddMoneyExample.TDD.MoneyExample
{
    public class Money : Expression
    {
        public Money(int amount, string currency)
        {
            Amount = amount;
            Currency = currency;
        }

        public int Amount { get; }
        public string Currency { get; }

        public static Money Dollar(int amount)
        {
            return new Money(amount, "USD");
        }

        public static Money Franc(int amount)
        {
            return new Money(amount, "CHF");
        }

        public Money Times(int multiplier)
        {
            return new Money(Amount * multiplier, Currency);
        }

        public Expression Plus(Money addend)
        {
            return new Sum(this, addend);
        }

        public override bool Equals(object? obj)
        {
            var money = (Money) obj;
            return Amount == money?.Amount
                   && Currency.Equals(money.Currency);
        }

        public override string ToString()
        {
            return $"{Amount} {Currency}";
        }
    }
}
