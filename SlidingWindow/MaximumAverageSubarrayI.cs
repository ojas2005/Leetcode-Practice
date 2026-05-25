using System;

public class MaximumAverageSubarrayI
{
    public double FindMaxAverage(int[] nums, int k)
    {
        double sum = 0;
        for (int i = 0; i < k; i++)
        {
            sum += nums[i];
        }
        
        double maxSum = sum;
        for (int i = k; i < nums.Length; i++)
        {
            sum += nums[i] - nums[i - k];
            maxSum = Math.Max(maxSum, sum);
        }
        
        return maxSum / k;
    }
}
