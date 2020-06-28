using NuGet.Frameworks;
using TddMoneyExample.TDD.MoneyExample;
using Xunit;
using Xunit.Sdk;

namespace MoneyExampleTests
{
    public class MoneyTest
    {
        [Fact]
        public void TestDollarMultiplication()
        {
            Money five = Money.dollar(5);

            Assert.Equal(Money.dollar(10), five.Times(2));
            Assert.Equal(Money.dollar(15), five.Times(3));
        }

        [Fact]
        public void TestFrancMultiplication()
        {
            Money five = Money.franc(5);

            Assert.Equal(Money.franc(10), five.Times(2));
            Assert.Equal(Money.franc(15), five.Times(3));
        }

        [Fact]
        public void TestEquality()
        {
            Assert.True(Money.dollar(5).Equals(Money.dollar(5)));
            Assert.False(Money.dollar(5).Equals(Money.dollar(6)));
            Assert.True(Money.franc(5).Equals(Money.franc(5)));
            Assert.False(Money.franc(5).Equals(Money.franc(6)));
            Assert.False(Money.franc(5).Equals(Money.dollar(5)));
        }
    }
}
