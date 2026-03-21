public class ExcelSheetColumnNumber
{
    public int TitleToNumber(string columnTitle)
    {
        int ans = 0;
        for (int i = 0; i < columnTitle.Length; i++)
        {
            int d = columnTitle[i] - 'A' + 1;
            ans = ans * 26 + d;
        }
        return ans;
    }
}
