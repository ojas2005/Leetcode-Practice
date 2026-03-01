using System;

public class SquaresOfASortedArray
{
    public int[] SortedSquares(int[] nums)
    {
        int n = nums.Length;
        int[] result = new int[n];
        int left = 0, right = n - 1;
        for (int i = n - 1; i >= 0; i--)
        {
            if (Math.Abs(nums[left]) > Math.Abs(nums[right]))
            {
                result[i] = nums[left] * nums[left];
                left++;
            }
            else
            {
                result[i] = nums[right] * nums[right];
                right--;
            }
        }
        return result;
    }
}
