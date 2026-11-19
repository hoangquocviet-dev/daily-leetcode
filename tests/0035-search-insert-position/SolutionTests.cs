using Xunit;

namespace DailyLeetCode.Tests;

public class SearchInsertPositionTests
{
    private readonly Solution _sol = new();

    [Fact]
    public void Test_Found()
    {
        Assert.Equal(2, _sol.SearchInsert(new int[] { 1, 3, 5, 6 }, 5));
    }

    [Fact]
    public void Test_InsertPosition()
    {
        Assert.Equal(1, _sol.SearchInsert(new int[] { 1, 3, 5, 6 }, 2));
        Assert.Equal(4, _sol.SearchInsert(new int[] { 1, 3, 5, 6 }, 7));
    }
}