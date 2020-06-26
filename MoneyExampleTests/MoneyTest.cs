using ConsoleSandboxApp.TDD.MoneyExample;
using Xunit;

namespace MoneyExampleTests
{
    public class MoneyTest
    {
        [Fact]
        public void TestMultiplication()
        {
            var five = new Dollar(5);
            five.Times(2);
            Assert.Equal(10, five.Amount);
        }
    }
}
