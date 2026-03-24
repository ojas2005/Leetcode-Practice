public class Solution
{
    public IList<int> PartitionLabels(string s)
    {
        int[] lastIndex=new int[26];
        for(int i=0;i<s.Length;i++)lastIndex[s[i]-'a']=i;
        List<int> res=new List<int>();
        int start=0,end=0;
        for(int i=0;i<s.Length;i++)
        {
            end=Math.Max(end,lastIndex[s[i]-'a']);
            if(i==end)
            {
                res.Add(end-start+1);
                start=i+1;
            }
        }
        return res;
    }
}
