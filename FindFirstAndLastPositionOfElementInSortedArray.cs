public class Solution
{
    public int[] SearchRange(int[] nums,int target)
    {
        int first=FindBound(nums,target,true);
        if(first==-1)return new int[]{-1,-1};
        int last=FindBound(nums,target,false);
        return new int[]{first,last};
    }
    private int FindBound(int[] nums,int target,bool findFirst)
    {
        int lo=0,hi=nums.Length-1;
        int result=-1;
        while(lo<=hi)
        {
            int mid=(lo+hi)/2;
            if(nums[mid]==target)
            {
                result=mid;
                if(findFirst)hi=mid-1;
                else lo=mid+1;
            }
            else if(nums[mid]<target)lo=mid+1;
            else hi=mid-1;
        }
        return result;
    }
}
