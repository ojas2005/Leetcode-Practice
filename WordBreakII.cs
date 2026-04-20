public class Solution
{
    public IList<string> WordBreak(string s,IList<string> wordDict)
    {
        HashSet<string> dict=new HashSet<string>(wordDict);
        Dictionary<int,List<string>> memo=new Dictionary<int,List<string>>();
        return Helper(s,0,dict,memo);
    }
    private List<string> Helper(string s,int start,HashSet<string> dict,Dictionary<int,List<string>> memo)
    {
        if(memo.ContainsKey(start))return memo[start];
        List<string> res=new List<string>();
        if(start==s.Length)
        {
            res.Add("");
            return res;
        }
        for(int end=start+1;end<=s.Length;end++)
        {
            string word=s.Substring(start,end-start);
            if(dict.Contains(word))
            {
                List<string> subResults=Helper(s,end,dict,memo);
                foreach(string sub in subResults)
                {
                    res.Add(word+(sub==""?"":" ")+sub);
                }
            }
        }
        memo[start]=res;
        return res;
    }
}
