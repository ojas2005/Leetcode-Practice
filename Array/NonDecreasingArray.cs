public class NonDecreasingArray
{
    public bool CheckPossibility(int[] nums)
    {
        int count = 0;
        for (int i = 1; i < nums.Length && count <= 1; i++)
        {
            if (nums[i - 1] > nums[i])
            {
                count++;
                if (i - 2 < 0 || nums[i - 2] <= nums[i])
                {
                    nums[i - 1] = nums[i];
                }
                else
                {
                    nums[i] = nums[i - 1];
                }
            }
        }
        return count <= 1;
    }
}
