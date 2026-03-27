public class Solution
{
    public string FrequencySort(string s)
    {
        Dictionary<char,int> count=new Dictionary<char,int>();
        for(int i=0;i<s.Length;i++)
        {
            if(count.ContainsKey(s[i]))count[s[i]]++;
            else count[s[i]]=1;
        }
        List<char> chars=new List<char>(count.Keys);
        chars.Sort((a,b)=>count[b]-count[a]);
        StringBuilder sb=new StringBuilder();
        foreach(char c in chars)
        {
            for(int i=0;i<count[c];i++)sb.Append(c);
        }
        return sb.ToString();
    }
}
