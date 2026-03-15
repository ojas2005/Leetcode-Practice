public class Solution
{
    public int LongestPalindrome(string s)
    {
        int[] count=new int[128];
        for(int i=0;i<s.Length;i++)count[s[i]]++;
        int length=0;
        bool hasOdd=false;
        for(int i=0;i<128;i++)
        {
            length+=count[i]/2*2;
            if(count[i]%2==1)hasOdd=true;
        }
        return hasOdd?length+1:length;
    }
}
