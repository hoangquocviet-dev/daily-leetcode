public class Solution {
    public ListNode ReverseList(ListNode head) {
        var list = new System.Collections.Generic.List<int>();
        ListNode curr = head;
        while (curr != null) {
            list.Add(curr.val);
            curr = curr.next;
        }
        if (list.Count == 0) return null;
        ListNode newHead = new ListNode(list[list.Count - 1]);
        ListNode p = newHead;
        for (int i = list.Count - 2; i >= 0; i--) {
            p.next = new ListNode(list[i]);
            p = p.next;
        }
        return newHead;
    }
}