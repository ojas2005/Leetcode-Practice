public class ListNode
{
    public int val;
    public ListNode next;
    public ListNode(int val=0, ListNode next=null)
    {
        this.val = val;
        this.next = next;
    }
}

public class SwapNodesInPairs
{
    public ListNode SwapPairs(ListNode head)
    {
        if (head == null || head.next == null) return head;

        ListNode dummy = new ListNode(0);
        dummy.next = head;
        ListNode point = dummy;

        while (point.next != null && point.next.next != null)
        {
            ListNode swap1 = point.next;
            ListNode swap2 = point.next.next;

            swap1.next = swap2.next;
            swap2.next = swap1;
            point.next = swap2;

            point = swap1;
        }

        return dummy.next;
    }
}
