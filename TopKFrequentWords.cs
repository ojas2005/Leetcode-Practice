public class Solution
{
    public IList<string> TopKFrequent(string[] words,int k)
    {
        Dictionary<string,int> count=new Dictionary<string,int>();
        for(int i=0;i<words.Length;i++)
        {
            if(count.ContainsKey(words[i]))count[words[i]]++;
            else count[words[i]]=1;
        }
        List<string> keys=new List<string>(count.Keys);
        keys.Sort((a,b)=>count[a]!=count[b]?count[b]-count[a]:string.Compare(a,b));
        List<string> res=new List<string>();
        for(int i=0;i<k;i++)res.Add(keys[i]);
        return res;
    }
}
