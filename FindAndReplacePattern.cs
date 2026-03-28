public class Solution
{
    public IList<string> FindAndReplacePattern(string[] words,string pattern)
    {
        List<string> res=new List<string>();
        foreach(string word in words)
        {
            if(Matches(word,pattern))res.Add(word);
        }
        return res;
    }
    private bool Matches(string word,string pattern)
    {
        Dictionary<char,char> wordToPattern=new Dictionary<char,char>();
        Dictionary<char,char> patternToWord=new Dictionary<char,char>();
        for(int i=0;i<word.Length;i++)
        {
            char w=word[i],p=pattern[i];
            if(wordToPattern.ContainsKey(w)&&wordToPattern[w]!=p)return false;
            if(patternToWord.ContainsKey(p)&&patternToWord[p]!=w)return false;
            wordToPattern[w]=p;
            patternToWord[p]=w;
        }
        return true;
    }
}
