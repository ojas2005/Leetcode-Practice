public class Solution
{
    public int Compress(char[] chars)
    {
        int write=0,read=0;
        int n=chars.Length;
        while(read<n)
        {
            char curr=chars[read];
            int count=0;
            while(read<n&&chars[read]==curr)
            {
                read++;
                count++;
            }
            chars[write++]=curr;
            if(count>1)
            {
                foreach(char c in count.ToString())chars[write++]=c;
            }
        }
        return write;
    }
}
