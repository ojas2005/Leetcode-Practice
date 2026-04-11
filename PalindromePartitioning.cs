public class Solution
{
    public IList<IList<string>> Partition(string s)
    {
        List<IList<string>> res=new List<IList<string>>();
        Backtrack(s,0,new List<string>(),res);
        return res;
    }
    private void Backtrack(string s,int start,List<string> curr,List<IList<string>> res)
    {
        if(start==s.Length)
        {
            res.Add(new List<string>(curr));
            return;
        }
        for(int end=start+1;end<=s.Length;end++)
        {
            string sub=s.Substring(start,end-start);
            if(IsPalindrome(sub))
            {
                curr.Add(sub);
                Backtrack(s,end,curr,res);
                curr.RemoveAt(curr.Count-1);
            }
        }
    }
    private bool IsPalindrome(string s)
    {
        int l=0,r=s.Length-1;
        while(l<r)
        {
            if(s[l]!=s[r])return false;
            l++;
            r--;
        }
        return true;
    }
}
