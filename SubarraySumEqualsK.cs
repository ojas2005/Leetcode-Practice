public class Solution
{
    public int SubarraySum(int[] nums,int k)
    {
        Dictionary<int,int> map=new Dictionary<int,int>();
        map[0]=1;
        int sum=0,count=0;
        for(int i=0;i<nums.Length;i++)
        {
            sum+=nums[i];
            if(map.ContainsKey(sum-k))count+=map[sum-k];
            if(map.ContainsKey(sum))map[sum]++;
            else map[sum]=1;
        }
        return count;
    }
}
