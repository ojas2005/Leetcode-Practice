public class Solution
{
    public string CountAndSay(int n)
    {
        string res="1";
        for(int i=1;i<n;i++)
        {
            res=Next(res);
        }
        return res;
    }
    private string Next(string s)
    {
        StringBuilder sb=new StringBuilder();
        int i=0;
        while(i<s.Length)
        {
            int count=1;
            while(i+1<s.Length&&s[i]==s[i+1])
            {
                count++;
                i++;
            }
            sb.Append(count);
            sb.Append(s[i]);
            i++;
        }
        return sb.ToString();
    }
}
