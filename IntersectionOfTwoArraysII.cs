public class Solution
{
    public int[] Intersect(int[] nums1,int[] nums2)
    {
        Dictionary<int,int> map=new Dictionary<int,int>();
        for(int i=0;i<nums1.Length;i++)
        {
            if(map.ContainsKey(nums1[i]))map[nums1[i]]++;
            else map[nums1[i]]=1;
        }
        List<int> res=new List<int>();
        for(int i=0;i<nums2.Length;i++)
        {
            if(map.ContainsKey(nums2[i])&&map[nums2[i]]>0)
            {
                res.Add(nums2[i]);
                map[nums2[i]]--;
            }
        }
        return res.ToArray();
    }
}
