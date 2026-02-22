public class Solution
{
    public IList<IList<int>> CombinationSum(int[] candidates,int target)
    {
        List<IList<int>> res=new List<IList<int>>();
        List<int> curr=new List<int>();
        Backtrack(candidates,target,0,curr,res);
        return res;
    }
    private void Backtrack(int[] candidates,int target,int start,List<int> curr,List<IList<int>> res)
    {
        if(target==0)
        {
            res.Add(new List<int>(curr));
            return;
        }
        for(int i=start;i<candidates.Length;i++)
        {
            if(candidates[i]>target)continue;
            curr.Add(candidates[i]);
            Backtrack(candidates,target-candidates[i],i,curr,res);
            curr.RemoveAt(curr.Count-1);
        }
    }
}
