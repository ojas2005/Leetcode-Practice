public class Solution
{
    public IList<string> GenerateParenthesis(int n)
    {
        List<string> res=new List<string>();
        Backtrack(n,0,0,new StringBuilder(),res);
        return res;
    }
    private void Backtrack(int n,int open,int close,StringBuilder curr,List<string> res)
    {
        if(curr.Length==2*n)
        {
            res.Add(curr.ToString());
            return;
        }
        if(open<n)
        {
            curr.Append('(');
            Backtrack(n,open+1,close,curr,res);
            curr.Length--;
        }
        if(close<open)
        {
            curr.Append(')');
            Backtrack(n,open,close+1,curr,res);
            curr.Length--;
        }
    }
}
