using Xunit;

namespace DailyLeetCode.Tests;

public class NumberOf1BitsTests
{
    private readonly Solution _solution = new();

    [Theory]
    [InlineData(11, 3)]
    [InlineData(128, 1)]
    [InlineData(2147483645, 30)]
    public void HammingWeight_CountsSetBits(int n, int expected)
    {
        Assert.Equal(expected, _solution.HammingWeight(n));
    }
}