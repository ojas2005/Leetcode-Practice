public class Solution
{
    public int LongestConsecutive(int[] nums)
    {
        HashSet<int> set=new HashSet<int>(nums);
        int maxLen=0;
        foreach(int num in set)
        {
            if(!set.Contains(num-1))
            {
                int length=1;
                int curr=num;
                while(set.Contains(curr+1))
                {
                    curr++;
                    length++;
                }
                maxLen=Math.Max(maxLen,length);
            }
        }
        return maxLen;
    }
}
