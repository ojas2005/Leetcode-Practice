using System;

public class HouseRobberII
{
    public int Rob(int[] nums)
    {
        if (nums.Length == 1) return nums[0];
        return Math.Max(RobRange(nums, 0, nums.Length - 2), RobRange(nums, 1, nums.Length - 1));
    }

    private int RobRange(int[] nums, int start, int end)
    {
        int prev1 = 0, prev2 = 0;
        for (int i = start; i <= end; i++)
        {
            int tmp = prev1;
            prev1 = Math.Max(prev2 + nums[i], prev1);
            prev2 = tmp;
        }
        return prev1;
    }
}
