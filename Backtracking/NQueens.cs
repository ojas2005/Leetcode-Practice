public class Solution
{
    public IList<IList<string>> SolveNQueens(int n)
    {
        List<IList<string>> res=new List<IList<string>>();
        int[] queens=new int[n];
        Backtrack(0,n,queens,res);
        return res;
    }
    private void Backtrack(int row,int n,int[] queens,List<IList<string>> res)
    {
        if(row==n)
        {
            res.Add(Build(queens,n));
            return;
        }
        for(int col=0;col<n;col++)
        {
            if(IsValid(queens,row,col))
            {
                queens[row]=col;
                Backtrack(row+1,n,queens,res);
            }
        }
    }
    private bool IsValid(int[] queens,int row,int col)
    {
        for(int i=0;i<row;i++)
        {
            if(queens[i]==col)return false;
            if(Math.Abs(queens[i]-col)==row-i)return false;
        }
        return true;
    }
    private List<string> Build(int[] queens,int n)
    {
        List<string> board=new List<string>();
        for(int i=0;i<n;i++)
        {
            char[] row=new char[n];
            for(int j=0;j<n;j++)row[j]='.';
            row[queens[i]]='Q';
            board.Add(new string(row));
        }
        return board;
    }
}
