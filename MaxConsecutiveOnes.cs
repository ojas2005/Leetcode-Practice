public class Solution
{
    public int FindMaxConsecutiveOnes(int[] nums)
    {
        int maxCount=0,count=0;
        for(int i=0;i<nums.Length;i++)
        {
            if(nums[i]==1)
            {
                count++;
                maxCount=Math.Max(maxCount,count);
            }
            else
            {
                count=0;
            }
        }
        return maxCount;
    }
}
