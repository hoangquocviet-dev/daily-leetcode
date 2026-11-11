using Xunit;

namespace DailyLeetCode.Tests;

public class ContainsDuplicateTests {
    private readonly Solution _solution = new();

    [Fact]
    public void ContainsDuplicate_BasicCases() {
        Assert.True(_solution.ContainsDuplicate(new int[] { 1, 2, 3, 1 }));
        Assert.False(_solution.ContainsDuplicate(new int[] { 1, 2, 3, 4 }));
        Assert.True(_solution.ContainsDuplicate(new int[] { 1, 1, 1, 3, 3, 4, 3, 2, 4, 2 }));
    }
}
