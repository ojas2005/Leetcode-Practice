public class Solution
{
    public int MaxArea(int[] height)
    {
        int l=0,r=height.Length-1;
        int maxArea=0;
        while(l<r)
        {
            int h=Math.Min(height[l],height[r]);
            maxArea=Math.Max(maxArea,h*(r-l));
            if(height[l]<height[r])l++;
            else r--;
        }
        return maxArea;
    }
}
