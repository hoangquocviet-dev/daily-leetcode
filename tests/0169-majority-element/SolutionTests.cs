using Xunit;

namespace DailyLeetCode.Tests;

public class MajorityElementTests
{
    private readonly Solution _solution = new();

    [Theory]
    [InlineData(new int[] { 3, 2, 3 }, 3)]
    [InlineData(new int[] { 2, 2, 1, 1, 1, 2, 2 }, 2)]
    public void MajorityElement_ReturnsCandidate(int[] nums, int expected)
    {
        Assert.Equal(expected, _solution.MajorityElement(nums));
    }
}