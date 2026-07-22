public class Solution
{
    public IList<IList<int>> Subsets(int[] nums)
    {
        List<IList<int>> res=new List<IList<int>>();
        Backtrack(nums,0,new List<int>(),res);
        return res;
    }
    private void Backtrack(int[] nums,int start,List<int> curr,List<IList<int>> res)
    {
        res.Add(new List<int>(curr));
        for(int i=start;i<nums.Length;i++)
        {
            curr.Add(nums[i]);
            Backtrack(nums,i+1,curr,res);
            curr.RemoveAt(curr.Count-1);
        }
    }
}
