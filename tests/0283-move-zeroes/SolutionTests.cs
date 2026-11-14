using Xunit;

namespace DailyLeetCode.Tests;

public class MoveZeroesTests
{
    private readonly Solution _solution = new();

    [Fact]
    public void MoveZeroes_ShiftsZeroesToEnd()
    {
        int[] nums = { 0, 1, 0, 3, 12 };
        _solution.MoveZeroes(nums);
        Assert.Equal(new int[] { 1, 3, 12, 0, 0 }, nums);
    }
}