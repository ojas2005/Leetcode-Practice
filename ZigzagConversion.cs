public class Solution
{
    public string Convert(string s,int numRows)
    {
        if(numRows==1)return s;
        StringBuilder[] rows=new StringBuilder[numRows];
        for(int i=0;i<numRows;i++)rows[i]=new StringBuilder();
        int curRow=0;
        bool goingDown=false;
        for(int i=0;i<s.Length;i++)
        {
            rows[curRow].Append(s[i]);
            if(curRow==0||curRow==numRows-1)goingDown=!goingDown;
            curRow+=goingDown?1:-1;
        }
        StringBuilder res=new StringBuilder();
        foreach(var row in rows)res.Append(row);
        return res.ToString();
    }
}
