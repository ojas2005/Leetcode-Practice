public class Solution
{
    public int OrangesRotting(int[][] grid)
    {
        int rows=grid.Length,cols=grid[0].Length;
        Queue<int[]> q=new Queue<int[]>();
        int fresh=0;
        for(int i=0;i<rows;i++)
        for(int j=0;j<cols;j++)
        {
            if(grid[i][j]==2)q.Enqueue(new int[]{i,j});
            if(grid[i][j]==1)fresh++;
        }
        int mins=0;
        int[] dx={1,-1,0,0};
        int[] dy={0,0,1,-1};
        while(q.Count>0&&fresh>0)
        {
            int size=q.Count;
            for(int k=0;k<size;k++)
            {
                int[] cur=q.Dequeue();
                for(int d=0;d<4;d++)
                {
                    int x=cur[0]+dx[d],y=cur[1]+dy[d];
                    if(x>=0&&x<rows&&y>=0&&y<cols&&grid[x][y]==1)
                    {
                        grid[x][y]=2;
                        fresh--;
                        q.Enqueue(new int[]{x,y});
                    }
                }
            }
            mins++;
        }
        return fresh==0?mins:-1;
    }
}
