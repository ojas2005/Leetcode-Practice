public class Solution
{
    public int FourSumCount(int[] nums1,int[] nums2,int[] nums3,int[] nums4)
    {
        Dictionary<int,int> sumCount=new Dictionary<int,int>();
        foreach(int a in nums1)
        {
            foreach(int b in nums2)
            {
                int sum=a+b;
                if(sumCount.ContainsKey(sum))sumCount[sum]++;
                else sumCount[sum]=1;
            }
        }
        int count=0;
        foreach(int c in nums3)
        {
            foreach(int d in nums4)
            {
                int target=-(c+d);
                if(sumCount.ContainsKey(target))count+=sumCount[target];
            }
        }
        return count;
    }
}
