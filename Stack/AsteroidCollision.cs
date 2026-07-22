public class Solution
{
    public int[] AsteroidCollision(int[] asteroids)
    {
        Stack<int> stack=new Stack<int>();
        for(int i=0;i<asteroids.Length;i++)
        {
            int curr=asteroids[i];
            bool alive=true;
            while(alive&&curr<0&&stack.Count>0&&stack.Peek()>0)
            {
                int top=stack.Peek();
                if(top<-curr)
                {
                    stack.Pop();
                }
                else if(top==-curr)
                {
                    stack.Pop();
                    alive=false;
                }
                else
                {
                    alive=false;
                }
            }
            if(alive)stack.Push(curr);
        }
        int[] result=stack.ToArray();
        Array.Reverse(result);
        return result;
    }
}
