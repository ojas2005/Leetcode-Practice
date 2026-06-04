public class ListNode
{
    public int val;
    public ListNode next;
    public ListNode(int val=0,ListNode next=null){this.val=val;this.next=next;}
}
public class Solution
{
    public void DeleteNode(ListNode node)
    {
        node.val=node.next.val;
        node.next=node.next.next;
    }
}
