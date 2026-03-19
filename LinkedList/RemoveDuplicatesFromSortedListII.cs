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

public class RemoveDuplicatesFromSortedListII
{
    public ListNode DeleteDuplicates(ListNode head)
    {
        ListNode dummy = new ListNode(0, head);
        ListNode pred = dummy;
        
        while (head != null)
        {
            if (head.next != null && head.val == head.next.val)
            {
                while (head.next != null && head.val == head.next.val)
                {
                    head = head.next;
                }
                pred.next = head.next;
            }
            else
            {
                pred = pred.next;
            }
            head = head.next;
        }
        
        return dummy.next;
    }
}
