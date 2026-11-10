using Xunit;

namespace DailyLeetCode.Tests;

public class ReverseLinkedListTests
{
    private readonly Solution _solution = new();

    [Fact]
    public void ReverseList_ReversesProperly()
    {
        var head = new ListNode(1, new ListNode(2, new ListNode(3)));
        var res = _solution.ReverseList(head);
        Assert.Equal(3, res.val);
        Assert.Equal(2, res.next.val);
        Assert.Equal(1, res.next.next.val);
    }
}