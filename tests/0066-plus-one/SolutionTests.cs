using Xunit;

namespace DailyLeetCode.Tests;

public class PlusOneTests
{
    private readonly Solution _sol = new();

    [Fact]
    public void Test_Normal()
    {
        Assert.Equal(new int[] { 1, 2, 4 }, _sol.PlusOne(new int[] { 1, 2, 3 }));
    }

    [Fact]
    public void Test_AllNines()
    {
        Assert.Equal(new int[] { 1, 0, 0 }, _sol.PlusOne(new int[] { 9, 9 }));
    }
}