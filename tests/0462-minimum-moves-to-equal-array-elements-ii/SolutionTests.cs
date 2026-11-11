using Xunit;

namespace DailyLeetCode.Tests;

public class MinMoves2Tests {
    private readonly Solution _solution = new();

    [Fact]
    public void MinMoves2_BasicCases() {
        Assert.Equal(2, _solution.MinMoves2(new int[] { 1, 2, 3 }));
        Assert.Equal(16, _solution.MinMoves2(new int[] { 1, 10, 2, 9 }));
    }
}
