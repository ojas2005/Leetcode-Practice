using System;

public class BoatsToSavePeople
{
    public int NumRescueBoats(int[] people, int limit)
    {
        Array.Sort(people);
        int i = 0, j = people.Length - 1;
        int ans = 0;
        while (i <= j)
        {
            ans++;
            if (people[i] + people[j] <= limit) i++;
            j--;
        }
        return ans;
    }
}
