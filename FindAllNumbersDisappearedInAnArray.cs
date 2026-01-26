public class Solution
{
    public IList<int> FindDisappearedNumbers(int[] nums)
    {
        int n=nums.Length;
        for(int i=0;i<n;i++)
        {
            int idx=Math.Abs(nums[i])-1;
            if(nums[idx]>0)nums[idx]=-nums[idx];
        }
        List<int> res=new List<int>();
        for(int i=0;i<n;i++)
        {
            if(nums[i]>0)res.Add(i+1);
        }
        return res;
    }
}
