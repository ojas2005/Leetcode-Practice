public class Solution
{
    public IList<string> SummaryRanges(int[] nums)
    {
        List<string> res=new List<string>();
        int n=nums.Length;
        int i=0;
        while(i<n)
        {
            int start=i;
            while(i+1<n&&nums[i+1]==nums[i]+1)i++;
            if(start==i)res.Add(nums[start].ToString());
            else res.Add(nums[start]+"->"+nums[i]);
            i++;
        }
        return res;
    }
}
