public class Solution
{
    public int FindMaxLength(int[] nums)
    {
        Dictionary<int,int> map=new Dictionary<int,int>();
        map[0]=-1;
        int sum=0,maxLen=0;
        for(int i=0;i<nums.Length;i++)
        {
            sum+=nums[i]==1?1:-1;
            if(map.ContainsKey(sum))maxLen=Math.Max(maxLen,i-map[sum]);
            else map[sum]=i;
        }
        return maxLen;
    }
}
