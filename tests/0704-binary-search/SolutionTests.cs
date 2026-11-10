using Xunit;

namespace DailyLeetCode.Tests;

public class BinarySearchTests
{
    private readonly Solution _solution = new();

    [Fact]
    public void Search_FindsTargetIndex()
    {
        Assert.Equal(4, _solution.Search(new int[] { -1, 0, 3, 5, 9, 12 }, 9));
        Assert.Equal(-1, _solution.Search(new int[] { -1, 0, 3, 5, 9, 12 }, 2));
    }
}