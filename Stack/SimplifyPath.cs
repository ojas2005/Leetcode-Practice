public class Solution
{
    public string SimplifyPath(string path)
    {
        string[] parts=path.Split('/');
        Stack<string> stack=new Stack<string>();
        foreach(string part in parts)
        {
            if(part==""||part==".")continue;
            if(part=="..")
            {
                if(stack.Count>0)stack.Pop();
            }
            else
            {
                stack.Push(part);
            }
        }
        List<string> list=new List<string>(stack);
        list.Reverse();
        return "/"+string.Join("/",list);
    }
}
