public class Solution
{
    public IList<IList<int>> Permute(int[] nums)
    {
        List<IList<int>> res=new List<IList<int>>();
        Backtrack(nums,new List<int>(),new bool[nums.Length],res);
        return res;
    }
    private void Backtrack(int[] nums,List<int> curr,bool[] used,List<IList<int>> res)
    {
        if(curr.Count==nums.Length)
        {
            res.Add(new List<int>(curr));
            return;
        }
        for(int i=0;i<nums.Length;i++)
        {
            if(used[i])continue;
            used[i]=true;
            curr.Add(nums[i]);
            Backtrack(nums,curr,used,res);
            curr.RemoveAt(curr.Count-1);
            used[i]=false;
        }
    }
}
