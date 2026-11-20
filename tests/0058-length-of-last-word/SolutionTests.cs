using Xunit;

namespace DailyLeetCode.Tests;

public class LengthOfLastWordTests
{
    private readonly Solution _sol = new();

    [Fact]
    public void Test_Basic()
    {
        Assert.Equal(5, _sol.LengthOfLastWord("Hello World"));
        Assert.Equal(4, _sol.LengthOfLastWord("   fly me   to   the moon  "));
    }
}