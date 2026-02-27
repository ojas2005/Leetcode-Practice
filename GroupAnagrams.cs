public class Solution
{
    public IList<IList<string>> GroupAnagrams(string[] strs)
    {
        Dictionary<string,List<string>> map=new Dictionary<string,List<string>>();
        for(int i=0;i<strs.Length;i++)
        {
            char[] arr=strs[i].ToCharArray();
            Array.Sort(arr);
            string key=new string(arr);
            if(!map.ContainsKey(key))map[key]=new List<string>();
            map[key].Add(strs[i]);
        }
        return new List<IList<string>>(map.Values);
    }
}
