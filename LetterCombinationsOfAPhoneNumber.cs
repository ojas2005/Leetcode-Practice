public class Solution
{
    public IList<string> LetterCombinations(string digits)
    {
        List<string> res=new List<string>();
        if(digits.Length==0)return res;
        string[] map={"","","abc","def","ghi","jkl","mno","pqrs","tuv","wxyz"};
        Backtrack(digits,0,new StringBuilder(),map,res);
        return res;
    }
    private void Backtrack(string digits,int index,StringBuilder curr,string[] map,List<string> res)
    {
        if(index==digits.Length)
        {
            res.Add(curr.ToString());
            return;
        }
        string letters=map[digits[index]-'0'];
        for(int i=0;i<letters.Length;i++)
        {
            curr.Append(letters[i]);
            Backtrack(digits,index+1,curr,map,res);
            curr.Length--;
        }
    }
}
