public class Solution
{
    public int SubarraysDivByK(int[] nums,int k)
    {
        Dictionary<int,int> map=new Dictionary<int,int>();
        map[0]=1;
        int sum=0,count=0;
        for(int i=0;i<nums.Length;i++)
        {
            sum+=nums[i];
            int rem=((sum%k)+k)%k;
            if(map.ContainsKey(rem))
            {
                count+=map[rem];
                map[rem]++;
            }
            else
            {
                map[rem]=1;
            }
        }
        return count;
    }
}
