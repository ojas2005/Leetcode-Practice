public class Solution
{
    public IList<int> FindAnagrams(string s,string p)
    {
        List<int> res=new List<int>();
        if(s.Length<p.Length)return res;
        int[] need=new int[26];
        int[] window=new int[26];
        for(int i=0;i<p.Length;i++)need[p[i]-'a']++;
        for(int i=0;i<s.Length;i++)
        {
            window[s[i]-'a']++;
            if(i>=p.Length)window[s[i-p.Length]-'a']--;
            if(i>=p.Length-1&&IsEqual(need,window))res.Add(i-p.Length+1);
        }
        return res;
    }
    private bool IsEqual(int[] a,int[] b)
    {
        for(int i=0;i<26;i++)
        {
            if(a[i]!=b[i])return false;
        }
        return true;
    }
}
