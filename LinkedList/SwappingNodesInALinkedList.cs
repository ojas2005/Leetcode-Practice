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

public class SwappingNodesInALinkedList
{
    public ListNode SwapNodes(ListNode head, int k)
    {
        ListNode fast = head;
        ListNode slow = head;
        ListNode first = head;

        for (int i = 1; i < k; i++)
        {
            fast = fast.next;
        }
        first = fast;

        while (fast.next != null)
        {
            fast = fast.next;
            slow = slow.next;
        }

        int temp = first.val;
        first.val = slow.val;
        slow.val = temp;

        return head;
    }
}
