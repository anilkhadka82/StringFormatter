using Shouldly;
using Xunit;

namespace StringFormatter.Tests
{
    public class StringExtensionsTests
    {
        [Fact]
        public void NullListShouldReturnEmptyString()
        {
            string[] dummyStringList = null;

            dummyStringList.ToCommaSepatatedList().ShouldBe("");
        }

        [Theory]
        [InlineData("\'John\',\'Sam\'", new string[] { "John", "Sam" })]
        [InlineData("\'Matt\',\'Ryan\'", new string[] { "Matt", "Ryan" })]
        public void ShouldReturnFormattedStringsAsExpected(string expectedString, string[] data)
        {
            data.ToCommaSepatatedList().ShouldBe(expectedString);
        }
    }
}
