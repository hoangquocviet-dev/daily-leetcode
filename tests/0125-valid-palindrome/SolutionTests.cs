using Xunit;

namespace DailyLeetCode.Tests;

public class ValidPalindromeTests
{
    private readonly Solution _solution = new();

    [Theory]
    [InlineData("A man, a plan, a canal: Panama", true)]
    [InlineData("race a car", false)]
    [InlineData(" ", true)]
    [InlineData(".,", true)]
    [InlineData("0P", false)]
    [InlineData("ab_a", true)]
    public void IsPalindrome_ReturnsExpectedResult(string input, bool expected)
    {
        bool actual = _solution.IsPalindrome(input);
        Assert.Equal(expected, actual);
    }
}