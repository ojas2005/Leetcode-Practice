public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int,int> dict = new();
        for(int i = 0;i<nums.Length;i++)
        {
            int rem = target-nums[i];
            if(dict.ContainsKey(rem))
            {
                return new int[] {dict[rem],i};

            }
            dict[nums[i]] = i;
        }
        return new int[] {-1,-1};
    }
}