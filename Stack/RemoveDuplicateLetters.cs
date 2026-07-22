public class Solution
{
    public string RemoveDuplicateLetters(string s)
    {
        int[] lastIndex=new int[26];
        for(int i=0;i<s.Length;i++)lastIndex[s[i]-'a']=i;
        bool[] inStack=new bool[26];
        Stack<char> stack=new Stack<char>();
        for(int i=0;i<s.Length;i++)
        {
            char c=s[i];
            if(inStack[c-'a'])continue;
            while(stack.Count>0&&stack.Peek()>c&&lastIndex[stack.Peek()-'a']>i)
            {
                inStack[stack.Pop()-'a']=false;
            }
            stack.Push(c);
            inStack[c-'a']=true;
        }
        char[] result=stack.ToArray();
        Array.Reverse(result);
        return new string(result);
    }
}
