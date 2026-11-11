using Xunit;

namespace DailyLeetCode.Tests;

public class ValidAnagramTests {
    private readonly Solution _solution = new();

    [Fact]
    public void IsAnagram_BasicCases() {
        Assert.True(_solution.IsAnagram("anagram", "nagaram"));
        Assert.False(_solution.IsAnagram("rat", "car"));
    }
}
