using System.Collections.Generic;

public class OnlineStockSpan
{
    private Stack<(int price, int span)> stack;

    public OnlineStockSpan()
    {
        stack = new Stack<(int, int)>();
    }

    public int Next(int price)
    {
        int span = 1;
        while (stack.Count > 0 && stack.Peek().price <= price)
        {
            span += stack.Pop().span;
        }
        stack.Push((price, span));
        return span;
    }
}
