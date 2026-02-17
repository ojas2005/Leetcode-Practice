public class Solution
{
    public void GameOfLife(int[][] board)
    {
        int m=board.Length,n=board[0].Length;
        int[] dx={-1,-1,-1,0,0,1,1,1};
        int[] dy={-1,0,1,-1,1,-1,0,1};
        for(int i=0;i<m;i++)
        {
            for(int j=0;j<n;j++)
            {
                int live=0;
                for(int d=0;d<8;d++)
                {
                    int x=i+dx[d],y=j+dy[d];
                    if(x>=0&&x<m&&y>=0&&y<n&&Math.Abs(board[x][y])==1)live++;
                }
                if(board[i][j]==1&&(live<2||live>3))board[i][j]=-1;
                if(board[i][j]==0&&live==3)board[i][j]=2;
            }
        }
        for(int i=0;i<m;i++)
        {
            for(int j=0;j<n;j++)
            {
                if(board[i][j]>0)board[i][j]=1;
                else board[i][j]=0;
            }
        }
    }
}
