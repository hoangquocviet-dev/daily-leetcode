using Xunit;

namespace DailyLeetCode.Tests;

public class ValidParenthesesTests
{
    private readonly Solution _solution = new();

    [Theory]
    [InlineData("()", true)]
    [InlineData("()[]{}", true)]
    [InlineData("(]", false)]
    [InlineData("([)]", false)]
    [InlineData("{[]}", true)]
    public void IsValid_ReturnsExpectedResult(string input, bool expected)
    {
        Assert.Equal(expected, _solution.IsValid(input));
    }
}