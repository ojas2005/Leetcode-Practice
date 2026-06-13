public class ListNode
{
    public int val;
    public ListNode next;
    public ListNode(int val=0,ListNode next=null){this.val=val;this.next=next;}
}
public class Solution
{
    public bool IsPalindrome(ListNode head)
    {
        List<int> vals=new List<int>();
        ListNode curr=head;
        while(curr!=null)
        {
            vals.Add(curr.val);
            curr=curr.next;
        }
        int l=0,r=vals.Count-1;
        while(l<r)
        {
            if(vals[l]!=vals[r])return false;
            l++;
            r--;
        }
        return true;
    }
}
