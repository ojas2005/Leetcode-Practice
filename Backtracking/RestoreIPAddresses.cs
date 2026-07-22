public class Solution
{
    public IList<string> RestoreIpAddresses(string s)
    {
        List<string> res=new List<string>();
        Backtrack(s,0,new List<string>(),res);
        return res;
    }
    private void Backtrack(string s,int start,List<string> curr,List<string> res)
    {
        if(curr.Count==4)
        {
            if(start==s.Length)res.Add(string.Join(".",curr));
            return;
        }
        for(int len=1;len<=3&&start+len<=s.Length;len++)
        {
            string part=s.Substring(start,len);
            if(len>1&&part[0]=='0')break;
            if(int.Parse(part)>255)break;
            curr.Add(part);
            Backtrack(s,start+len,curr,res);
            curr.RemoveAt(curr.Count-1);
        }
    }
}
