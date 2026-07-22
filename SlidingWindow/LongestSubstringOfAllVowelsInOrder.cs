public class Solution
{
    public int LongestBeautifulSubstring(string word)
    {
        int n=word.Length;
        int maxLen=0;
        int i=0;
        while(i<n)
        {
            int j=i+1;
            HashSet<char> seen=new HashSet<char>();
            seen.Add(word[i]);
            while(j<n&&word[j]>=word[j-1])
            {
                seen.Add(word[j]);
                j++;
            }
            if(seen.Count==5&&word[j-1]=='u')maxLen=Math.Max(maxLen,j-i);
            i=j;
        }
        return maxLen;
    }
}
