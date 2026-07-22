public class Solution
{
    public string MinWindow(string s,string t)
    {
        if(s.Length==0||t.Length==0)return "";
        Dictionary<char,int> need=new Dictionary<char,int>();
        for(int i=0;i<t.Length;i++)
        {
            if(need.ContainsKey(t[i]))need[t[i]]++;
            else need[t[i]]=1;
        }
        int required=need.Count;
        int formed=0;
        Dictionary<char,int> windowCounts=new Dictionary<char,int>();
        int left=0;
        int bestLen=int.MaxValue,bestLeft=0;
        for(int right=0;right<s.Length;right++)
        {
            char c=s[right];
            if(windowCounts.ContainsKey(c))windowCounts[c]++;
            else windowCounts[c]=1;
            if(need.ContainsKey(c)&&windowCounts[c]==need[c])formed++;
            while(left<=right&&formed==required)
            {
                if(right-left+1<bestLen)
                {
                    bestLen=right-left+1;
                    bestLeft=left;
                }
                char leftChar=s[left];
                windowCounts[leftChar]--;
                if(need.ContainsKey(leftChar)&&windowCounts[leftChar]<need[leftChar])formed--;
                left++;
            }
        }
        return bestLen==int.MaxValue?"":s.Substring(bestLeft,bestLen);
    }
}
