using Xunit;

namespace DailyLeetCode.Tests;

public class IsSubsequenceTests
{
    private readonly Solution _sol = new();

    [Fact]
    public void Test_Subsequence_True()
    {
        Assert.True(_sol.IsSubsequence("abc", "ahbgdc"));
    }

    [Fact]
    public void Test_Subsequence_False()
    {
        Assert.False(_sol.IsSubsequence("axc", "ahbgdc"));
    }
}