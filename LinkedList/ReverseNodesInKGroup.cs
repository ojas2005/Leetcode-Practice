public class ListNode
{
    public int val;
    public ListNode next;
    public ListNode(int val=0,ListNode next=null){this.val=val;this.next=next;}
}
public class Solution
{
    public ListNode ReverseKGroup(ListNode head,int k)
    {
        ListNode node=head;
        int count=0;
        while(node!=null&&count<k)
        {
            node=node.next;
            count++;
        }
        if(count<k)return head;
        ListNode prev=ReverseKGroup(node,k);
        ListNode curr=head;
        for(int i=0;i<k;i++)
        {
            ListNode next=curr.next;
            curr.next=prev;
            prev=curr;
            curr=next;
        }
        return prev;
    }
}
