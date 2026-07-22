public class Solution
{
    public int[] TopKFrequent(int[] nums,int k)
    {
        Dictionary<int,int> count=new Dictionary<int,int>();
        for(int i=0;i<nums.Length;i++)
        {
            if(count.ContainsKey(nums[i]))count[nums[i]]++;
            else count[nums[i]]=1;
        }
        List<int> keys=new List<int>(count.Keys);
        keys.Sort((a,b)=>count[b]-count[a]);
        int[] res=new int[k];
        for(int i=0;i<k;i++)res[i]=keys[i];
        return res;
    }
}
