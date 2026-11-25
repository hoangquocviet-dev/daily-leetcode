using Xunit;

namespace DailyLeetCode.Tests;

public class MissingNumberTests
{
    private readonly Solution _sol = new();

    [Fact]
    public void Test_MissingNumber()
    {
        Assert.Equal(2, _sol.MissingNumber(new int[] { 3, 0, 1 }));
        Assert.Equal(8, _sol.MissingNumber(new int[] { 9, 6, 4, 2, 3, 5, 7, 0, 1 }));
    }
}