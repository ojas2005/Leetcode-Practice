public class Solution
{
    public bool SearchMatrix(int[][] matrix,int target)
    {
        int m=matrix.Length,n=matrix[0].Length;
        int lo=0,hi=m*n-1;
        while(lo<=hi)
        {
            int mid=(lo+hi)/2;
            int val=matrix[mid/n][mid%n];
            if(val==target)return true;
            if(val<target)lo=mid+1;
            else hi=mid-1;
        }
        return false;
    }
}
