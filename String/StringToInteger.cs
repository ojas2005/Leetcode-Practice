public class Solution
{
    public int MyAtoi(string s)
    {
        int i=0,n=s.Length;
        while(i<n&&s[i]==' ')i++;
        int sign=1;
        if(i<n&&(s[i]=='+'||s[i]=='-'))
        {
            if(s[i]=='-')sign=-1;
            i++;
        }
        long res=0;
        while(i<n&&s[i]>='0'&&s[i]<='9')
        {
            res=res*10+(s[i]-'0');
            if(res*sign>int.MaxValue)return int.MaxValue;
            if(res*sign<int.MinValue)return int.MinValue;
            i++;
        }
        return (int)(res*sign);
    }
}
