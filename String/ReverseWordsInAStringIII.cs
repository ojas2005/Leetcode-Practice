using System;
using System.Text;

public class ReverseWordsInAStringIII
{
    public string ReverseWords(string s)
    {
        string[] words = s.Split(' ');
        for (int i = 0; i < words.Length; i++)
        {
            char[] arr = words[i].ToCharArray();
            Array.Reverse(arr);
            words[i] = new string(arr);
        }
        return string.Join(" ", words);
    }
}
