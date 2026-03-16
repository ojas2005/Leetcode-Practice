using System;

public class TaskScheduler
{
    public int LeastInterval(char[] tasks, int n)
    {
        int[] frequencies = new int[26];
        foreach (char t in tasks) frequencies[t - 'A']++;
        
        Array.Sort(frequencies);
        int maxFreq = frequencies[25];
        int idleTime = (maxFreq - 1) * n;
        
        for (int i = 24; i >= 0 && frequencies[i] > 0; i--)
        {
            idleTime -= Math.Min(maxFreq - 1, frequencies[i]);
        }
        idleTime = Math.Max(0, idleTime);
        
        return tasks.Length + idleTime;
    }
}
