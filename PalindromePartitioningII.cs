public class Solution
{
    public int MinCut(string s)
    {
        int n=s.Length;
        bool[,] isPalindrome=new bool[n,n];
        for(int i=0;i<n;i++)isPalindrome[i,i]=true;
        for(int len=2;len<=n;len++)
        {
            for(int i=0;i<=n-len;i++)
            {
                int j=i+len-1;
                if(s[i]==s[j])
                {
                    if(len==2||isPalindrome[i+1,j-1])isPalindrome[i,j]=true;
                }
            }
        }
        int[] dp=new int[n];
        for(int i=0;i<n;i++)
        {
            if(isPalindrome[0,i])
            {
                dp[i]=0;
            }
            else
            {
                dp[i]=int.MaxValue;
                for(int j=1;j<=i;j++)
                {
                    if(isPalindrome[j,i]&&dp[j-1]+1<dp[i])dp[i]=dp[j-1]+1;
                }
            }
        }
        return dp[n-1];
    }
}
