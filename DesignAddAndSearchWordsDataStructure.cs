public class WordDictionary
{
    private WordDictionary[] children;
    private bool isEnd;
    public WordDictionary()
    {
        children=new WordDictionary[26];
        isEnd=false;
    }
    public void AddWord(string word)
    {
        WordDictionary node=this;
        for(int i=0;i<word.Length;i++)
        {
            int idx=word[i]-'a';
            if(node.children[idx]==null)node.children[idx]=new WordDictionary();
            node=node.children[idx];
        }
        node.isEnd=true;
    }
    public bool Search(string word)
    {
        return SearchHelper(word,0,this);
    }
    private bool SearchHelper(string word,int index,WordDictionary node)
    {
        if(node==null)return false;
        if(index==word.Length)return node.isEnd;
        char c=word[index];
        if(c=='.')
        {
            for(int i=0;i<26;i++)
            {
                if(SearchHelper(word,index+1,node.children[i]))return true;
            }
            return false;
        }
        else
        {
            return SearchHelper(word,index+1,node.children[c-'a']);
        }
    }
}
