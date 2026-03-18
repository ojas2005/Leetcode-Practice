public class IsomorphicStrings
{
    public bool IsIsomorphic(string s, string t)
    {
        if (s.Length != t.Length) return false;
        
        int[] mapS = new int[256];
        int[] mapT = new int[256];
        
        for (int i = 0; i < s.Length; i++)
        {
            if (mapS[s[i]] != mapT[t[i]]) return false;
            mapS[s[i]] = i + 1;
            mapT[t[i]] = i + 1;
        }
        
        return true;
    }
}
