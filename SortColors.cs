public class Solution
{
    public void SortColors(int[] nums)
    {
        int low=0,mid=0,high=nums.Length-1;
        while(mid<=high)
        {
            if(nums[mid]==0)
            {
                Swap(nums,low,mid);
                low++;
                mid++;
            }
            else if(nums[mid]==1)
            {
                mid++;
            }
            else
            {
                Swap(nums,mid,high);
                high--;
            }
        }
    }
    private void Swap(int[] nums,int a,int b)
    {
        int t=nums[a];
        nums[a]=nums[b];
        nums[b]=t;
    }
}
