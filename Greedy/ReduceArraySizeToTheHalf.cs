using System;
using System.Collections.Generic;

public class ReduceArraySizeToTheHalf
{
    public int MinSetSize(int[] arr)
    {
        Dictionary<int, int> counts = new Dictionary<int, int>();
        foreach (int x in arr)
        {
            if (counts.ContainsKey(x)) counts[x]++;
            else counts[x] = 1;
        }
        List<int> freqs = new List<int>(counts.Values);
        freqs.Sort((a, b) => b.CompareTo(a));
        
        int removed = 0, steps = 0;
        int target = arr.Length / 2;
        foreach (int f in freqs)
        {
            removed += f;
            steps++;
            if (removed >= target) break;
        }
        return steps;
    }
}
