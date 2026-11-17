using Xunit;

namespace DailyLeetCode.Tests;

public class MergeTwoListsTests
{
    private readonly Solution _sol = new();

    [Fact]
    public void Test_MergeBothValid()
    {
        var l1 = new ListNode(1, new ListNode(2, new ListNode(4)));
        var l2 = new ListNode(1, new ListNode(3, new ListNode(4)));
        var res = _sol.MergeTwoLists(l1, l2);
        Assert.Equal(1, res.val);
        Assert.Equal(1, res.next.val);
    }
}