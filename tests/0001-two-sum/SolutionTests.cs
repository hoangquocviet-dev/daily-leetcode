using Xunit;

namespace DailyLeetCode.Tests;

public class TwoSumTests
{
    private readonly Solution _solution = new();

    [Fact]
    public void TwoSum_BasicCases()
    {
        Assert.Equal(new int[] { 0, 1 }, _solution.TwoSum(new int[] { 2, 7, 11, 15 }, 9));
        Assert.Equal(new int[] { 1, 2 }, _solution.TwoSum(new int[] { 3, 2, 4 }, 6));
        Assert.Equal(new int[] { 0, 1 }, _solution.TwoSum(new int[] { 3, 3 }, 6));
    }
}