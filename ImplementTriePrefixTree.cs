public class Trie
{
    private Trie[] children;
    private bool isEnd;
    public Trie()
    {
        children=new Trie[26];
        isEnd=false;
    }
    public void Insert(string word)
    {
        Trie node=this;
        for(int i=0;i<word.Length;i++)
        {
            int idx=word[i]-'a';
            if(node.children[idx]==null)node.children[idx]=new Trie();
            node=node.children[idx];
        }
        node.isEnd=true;
    }
    public bool Search(string word)
    {
        Trie node=Find(word);
        return node!=null&&node.isEnd;
    }
    public bool StartsWith(string prefix)
    {
        return Find(prefix)!=null;
    }
    private Trie Find(string word)
    {
        Trie node=this;
        for(int i=0;i<word.Length;i++)
        {
            int idx=word[i]-'a';
            if(node.children[idx]==null)return null;
            node=node.children[idx];
        }
        return node;
    }
}
