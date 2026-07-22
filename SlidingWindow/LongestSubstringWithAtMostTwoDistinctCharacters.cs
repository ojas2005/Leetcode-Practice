public class Solution
{
    public int LengthOfLongestSubstringTwoDistinct(string s)
    {
        Dictionary<char,int> count=new Dictionary<char,int>();
        int left=0,maxLen=0;
        for(int right=0;right<s.Length;right++)
        {
            char c=s[right];
            if(count.ContainsKey(c))count[c]++;
            else count[c]=1;
            while(count.Count>2)
            {
                char leftChar=s[left];
                count[leftChar]--;
                if(count[leftChar]==0)count.Remove(leftChar);
                left++;
            }
            maxLen=Math.Max(maxLen,right-left+1);
        }
        return maxLen;
    }
}
