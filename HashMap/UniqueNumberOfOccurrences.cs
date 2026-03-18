using System.Collections.Generic;

public class UniqueNumberOfOccurrences
{
    public bool UniqueOccurrences(int[] arr)
    {
        Dictionary<int, int> counts = new Dictionary<int, int>();
        foreach (int num in arr)
        {
            if (counts.ContainsKey(num)) counts[num]++;
            else counts[num] = 1;
        }

        HashSet<int> occurrences = new HashSet<int>();
        foreach (var count in counts.Values)
        {
            if (!occurrences.Add(count)) return false;
        }
        return true;
    }
}
