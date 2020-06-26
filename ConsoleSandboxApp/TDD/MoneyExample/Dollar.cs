namespace ConsoleSandboxApp.TDD.MoneyExample
{
    public class Dollar
    {
        public Dollar(int amount)
        {
            Amount = amount;
        }

        public int Amount { get; set; }

        public void Times(int multiplier)
        {
            Amount *= multiplier;
        }
    }
}
