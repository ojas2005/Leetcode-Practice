public class Solution
{
    public bool CheckInclusion(string s1,string s2)
    {
        if(s1.Length>s2.Length)return false;
        int[] need=new int[26];
        int[] window=new int[26];
        for(int i=0;i<s1.Length;i++)need[s1[i]-'a']++;
        for(int i=0;i<s2.Length;i++)
        {
            window[s2[i]-'a']++;
            if(i>=s1.Length)window[s2[i-s1.Length]-'a']--;
            if(i>=s1.Length-1&&IsEqual(need,window))return true;
        }
        return false;
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
