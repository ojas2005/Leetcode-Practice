public class TransposeMatrix
{
    public int[][] Transpose(int[][] matrix)
    {
        int R = matrix.Length, C = matrix[0].Length;
        int[][] ans = new int[C][];
        for (int c = 0; c < C; c++)
        {
            ans[c] = new int[R];
            for (int r = 0; r < R; r++)
            {
                ans[c][r] = matrix[r][c];
            }
        }
        return ans;
    }
}
