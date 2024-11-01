using System.Threading.Channels;

namespace MyAlgorithms.Tests
{
    public class MoneyReference
    {
        public string Currency { get; set; }
        public decimal Amount { get; set; }
    }

    public struct MoneyValue
    {
        public string Currency { get; set; }
        public decimal Amount { get; set; }
    }


    public class Value_Reference_Tests
    {
        [Fact]
        public void Equal()
        {
            MoneyValue mv1 = new() { Amount = 100, Currency = "GEL" };
            MoneyValue mv2 = new() { Amount = 100, Currency = "USD" };

            MoneyReference mr1 = new() { Amount = 100, Currency = "GEL" };
            MoneyReference mr2 = /*new() { Amount = 100, Currency = "GEL" };*/ mr1;

            Assert.Equal(mr1, mr2);
        }
    }
}
