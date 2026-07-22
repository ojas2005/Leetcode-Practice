using System.Collections.Generic;

public class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {
        Dictionary<int, int> dict = new();

        for (int i = 0; i < nums.Length; i++)
        {
            int complement = target - nums[i];

            if (dict.ContainsKey(complement))
            {
                return new int[] { dict[complement],i};
            }

            dict[nums[i]]=i; //to put in dictionary
        }

        return new int[] { -1, -1 }; //when nothing matches with the target
    }
}