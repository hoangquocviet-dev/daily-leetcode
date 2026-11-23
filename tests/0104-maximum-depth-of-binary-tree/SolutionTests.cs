using Xunit;

namespace DailyLeetCode.Tests;

public class MaxDepthTests
{
    private readonly Solution _sol = new();

    [Fact]
    public void Test_EmptyTree()
    {
        Assert.Equal(0, _sol.MaxDepth(null));
    }

    [Fact]
    public void Test_SampleTree()
    {
        var root = new TreeNode(3, new TreeNode(9), new TreeNode(20, new TreeNode(15), new TreeNode(7)));
        Assert.Equal(3, _sol.MaxDepth(root));
    }
}