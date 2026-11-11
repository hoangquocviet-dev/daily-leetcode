using Xunit;

namespace DailyLeetCode.Tests;

public class ClimbingStairsTests
{
    private readonly Solution _solution = new();

    [Theory]
    [InlineData(2, 2)]
    [InlineData(3, 3)]
    [InlineData(4, 5)]
    [InlineData(5, 8)]
    public void ClimbStairs_ReturnsFibonacci(int n, int expected)
    {
        Assert.Equal(expected, _solution.ClimbStairs(n));
    }
}