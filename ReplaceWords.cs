public class Solution
{
    public string ReplaceWords(IList<string> dictionary,string sentence)
    {
        HashSet<string> roots=new HashSet<string>(dictionary);
        string[] words=sentence.Split(' ');
        for(int i=0;i<words.Length;i++)
        {
            string word=words[i];
            for(int len=1;len<=word.Length;len++)
            {
                string prefix=word.Substring(0,len);
                if(roots.Contains(prefix))
                {
                    words[i]=prefix;
                    break;
                }
            }
        }
        return string.Join(" ",words);
    }
}
