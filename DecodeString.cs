public class Solution
{
    public string DecodeString(string s)
    {
        Stack<int> countStack=new Stack<int>();
        Stack<StringBuilder> stringStack=new Stack<StringBuilder>();
        StringBuilder curr=new StringBuilder();
        int num=0;
        foreach(char c in s)
        {
            if(char.IsDigit(c))
            {
                num=num*10+(c-'0');
            }
            else if(c=='[')
            {
                countStack.Push(num);
                stringStack.Push(curr);
                curr=new StringBuilder();
                num=0;
            }
            else if(c==']')
            {
                int repeat=countStack.Pop();
                StringBuilder prev=stringStack.Pop();
                for(int i=0;i<repeat;i++)prev.Append(curr);
                curr=prev;
            }
            else
            {
                curr.Append(c);
            }
        }
        return curr.ToString();
    }
}
