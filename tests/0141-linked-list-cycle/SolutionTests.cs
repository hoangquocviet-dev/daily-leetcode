using Xunit;

namespace DailyLeetCode.Tests;

public class LinkedListCycleTests
{
    private readonly Solution _solution = new();

    [Fact]
    public void HasCycle_DetectsCycles()
    {
        var head = new ListNode(1);
        head.next = new ListNode(2);
        head.next.next = head; // Cycle
        Assert.True(_solution.HasCycle(head));
    }
}