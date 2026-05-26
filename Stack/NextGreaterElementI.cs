using System.Collections.Generic;

public class NextGreaterElementI
{
    public int[] NextGreaterElement(int[] nums1, int[] nums2)
    {
        Dictionary<int, int> nextGreater = new Dictionary<int, int>();
        Stack<int> stack = new Stack<int>();
        foreach (int num in nums2)
        {
            while (stack.Count > 0 && stack.Peek() < num)
            {
                nextGreater[stack.Pop()] = num;
            }
            stack.Push(num);
        }
        int[] ans = new int[nums1.Length];
        for (int i = 0; i < nums1.Length; i++)
        {
            ans[i] = nextGreater.ContainsKey(nums1[i]) ? nextGreater[nums1[i]] : -1;
        }
        return ans;
    }
}
