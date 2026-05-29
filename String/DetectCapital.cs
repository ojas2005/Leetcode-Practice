using System;

public class DetectCapital
{
    public bool DetectCapitalUse(string word)
    {
        if (word.Length <= 1) return true;

        bool allUpper = true;
        bool allLower = true;
        bool firstUpperRestLower = char.IsUpper(word[0]);

        for (int i = 1; i < word.Length; i++)
        {
            if (char.IsUpper(word[i]))
            {
                allLower = false;
                firstUpperRestLower = false;
            }
            else
            {
                allUpper = false;
            }
        }

        if (char.IsUpper(word[0]))
        {
            return allUpper || firstUpperRestLower;
        }
        else
        {
            return allLower;
        }
    }
}
