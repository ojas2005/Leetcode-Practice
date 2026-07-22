public class Solution
{
    public bool CanConstruct(string ransomNote,string magazine)
    {
        int[] count=new int[26];
        for(int i=0;i<magazine.Length;i++)count[magazine[i]-'a']++;
        for(int i=0;i<ransomNote.Length;i++)
        {
            count[ransomNote[i]-'a']--;
            if(count[ransomNote[i]-'a']<0)return false;
        }
        return true;
    }
}
