public class Solution
{
    public int Trap(int[] height)
    {
        int n=height.Length;
        if(n==0)return 0;
        int l=0,r=n-1;
        int leftMax=height[l],rightMax=height[r];
        int res=0;
        while(l<r)
        {
            if(leftMax<rightMax)
            {
                l++;
                leftMax=Math.Max(leftMax,height[l]);
                res+=leftMax-height[l];
            }
            else
            {
                r--;
                rightMax=Math.Max(rightMax,height[r]);
                res+=rightMax-height[r];
            }
        }
        return res;
    }
}
