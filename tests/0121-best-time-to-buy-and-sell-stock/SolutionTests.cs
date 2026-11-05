using Xunit;

namespace DailyLeetCode.Tests;

public class BestTimeToBuyAndSellStockTests
{
    private readonly Solution _solution = new();

    [Fact]
    public void MaxProfit_ReturnsOptimalProfit()
    {
        Assert.Equal(5, _solution.MaxProfit(new int[] { 7, 1, 5, 3, 6, 4 }));
        Assert.Equal(0, _solution.MaxProfit(new int[] { 7, 6, 4, 3, 1 }));
    }
}