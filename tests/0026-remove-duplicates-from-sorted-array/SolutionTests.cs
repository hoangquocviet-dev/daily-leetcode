using Xunit;

namespace DailyLeetCode.Tests;

public class RemoveDuplicatesTests
{
    private readonly Solution _sol = new();

    [Fact]
    public void Test_RemoveDuplicates()
    {
        int[] nums = { 1, 1, 2 };
        int k = _sol.RemoveDuplicates(nums);
        Assert.Equal(2, k);
        Assert.Equal(1, nums[0]);
        Assert.Equal(2, nums[1]);
    }
}