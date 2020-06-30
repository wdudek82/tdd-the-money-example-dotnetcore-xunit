namespace TddMoneyExample.TDD.MoneyExample
{
    public class Pair
    {
        private string _from;
        private string _to;

        public Pair(string from, string to)
        {
            _from = from;
            _to = to;
        }

        public override bool Equals(object? obj)
        {
            var pair = (Pair) obj;
            return _from.Equals(pair?._from) && _to.Equals(pair?._to);
        }

        public override int GetHashCode()
        {
            return 0;
        }
    }
}
