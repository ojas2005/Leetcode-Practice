using System;
using System.Text;

public class ReverseWordsInAString
{
    public string ReverseWords(string s)
    {
        string[] words = s.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        Array.Reverse(words);
        return string.Join(" ", words);
    }
}
