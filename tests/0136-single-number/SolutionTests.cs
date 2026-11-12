using Xunit;

namespace DailyLeetCode.Tests;

public class SingleNumberTests
{
    private readonly Solution _solution = new();

    [Theory]
    [InlineData(new int[] { 2, 2, 1 }, 1)]
    [InlineData(new int[] { 4, 1, 2, 1, 2 }, 4)]
    [InlineData(new int[] { 1 }, 1)]
    public void SingleNumber_ReturnsUniqueElement(int[] nums, int expected)
    {
        Assert.Equal(expected, _solution.SingleNumber(nums));
    }
}