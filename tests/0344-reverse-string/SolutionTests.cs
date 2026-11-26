using Xunit;

namespace DailyLeetCode.Tests;

public class ReverseStringTests
{
    private readonly Solution _sol = new();

    [Fact]
    public void Test_ReverseString()
    {
        char[] s = { 'h', 'e', 'l', 'l', 'o' };
        _sol.ReverseString(s);
        Assert.Equal(new char[] { 'o', 'l', 'l', 'e', 'h' }, s);
    }
}