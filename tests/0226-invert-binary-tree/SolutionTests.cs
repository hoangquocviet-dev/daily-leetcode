using Xunit;

namespace DailyLeetCode.Tests;

public class InvertBinaryTreeTests
{
    private readonly Solution _solution = new();

    [Fact]
    public void InvertTree_InvertsCorrectly()
    {
        var root = new TreeNode(2, new TreeNode(1), new TreeNode(3));
        var inverted = _solution.InvertTree(root);
        Assert.Equal(3, inverted.left.val);
        Assert.Equal(1, inverted.right.val);
    }
}