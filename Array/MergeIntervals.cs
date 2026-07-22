public class Solution
{
    public int[][] Merge(int[][] intervals)
    {
        Array.Sort(intervals,(a,b)=>a[0]-b[0]);
        List<int[]> res=new List<int[]>();
        foreach(var interval in intervals)
        {
            if(res.Count==0||res[res.Count-1][1]<interval[0])
            {
                res.Add(interval);
            }
            else
            {
                res[res.Count-1][1]=Math.Max(res[res.Count-1][1],interval[1]);
            }
        }
        return res.ToArray();
    }
}
