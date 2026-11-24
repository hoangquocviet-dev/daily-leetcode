using Xunit;

namespace DailyLeetCode.Tests;

public class SameTreeTests
{
    private readonly Solution _sol = new();

    [Fact]
    public void Test_SameTree_True()
    {
        var p = new TreeNode(1, new TreeNode(2), new TreeNode(3));
        var q = new TreeNode(1, new TreeNode(2), new TreeNode(3));
        Assert.True(_sol.IsSameTree(p, q));
    }
}